using BCrypt.Net;
using Google.Protobuf.WellKnownTypes;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJETO_INTEGRADOR
{
    public partial class Orcamento : Form
    {
        public Orcamento()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void btn_salvarOrcamento_Click(object sender, EventArgs e)
        {
            if (Form1.Sessao.Carrinho.Count == 0)
            {
                MessageBox.Show("Não há itens no orçamento.");
                return;
            }

            SaveFileDialog salvarArquivo = new SaveFileDialog();
            salvarArquivo.Filter = "PDF|*.pdf";
            salvarArquivo.FileName = $"Orcamento_{DateTime.Now:yyyyMMdd_HHmm}";

            if (salvarArquivo.ShowDialog() != DialogResult.OK)
                return;

            double valorTotalFinal = Form1.Sessao.Carrinho.Sum(x => x.Subtotal);
            int idGerado = 0;

            // 1. BLOCO SOMENTE BANCO (rápido e fechado)
            using (var conn = Conexao.GetConexao())
            {
                conn.Open();

                string sql = @"
            INSERT INTO Orcamentos (id_usuario, valor_total, data_criacao)
            VALUES (@user, @total, datetime('now'));
 
            SELECT last_insert_rowid();
        ";

                using (var cmd = new SqliteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@user", Form1.Sessao.id_usuario);
                    cmd.Parameters.AddWithValue("@total", valorTotalFinal);

                    idGerado = Convert.ToInt32(cmd.ExecuteScalar());
                }
            } // FECHA conexão AQUI (importante)

            // 2. PDF FORA DO BANCO (não trava SQLite)
            GerarPDF(idGerado, salvarArquivo.FileName);

            System.Diagnostics.Process.Start(
                new System.Diagnostics.ProcessStartInfo(salvarArquivo.FileName)
                { UseShellExecute = true }
            );

            MessageBox.Show($"Orçamento #{idGerado} salvo com sucesso!");

            Form1.Sessao.Carrinho.Clear();
            this.Close();
        }

        private void GerarPDF(int id, string caminhoArquivo)
        {
            using (FileStream fs = new FileStream(caminhoArquivo, FileMode.Create, FileAccess.Write))
            {
                Document doc = new Document(PageSize.A4);
                PdfWriter.GetInstance(doc, fs);
                doc.Open();

                // Definição de fontes
                var fonteTitulo = FontFactory.GetFont("Arial", 18, iTextSharp.text.Font.BOLD);
                var fonteSub = FontFactory.GetFont("Arial", 12, iTextSharp.text.Font.BOLD);
                var fonteTexto = FontFactory.GetFont("Arial", 11, iTextSharp.text.Font.NORMAL);

                // Conteúdo do PDF
                doc.Add(new Paragraph("PROTEGELAR - ORÇAMENTO RESIDENCIAL", fonteTitulo));
                doc.Add(new Paragraph($"Protocolo: {id} | Data: {DateTime.Now:dd/MM/yyyy HH:mm}"));
                doc.Add(new Paragraph($"Cliente: {Form1.Sessao.email}"));
                doc.Add(new Paragraph("------------------------------------------------------------------------------------------"));

                foreach (var item in Form1.Sessao.Carrinho)
                {
                    doc.Add(new Paragraph($"{item.Servico} ({item.Largura:F2}m x {item.Altura:F2}m) - Subtotal: {item.Subtotal:C2}", fonteTexto));
                }

                doc.Add(new Paragraph("------------------------------------------------------------------------------------------"));
                doc.Add(new Paragraph($"VALOR TOTAL FINAL: {lbl_valorTotal.Text}", fonteSub));

                doc.Close();
            }
        }

        private void btn_novoOrcamento_Click(object sender, EventArgs e)
        {
            Servicos TelaServicos = new Servicos();
            TelaServicos.ShowDialog();
            this.Hide();
        }

        private void Orcamento_Load(object sender, EventArgs e)
        {
            // Centraliza o painel principal
            if (panel1 != null)
            {
                panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
                panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
            }

            DesenharItensNoRecibo();
        }

        private void DesenharItensNoRecibo()
        {
            // Limpa itens antigos para não duplicar na tela
            for (int i = panel1.Controls.Count - 1; i >= 0; i--)
            {
                if (panel1.Controls[i].Tag?.ToString() == "dinamico")
                    panel1.Controls.RemoveAt(i);
            }

            int eixoY = 130;
            double totalGeral = 0;

            // Percorre o carrinho global da Sessao
            foreach (var item in Form1.Sessao.Carrinho)
            {
                Label lbl = new Label
                {
                    Text = $"• {item.Servico} ({item.Largura:F2}m x {item.Altura:F2}m) ... {item.Subtotal:C2}",
                    Font = new System.Drawing.Font("Arial", 12F, FontStyle.Regular),
                    Location = new Point(50, eixoY),
                    AutoSize = true,
                    Tag = "dinamico"
                };
                panel1.Controls.Add(lbl);
                eixoY += 35;
                totalGeral += item.Subtotal;
            }

            lbl_valorTotal.Text = totalGeral.ToString("C2");
        }
    }
}