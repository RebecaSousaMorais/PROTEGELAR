using BCrypt.Net;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJETO_INTEGRADOR
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();

            // Mantém a posição centralizada
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
            this.Close();
        }

        private void btn_criarConta_cadastro_Click(object sender, EventArgs e)
        {
            btn_criarConta_cadastro.Enabled = false;

            try
            {
                string nome =
                    txt_nomeCompleto_cadastro.Text.Trim();

                string email =
                    txt_email_cadastro.Text.Trim();

                string telefone =
                    txt_telefone_cadastro.Text.Trim();

                string senha =
                    txt_senha_cadastro.Text;

                string confirmarSenha =
                    txt_confirmarSenha_cadastro.Text;

                // Campos vazios
                if (string.IsNullOrWhiteSpace(nome) ||
                    string.IsNullOrWhiteSpace(email) ||
                    string.IsNullOrWhiteSpace(telefone) ||
                    string.IsNullOrWhiteSpace(senha) ||
                    string.IsNullOrWhiteSpace(confirmarSenha))
                {
                    MessageBox.Show(
                        "Preencha todos os campos obrigatórios!");

                    return;
                }

                // Validar telefone
                if (!Regex.IsMatch(telefone, @"^[1-9]{2}9\d{8}$"))
                {
                    MessageBox.Show(
                        "Telefone inválido. Digite 11 números com DDD."
                    );

                    return;
                }

                // Validar e-mail
                try
                {
                    var validarEmail =
                        new System.Net.Mail.MailAddress(email);
                }
                catch
                {
                    MessageBox.Show("E-mail inválido.");
                    return;
                }

                // Confirmar senha
                if (senha != confirmarSenha)
                {
                    MessageBox.Show(
                        "As senhas não coincidem!");

                    return;
                }

                // Validar senha forte
                if (!ValidarSenha(senha))
                {
                    MessageBox.Show(
                        "A senha deve possuir entre 8 e 25 caracteres, contendo letra maiúscula, minúscula, número e símbolo.");

                    return;
                }

                string senhaHash =
                    BCrypt.Net.BCrypt.HashPassword(senha);

                using (var conn = Conexao.GetConexao())
                {
                    conn.Open();

                    string query = @"
                    INSERT INTO Usuarios
                    (nome_completo, email, senha, telefone)
                    VALUES
                    (@nome, @email, @senha, @telefone)
                    ";

                    using (var cmd =
                        new SqliteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nome", nome);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@senha", senhaHash);
                        cmd.Parameters.AddWithValue("@telefone", telefone);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Usuário cadastrado com sucesso!");

                this.Close();
            }
            catch (SqliteException ex)
            {
                if (ex.SqliteErrorCode == 19)
                {
                    MessageBox.Show(
                        "E-mail já cadastrado.");
                }
                else
                {
                    MessageBox.Show(
                        "Erro no banco: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erro ao cadastrar: " + ex.Message);
            }
            finally
            {
                btn_criarConta_cadastro.Enabled = true;
            }
        }

        // Função para validar força da senha
        private bool ValidarSenha(string senha)
        {
            if (string.IsNullOrWhiteSpace(senha))
                return false;

            if (senha.Length < 8 || senha.Length > 25)
                return false;

            return senha.Any(char.IsUpper) &&
                   senha.Any(char.IsLower) &&
                   senha.Any(char.IsDigit) &&
                   senha.Any(ch =>
                       "!@#$%^&*()_+-=[]{}|;:'\",.<>?"
                       .Contains(ch));
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
