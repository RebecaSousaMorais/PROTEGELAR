using BCrypt.Net;
using Microsoft.Data.Sqlite;

namespace PROJETO_INTEGRADOR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // Mantem a posição centralizada
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            // Inicia a tela maximizada
            this.WindowState = FormWindowState.Maximized;
        }

        private void lbl_login_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Email_login_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Senha_login_Click(object sender, EventArgs e)
        {

        }

        private void txt_email_login_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_senha_login_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_entrar_login_Click(object sender, EventArgs e)
        {
            string email = txt_email_login.Text;
            string senha = txt_senha_login.Text;

            // Conexão com SQLite usando sua classe Conexao
            using (var conn = Conexao.GetConexao())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT id_usuario, nome_completo, senha FROM Usuarios WHERE email = @email";

                    using (var cmd = new SqliteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@email", email);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string nomeUsuario = reader["nome_completo"].ToString() ?? "";
                                string hashDoBanco = reader["senha"].ToString() ?? "";

                                if (BCrypt.Net.BCrypt.Verify(senha, hashDoBanco))
                                {
                                    // GUARDANDO DADOS NA SESSÃO
                                    Sessao.email = email;
                                    Sessao.id_usuario = Convert.ToInt32(reader["id_usuario"]);

                                    MessageBox.Show($"Bem-vindo(a), {nomeUsuario}!");

                                    // NAVEGAÇÃO: Esconde o login e abre a Home
                                    this.Hide();
                                    Home TelaHome = new Home();
                                    TelaHome.ShowDialog();
                                    this.Show();
                                }
                                else
                                {
                                    MessageBox.Show("E-mail ou senha inválidos.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("E-mail ou senha inválidos.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro técnico: " + ex.Message);
                }
            }
        }

        public static class Sessao
        {
            public static string email;
            public static int id_usuario;
            public static List<ItensCarrinho> Carrinho = new List<ItensCarrinho>();
        }

        // Estrutura para os itens que vêm da tela de Serviços
        public class ItensCarrinho
        {
            public string Servico { get; set; }
            public double Largura { get; set; }
            public double Altura { get; set; }
            public double Subtotal { get; set; }
        }

        private void btn_criarConta_login_Click(object sender, EventArgs e)
        {
            // Ao clicar leva o usuario a tela de cadastro
            Cadastro TelaCadastro = new Cadastro();
            TelaCadastro.ShowDialog();
            //this.Close();
        }

        private void lbl_esqueceuSenha_Login_Click(object sender, EventArgs e)
        {
            // Ao clicar leva o usuario a tela de recuperar senha
            RecuperarSenha TelarecuperarSenha = new RecuperarSenha();
            TelarecuperarSenha.ShowDialog();
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
            // Centraliza tela, e deixa a senha em char *
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;

            txt_senha_login.UseSystemPasswordChar = true;
        }

        private void chk_mostrarSenha_login_CheckedChanged(object sender, EventArgs e)
        {
            // Se o checkbox estiver marcado, mostra o texto. Se não, oculta
            bool ocultar = !chk_mostrarSenha_login.Checked;

            txt_senha_login.UseSystemPasswordChar = ocultar;
        }
    }
}
