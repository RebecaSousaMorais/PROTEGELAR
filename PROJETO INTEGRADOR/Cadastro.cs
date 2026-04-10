using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using BCrypt.Net;

namespace PROJETO_INTEGRADOR
{
    public partial class Cadastro : Form
    {
        // 1. String de conexão direta para o XAMPP (RNF01)
        private string stringConexao = "Server=localhost;Database=dbprotegelar;Uid=root;Pwd=;";
        public Cadastro()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            // Inicia a tela maximizada
            this.WindowState = FormWindowState.Maximized;
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {
            // Centraliza o painel branco (pnlPapel) na tela (RNF03)
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;

            txt_senha_cadastro.UseSystemPasswordChar = true;
            txt_confirmarSenha_cadastro.UseSystemPasswordChar = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_nomeCompleto_cadastro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_email_cadastro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_telefone_cadastro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_endResidencial_cadastro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_senha_cadastro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_confirmarSenha_cadastro_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_voltar_cadastro_Click(object sender, EventArgs e)
        {
            // Ao clicar retorna a tela de Login
            Form1 TelaLogin = new Form1();
            TelaLogin.ShowDialog();
        }

        private void btn_criarConta_cadastro_Click(object sender, EventArgs e)
        {
            // Coleta de dados (RF01)
            string nome = txt_nomeCompleto_cadastro.Text;
            string email = txt_email_cadastro.Text;
            string telefone = txt_telefone_cadastro.Text;
            string endereco = txt_endResidencial_cadastro.Text;
            string senha = txt_senha_cadastro.Text;
            string confirmarSenha = txt_confirmarSenha_cadastro.Text;

            // 🔹 RN04: Validação de campos vazios
            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(telefone) || string.IsNullOrWhiteSpace(endereco) ||
                string.IsNullOrWhiteSpace(senha) || string.IsNullOrWhiteSpace(confirmarSenha))
            {
                MessageBox.Show("Preencha todos os campos obrigatórios!");
                return;
            }

            // 🔹 RN06: Verificação de confirmação de senha
            if (senha != confirmarSenha)
            {
                MessageBox.Show("As senhas não coincidem!");
                return;
            }

            // 🔹 RN01: Validação de critérios mínimos de senha (8-25 caracteres)
            if (!ValidarSenha(senha))
            {
                MessageBox.Show("A senha deve ter entre 8 e 25 caracteres e conter: maiúscula, minúscula, número e símbolo.");
                return;
            }

            // 🔐 CRIPTOGRAFIA: Gerando o Hash da senha
            string senhaHash = BCrypt.Net.BCrypt.HashPassword(senha);

            using (MySqlConnection conn = new MySqlConnection(stringConexao))
            {
                try
                {
                    conn.Open();

                    // Query de Inserção (Note que enviamos o Hash, não a senha aberta)
                    string query = "INSERT INTO Usuarios (nome_completo, email, senha, endereco, telefone) VALUES (@nome, @email, @senha, @endereco, @telefone)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nome", nome);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@senha", senhaHash); // Salvando o Hash seguro
                        cmd.Parameters.AddWithValue("@endereco", endereco);
                        cmd.Parameters.AddWithValue("@telefone", telefone);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Usuário cadastrado com segurança!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar: " + ex.Message);
                }
            }
        }

        // Função para validar força da senha
        private bool ValidarSenha(string senha)
        {
            return senha.Length >= 8 &&
                   senha.Any(char.IsUpper) &&
                   senha.Any(char.IsLower) &&
                   senha.Any(char.IsDigit) &&
                   senha.Any(ch => "!@#$%^&*()_+-=[]{}|;:'\",.<>?".Contains(ch));
        }

        private void lbl_endResidencial_Click(object sender, EventArgs e)
        {

        }

        private void chk_mostrarSenha_cadastro_CheckedChanged(object sender, EventArgs e)
        {
            // Se o checkbox estiver marcado, mostra o texto. Se não, oculta
            bool ocultar = !chk_mostrarSenha_cadastro.Checked;

            txt_confirmarSenha_cadastro.UseSystemPasswordChar = ocultar;
            txt_senha_cadastro.UseSystemPasswordChar = ocultar;
        }
    }
}
