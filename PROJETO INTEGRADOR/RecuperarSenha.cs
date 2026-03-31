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
    public partial class RecuperarSenha : Form
    {
        public RecuperarSenha()
        {
            InitializeComponent();

            // Ao iniciar mantem centralizado
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void RecuperarSenha_Load(object sender, EventArgs e)
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
        }

        private void btn_voltar_recuperarSenha_Click(object sender, EventArgs e)
        {
            // Ao clicar retorna a tela de Login
            Form1 TelaLogin = new Form1();
            TelaLogin.ShowDialog();
        }

        private void btn_recuperarSenha_Click(object sender, EventArgs e)
        {
            // Ao clicar sera enviado um email com código para o email inserido
            string email = txt_email_recuperarSenha.Text;

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Digite seu email para recuperar a senha.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // É uma simulação.
            // Integrar com API/SMTP

            if(email == "admin@teste.com")
            {
                MessageBox.Show("Um e-mail com instruções de recuperação foi enviado.", "Recuperação de Senha", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Usuario não encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
