using Microsoft.Data.Sqlite;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PROJETO_INTEGRADOR.Form1;

namespace PROJETO_INTEGRADOR
{
    public partial class Editar_Servicos : Form
    {
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

            dataGridView1.AutoGenerateColumns = false;

            // VISUAL DO GRID
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.EnableHeadersVisualStyles = false;

            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(26, 58, 90);

            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dataGridView1.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            dataGridView1.ColumnHeadersHeight = 45;

            dataGridView1.DefaultCellStyle.Font =
                new Font("Segoe UI", 10);

            dataGridView1.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(230, 230, 230);

            dataGridView1.DefaultCellStyle.SelectionForeColor =
                Color.Black;

            dataGridView1.RowTemplate.Height = 40;

            dataGridView1.CellBorderStyle =
                DataGridViewCellBorderStyle.SingleHorizontal;

            dataGridView1.GridColor =
                Color.LightGray;

            // BOTÃO EDITAR
            DataGridViewButtonColumn colEditar =
                (DataGridViewButtonColumn)dataGridView1.Columns["col_editar"];

            colEditar.Text = "✏ Editar";
            colEditar.UseColumnTextForButtonValue = true;

            // BOTÃO EXCLUIR
            DataGridViewButtonColumn colExcluir =
                (DataGridViewButtonColumn)dataGridView1.Columns["col_excluir"];

            colExcluir.Text = "🗑 Excluir";
            colExcluir.UseColumnTextForButtonValue = true;

            CarregarGrid();
        }

        private void CarregarGrid()
        {
            using (var conn = Conexao.GetConexao())
            {
                try
                {
                    conn.Open();

                    string sql = @"
                        SELECT
                            id_servico,
                            categoria,
                            nome_servico,
                            preco_m2
                        FROM Servicos
                        ORDER BY categoria ASC
                    ";

                    using (var cmd = new SqliteCommand(sql, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        dataGridView1.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Erro ao carregar serviços: " + ex.Message,
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // EVITA CABEÇALHO
            if (e.RowIndex < 0)
                return;

            string nomeColuna =
            dataGridView1.Columns[e.ColumnIndex].Name;

            string id = dataGridView1
            .Rows[e.RowIndex]
            .Cells["col_id"]
            .Value
            .ToString();

            // EDITAR
            if (nomeColuna == "col_editar")
            {
                EditarServico(id, e.RowIndex);
            }

            // EXCLUIR
            else if (nomeColuna == "col_excluir")
            {
                ExcluirServico(id);
            }
        }

        private void EditarServico(
        string id,
        int rowIndex)
        {
            string precoAtual =
            dataGridView1
            .Rows[rowIndex]
            .Cells["col_preco"]
            .Value
            .ToString();

            string novoPreco = Interaction.InputBox(
            "Digite o novo preço por m²:",
            "Editar Serviço",
            precoAtual
            );

            if (string.IsNullOrWhiteSpace(novoPreco))
                return;

            novoPreco = novoPreco.Replace(",", ".");

            if (!double.TryParse(
            novoPreco,
            NumberStyles.Any,
            CultureInfo.InvariantCulture,
            out double precoConvertido))
            {
                MessageBox.Show(
                "Digite um valor numérico válido.",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );
                return;
            }

            using (var conn = Conexao.GetConexao())
            {
                try
                {
                    conn.Open();

                    string sql =
                        "UPDATE Servicos " +
                        "SET preco_m2 = @preco " +
                        "WHERE id_servico = @id";

                    using (var cmd =
                    new SqliteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue(
                        "@preco",
                        precoConvertido
                        );

                        cmd.Parameters.AddWithValue(
                        "@id",
                        id
                        );

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show(
                    "Preço atualizado com sucesso!",
                    "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );

                    CarregarGrid();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(
                    "Erro ao atualizar: " +
                    ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                }
            }
        }
        private void ExcluirServico(string id)
        {
            DialogResult resp = MessageBox.Show(
            "Deseja realmente excluir este serviço?",
            "Confirmação",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
            );

            if (resp != DialogResult.Yes)
                return;

            using (var conn = Conexao.GetConexao())
            {
                try
                {
                    conn.Open();

                    // VERIFICA USO
                    string verificarUso =
                        "SELECT COUNT(*) " +
                        "FROM itens_orcamento " +
                        "WHERE id_servico = @id";


                    using (var verificarCmd =
                    new SqliteCommand(
                    verificarUso,
                    conn))
                    {
                        verificarCmd.Parameters.AddWithValue(
                        "@id",
                        id
                        );

                        long totalUso =
                        (long)verificarCmd.ExecuteScalar();

                        if (totalUso > 0)
                        {
                            MessageBox.Show(
                            "Este serviço não pode ser excluído porque já foi utilizado em orçamentos.",
                            "Aviso",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                            );

                            return;
                        }
                    }

                    // EXCLUI
                    string sql =
                        "DELETE FROM Servicos " +
                        "WHERE id_servico = @id";

                    using (var cmd =
                    new SqliteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue(
                        "@id",
                        id
                        );

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show(
                    "Serviço excluído com sucesso!",
                    "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );

                    CarregarGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                    "Erro ao excluir: " +
                    ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                }
            }
        }

        private void btn_voltar_servicos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_novoOrcamento_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Sessao.Limpar();
            this.Hide();
            Form1 login = new Form1();
            login.Show();
            this.Close();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {

        }
    }
}
