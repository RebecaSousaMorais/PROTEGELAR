namespace PROJETO_INTEGRADOR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
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
            // Ao clicar sera feita autenticação do usuario
        }

        private void btn_criarConta_login_Click(object sender, EventArgs e)
        {
            // Ao clicar leva o usuario a tela de cadastro
            Cadastro TelaCadastro = new Cadastro();
            TelaCadastro.ShowDialog();
        }

        private void lbl_esqueceuSenha_Login_Click(object sender, EventArgs e)
        {
            // Ao clicar leva o usuario a tela de recuperar senha
            RecuperarSenha TelarecuperarSenha = new RecuperarSenha();
            TelarecuperarSenha.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
        }

        private void chk_mostrarSenha_login_CheckedChanged(object sender, EventArgs e)
        {
            // Se o checkbox estiver marcado, mostra o texto. Se não, oculta
            bool ocultar = !chk_mostrarSenha_login.Checked;

            txt_senha_login.UseSystemPasswordChar = ocultar;
        }
    }
}
