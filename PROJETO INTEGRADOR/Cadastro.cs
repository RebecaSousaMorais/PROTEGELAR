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
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
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
            Form1 TelaLogin = new Form1();
            TelaLogin.ShowDialog();
        }

        private void btn_criarConta_cadastro_Click(object sender, EventArgs e)
        {

        }
    }
}
