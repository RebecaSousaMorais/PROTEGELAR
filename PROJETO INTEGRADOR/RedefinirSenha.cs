using BCrypt.Net;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PROJETO_INTEGRADOR.Form1;

namespace PROJETO_INTEGRADOR
{
    public partial class RedefinirSenha : Form
    {
        private string emailUsuario;

        // O construtor agora aceita a string "emailValidado"
        public RedefinirSenha(string email)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            emailUsuario = email;
        }

        private void RedefinirSenha_Load(object sender, EventArgs e)
        {
            // Centraliza o painel
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;

            // Exibe o e-mail na label para o usuário ter certeza de qual conta está alterando
            lbl_usuarioEmail.Text = "Alterando senha de: " + emailUsuario;

            // Garante que as senhas comecem ocultas
            txt_novaSenha_redefinirSenha.UseSystemPasswordChar = true;
            txt_confirmarSenha_redefinirSenha.UseSystemPasswordChar = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Se o checkbox estiver marcado, mostra o texto. Se não, oculta
            bool ocultar = !chk_mostrarSenha_redefinirSenha.Checked;

            txt_confirmarSenha_redefinirSenha.UseSystemPasswordChar = ocultar;
            txt_novaSenha_redefinirSenha.UseSystemPasswordChar = ocultar;
        }

        private void txt_confirmarSenha_redefinirSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_usuarioEmail_Click(object sender, EventArgs e)
        {

        }

        private void btn_salvarNovaSenha_Click(object sender, EventArgs e)
        {
            string novaSenha = txt_novaSenha_redefinirSenha.Text;
            string confirmaSenha = txt_confirmarSenha_redefinirSenha.Text;

            // Campos vazios
            if (string.IsNullOrWhiteSpace(novaSenha) ||
                string.IsNullOrWhiteSpace(confirmaSenha))
            {
                MessageBox.Show(
                    "Preencha todos os campos.");

                return;
            }

            // Confirmação
            if (novaSenha != confirmaSenha)
            {
                MessageBox.Show(
                    "As senhas não coincidem!");

                return;
            }

            // Validação forte
            if (!ValidarSenha(novaSenha))
            {
                MessageBox.Show(
                    "A senha deve possuir entre 8 e 25 caracteres, contendo letra maiúscula, minúscula, número e símbolo.");

                return;
            }

            btn_salvarNovaSenha.Enabled = false;

            try
            {
                string hash = BCrypt.Net.BCrypt.HashPassword(novaSenha);

                using (var conn = Conexao.GetConexao())
                {
                    conn.Open();

                    string sql = @"
                        UPDATE Usuarios
                        SET senha = @senha
                        WHERE email = @email
                    ";

                    using (var cmd = new SqliteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@senha", hash);
                        cmd.Parameters.AddWithValue("@email", emailUsuario);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Senha atualizada com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar senha: " + ex.Message);
            }
            finally
            {
                btn_salvarNovaSenha.Enabled = true;
            }
        }

        // Validação forte da senha
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

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_novoOrcamento_Click(object sender, EventArgs e)
        {
            this.Hide();

            Servicos TelaServicos = new Servicos();

            TelaServicos.FormClosed += (s, args) =>
            {
                this.Show();
            };
            TelaServicos.Show();
        }

        private void btn_gerenciarServico_Click(object sender, EventArgs e)
        {
            this.Hide();
            Editar_Servicos TelaEditar = new Editar_Servicos();

            TelaEditar.FormClosed += (s, args) =>
            {
                this.Show();
            };
            TelaEditar.Show();
        }

        private void btn_verPerfil_Click(object sender, EventArgs e)
        {
            this.Hide();
            Perfil TelaPerfil = new Perfil();

            TelaPerfil.FormClosed += (s, args) =>
            {
                this.Show();
            };
            TelaPerfil.Show();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Sessao.Limpar();

            this.Hide();

            Form1 login = new Form1();

            login.Show();

            this.Close();
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
