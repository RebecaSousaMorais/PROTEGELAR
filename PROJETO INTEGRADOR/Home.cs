using BCrypt.Net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PROJETO_INTEGRADOR.Form1;

namespace PROJETO_INTEGRADOR
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
        }

        private void lbl_Home_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_logout_Click(object sender, EventArgs e)
        {

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Sessao.Limpar();

            this.Hide();

            Form1 login = new Form1();

            login.Show();

            this.Close();
        }

        private void btn_novoOrcamento_Click(object sender, EventArgs e)
        {
            this.Hide();

            Servicos TelaServicos = new Servicos();

            TelaServicos.FormClosed += (s, args) =>
            {
                this.Show();
            };
            TelaServicos.Show();
        }

        private void btn_gerenciarServico_Click(object sender, EventArgs e)
        {
            this.Hide();
            Editar_Servicos TelaEditar = new Editar_Servicos();

            TelaEditar.FormClosed += (s, args) =>
            {
                this.Show();
            };
            TelaEditar.Show();
        }

        private void btn_verPerfil_Click(object sender, EventArgs e)
        {
            this.Hide();
            Perfil TelaPerfil = new Perfil();

            TelaPerfil.FormClosed += (s, args) =>
            {
                this.Show();
            };
            TelaPerfil.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pnl_sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
