using BCrypt.Net;
using DotNetEnv;
using Microsoft.Data.Sqlite;
using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using System.IO;

namespace PROJETO_INTEGRADOR
{
    public partial class RecuperarSenha : Form
    {
        // Variável global para validar o código na próxima etapa
        private string emailValidado = string.Empty;

        public RecuperarSenha()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;

            Env.Load(Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                ".env"
            ));
        }

        // ETAPA 1: Enviar o e-mail com o código
        private async void btn_recuperarSenha_Click(object sender, EventArgs e)
        {
            ServicePointManager.SecurityProtocol =
                SecurityProtocolType.Tls12 | SecurityProtocolType.Tls13;

            string email = txt_email_recuperarSenha.Text.Trim();

            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
            {
                MessageBox.Show("E-mail inválido.");
                return;
            }

            // valida usuário
            using (var conn = Conexao.GetConexao())
            {
                conn.Open();


                var cmd = new SqliteCommand(
                    "SELECT COUNT(*) FROM Usuarios WHERE email = @email", conn);

                cmd.Parameters.AddWithValue("@email", email);

                if ((long)cmd.ExecuteScalar() == 0)
                {
                    MessageBox.Show("E-mail não cadastrado.");
                    return;
                }
            }

            emailValidado = email;

            string token = new Random().Next(100000, 999999).ToString();
            DateTime expira = DateTime.Now.AddMinutes(5);

            // salva token
            using (var conn = Conexao.GetConexao())
            {
                conn.Open();

                var sql = @"
                DELETE FROM RecuperacaoSenha WHERE email = @email;
 
                INSERT INTO RecuperacaoSenha (email, token, tentativas, expira_em)
                VALUES (@email, @token, 0, @expira);
                ";

                using (var cmd = new SqliteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@token", token);
                    cmd.Parameters.AddWithValue("@expira", expira);

                    cmd.ExecuteNonQuery();
                }
            }

            // envio email
            string apiKey = Env.GetString("BREVO_API_KEY");
            string remetente = Env.GetString("EMAIL_REMETENTE");

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("api-key", apiKey);

                var payload = new
                {
                    sender = new { name = "Protegelar", email = remetente },
                    to = new[] { new { email = email } },
                    subject = "Código de recuperação",
                    htmlContent = $"<h2>Código: {token}</h2><p>Expira em 5 minutos</p>"
                };

                var response = await client.PostAsync(
                    "https://api.brevo.com/v3/smtp/email",
                    new StringContent(JsonSerializer.Serialize(payload), Encoding.UTF8, "application/json")
                );

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Código enviado!");

                    txt_validarToken.Visible = true;
                    btn_validarToken.Visible = true;

                    btn_recuperarSenha.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Erro ao enviar e-mail.");
                }
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            // Ao clicar retorna a tela de Login
            this.Close();
        }

        private void RecuperarSenha_Load(object sender, EventArgs e)
        {
            // Centraliza o painel principal na tela
            if (panel1 != null)
            {
                panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
                panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
            }

            // Garante que os campos de validação comecem ocultos
            txt_validarToken.Visible = false;
            btn_validarToken.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_validarToken_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_validarToken_Click(object sender, EventArgs e)
        {
            string tokenDigitado = txt_validarToken.Text.Trim();

            using (var conn = Conexao.GetConexao())
            {
                conn.Open();

                string sql = @"
                SELECT token, tentativas, expira_em
                FROM RecuperacaoSenha
                WHERE email = @email
                ";

                using (var cmd = new SqliteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@email", emailValidado);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            MessageBox.Show("Solicite um novo código.");
                            return;
                        }

                        string tokenBanco = reader["token"].ToString();
                        int tentativas = Convert.ToInt32(reader["tentativas"]);
                        DateTime expira = Convert.ToDateTime(reader["expira_em"]);

                        if (DateTime.Now > expira)
                        {
                            MessageBox.Show("Código expirado.");
                            return;
                        }

                        if (tentativas >= 5)
                        {
                            MessageBox.Show("Limite de tentativas excedido.");
                            return;
                        }

                        if (tokenDigitado == tokenBanco)
                        {
                            using (var del = new SqliteCommand(
                                "DELETE FROM RecuperacaoSenha WHERE email=@email", conn))
                            {
                                del.Parameters.AddWithValue("@email", emailValidado);
                                del.ExecuteNonQuery();
                            }

                            this.Hide();

                            RedefinirSenha tela =
                                new RedefinirSenha(emailValidado);

                            tela.FormClosed += (s, args) =>
                            {
                                this.Close();
                            };

                            tela.Show();
                        }
                        else
                        {
                            using (var upd = new SqliteCommand(
                                "UPDATE RecuperacaoSenha SET tentativas = tentativas + 1 WHERE email = @email", conn))
                            {
                                upd.Parameters.AddWithValue("@email", emailValidado);
                                upd.ExecuteNonQuery();
                            }

                            MessageBox.Show("Código incorreto.");
                        }
                    }
                }
            }
        }
    }
}