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

            // 1. Validações Básicas
            if (string.IsNullOrWhiteSpace(novaSenha) || novaSenha.Length < 6)
            {
                MessageBox.Show("A senha deve ter pelo menos 6 caracteres.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (novaSenha != confirmaSenha)
            {
                MessageBox.Show("As senhas não coincidem!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 2. Lógica de Banco de Dados (Futuro)
            try
            {
                // Aqui você usará o 'this.emailUsuario' para saber qual linha do banco atualizar
                // Exemplo lógico: UPDATE usuarios SET senha = @senha WHERE email = @email;

                MessageBox.Show("Senha redefinida com sucesso no sistema Protegelar!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Fecha a tela e volta para o login
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar com o banco de dados: " + ex.Message);
            }
        }
    }
}
