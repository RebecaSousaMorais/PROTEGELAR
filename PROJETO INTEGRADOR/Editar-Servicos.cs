using Microsoft.VisualBasic;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
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
            // Evita clique no cabeçalho
            if (e.RowIndex < 0)

                return;

            string nomeColuna = dataGridView1.Columns[e.ColumnIndex].Name;

            // PEGA O ID OCULTO
            string id = dataGridView1
            .Rows[e.RowIndex]
            .Cells["col_id"]
            .Value
            .ToString();

            // BOTÃO EDITAR
            if (nomeColuna == "col_editar")
            {
                string precoAtual = dataGridView1
                .Rows[e.RowIndex]
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

                // Corrige vírgula
                novoPreco = novoPreco.Replace(",", ".");

                // Validação
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

                        string sql = @"
                        UPDATE Servicos
                        SET preco_m2 = @preco
                        WHERE id_servico = @id
                        ";

                        using (var cmd = new SqliteCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@preco", precoConvertido);
                            cmd.Parameters.AddWithValue("@id", id);

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
                        "Erro ao atualizar: " + ex.Message,
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                    }
                }
            }

            // BOTÃO EXCLUIR
            else if (nomeColuna == "col_excluir")
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

                        // VERIFICA SE O SERVIÇO JÁ FOI UTILIZADO
                        string verificarUso = @"
                        SELECT COUNT(*)
                        FROM itens_orcamento
                        WHERE id_servico = @id
                        ";

                        using (var verificarCmd =
                            new SqliteCommand(verificarUso, conn))
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
                                    "Este serviço não pode ser excluído " +
                                    "porque já foi utilizado em orçamentos.",
                                    "Aviso",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning
                                );

                                return;
                            }
                        }

                        // EXCLUI O SERVIÇO

                        string sql = @"
            DELETE FROM Servicos
            WHERE id_servico = @id
            ";

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
                            "Erro ao excluir: " + ex.Message,
                            "Erro",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }
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

        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
            //
        //}
    }
}
