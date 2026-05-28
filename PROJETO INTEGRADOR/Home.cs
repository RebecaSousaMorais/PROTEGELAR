using BCrypt.Net;
using Microsoft.Data.Sqlite;
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
            panel1.Left =
            (this.ClientSize.Width - panel1.Width) / 2;

            panel1.Top =
                (this.ClientSize.Height - panel1.Height) / 2;

            // NÃO GERAR COLUNAS AUTOMÁTICAS
            dataGridView1.AutoGenerateColumns = false;

            // VISUAL GRID
            dataGridView1.BorderStyle =
                BorderStyle.None;

            dataGridView1.BackgroundColor =
                Color.White;

            dataGridView1.EnableHeadersVisualStyles =
                false;

            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(26, 58, 90);

            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dataGridView1.ColumnHeadersDefaultCellStyle.Font =
                new Font("Arial", 14, FontStyle.Bold);

            dataGridView1.ColumnHeadersHeight = 45;

            dataGridView1.DefaultCellStyle.Font =
                new Font("Arial", 12);

            dataGridView1.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(230, 230, 230);

            dataGridView1.DefaultCellStyle.SelectionForeColor =
                Color.Black;

            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(245, 245, 245);

            dataGridView1.RowTemplate.Height = 38;

            dataGridView1.GridColor =
                Color.LightGray;

            dataGridView1.CellBorderStyle =
                DataGridViewCellBorderStyle.SingleHorizontal;

            dataGridView1.RowHeadersVisible = false;

            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.AllowUserToDeleteRows = false;

            dataGridView1.AllowUserToResizeRows = false;

            dataGridView1.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dataGridView1.MultiSelect = false;

            dataGridView1.ReadOnly = true;

            // TAMANHO MANUAL DAS COLUNAS
            dataGridView1.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.None;

            dataGridView1.Columns["col_cliente"].Width = 120;

            dataGridView1.Columns["col_data"].Width = 100;

            dataGridView1.Columns["col_total"].Width = 150;

            // FORMATAÇÃO REAL BR
            dataGridView1.Columns["col_total"]
                .DefaultCellStyle.Format = "C2";

            dataGridView1.Columns["col_total"]
                .DefaultCellStyle.FormatProvider =
                new System.Globalization.CultureInfo("pt-BR");

            CarregarHistorico();
        }

        private void CarregarHistorico()
        {
            using (var conn = Conexao.GetConexao())
            {
                try
                {
                    conn.Open();
                    string sql = @"
                    SELECT
                        nome_cliente,
                        strftime('%d/%m/%Y', data_criacao) AS data_criacao,
                        valor_total
                    FROM Orcamentos
                    ORDER BY data_criacao DESC
                    LIMIT 5
                ";

                    using (var cmd =
                        new SqliteCommand(sql, conn))

                    using (var reader =
                        cmd.ExecuteReader())
                    {
                        DataTable dt =
                            new DataTable();

                        dt.Load(reader);

                        dataGridView1.DataSource = dt;
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Erro ao carregar histórico: " +
                        ex.Message
                    );
                }
            }
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
            Form1 login = new Form1();
            this.Hide();
            login.Show();
            Sessao.Limpar();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            // Ja esta na home
        }

        private void lbl_historicoOrcamento_Click(object sender, EventArgs e)
        {

        }
    }
}
