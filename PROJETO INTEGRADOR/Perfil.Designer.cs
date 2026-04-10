namespace PROJETO_INTEGRADOR
{
    partial class Perfil
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btn_editTelefone = new Button();
            btn_editEndereco = new Button();
            btn_editSenha = new Button();
            btn_editNome = new Button();
            btn_editEmail = new Button();
            btn_salvarAlteracoes = new Button();
            txt_telefone_perfil = new TextBox();
            txt_email_perfil = new TextBox();
            txt_senha_perfil = new TextBox();
            txt_endereco_perfil = new TextBox();
            txt_nome_perfil = new TextBox();
            lbl_telefone = new Label();
            lbl_endereco = new Label();
            lbl_senha = new Label();
            lbl_email = new Label();
            lbl_nomeCompleto = new Label();
            lbl_perfil = new Label();
            btn_voltar_perfil = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(btn_voltar_perfil);
            panel1.Controls.Add(btn_editTelefone);
            panel1.Controls.Add(btn_editEndereco);
            panel1.Controls.Add(btn_editSenha);
            panel1.Controls.Add(btn_editNome);
            panel1.Controls.Add(btn_editEmail);
            panel1.Controls.Add(btn_salvarAlteracoes);
            panel1.Controls.Add(txt_telefone_perfil);
            panel1.Controls.Add(txt_email_perfil);
            panel1.Controls.Add(txt_senha_perfil);
            panel1.Controls.Add(txt_endereco_perfil);
            panel1.Controls.Add(txt_nome_perfil);
            panel1.Controls.Add(lbl_telefone);
            panel1.Controls.Add(lbl_endereco);
            panel1.Controls.Add(lbl_senha);
            panel1.Controls.Add(lbl_email);
            panel1.Controls.Add(lbl_nomeCompleto);
            panel1.Controls.Add(lbl_perfil);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 426);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btn_editTelefone
            // 
            btn_editTelefone.BackColor = Color.FromArgb(242, 101, 34);
            btn_editTelefone.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_editTelefone.ForeColor = Color.White;
            btn_editTelefone.Location = new Point(570, 236);
            btn_editTelefone.Name = "btn_editTelefone";
            btn_editTelefone.Size = new Size(75, 31);
            btn_editTelefone.TabIndex = 17;
            btn_editTelefone.Text = "✏️";
            btn_editTelefone.UseVisualStyleBackColor = false;
            btn_editTelefone.Click += btn_editTelefone_Click;
            // 
            // btn_editEndereco
            // 
            btn_editEndereco.BackColor = Color.FromArgb(242, 101, 34);
            btn_editEndereco.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_editEndereco.ForeColor = Color.White;
            btn_editEndereco.Location = new Point(570, 196);
            btn_editEndereco.Name = "btn_editEndereco";
            btn_editEndereco.Size = new Size(75, 31);
            btn_editEndereco.TabIndex = 16;
            btn_editEndereco.Text = "✏️";
            btn_editEndereco.UseVisualStyleBackColor = false;
            btn_editEndereco.Click += btn_editEndereco_Click;
            // 
            // btn_editSenha
            // 
            btn_editSenha.BackColor = Color.FromArgb(242, 101, 34);
            btn_editSenha.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_editSenha.ForeColor = Color.White;
            btn_editSenha.Location = new Point(570, 159);
            btn_editSenha.Name = "btn_editSenha";
            btn_editSenha.Size = new Size(75, 31);
            btn_editSenha.TabIndex = 15;
            btn_editSenha.Text = "✏️";
            btn_editSenha.UseVisualStyleBackColor = false;
            btn_editSenha.Click += btn_editSenha_Click;
            // 
            // btn_editNome
            // 
            btn_editNome.BackColor = Color.FromArgb(242, 101, 34);
            btn_editNome.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_editNome.ForeColor = Color.White;
            btn_editNome.Location = new Point(570, 75);
            btn_editNome.Name = "btn_editNome";
            btn_editNome.Size = new Size(75, 30);
            btn_editNome.TabIndex = 14;
            btn_editNome.Text = "✏️";
            btn_editNome.UseVisualStyleBackColor = false;
            btn_editNome.Click += btn_editNome_Click;
            // 
            // btn_editEmail
            // 
            btn_editEmail.BackColor = Color.FromArgb(242, 101, 34);
            btn_editEmail.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_editEmail.ForeColor = Color.White;
            btn_editEmail.Location = new Point(570, 117);
            btn_editEmail.Name = "btn_editEmail";
            btn_editEmail.Size = new Size(75, 30);
            btn_editEmail.TabIndex = 13;
            btn_editEmail.Text = "✏️";
            btn_editEmail.UseVisualStyleBackColor = false;
            btn_editEmail.Click += btn_editEmail_Click;
            // 
            // btn_salvarAlteracoes
            // 
            btn_salvarAlteracoes.BackColor = Color.FromArgb(242, 101, 34);
            btn_salvarAlteracoes.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_salvarAlteracoes.ForeColor = Color.White;
            btn_salvarAlteracoes.Location = new Point(253, 329);
            btn_salvarAlteracoes.Name = "btn_salvarAlteracoes";
            btn_salvarAlteracoes.Size = new Size(152, 30);
            btn_salvarAlteracoes.TabIndex = 12;
            btn_salvarAlteracoes.Text = "Salvar Alterações";
            btn_salvarAlteracoes.UseVisualStyleBackColor = false;
            btn_salvarAlteracoes.Click += btn_salvarAlteracoes_Click;
            // 
            // txt_telefone_perfil
            // 
            txt_telefone_perfil.Font = new Font("Arial", 12F);
            txt_telefone_perfil.Location = new Point(253, 242);
            txt_telefone_perfil.Name = "txt_telefone_perfil";
            txt_telefone_perfil.Size = new Size(288, 26);
            txt_telefone_perfil.TabIndex = 11;
            // 
            // txt_email_perfil
            // 
            txt_email_perfil.Font = new Font("Arial", 12F);
            txt_email_perfil.Location = new Point(253, 123);
            txt_email_perfil.Name = "txt_email_perfil";
            txt_email_perfil.Size = new Size(288, 26);
            txt_email_perfil.TabIndex = 10;
            // 
            // txt_senha_perfil
            // 
            txt_senha_perfil.Font = new Font("Arial", 12F);
            txt_senha_perfil.Location = new Point(253, 165);
            txt_senha_perfil.Name = "txt_senha_perfil";
            txt_senha_perfil.Size = new Size(288, 26);
            txt_senha_perfil.TabIndex = 9;
            // 
            // txt_endereco_perfil
            // 
            txt_endereco_perfil.Font = new Font("Arial", 12F);
            txt_endereco_perfil.Location = new Point(253, 202);
            txt_endereco_perfil.Name = "txt_endereco_perfil";
            txt_endereco_perfil.Size = new Size(288, 26);
            txt_endereco_perfil.TabIndex = 8;
            // 
            // txt_nome_perfil
            // 
            txt_nome_perfil.Font = new Font("Arial", 12F);
            txt_nome_perfil.Location = new Point(253, 81);
            txt_nome_perfil.Name = "txt_nome_perfil";
            txt_nome_perfil.Size = new Size(288, 26);
            txt_nome_perfil.TabIndex = 7;
            // 
            // lbl_telefone
            // 
            lbl_telefone.AutoSize = true;
            lbl_telefone.Font = new Font("Arial", 12F);
            lbl_telefone.Location = new Point(85, 242);
            lbl_telefone.Name = "lbl_telefone";
            lbl_telefone.Size = new Size(66, 18);
            lbl_telefone.TabIndex = 6;
            lbl_telefone.Text = "Telefone";
            // 
            // lbl_endereco
            // 
            lbl_endereco.AutoSize = true;
            lbl_endereco.Font = new Font("Arial", 12F);
            lbl_endereco.Location = new Point(85, 202);
            lbl_endereco.Name = "lbl_endereco";
            lbl_endereco.Size = new Size(162, 18);
            lbl_endereco.TabIndex = 5;
            lbl_endereco.Text = "Endereço Residencial";
            // 
            // lbl_senha
            // 
            lbl_senha.AutoSize = true;
            lbl_senha.Font = new Font("Arial", 12F);
            lbl_senha.Location = new Point(85, 165);
            lbl_senha.Name = "lbl_senha";
            lbl_senha.Size = new Size(53, 18);
            lbl_senha.TabIndex = 4;
            lbl_senha.Text = "Senha";
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Font = new Font("Arial", 12F);
            lbl_email.Location = new Point(85, 123);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(53, 18);
            lbl_email.TabIndex = 3;
            lbl_email.Text = "E-mail";
            // 
            // lbl_nomeCompleto
            // 
            lbl_nomeCompleto.AutoSize = true;
            lbl_nomeCompleto.Font = new Font("Arial", 12F);
            lbl_nomeCompleto.Location = new Point(85, 81);
            lbl_nomeCompleto.Name = "lbl_nomeCompleto";
            lbl_nomeCompleto.Size = new Size(122, 18);
            lbl_nomeCompleto.TabIndex = 2;
            lbl_nomeCompleto.Text = "Nome Completo";
            // 
            // lbl_perfil
            // 
            lbl_perfil.AutoSize = true;
            lbl_perfil.Font = new Font("Arial Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_perfil.ForeColor = Color.FromArgb(14, 79, 114);
            lbl_perfil.Location = new Point(253, 11);
            lbl_perfil.Name = "lbl_perfil";
            lbl_perfil.Size = new Size(258, 45);
            lbl_perfil.TabIndex = 1;
            lbl_perfil.Text = "MEUS DADOS";
            lbl_perfil.Click += lbl_perfil_Click;
            // 
            // btn_voltar_perfil
            // 
            btn_voltar_perfil.BackColor = Color.FromArgb(242, 101, 34);
            btn_voltar_perfil.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_voltar_perfil.ForeColor = Color.White;
            btn_voltar_perfil.Location = new Point(422, 328);
            btn_voltar_perfil.Name = "btn_voltar_perfil";
            btn_voltar_perfil.Size = new Size(139, 32);
            btn_voltar_perfil.TabIndex = 18;
            btn_voltar_perfil.Text = "Voltar";
            btn_voltar_perfil.UseVisualStyleBackColor = false;
            btn_voltar_perfil.Click += btn_voltar_cadastro_Click;
            // 
            // Perfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Perfil";
            Text = "Perfil";
            Load += Perfil_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lbl_perfil;
        private Label lbl_telefone;
        private Label lbl_endereco;
        private Label lbl_senha;
        private Label lbl_email;
        private Label lbl_nomeCompleto;
        private TextBox txt_email_perfil;
        private TextBox txt_senha_perfil;
        private TextBox txt_endereco_perfil;
        private TextBox txt_nome_perfil;
        private TextBox txt_telefone_perfil;
        private Button btn_salvarAlteracoes;
        private Button btn_editEndereco;
        private Button btn_editSenha;
        private Button btn_editNome;
        private Button btn_editEmail;
        private Button btn_editTelefone;
        private Button btn_voltar_perfil;
    }
}