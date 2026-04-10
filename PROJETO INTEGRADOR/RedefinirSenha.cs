using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using BCrypt.Net;

namespace PROJETO_INTEGRADOR
{
    public partial class RedefinirSenha : Form
    {
        // Variável para guardar o e-mail que veio da tela de Recuperar
        private string emailUsuario;


        // O construtor agora aceita a string "emailRecebido"
        public RedefinirSenha(string emailRecebido)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;

            // Guarda o e-mail internamente
            this.emailUsuario = emailRecebido;
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

            // 1. Validações Básicas (já existentes)
            if (string.IsNullOrWhiteSpace(novaSenha) || novaSenha.Length < 8)
            {
                MessageBox.Show("A senha deve ter pelo menos 8 caracteres.", "Aviso");
                return;
            }

            if (novaSenha != confirmaSenha)
            {
                MessageBox.Show("As senhas não coincidem!", "Erro");
                return;
            }

            // 🔐 2. CRIPTOGRAFIA: Gerar o Hash da nova senha
            string novoHash = BCrypt.Net.BCrypt.HashPassword(novaSenha);

            // 3. Lógica de Banco de Dados
            using (MySqlConnection conn = new MySqlConnection("Server=localhost;Database=dbprotegelar;Uid=root;Pwd=;"))
            {
                try
                {
                    conn.Open();
                    // Usamos o 'emailUsuario' que você já recebe no construtor da tela
                    string query = "UPDATE Usuarios SET senha = @senha WHERE email = @email";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@senha", novoHash); // Enviando o Hash
                        cmd.Parameters.AddWithValue("@email", this.emailUsuario);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Senha redefinida com sucesso!", "Sucesso");
                    this.Close(); // Volta para o Login
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar banco: " + ex.Message);
                }
            }
        }
    }
}
