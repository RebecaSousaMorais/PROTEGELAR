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

            // Popula categorias
            cmb_categoria.Items.Add("Redes de Proteção");
            cmb_categoria.Items.Add("Projetos Especiais");
            cmb_categoria.Items.Add("Estruturas Metálicas");
            cmb_categoria.Items.Add("Telas Mosquiteiras");

            // Evento para atualizar serviços ao mudar categoria
            cmb_categoria.SelectedIndexChanged += cmb_categoria_SelectedIndexChanged;
        }

        private void cmb_categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_servico.Items.Clear();

            switch (cmb_categoria.SelectedItem.ToString())
            {
                case "Redes de Proteção":
                    cmb_servico.Items.Add("Instalação de redes de proteção");
                    cmb_servico.Items.Add("Redes para janelas e sacadas");
                    cmb_servico.Items.Add("Redes para pets");
                    cmb_servico.Items.Add("Redes para piscinas");
                    cmb_servico.Items.Add("Redes para escadas");
                    break;

                case "Projetos Especiais":
                    cmb_servico.Items.Add("Projetos especiais de proteção");
                    break;

                case "Estruturas Metálicas":
                    cmb_servico.Items.Add("Estruturas metálicas para instalação");
                    break;

                case "Telas Mosquiteiras":
                    cmb_servico.Items.Add("Telas mosquiteiras");
                    break;
            }
        }

        private void btn_salvarOrcamento_Click(object sender, EventArgs e)
        {
            string categoria = cmb_categoria.Text;
            string servico = cmb_servico.Text;
            string observacoes = txt_observacoes.Text;

            if (!double.TryParse(txt_largura.Text, out double largura) ||
                !double.TryParse(txt_altura.Text, out double altura))
            {
                MessageBox.Show("Informe valores numéricos válidos para largura e altura.",
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Este cálculo é apenas uma simulação.
            // Substituir por lógica real quando integrar com banco/API.
            double precoBase = 50.0;
            double precoFinal = precoBase + (largura * altura * 10);

            lbl_precoOrcamento.Text = $"Preço R$ {precoFinal:F2}";

            MessageBox.Show("Orçamento salvo com sucesso!",
                            "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_editarServico_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aqui você pode implementar a edição dos serviços cadastrados.", "Editar Serviços", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Editar_Servicos TelaEditar = new Editar_Servicos();
            TelaEditar.ShowDialog();
            this.Hide();
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
    }
}
