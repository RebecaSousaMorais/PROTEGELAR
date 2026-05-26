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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Perfil));
            panel1 = new Panel();
            txt_email_perfil = new TextBox();
            lbl_email = new Label();
            txt_telefone_perfil = new MaskedTextBox();
            btn_voltar_perfil = new Button();
            btn_editSenha = new Button();
            btn_salvarAlteracoes = new Button();
            txt_senha_perfil = new TextBox();
            txt_nome_perfil = new TextBox();
            lbl_telefone = new Label();
            lbl_senha = new Label();
            lbl_nomeCompleto = new Label();
            lbl_perfil = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            btn_logout = new Button();
            btn_verPerfil = new Button();
            btn_novoOrcamento = new Button();
            btn_gerenciarServico = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(txt_email_perfil);
            panel1.Controls.Add(lbl_email);
            panel1.Controls.Add(txt_telefone_perfil);
            panel1.Controls.Add(btn_voltar_perfil);
            panel1.Controls.Add(btn_editSenha);
            panel1.Controls.Add(btn_salvarAlteracoes);
            panel1.Controls.Add(txt_senha_perfil);
            panel1.Controls.Add(txt_nome_perfil);
            panel1.Controls.Add(lbl_telefone);
            panel1.Controls.Add(lbl_senha);
            panel1.Controls.Add(lbl_nomeCompleto);
            panel1.Controls.Add(lbl_perfil);
            panel1.Location = new Point(252, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(992, 426);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // txt_email_perfil
            // 
            txt_email_perfil.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_email_perfil.Location = new Point(253, 128);
            txt_email_perfil.Name = "txt_email_perfil";
            txt_email_perfil.Size = new Size(320, 26);
            txt_email_perfil.TabIndex = 22;
            txt_email_perfil.TextChanged += txt_email_perfil_TextChanged;
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Font = new Font("Arial", 12F);
            lbl_email.Location = new Point(85, 128);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(53, 18);
            lbl_email.TabIndex = 21;
            lbl_email.Text = "E-mail";
            // 
            // txt_telefone_perfil
            // 
            txt_telefone_perfil.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_telefone_perfil.Location = new Point(253, 228);
            txt_telefone_perfil.Mask = "(00) 00000-0000";
            txt_telefone_perfil.Name = "txt_telefone_perfil";
            txt_telefone_perfil.Size = new Size(320, 26);
            txt_telefone_perfil.TabIndex = 19;
            txt_telefone_perfil.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
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
            // btn_editSenha
            // 
            btn_editSenha.BackColor = Color.FromArgb(242, 101, 34);
            btn_editSenha.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_editSenha.ForeColor = Color.White;
            btn_editSenha.Location = new Point(605, 176);
            btn_editSenha.Name = "btn_editSenha";
            btn_editSenha.Size = new Size(75, 31);
            btn_editSenha.TabIndex = 15;
            btn_editSenha.Text = "✏️";
            btn_editSenha.UseVisualStyleBackColor = false;
            btn_editSenha.Click += btn_editSenha_Click;
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
            // txt_senha_perfil
            // 
            txt_senha_perfil.Font = new Font("Arial", 12F);
            txt_senha_perfil.Location = new Point(253, 179);
            txt_senha_perfil.Name = "txt_senha_perfil";
            txt_senha_perfil.Size = new Size(320, 26);
            txt_senha_perfil.TabIndex = 9;
            // 
            // txt_nome_perfil
            // 
            txt_nome_perfil.Font = new Font("Arial", 12F);
            txt_nome_perfil.Location = new Point(253, 81);
            txt_nome_perfil.Name = "txt_nome_perfil";
            txt_nome_perfil.Size = new Size(320, 26);
            txt_nome_perfil.TabIndex = 7;
            // 
            // lbl_telefone
            // 
            lbl_telefone.AutoSize = true;
            lbl_telefone.Font = new Font("Arial", 12F);
            lbl_telefone.Location = new Point(85, 226);
            lbl_telefone.Name = "lbl_telefone";
            lbl_telefone.Size = new Size(66, 18);
            lbl_telefone.TabIndex = 6;
            lbl_telefone.Text = "Telefone";
            // 
            // lbl_senha
            // 
            lbl_senha.AutoSize = true;
            lbl_senha.Font = new Font("Arial", 12F);
            lbl_senha.Location = new Point(85, 179);
            lbl_senha.Name = "lbl_senha";
            lbl_senha.Size = new Size(53, 18);
            lbl_senha.TabIndex = 4;
            lbl_senha.Text = "Senha";
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
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(26, 58, 90);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(btn_logout);
            panel2.Controls.Add(btn_verPerfil);
            panel2.Controls.Add(btn_novoOrcamento);
            panel2.Controls.Add(btn_gerenciarServico);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(246, 450);
            panel2.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(26, 58, 90);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(10, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(227, 121);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btn_logout
            // 
            btn_logout.BackColor = Color.FromArgb(242, 101, 34);
            btn_logout.FlatAppearance.BorderSize = 0;
            btn_logout.FlatStyle = FlatStyle.Flat;
            btn_logout.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            btn_logout.ForeColor = Color.White;
            btn_logout.Location = new Point(0, 268);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(246, 38);
            btn_logout.TabIndex = 6;
            btn_logout.Text = "Sair";
            btn_logout.TextAlign = ContentAlignment.MiddleLeft;
            btn_logout.UseVisualStyleBackColor = false;
            btn_logout.Click += btn_logout_Click;
            // 
            // btn_verPerfil
            // 
            btn_verPerfil.BackColor = Color.FromArgb(242, 101, 34);
            btn_verPerfil.FlatAppearance.BorderSize = 0;
            btn_verPerfil.FlatStyle = FlatStyle.Flat;
            btn_verPerfil.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            btn_verPerfil.ForeColor = Color.White;
            btn_verPerfil.Location = new Point(0, 224);
            btn_verPerfil.Name = "btn_verPerfil";
            btn_verPerfil.Size = new Size(246, 38);
            btn_verPerfil.TabIndex = 7;
            btn_verPerfil.Text = "Perfil";
            btn_verPerfil.TextAlign = ContentAlignment.MiddleLeft;
            btn_verPerfil.UseVisualStyleBackColor = false;
            btn_verPerfil.Click += btn_verPerfil_Click;
            // 
            // btn_novoOrcamento
            // 
            btn_novoOrcamento.BackColor = Color.FromArgb(242, 101, 34);
            btn_novoOrcamento.FlatAppearance.BorderSize = 0;
            btn_novoOrcamento.FlatStyle = FlatStyle.Flat;
            btn_novoOrcamento.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_novoOrcamento.ForeColor = Color.White;
            btn_novoOrcamento.Location = new Point(0, 140);
            btn_novoOrcamento.Name = "btn_novoOrcamento";
            btn_novoOrcamento.Size = new Size(246, 36);
            btn_novoOrcamento.TabIndex = 2;
            btn_novoOrcamento.Text = "Novo Orçamento";
            btn_novoOrcamento.TextAlign = ContentAlignment.MiddleLeft;
            btn_novoOrcamento.UseVisualStyleBackColor = false;
            btn_novoOrcamento.Click += btn_novoOrcamento_Click;
            // 
            // btn_gerenciarServico
            // 
            btn_gerenciarServico.BackColor = Color.FromArgb(242, 101, 34);
            btn_gerenciarServico.FlatAppearance.BorderSize = 0;
            btn_gerenciarServico.FlatStyle = FlatStyle.Flat;
            btn_gerenciarServico.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            btn_gerenciarServico.ForeColor = Color.White;
            btn_gerenciarServico.Location = new Point(0, 182);
            btn_gerenciarServico.Name = "btn_gerenciarServico";
            btn_gerenciarServico.Size = new Size(246, 36);
            btn_gerenciarServico.TabIndex = 3;
            btn_gerenciarServico.Text = "Editar Serviços";
            btn_gerenciarServico.TextAlign = ContentAlignment.MiddleLeft;
            btn_gerenciarServico.UseVisualStyleBackColor = false;
            btn_gerenciarServico.Click += btn_gerenciarServico_Click;
            // 
            // Perfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1256, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Perfil";
            Text = "Perfil";
            Load += Perfil_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lbl_perfil;
        private Label lbl_telefone;
        private Label lbl_senha;
        private Label lbl_nomeCompleto;
        private TextBox txt_senha_perfil;
        private TextBox txt_nome_perfil;
        private Button btn_salvarAlteracoes;
        private Button btn_editSenha;
        private Button btn_voltar_perfil;
        private MaskedTextBox txt_telefone_perfil;
        private Label lbl_email;
        private TextBox txt_email_perfil;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button btn_logout;
        private Button btn_verPerfil;
        private Button btn_novoOrcamento;
        private Button btn_gerenciarServico;
    }
}