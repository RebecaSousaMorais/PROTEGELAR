using Microsoft.VisualBasic;
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
    public partial class Editar_Servicos : Form
    {
        private string stringConexao = "Server=localhost;Database=dbprotegelar;Uid=root;Pwd=;";
        public Editar_Servicos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Editar_Servicos_Load(object sender, EventArgs e)
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
            this.WindowState = FormWindowState.Maximized;
            CarregarGrid();
        }

        private void CarregarGrid()
        {
            using (MySqlConnection conn = new MySqlConnection(stringConexao))
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT id_servico, categoria, nome_servico, preco_m2 FROM servicos";
                    MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex) { MessageBox.Show("Erro ao carregar grade: " + ex.Message); }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string id = dataGridView1.Rows[e.RowIndex].Cells["id_servico"].Value.ToString();

            // LÓGICA DE EDITAR (Botão col_editar)
            if (dataGridView1.Columns[e.ColumnIndex].Name == "col_editar")
            {
                string precoAtual = dataGridView1.Rows[e.RowIndex].Cells["preco_m2"].Value.ToString();
                string novoPreco = Interaction.InputBox("Novo preço m²:", "Editar", precoAtual);

                if (!string.IsNullOrWhiteSpace(novoPreco))
                {
                    ExecutarComando($"UPDATE servicos SET preco_m2 = '{novoPreco.Replace(",", ".")}' WHERE id_servico = {id}");
                }
            }
            // LÓGICA DE EXCLUIR (Botão col_excluir)
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "col_excluir")
            {
                var resp = MessageBox.Show("Deseja excluir este serviço?", "Aviso", MessageBoxButtons.YesNo);
                if (resp == DialogResult.Yes)
                {
                    ExecutarComando($"DELETE FROM servicos WHERE id_servico = {id}");
                }
            }
        }

        private void ExecutarComando(string sql)
        {
            using (MySqlConnection conn = new MySqlConnection(stringConexao))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    CarregarGrid();
                }
                catch (Exception ex) { MessageBox.Show("Erro na operação: " + ex.Message); }
            }
        }

        private void btn_voltar_servicos_Click(object sender, EventArgs e)
        {
            Servicos TelaServicos = new Servicos();
            TelaServicos.ShowDialog();
            //this.Hide();
        }

        private void btn_novoOrcamento_Click(object sender, EventArgs e)
        {
            Servicos TelaServicos = new Servicos();
            TelaServicos.ShowDialog();
            //this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //
        }
    }
}
