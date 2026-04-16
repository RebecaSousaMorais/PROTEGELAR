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
using BCrypt.Net;
using MySqlX.XDevAPI;
using static PROJETO_INTEGRADOR.Form1;

namespace PROJETO_INTEGRADOR
{
    public partial class Servicos : Form
    {
        private string stringConexao = "Server=localhost;Database=dbprotegelar;Uid=root;Pwd=;";
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
            using (MySqlConnection conn = new MySqlConnection(stringConexao))
            {
                try
                {
                    conn.Open();
                    // Busca as categorias únicas que inserimos no banco
                    string sql = "SELECT DISTINCT categoria FROM servicos WHERE categoria IS NOT NULL ORDER BY categoria ASC";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
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
            // 1. Limpa a segunda combo (Serviços) para não acumular lixo
            cmb_servico.Items.Clear();

            // 2. Pega o texto que o usuário acabou de clicar na primeira combo
            string categoriaSelecionada = cmb_categoria.SelectedItem.ToString();

            using (MySqlConnection conn = new MySqlConnection(stringConexao))
            {
                try
                {
                    conn.Open();
                    // 3. Busca no banco apenas serviços que pertencem a essa categoria
                    string sql = "SELECT nome_servico FROM servicos WHERE categoria = @cat";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@cat", categoriaSelecionada);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // 4. Adiciona cada serviço encontrado na SEGUNDA combo
                            cmb_servico.Items.Add(reader["nome_servico"].ToString());
                        }
                    }

                    // Opcional: Seleciona o primeiro serviço automaticamente para não ficar vazio
                    if (cmb_servico.Items.Count > 0) cmb_servico.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao filtrar serviços: " + ex.Message);
                }
            }
        }

        private void btn_salvarOrcamento_Click(object sender, EventArgs e)
        {
            // 1. Validação: Impede campos vazios
            if (string.IsNullOrWhiteSpace(txt_largura.Text) || string.IsNullOrWhiteSpace(txt_altura.Text) || cmb_servico.SelectedItem == null)
            {
                MessageBox.Show("Por favor, preencha as medidas e selecione o serviço.", "Atenção");
                return;
            }

            // Trata a entrada de números (aceita ponto ou vírgula)
            if (!double.TryParse(txt_largura.Text.Replace(".", ","), out double largura) ||
                !double.TryParse(txt_altura.Text.Replace(".", ","), out double altura))
            {
                MessageBox.Show("Introduza valores numéricos válidos para as medidas.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(stringConexao))
            {
                try
                {
                    conn.Open();
                    string sqlBusca = "SELECT id_servico, preco_m2 FROM servicos WHERE nome_servico = @nome";
                    MySqlCommand cmdBusca = new MySqlCommand(sqlBusca, conn);
                    cmdBusca.Parameters.AddWithValue("@nome", cmb_servico.SelectedItem.ToString());

                    int idServico = 0;
                    double precoM2 = 0;

                    using (MySqlDataReader reader = cmdBusca.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            idServico = Convert.ToInt32(reader["id_servico"]);
                            precoM2 = Convert.ToDouble(reader["preco_m2"]);
                        }
                    }

                    double totalCalculado = (largura * altura) * precoM2;

                    // --- AQUI ESTÁ O SEGREDO: ALIMENTAR O CARRINHO DA SESSÃO ---
                    // Criamos o objeto do item para a tela de recibo enxergar
                    var novoItem = new Form1.ItensCarrinho
                    {
                        Servico = cmb_servico.SelectedItem.ToString(),
                        Largura = largura,
                        Altura = altura,
                        Subtotal = totalCalculado
                    };
                    Form1.Sessao.Carrinho.Add(novoItem);

                    // 4. Grava na tabela (Sua lógica de banco que já funciona)
                    string sqlInsert = @"INSERT INTO orcamentos (id_usuario, id_servico, largura, altura, valor_total, observacoes)
                               VALUES ((SELECT id_usuario FROM usuarios WHERE email = @email), @servico, @larg, @alt, @total, @obs)";

                    using (MySqlCommand cmdInsert = new MySqlCommand(sqlInsert, conn))
                    {
                        cmdInsert.Parameters.AddWithValue("@email", Sessao.email);
                        cmdInsert.Parameters.AddWithValue("@servico", idServico);
                        cmdInsert.Parameters.AddWithValue("@larg", largura);
                        cmdInsert.Parameters.AddWithValue("@alt", altura);
                        cmdInsert.Parameters.AddWithValue("@total", totalCalculado);
                        cmdInsert.Parameters.AddWithValue("@obs", txt_observacoes.Text);
                        cmdInsert.ExecuteNonQuery();
                    }

                    // 5. NAVEGAÇÃO: Agora chamamos a tela sem precisar passar parâmetros, pois está na Sessão
                    Orcamento TelaOrcamento = new Orcamento();
                    TelaOrcamento.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro técnico: " + ex.Message);
                }
            }
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
