using BCrypt.Net;
using MySqlConnector;
using MySqlX.XDevAPI;

namespace PROJETO_INTEGRADOR
{
    public partial class Form1 : Form
    {
        // 1. String de conexão direta para o XAMPP (RNF01)
        private string stringConexao = "Server=localhost;Database=dbprotegelar;Uid=root;Pwd=;";
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

            using (MySqlConnection conn = new MySqlConnection(stringConexao))
            {
                try
                {
                    conn.Open();
                    // Buscamos apenas pelo e-mail para pegar o Hash guardado
                    string query = "SELECT nome_completo, senha FROM Usuarios WHERE email = @email";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@email", email);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read()) // Se encontrou o e-mail...
                            {
                                string nomeUsuario = reader["nome_completo"].ToString();
                                string hashDoBanco = reader["senha"].ToString();

                                // 🔐 VERIFICAÇÃO: O BCrypt compara a senha digitada com o Hash
                                if (BCrypt.Net.BCrypt.Verify(senha, hashDoBanco))
                                {
                                    Sessao.email = email; // Guarda o e-mail na memória global
                                    MessageBox.Show($"Bem-vindo(a), {nomeUsuario}!");
                                    Home TelaHome = new Home();
                                    TelaHome.ShowDialog();
                                }
                                else
                                {
                                    MessageBox.Show("E-mail ou senha inválidos.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Usuário não encontrado.");
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
