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

            string nomeColuna =
                dataGridView1.Columns[e.ColumnIndex].Name;

            // Só executa na coluna de ações
            if (nomeColuna != "col_acoes")
                return;

            // PEGA O ID
            string id = dataGridView1
                .Rows[e.RowIndex]
                .Cells["col_id"]
                .Value
                .ToString();

            // PEGA O PREÇO ATUAL
            string precoAtual = dataGridView1
                .Rows[e.RowIndex]
                .Cells["col_preco"]
                .Value
                .ToString();

            // MENU DE ESCOLHA
            DialogResult escolha = MessageBox.Show(
                "SIM = Editar\nNÃO = Excluir",
                "Escolha uma ação",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question
            );

            // =========================
            // EDITAR
            // =========================
            if (escolha == DialogResult.Yes)
            {
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

            // =========================
            // EXCLUIR
            // =========================
            else if (escolha == DialogResult.No)
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

                        // VERIFICA SE JÁ FOI USADO
                        string verificarUso = @"
                    SELECT COUNT(*)
                    FROM itens_orcamento
                    WHERE id_servico = @id
                ";

                        using (var verificarCmd =
                            new SqliteCommand(verificarUso, conn))
                        {
                            verificarCmd.Parameters.AddWithValue("@id", id);

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
                        string sql = @"
                    DELETE FROM Servicos
                    WHERE id_servico = @id
                ";

                        using (var cmd =
                            new SqliteCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", id);

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
    }
}
