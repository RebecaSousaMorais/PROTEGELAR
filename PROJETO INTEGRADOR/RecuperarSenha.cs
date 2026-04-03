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
       // private string tokenGerado = string.Empty;

        public RecuperarSenha()
        {
            /*
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            // Tenta carregar o .env de 3 formas diferentes para garantir que funcione em qualquer PC
            try
            {
                // 1. Tenta carregar da pasta onde o .exe está rodando (bin/Debug)
                if (System.IO.File.Exists(".env"))
                {
                    Env.Load();
                }
                else
                {
                    // 2. Tenta carregar subindo 2 níveis (Raiz do Projeto)
                    string caminhoProjeto = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", ".env");

                    // 3. Tenta carregar subindo 3 níveis (Raiz da Solução - caso use pastas extras)
                    string caminhoSolucao = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", ".env");

                    if (System.IO.File.Exists(caminhoProjeto)) Env.Load(caminhoProjeto);
                    else if (System.IO.File.Exists(caminhoSolucao)) Env.Load(caminhoSolucao);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao localizar .env: " + ex.Message);
            }
            */
        }

        private async void btn_recuperarSenha_Click(object sender, EventArgs e)
        {
            /*
            // Configurações de Segurança de Rede para evitar erros de SSL/TLS
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls13;

            string emailDestino = txt_email_recuperarSenha.Text;

            // Validação de entrada
            if (string.IsNullOrWhiteSpace(emailDestino) || !emailDestino.Contains("@"))
            {
                MessageBox.Show("Por favor, insira um e-mail válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. BUSCA OS DADOS DO ARQUIVO .ENV (Protegendo sua chave e seu e-mail)
            string apiKey = Env.GetString("BREVO_API_KEY");
            string emailRemetente = Env.GetString("EMAIL_REMETENTE");

            // Verifica se as variáveis foram carregadas corretamente
            if (string.IsNullOrEmpty(apiKey) || string.IsNullOrEmpty(emailRemetente))
            {
                MessageBox.Show("Erro: Arquivo .env não encontrado ou variáveis vazias!", "Erro Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 3. Gerar o código de 6 dígitos
            tokenGerado = new Random().Next(100000, 999999).ToString();

            // Handler para ignorar erros de certificado (SSL) em redes restritas
            var handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => { return true; };

            using (var client = new HttpClient(handler))
            {
                try
                {
                    client.DefaultRequestHeaders.Clear();
                    // USA A CHAVE VINDA DO .ENV
                    client.DefaultRequestHeaders.Add("api-key", apiKey);

                    // 4. Montar o JSON para a API do Brevo
                    var payload = new
                    {
                        sender = new { name = "Suporte Protegelar", email = emailRemetente },
                        to = new[] { new { email = emailDestino } },
                        subject = "Recuperação de Acesso - Protegelar",
                        htmlContent = $@"
                            <div style='font-family: sans-serif; padding: 20px; border: 1px solid #ddd; border-radius: 8px;'>
                                <h2 style='color: #2c3e50;'>Código de Segurança</h2>
                                <p>Olá! Use o código abaixo para redefinir sua senha no sistema <strong>Protegelar</strong>:</p>
                                <div style='background: #f8f9fa; padding: 15px; text-align: center; font-size: 28px; font-weight: bold; color: #e74c3c; letter-spacing: 4px;'>
                                    {tokenGerado}
                                </div>
                                <p style='font-size: 12px; color: #95a5a6; margin-top: 20px;'>Se você não solicitou este código, ignore este e-mail.</p>
                            </div>"
                    };

                    string json = JsonSerializer.Serialize(payload);
                    var conteudo = new StringContent(json, Encoding.UTF8, "application/json");

                    // 5. Envio Assíncrono para não travar a interface
                    var resposta = await client.PostAsync("https://api.brevo.com/v3/smtp/email", conteudo);

                    if (resposta.IsSuccessStatusCode)
                    {
                        MessageBox.Show($"Código enviado com sucesso para {emailDestino}!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Opcional: Mostrar campos para digitar o código e validar
                        // txt_validarToken.Visible = true;
                        // btn_confirmarToken.Visible = true;
                    }
                    else
                    {
                        string erroBody = await resposta.Content.ReadAsStringAsync();
                        MessageBox.Show("Erro ao enviar: " + erroBody, "Erro API", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha na conexão: " + ex.Message, "Erro Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                */
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close(); // Volta para a tela de login
        }

        private void RecuperarSenha_Load(object sender, EventArgs e)
        {

        }
    }
}