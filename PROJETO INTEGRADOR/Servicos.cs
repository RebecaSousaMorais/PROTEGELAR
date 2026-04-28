using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PROJETO_INTEGRADOR.Form1;

namespace PROJETO_INTEGRADOR
{
    public partial class Servicos : Form
    {
        public Servicos()
        {
            InitializeComponent();
        }

        private void Servicos_Load(object sender, EventArgs e)
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
            this.WindowState = FormWindowState.Maximized;

            // CARREGA AS CATEGORIAS DO BANCO (Sem repetir nomes)
            CarregarCategoriasDoBanco();
        }

        private void CarregarCategoriasDoBanco()
        {
            cmb_categoria.Items.Clear();

            using (var conn = Conexao.GetConexao())
            {
                try
                {
                    conn.Open();

                    string sql = "SELECT DISTINCT categoria FROM Servicos WHERE categoria IS NOT NULL ORDER BY categoria ASC";

                    using (var cmd = new SqliteCommand(sql, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmb_categoria.Items.Add(reader["categoria"].ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar categorias: " + ex.Message);
                }
            }
        }

        private void cmb_categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_servico.Items.Clear();

            if (cmb_categoria.SelectedItem == null)
                return;

            string categoriaSelecionada = cmb_categoria.SelectedItem.ToString() ?? "";

            using (var conn = Conexao.GetConexao())
            {
                try
                {
                    conn.Open();

                    string sql = @"
                        SELECT nome_servico
                        FROM Servicos
                        WHERE categoria = @cat
                        ORDER BY nome_servico ASC
                    ";

                    using (var cmd = new SqliteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@cat", categoriaSelecionada);

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cmb_servico.Items.Add(reader["nome_servico"].ToString());
                            }
                        }
                    }

                    // Seleciona automaticamente o primeiro item
                    if (cmb_servico.Items.Count > 0)
                    {
                        cmb_servico.SelectedIndex = 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao filtrar serviços: " + ex.Message);
                }
            }
        }

        private void btn_salvarOrcamento_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_largura.Text) ||
        string.IsNullOrWhiteSpace(txt_altura.Text) ||
        cmb_servico.SelectedItem == null)
            {
                MessageBox.Show("Preencha as medidas e selecione um serviço.");
                return;
            }

            if (!double.TryParse(txt_largura.Text.Replace(".", ","), out double largura) ||
                !double.TryParse(txt_altura.Text.Replace(".", ","), out double altura))
            {
                MessageBox.Show("Digite valores válidos.");
                return;
            }

            int idServico = 0;
            double precoM2 = 0;

            // 1. BLOCO SOMENTE LEITURA (fecha rápido)
            using (var conn = Conexao.GetConexao())
            {
                conn.Open();

                string sqlBusca = @"
            SELECT id_servico, preco_m2
            FROM Servicos
            WHERE nome_servico = @nome
        ";

                using (var cmd = new SqliteCommand(sqlBusca, conn))
                {
                    cmd.Parameters.AddWithValue("@nome", cmb_servico.SelectedItem.ToString());

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            idServico = Convert.ToInt32(reader["id_servico"]);
                            precoM2 = Convert.ToDouble(reader["preco_m2"]);
                        }
                    }
                }
            } // conexão FECHA AQUI (importante)

            double totalCalculado = (largura * altura) * precoM2;

            Sessao.Carrinho.Add(new ItensCarrinho
            {
                Servico = cmb_servico.SelectedItem.ToString(),
                Largura = largura,
                Altura = altura,
                Subtotal = totalCalculado
            });

            long idOrcamento;

            // 2. BLOCO SOMENTE ESCRITA (nova conexão)
            using (var conn = Conexao.GetConexao())
            {
                conn.Open();

                string sqlInsert = @"
            INSERT INTO Orcamentos (id_usuario, valor_total)
            VALUES (@usuario, @total);
        ";

                using (var cmd = new SqliteCommand(sqlInsert, conn))
                {
                    cmd.Parameters.AddWithValue("@usuario", Sessao.id_usuario);
                    cmd.Parameters.AddWithValue("@total", totalCalculado);
                    cmd.ExecuteNonQuery();
                }

                using (var cmdId = new SqliteCommand("SELECT last_insert_rowid();", conn))
                {
                    idOrcamento = (long)cmdId.ExecuteScalar();
                }

                string sqlItem = @"
            INSERT INTO itens_orcamento
            (id_orcamento, id_servico, largura, altura, subtotal_item)
            VALUES
            (@orcamento, @servico, @largura, @altura, @subtotal);
        ";

                using (var cmdItem = new SqliteCommand(sqlItem, conn))
                {
                    cmdItem.Parameters.AddWithValue("@orcamento", idOrcamento);
                    cmdItem.Parameters.AddWithValue("@servico", idServico);
                    cmdItem.Parameters.AddWithValue("@largura", largura);
                    cmdItem.Parameters.AddWithValue("@altura", altura);
                    cmdItem.Parameters.AddWithValue("@subtotal", totalCalculado);

                    cmdItem.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Orçamento salvo com sucesso.");

            Orcamento tela = new Orcamento();
            tela.ShowDialog();
        }

        private void btn_editarServico_Click(object sender, EventArgs e)
        {
            // 1. Criamos a tela
            Editar_Servicos telaEditar = new Editar_Servicos();

            // 2. Escondemos a tela atual ANTES de abrir a outra
            this.Hide();

            // 3. Abrimos a nova como diálogo
            telaEditar.ShowDialog();

            // 4. Quando fechar a de edição, voltamos a mostrar esta (Serviços)
            this.Show();
            CarregarCategoriasDoBanco(); // Recarrega caso algo tenha mudado
        }

        private void lbl_precoOrcamento_Click(object sender, EventArgs e)
        {

        }

        private void txt_observacoes_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_voltar_servico_Click(object sender, EventArgs e)
        {
            Home TelaHome = new Home();
            TelaHome.ShowDialog();
        }

        private void cmb_servico_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
