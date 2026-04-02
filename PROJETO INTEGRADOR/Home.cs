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
            // Close all child windows
            foreach (Form childForm in this.OwnedForms)
            {
                childForm.Close();
            }

            // Optionally, show the login form again
            Form1 TelaLogin = new Form1();
            TelaLogin.ShowDialog();

            // Close the current parent form (if needed)
            this.Close();
        }

        private void btn_novoOrcamento_Click(object sender, EventArgs e)
        {
            Servicos TelaServicos = new Servicos();
            TelaServicos.ShowDialog();
            this.Hide();
        }

        private void btn_gerenciarServico_Click(object sender, EventArgs e)
        {
            Editar_Servicos TelaEditar = new Editar_Servicos();
            TelaEditar.Show();
            this.Hide();
        }
    }
}
