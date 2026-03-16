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

        }

        private void btn_criarConta_login_Click(object sender, EventArgs e)
        {
            Cadastro TelaCadastro = new Cadastro();
            TelaCadastro.ShowDialog();
        }

        private void lbl_esqueceuSenha_Login_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
        }
    }
}
