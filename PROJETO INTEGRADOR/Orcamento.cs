using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.draw;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PROJETO_INTEGRADOR.Form1;

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
            if (Sessao.Carrinho.Count == 0)
            {
                MessageBox.Show("Não há itens no orçamento.");
                return;
            }

            SaveFileDialog salvarArquivo =
                new SaveFileDialog();

            salvarArquivo.Filter = "PDF|*.pdf";

            salvarArquivo.FileName =
                $"Orcamento_{DateTime.Now:yyyyMMdd_HHmm}";

            if (salvarArquivo.ShowDialog()
                != DialogResult.OK)
                return;

            double valorTotalFinal =
                Sessao.Carrinho.Sum(
                    x => x.Subtotal
                );

            int idGerado = 0;

            using (var conn = Conexao.GetConexao())
            {
                try
                {
                    conn.Open();

                    // SALVA ORÇAMENTO
                    string sqlOrcamento = @"
            INSERT INTO Orcamentos
            (
                id_usuario,
                nome_cliente,
                cpf_cliente,
                valor_total,
                data_criacao
            )
            VALUES
            (
                @user,
                @nome_cliente,
                @cpf_cliente,
                @total,
                datetime('now')
            );
 
            SELECT last_insert_rowid();
            ";

                    using (var cmd =
                        new SqliteCommand(
                            sqlOrcamento,
                            conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@user",
                            Sessao.id_usuario
                        );

                        cmd.Parameters.AddWithValue(
                            "@nome_cliente",
                            Sessao.nomeCliente
                        );

                        cmd.Parameters.AddWithValue(
                            "@cpf_cliente",
                            Sessao.cpfCliente
                        );

                        cmd.Parameters.AddWithValue(
                            "@total",
                            valorTotalFinal
                        );

                        idGerado =
                            Convert.ToInt32(
                                cmd.ExecuteScalar()
                            );
                    }

                    // SALVA ITENS
                    foreach (var item in Sessao.Carrinho)
                    {
                        string sqlItens = @"
                INSERT INTO Itens_Orcamento
                (
                    id_orcamento,
                    id_servico,
                    largura,
                    altura,
                    subtotal_item
                )
                VALUES
                (
                    @orcamento,
                    @id_servico,
                    @largura,
                    @altura,
                    @subtotal_item
                )
                ";

                        using (var cmdItens =
                            new SqliteCommand(
                                sqlItens,
                                conn))
                        {
                            cmdItens.Parameters.AddWithValue(
                                "@orcamento",
                                idGerado
                            );

                            cmdItens.Parameters.AddWithValue(
                                "@id_servico",
                                item.IdServico
                            );

                            cmdItens.Parameters.AddWithValue(
                                "@largura",
                                item.Largura
                            );

                            cmdItens.Parameters.AddWithValue(
                                "@altura",
                                item.Altura
                            );

                            cmdItens.Parameters.AddWithValue(
                                "@subtotal_item",
                                item.Subtotal
                            );

                            cmdItens.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Erro ao salvar orçamento: "
                        + ex.Message
                    );

                    return;
                }
            }

            // GERA PDF
            GerarPDF(
                idGerado,
                salvarArquivo.FileName
            );

            System.Diagnostics.Process.Start(
                new System.Diagnostics.ProcessStartInfo(
                    salvarArquivo.FileName
                )
                {
                    UseShellExecute = true
                }
            );

            MessageBox.Show(
                $"Orçamento #{idGerado} salvo com sucesso!"
            );

            // LIMPA SESSÃO
            Sessao.Carrinho.Clear();
            Sessao.nomeCliente = "";
            Sessao.cpfCliente = "";

            this.Close();
        }

        private void GerarPDF(int id, string caminhoArquivo)
        {
            try
            {
                iTextSharp.text.Document doc =
                    new iTextSharp.text.Document(
                        iTextSharp.text.PageSize.A4,
                        40f,
                        40f,
                        40f,
                        40f
                    );

                iTextSharp.text.pdf.PdfWriter.GetInstance(
                    doc,
                    new FileStream(
                        caminhoArquivo,
                        FileMode.Create
                    )
                );

                doc.Open();

                // FONTES

                iTextSharp.text.Font titulo =
                    iTextSharp.text.FontFactory.GetFont(
                        iTextSharp.text.FontFactory.HELVETICA_BOLD,
                        22f
                    );

                iTextSharp.text.Font subtitulo =
                    iTextSharp.text.FontFactory.GetFont(
                        iTextSharp.text.FontFactory.HELVETICA_BOLD,
                        14f
                    );

                iTextSharp.text.Font texto =
                    iTextSharp.text.FontFactory.GetFont(
                        iTextSharp.text.FontFactory.HELVETICA,
                        11f
                    );

                iTextSharp.text.Font textoNegrito =
                    iTextSharp.text.FontFactory.GetFont(
                        iTextSharp.text.FontFactory.HELVETICA_BOLD,
                        11f
                    );

                iTextSharp.text.Font totalFonte =
                    iTextSharp.text.FontFactory.GetFont(
                        iTextSharp.text.FontFactory.HELVETICA_BOLD,
                        15f
                    );

                // TÍTULO

                iTextSharp.text.Paragraph tituloPdf =
                    new iTextSharp.text.Paragraph(
                        "PROTEGELAR",
                        titulo
                    );

                tituloPdf.Alignment =
                    iTextSharp.text.Element.ALIGN_CENTER;

                doc.Add(tituloPdf);

                iTextSharp.text.Paragraph subtituloPdf =
                    new iTextSharp.text.Paragraph(
                        $"ORÇAMENTO #{id}",
                        subtitulo
                    );

                subtituloPdf.Alignment =
                    iTextSharp.text.Element.ALIGN_CENTER;

                doc.Add(subtituloPdf);

                doc.Add(new iTextSharp.text.Paragraph(" "));

                // LINHA

                iTextSharp.text.pdf.draw.LineSeparator linha =
                    new iTextSharp.text.pdf.draw.LineSeparator();

                doc.Add(linha);

                doc.Add(new iTextSharp.text.Paragraph(" "));

                // CLIENTE

                iTextSharp.text.Paragraph cliente =
                    new iTextSharp.text.Paragraph();

                cliente.Add(
                    new iTextSharp.text.Chunk(
                        "Cliente: ",
                        textoNegrito
                    )
                );

                cliente.Add(
                    new iTextSharp.text.Chunk(
                        Sessao.nomeCliente,
                        texto
                    )
                );

                doc.Add(cliente);

                // CPF

                iTextSharp.text.Paragraph cpf =
                    new iTextSharp.text.Paragraph();

                cpf.Add(
                    new iTextSharp.text.Chunk(
                        "CPF: ",
                        textoNegrito
                    )
                );

                cpf.Add(
                    new iTextSharp.text.Chunk(
                        Sessao.cpfCliente,
                        texto
                    )
                );

                doc.Add(cpf);

                // DATA

                iTextSharp.text.Paragraph data =
                    new iTextSharp.text.Paragraph();

                data.Add(
                    new iTextSharp.text.Chunk(
                        "Data: ",
                        textoNegrito
                    )
                );

                data.Add(
                    new iTextSharp.text.Chunk(
                        DateTime.Now.ToString(
                            "dd/MM/yyyy HH:mm"
                        ),
                        texto
                    )
                );

                doc.Add(data);

                doc.Add(new iTextSharp.text.Paragraph(" "));

                // TABELA

                iTextSharp.text.pdf.PdfPTable tabela =
                    new iTextSharp.text.pdf.PdfPTable(4);

                tabela.WidthPercentage = 100f;

                tabela.SetWidths(
                    new float[]
                    {
                5f,
                2f,
                2f,
                2f
                    }
                );

                // CABEÇALHO

                iTextSharp.text.pdf.PdfPCell c1 =
                    new iTextSharp.text.pdf.PdfPCell(
                        new iTextSharp.text.Phrase(
                            "Serviço",
                            textoNegrito
                        )
                    );

                iTextSharp.text.pdf.PdfPCell c2 =
                    new iTextSharp.text.pdf.PdfPCell(
                        new iTextSharp.text.Phrase(
                            "Largura",
                            textoNegrito
                        )
                    );

                iTextSharp.text.pdf.PdfPCell c3 =
                    new iTextSharp.text.pdf.PdfPCell(
                        new iTextSharp.text.Phrase(
                            "Altura",
                            textoNegrito
                        )
                    );

                iTextSharp.text.pdf.PdfPCell c4 =
                    new iTextSharp.text.pdf.PdfPCell(
                        new iTextSharp.text.Phrase(
                            "Subtotal",
                            textoNegrito
                        )
                    );

                c1.HorizontalAlignment =
                    iTextSharp.text.Element.ALIGN_CENTER;

                c2.HorizontalAlignment =
                    iTextSharp.text.Element.ALIGN_CENTER;

                c3.HorizontalAlignment =
                    iTextSharp.text.Element.ALIGN_CENTER;

                c4.HorizontalAlignment =
                    iTextSharp.text.Element.ALIGN_CENTER;

                tabela.AddCell(c1);
                tabela.AddCell(c2);
                tabela.AddCell(c3);
                tabela.AddCell(c4);

                // ITENS

                foreach (var item in Sessao.Carrinho)
                {
                    tabela.AddCell(item.Servico);

                    tabela.AddCell(
                        item.Largura.ToString("F2") + " m"
                    );

                    tabela.AddCell(
                        item.Altura.ToString("F2") + " m"
                    );

                    tabela.AddCell(
                        item.Subtotal.ToString("C2")
                    );
                }

                doc.Add(tabela);

                doc.Add(new iTextSharp.text.Paragraph(" "));

                // TOTAL

                double total =
                    Sessao.Carrinho.Sum(
                        x => x.Subtotal
                    );

                iTextSharp.text.Paragraph totalPdf =
                    new iTextSharp.text.Paragraph(
                        "VALOR TOTAL: " +
                        total.ToString("C2"),
                        totalFonte
                    );

                totalPdf.Alignment =
                    iTextSharp.text.Element.ALIGN_RIGHT;

                doc.Add(totalPdf);

                doc.Add(new iTextSharp.text.Paragraph(" "));
                doc.Add(new iTextSharp.text.Paragraph(" "));

                // RODAPÉ

                iTextSharp.text.Paragraph rodape =
                    new iTextSharp.text.Paragraph(
                        "Obrigado pela preferência!",
                        texto
                    );

                rodape.Alignment =
                    iTextSharp.text.Element.ALIGN_CENTER;

                doc.Add(rodape);

                doc.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erro ao gerar PDF: " +
                    ex.Message
                );
            }
        }

        private void btn_novoOrcamento_Click(object sender, EventArgs e)
        {
            this.Hide();

            Servicos telaServicos = new Servicos();

            telaServicos.FormClosed += (s, args) =>
            {
                this.Show();
                DesenharItensNoRecibo();
            };

            telaServicos.Show();
        }

        private void Orcamento_Load(object sender, EventArgs e)
        {
            if (panel1 != null)
            {
                panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
                panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
            }

            DesenharItensNoRecibo();
        }

        private void DesenharItensNoRecibo()
        {
            panel1.SuspendLayout();

            for (int i = panel1.Controls.Count - 1; i >= 0; i--)
            {
                if (panel1.Controls[i].Tag?.ToString() == "dinamico")
                    panel1.Controls.RemoveAt(i);
            }

            int eixoY = 130;

            double totalGeral = 0;

            Label lblNome = new Label
            {
                Text =
                    "Cliente: " +
                    Sessao.nomeCliente,

                Font =
                    new System.Drawing.Font(
                        "Arial",
                        12F,
                        FontStyle.Bold),

                Location = new Point(50, 70),
                AutoSize = true,
                Tag = "dinamico"
            };

            Label lblCpf = new Label
            {
                Text =
                    "CPF: " +
                    Sessao.cpfCliente,

                Font =
                    new System.Drawing.Font(
                        "Arial",
                        12F,
                        FontStyle.Regular),

                Location = new Point(50, 95),
                AutoSize = true,
                Tag = "dinamico"
            };

            panel1.Controls.Add(lblNome);
            panel1.Controls.Add(lblCpf);

            foreach (var item in Form1.Sessao.Carrinho.ToList())
            {
                Label lbl = new Label
                {
                    Text =
                        $"• {item.Servico} " +
                        $"({item.Largura:F2}m x " +
                        $"{item.Altura:F2}m) ... " +
                        $"{item.Subtotal:C2}",

                    Font =
                        new System.Drawing.Font(
                            "Arial",
                            12F,
                            FontStyle.Regular),

                    Location = new Point(50, eixoY),
                    AutoSize = true,
                    Tag = "dinamico"
                };

                Button btnRemover = new Button
                {
                    Text = "X",
                    Location = new Point(600, eixoY - 5),
                    Size = new Size(30, 25),
                    BackColor = Color.Red,
                    ForeColor = Color.White,
                    Tag = item
                };

                btnRemover.Click += (s, e) =>
                {
                    var itemRemover = (ItensCarrinho)((Button)s).Tag;

                    Form1.Sessao.Carrinho.Remove(itemRemover);
                    DesenharItensNoRecibo();
                };

                panel1.Controls.Add(lbl);
                panel1.Controls.Add(btnRemover);
                eixoY += 35;
                totalGeral += item.Subtotal;
            }

            lbl_valorTotal.Text =
                totalGeral.ToString("C2");

            if (Form1.Sessao.Carrinho.Count == 0)
            {
                lbl_valorTotal.Text = "R$ 0,00";
            }

            panel1.ResumeLayout();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            this.Hide();
            login.Show();
            Sessao.Limpar();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Hide();

            Home TelaHome = new Home();

            TelaHome.FormClosed += (s, args) =>
            {
                this.Close();
            };

            TelaHome.Show();
        }
    }
}