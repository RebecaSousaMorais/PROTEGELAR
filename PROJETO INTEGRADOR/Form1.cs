namespace PROJETO_INTEGRADOR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

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

            // Esta validação é apenas uma simulação.
            // Quando integrar com banco de dados, substitua por uma consulta real.
            if (email == "admin@teste.com" && senha == "1234")
            {
                MessageBox.Show("Login realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Exemplo: abrir tela principal
                Home TelaHome = new Home();
                TelaHome.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Email ou senha inválidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_criarConta_login_Click(object sender, EventArgs e)
        {
            // Ao clicar leva o usuario a tela de cadastro
            Cadastro TelaCadastro = new Cadastro();
            TelaCadastro.ShowDialog();
            this.Close();
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
