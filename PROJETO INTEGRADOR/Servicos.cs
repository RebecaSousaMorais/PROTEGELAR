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

            txt_nomeCliente.Text = Sessao.nomeCliente;
            txt_cpfCliente.Text = Sessao.cpfCliente;

            // CARREGA AS CATEGORIAS DO BANCO
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
            cmb_servico.Text = "";

            if (cmb_categoria.SelectedItem == null)
                return;

            string categoriaSelecionada =
                cmb_categoria.SelectedItem.ToString() ?? "";

            using (var conn = Conexao.GetConexao())
            {
                try
                {
                    conn.Open();

                    string sql = @"
                    SELECT DISTINCT nome_servico
                    FROM Servicos
                    WHERE categoria = @cat
                    ORDER BY nome_servico ASC
                ";

                    using (var cmd = new SqliteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@cat",
                            categoriaSelecionada
                        );

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cmb_servico.Items.Add(
                                    reader["nome_servico"].ToString()
                                );
                            }
                        }
                    }

                    if (cmb_servico.Items.Count > 0)
                    {
                        cmb_servico.SelectedIndex = 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Erro ao filtrar serviços: " + ex.Message
                    );
                }
            }
        }

        private void AtualizarValor()
        {
            if (cmb_servico.SelectedItem == null)
            {
                lbl_precoOrcamento.Text = "R$ 0,00";
                return;
            }

            bool larguraValida = double.TryParse(
                txt_largura.Text.Replace(".", ","),
                out double largura
            );

            bool alturaValida = double.TryParse(
                txt_altura.Text.Replace(".", ","),
                out double altura
            );

            if (!larguraValida || !alturaValida)
            {
                lbl_precoOrcamento.Text = "R$ 0,00";
                return;
            }

            if (largura <= 0 || altura <= 0)
            {
                lbl_precoOrcamento.Text = "R$ 0,00";
                return;
            }

            using (var conn = Conexao.GetConexao())
            {
                try
                {
                    conn.Open();

                    string sql = @"
                        SELECT preco_m2
                        FROM Servicos
                        WHERE nome_servico = @nome
                    ";

                    using (var cmd = new SqliteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@nome",
                            cmb_servico.SelectedItem.ToString()
                        );

                        var result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            double precoM2 =
                                Convert.ToDouble(result);

                            double total =
                                largura * altura * precoM2;

                            lbl_precoOrcamento.Text =
                                total.ToString("C2");
                        }
                    }
                }
                catch
                {
                    lbl_precoOrcamento.Text = "R$ 0,00";
                }
            }
        }

        private void btn_salvarOrcamento_Click(object sender, EventArgs e)
        {
            string nomeCliente =
            txt_nomeCliente.Text.Trim();

            string cpfCliente =
                txt_cpfCliente.Text.Trim();

            if (string.IsNullOrWhiteSpace(nomeCliente))
            {
                MessageBox.Show("Digite o nome do cliente.");
                return;
            }

            if (string.IsNullOrWhiteSpace(cpfCliente))
            {
                MessageBox.Show("Digite o CPF do cliente.");
                return;
            }

            if (cmb_servico.SelectedItem == null)
            {
                MessageBox.Show("Selecione um serviço.");
                return;
            }

            if (!double.TryParse(
                txt_largura.Text.Replace(".", ","),
                out double largura))
            {
                MessageBox.Show("Largura inválida.");
                return;
            }

            if (!double.TryParse(
                txt_altura.Text.Replace(".", ","),
                out double altura))
            {
                MessageBox.Show("Altura inválida.");
                return;
            }

            if (largura <= 0)
            {
                MessageBox.Show(
                    "Largura deve ser maior que zero."
                );
                return;
            }

            if (altura <= 0)
            {
                MessageBox.Show(
                    "Altura deve ser maior que zero."
                );
                return;
            }

            double precoM2 = 0;
            int idServico = 0;

            using (var conn = Conexao.GetConexao())
            {
                try
                {
                    conn.Open();

                    string sql = @"
                        SELECT id_servico ,preco_m2
                        FROM Servicos
                        WHERE nome_servico = @nome
                    ";

                    using (var cmd =
                        new SqliteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@nome",
                            cmb_servico.SelectedItem.ToString()
                        );

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                MessageBox.Show("Serviço não encontrado.");
                                return;
                            }

                            idServico =
                                Convert.ToInt32(reader["id_servico"]);

                            precoM2 =
                                Convert.ToDouble(reader["preco_m2"]);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Erro ao carregar serviço: " +
                        ex.Message
                    );

                    return;
                }
            }

            double total = largura * altura * precoM2;

            Sessao.nomeCliente = nomeCliente;
            Sessao.cpfCliente = cpfCliente;
            

            Sessao.Carrinho.Add(new ItensCarrinho
            {
                IdServico = idServico,

                Servico =
                cmb_servico.SelectedItem.ToString(),

                Largura = largura,
                Altura = altura,
                Subtotal = total
            });

            this.Hide();

            Orcamento tela = new Orcamento();

            tela.FormClosed += (s, args) =>
            {
                this.Show();
            };

            tela.Show();
        }

        private void btn_editarServico_Click(object sender, EventArgs e)
        {
            this.Hide();
            Editar_Servicos TelaEditar = new Editar_Servicos();

            TelaEditar.FormClosed += (s, args) =>
            {
                this.Show();
            };
            TelaEditar.Show();
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
            this.Close();
        }

        private void cmb_servico_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarValor();
        }

        private void txt_largura_TextChanged(object sender, EventArgs e)
        {
            AtualizarValor();
        }

        private void txt_altura_TextChanged(object sender, EventArgs e)
        {
            AtualizarValor();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
