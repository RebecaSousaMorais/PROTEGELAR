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
        public Editar_Servicos()
        {
            InitializeComponent();
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Editar_Servicos_Load(object sender, EventArgs e)
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;

            this.WindowState = FormWindowState.Maximized;

            // Configura colunas do DataGridView
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("col_nomeServico", "Nome do Serviço");
            dataGridView1.Columns.Add("col_preco", "Preço/m²");
            dataGridView1.Columns.Add("col_categoria", "Categoria");

            // Coluna Editar
            DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
            btnEditar.Name = "col_editar";
            btnEditar.HeaderText = "Editar";
            btnEditar.Text = "✏️";
            btnEditar.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btnEditar);

            // Coluna Excluir
            DataGridViewButtonColumn btnExcluir = new DataGridViewButtonColumn();
            btnExcluir.Name = "col_excluir";
            btnExcluir.HeaderText = "Excluir";
            btnExcluir.Text = "🗑️";
            btnExcluir.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btnExcluir);

            // Simulação de dados (futuramente virá do banco)
            dataGridView1.Rows.Add("Varal", "150,00", "Externo");
            dataGridView1.Rows.Add("Rede de Proteção", "300,00", "Externo");
            dataGridView1.Rows.Add("Jardinagem", "350,00", "Externo");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "colEditar")
                {
                    // Pega dados da linha
                    string nome = dataGridView1.Rows[e.RowIndex].Cells["colNomeServico"].Value.ToString();
                    string preco = dataGridView1.Rows[e.RowIndex].Cells["colPreco"].Value.ToString();
                    string categoria = dataGridView1.Rows[e.RowIndex].Cells["colCategoria"].Value.ToString();

                    // Abre tela de edição
                    Form editar = new Form();
                    editar.Text = "Editar Serviço";

                    TextBox txtNome = new TextBox { Text = nome, Left = 20, Top = 20, Width = 200 };
                    TextBox txtPreco = new TextBox { Text = preco, Left = 20, Top = 60, Width = 200 };
                    TextBox txtCategoria = new TextBox { Text = categoria, Left = 20, Top = 100, Width = 200 };
                    Button btnSalvar = new Button { Text = "Salvar", Left = 20, Top = 140 };

                    btnSalvar.Click += (s, ev) =>
                    {
                        dataGridView1.Rows[e.RowIndex].Cells["colNomeServico"].Value = txtNome.Text;
                        dataGridView1.Rows[e.RowIndex].Cells["colPreco"].Value = txtPreco.Text;
                        dataGridView1.Rows[e.RowIndex].Cells["colCategoria"].Value = txtCategoria.Text;
                        MessageBox.Show("Serviço atualizado com sucesso!", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        editar.Close();
                    };

                    editar.Controls.Add(txtNome);
                    editar.Controls.Add(txtPreco);
                    editar.Controls.Add(txtCategoria);
                    editar.Controls.Add(btnSalvar);
                    editar.ShowDialog();
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "colExcluir")
                {
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                    MessageBox.Show("Serviço excluído com sucesso!", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btn_voltar_servicos_Click(object sender, EventArgs e)
        {
            Servicos TelaServicos = new Servicos();
            TelaServicos.ShowDialog();
            this.Hide();
        }

        private void btn_novoOrcamento_Click(object sender, EventArgs e)
        {
            Servicos TelaServicos = new Servicos();
            TelaServicos.ShowDialog();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Excluir
                if (dataGridView1.Columns[e.ColumnIndex].Name == "col_excluir")
                {
                    var confirm = MessageBox.Show("Tem certeza que deseja excluir este serviço?",
                                                  "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirm == DialogResult.Yes)
                    {
                        dataGridView1.Rows.RemoveAt(e.RowIndex);
                        MessageBox.Show("Serviço excluído com sucesso!",
                                        "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                // Editar
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "col_editar")
                {
                    string nome = dataGridView1.Rows[e.RowIndex].Cells["col_nomeServico"].Value.ToString();
                    string preco = dataGridView1.Rows[e.RowIndex].Cells["col_preco"].Value.ToString();
                    string categoria = dataGridView1.Rows[e.RowIndex].Cells["col_categoria"].Value.ToString();

                    Form editar = new Form();
                    editar.Text = "Editar Serviço";

                    TextBox txtNome = new TextBox { Text = nome, Left = 20, Top = 20, Width = 200 };
                    TextBox txtPreco = new TextBox { Text = preco, Left = 20, Top = 60, Width = 200 };
                    TextBox txtCategoria = new TextBox { Text = categoria, Left = 20, Top = 100, Width = 200 };
                    Button btnSalvar = new Button { Text = "Salvar", Left = 20, Top = 140 };

                    btnSalvar.Click += (s, ev) =>
                    {
                        dataGridView1.Rows[e.RowIndex].Cells["col_nomeServico"].Value = txtNome.Text;
                        dataGridView1.Rows[e.RowIndex].Cells["col_preco"].Value = txtPreco.Text;
                        dataGridView1.Rows[e.RowIndex].Cells["col_categoria"].Value = txtCategoria.Text;
                        MessageBox.Show("Serviço atualizado com sucesso!",
                                        "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        editar.Close();
                    };

                    editar.Controls.Add(txtNome);
                    editar.Controls.Add(txtPreco);
                    editar.Controls.Add(txtCategoria);
                    editar.Controls.Add(btnSalvar);
                    editar.ShowDialog();
                }
            }
        }
    }
}
