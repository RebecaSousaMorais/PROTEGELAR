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
    public partial class Perfil : Form
    {
        public Perfil()
        {
            InitializeComponent();

            // Inicia a tela maximizada
            this.WindowState = FormWindowState.Maximized;
        }

        private void lbl_perfil_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_editNome_Click(object sender, EventArgs e)
        {
            txt_nome_perfil.ReadOnly = false; txt_nome_perfil.Focus();
        }

        private void btn_editEmail_Click(object sender, EventArgs e)
        {
            txt_email_perfil.ReadOnly = false; txt_email_perfil.Focus();
        }

        private void btn_editSenha_Click(object sender, EventArgs e)
        {
            this.Hide();

            RedefinirSenha tela = new RedefinirSenha(
                Sessao.email
            );

            tela.ShowDialog();

            this.Show();
        }

        private void btn_editEndereco_Click(object sender, EventArgs e)
        {
            txt_endereco_perfil.ReadOnly = false; txt_endereco_perfil.Focus();
        }

        private void btn_editTelefone_Click(object sender, EventArgs e)
        {
            txt_telefone_perfil.ReadOnly = false; txt_telefone_perfil.Focus();
        }

        private void btn_salvarAlteracoes_Click(object sender, EventArgs e)
        {
            btn_salvarAlteracoes.Enabled = false;

            try
            {
                using (var conn = Conexao.GetConexao())
                {
                    conn.Open();

                    string sql = @"
                        UPDATE Usuarios
                        SET nome_completo = @nome,
                            endereco = @end,
                            telefone = @tel
                        WHERE id_usuario = @id
                    ";

                    using (var cmd = new SqliteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@nome", txt_nome_perfil.Text);
                        cmd.Parameters.AddWithValue("@end", txt_endereco_perfil.Text);
                        cmd.Parameters.AddWithValue("@tel", txt_telefone_perfil.Text);
                        cmd.Parameters.AddWithValue("@id", Sessao.id_usuario);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Dados atualizados com sucesso!");
                BloquearCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex.Message);
            }
            finally
            {
                btn_salvarAlteracoes.Enabled = true;
            }
        }

        private void Perfil_Load(object sender, EventArgs e)
        {
            CarregarDadosDoUsuario();
        }

        private void CarregarDadosDoUsuario()
        {
            if (Sessao.id_usuario <= 0)
                return;

            using (var conn = Conexao.GetConexao())
            {
                try
                {
                    conn.Open();

                    string sql = @"
                        SELECT nome_completo, email, telefone, endereco
                        FROM Usuarios
                        WHERE id_usuario = @id
                    ";

                    using (var cmd = new SqliteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", Sessao.id_usuario);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txt_nome_perfil.Text = reader["nome_completo"].ToString();
                                txt_email_perfil.Text = reader["email"].ToString();
                                txt_telefone_perfil.Text = reader["telefone"].ToString();
                                txt_endereco_perfil.Text = reader["endereco"].ToString();

                                txt_senha_perfil.Text = "********";
                                txt_senha_perfil.UseSystemPasswordChar = true;
                            }
                        }
                    }

                    BloquearCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar perfil: " + ex.Message);
                }
            }
        }

        private void BloquearCampos()
        {
            txt_nome_perfil.ReadOnly = true;
            txt_email_perfil.ReadOnly = true; // E-mail geralmente não se altera direto
            txt_telefone_perfil.ReadOnly = true;
            txt_endereco_perfil.ReadOnly = true;
            txt_senha_perfil.ReadOnly = true;
        }

        private void btn_voltar_cadastro_Click(object sender, EventArgs e)
        {
            Home TelaHome = new Home();
            TelaHome.ShowDialog();
            this.Hide();
        }
    }
}
