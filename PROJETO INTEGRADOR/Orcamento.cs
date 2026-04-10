using Google.Protobuf.WellKnownTypes;
using iTextSharp.text;
using iTextSharp.text.pdf;
using MySqlConnector;
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
    public partial class Orcamento : Form
    {

        public Orcamento(string clienteEmail)
        {
            InitializeComponent();

            // Inicia a tela maximizada
            this.WindowState = FormWindowState.Maximized;
        }

        private void btn_salvarOrcamento_Click(object sender, EventArgs e)
        {

        }

        private void btn_salvarOrcamento_Click(object sender, EventArgs e, Conexao conexao)
        {

        }

        private void btn_novoOrcamento_Click(object sender, EventArgs e)
        {

        }

        private void Orcamento_Load(object sender, EventArgs e)
        {

        }
    }
}