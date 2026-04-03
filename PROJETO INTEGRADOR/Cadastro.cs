using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJETO_INTEGRADOR
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            // Inicia a tela maximizada
            this.WindowState = FormWindowState.Maximized;
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;

            txt_senha_cadastro.UseSystemPasswordChar = true;
            txt_confirmarSenha_cadastro.UseSystemPasswordChar = true;

            this.WindowState = FormWindowState.Maximized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_nomeCompleto_cadastro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_email_cadastro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_telefone_cadastro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_endResidencial_cadastro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_senha_cadastro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_confirmarSenha_cadastro_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_voltar_cadastro_Click(object sender, EventArgs e)
        {
            // Ao clicar retorna a tela de Login
            Form1 TelaLogin = new Form1();
            TelaLogin.ShowDialog();
            this.Close();
        }

        private void btn_criarConta_cadastro_Click(object sender, EventArgs e)
        {
            string nome = txt_nomeCompleto_cadastro.Text;
            string email = txt_email_cadastro.Text;
            string telefone = txt_telefone_cadastro.Text;
            string endereco = txt_endResidencial_cadastro.Text;
            string senha = txt_senha_cadastro.Text;
            string confirmarSenha = txt_confirmarSenha_cadastro.Text;

            // Verifica se todos os campos foram preenchidos
            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(telefone) || string.IsNullOrWhiteSpace(endereco) || string.IsNullOrWhiteSpace(confirmarSenha) || string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("Preencha todos os campos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verifica se as senhas coincidem
            if (senha != confirmarSenha)
            {
                MessageBox.Show("As senhas não coincidem!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar Senha
            if (!ValidarSenha(senha))
            {
                MessageBox.Show("A senha deve ter no mínimo 8 caracteres, incluir letras maiúsculas, minúsculas, números e caracteres especiais.",
                                "Senha inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Se passou em todas as validações
            MessageBox.Show("Conta criada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Aqui você pode salvar os dados no banco de dados
            this.Close();
        }

        // Função para validar força da senha
        private bool ValidarSenha(string senha)
        {
            return senha.Length >= 8 &&
                   senha.Any(char.IsUpper) &&
                   senha.Any(char.IsLower) &&
                   senha.Any(char.IsDigit) &&
                   senha.Any(ch => "!@#$%^&*()_+-=[]{}|;:'\",.<>?".Contains(ch));
        }

        private void chk_mostrarSenha_cadastro_CheckedChanged(object sender, EventArgs e)
        {
            // Se o checkbox estiver marcado, mostra o texto. Se não, oculta
            bool ocultar = !chk_mostrarSenha_cadastro.Checked;

            txt_senha_cadastro.UseSystemPasswordChar = ocultar;
            txt_confirmarSenha_cadastro.UseSystemPasswordChar = ocultar;
        }

        private void lbl_endResidencial_Click(object sender, EventArgs e)
        {

        }
    }
}
