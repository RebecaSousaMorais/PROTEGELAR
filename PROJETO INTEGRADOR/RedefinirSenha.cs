using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
using BCrypt.Net;

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

            if (string.IsNullOrWhiteSpace(novaSenha) || novaSenha.Length < 8)
            {
                MessageBox.Show("A senha deve ter pelo menos 8 caracteres.");
                return;
            }

            if (novaSenha != confirmaSenha)
            {
                MessageBox.Show("As senhas não coincidem!");
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
    }
}
