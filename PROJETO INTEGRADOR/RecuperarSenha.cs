using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
// Adicione estas duas referências:
using DotNetEnv;

namespace PROJETO_INTEGRADOR
{
    public partial class RecuperarSenha : Form
    {
        // Variável global para validar o código na próxima etapa
        private string tokenGerado = string.Empty;

        public RecuperarSenha()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;

            // Carregamento do arquivo .env usando o seu caminho específico
            try
            {
                string caminhoEnv = @"C:\Users\rebeca.smorais\Downloads\PROTEGELAR-main\PROTEGELAR-main\PROJETO INTEGRADOR\.env";

                if (System.IO.File.Exists(caminhoEnv))
                {
                    Env.Load(caminhoEnv);
                }
                else
                {
                    // Caso o arquivo mude de lugar futuramente
                    Env.Load();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar configurações (.env): " + ex.Message, "Erro Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ETAPA 1: Enviar o e-mail com o código
        private async void btn_recuperarSenha_Click(object sender, EventArgs e)
        {
            // Configura protocolos de segurança para a API
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls13;

            string emailDestino = txt_email_recuperarSenha.Text;

            // Validação simples de e-mail
            if (string.IsNullOrWhiteSpace(emailDestino) || !emailDestino.Contains("@"))
            {
                MessageBox.Show("Por favor, insira um e-mail válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Recupera as credenciais do seu .env
            string apiKey = Env.GetString("BREVO_API_KEY");
            string emailRemetente = Env.GetString("EMAIL_REMETENTE");

            if (string.IsNullOrEmpty(apiKey))
            {
                MessageBox.Show("Chave da API não encontrada! Verifique seu arquivo .env.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Gera um código aleatório de 6 dígitos
            tokenGerado = new Random().Next(100000, 999999).ToString();

            using (var client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Add("api-key", apiKey);

                    var payload = new
                    {
                        sender = new { name = "Suporte Protegelar", email = emailRemetente },
                        to = new[] { new { email = emailDestino } },
                        subject = "Código de Recuperação - Protegelar",
                        htmlContent = $@"
                            <div style='font-family: sans-serif; padding: 20px; border: 1px solid #ddd; border-radius: 8px;'>
                                <h2 style='color: #2c3e50;'>Código de Segurança</h2>
                                <p>Olá! Use o código abaixo para redefinir sua senha no sistema <strong>Protegelar</strong>:</p>
                                <div style='background: #f8f9fa; padding: 15px; text-align: center; font-size: 28px; font-weight: bold; color: #e67e22; letter-spacing: 4px;'>
                                    {tokenGerado}
                                </div>
                                <p style='font-size: 12px; color: #95a5a6; margin-top: 20px;'>Se você não solicitou este código, ignore este e-mail.</p>
                            </div>"
                    };

                    string json = JsonSerializer.Serialize(payload);
                    var conteudo = new StringContent(json, Encoding.UTF8, "application/json");

                    // Envio para a API do Brevo
                    var resposta = await client.PostAsync("https://api.brevo.com/v3/smtp/email", conteudo);

                    if (resposta.IsSuccessStatusCode)
                    {
                        MessageBox.Show($"Código enviado com sucesso para {emailDestino}!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Mostra os campos de validação que você criou
                        txt_validarToken.Visible = true;
                        btn_validarToken.Visible = true;

                        // Desabilita o botão de envio para evitar spam de e-mails
                        btn_recuperarSenha.Enabled = false;
                    }
                    else
                    {
                        string erroDetalhado = await resposta.Content.ReadAsStringAsync();
                        MessageBox.Show("Erro na API Brevo: " + erroDetalhado, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha na conexão: " + ex.Message, "Erro de Rede", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            // Ao clicar retorna a tela de Login
            Form1 TelaLogin = new Form1();
            TelaLogin.ShowDialog();
            this.Close();
        }

        private void RecuperarSenha_Load(object sender, EventArgs e)
        {
            // Centraliza o painel principal na tela
            if (panel1 != null)
            {
                panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
                panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
            }

            // Garante que os campos de validação comecem ocultos
            txt_validarToken.Visible = false;
            btn_validarToken.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_validarToken_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_validarToken_Click(object sender, EventArgs e)
        {
            // Compara o que o usuário digitou no TextBox com o token gerado na memória
            if (txt_validarToken.Text == tokenGerado && !string.IsNullOrEmpty(tokenGerado))
            {
                try
                {
                    // Primeiro criamos a tela
                    RedefinirSenha telaRedefinir = new RedefinirSenha(txt_email_recuperarSenha.Text);

                    // IMPORTANTE: Mostramos a nova ANTES de esconder a antiga
                    telaRedefinir.Show();

                    // Força o Windows a renderizar a tela nova
                    Application.DoEvents();

                    // Agora escondemos a de recuperação
                    Form1 telaLogin = new Form1();
                    //this.Hide();
                }
                catch (Exception ex)
                {
                    // Se a tela RedefinirSenha sumir, esse erro vai dizer o porquê
                    MessageBox.Show("Erro ao carregar a tela de Redefinição: " + ex.Message, "Erro de Inicialização");
                }
            }
            else
            {
                MessageBox.Show("Código incorreto!", "Erro");
            }
        }
    }
}