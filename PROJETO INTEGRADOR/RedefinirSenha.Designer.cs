namespace PROJETO_INTEGRADOR
{
    partial class RedefinirSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RedefinirSenha));
            panel1 = new Panel();
            lbl_usuarioEmail = new Label();
            btn_salvarNovaSenha = new Button();
            chk_mostrarSenha_redefinirSenha = new CheckBox();
            txt_confirmarSenha_redefinirSenha = new TextBox();
            txt_novaSenha_redefinirSenha = new TextBox();
            label1 = new Label();
            lbl_novaSenha = new Label();
            lbl_redefinirSenha = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            btn_logout = new Button();
            btn_verPerfil = new Button();
            btn_novoOrcamento = new Button();
            btn_gerenciarServico = new Button();
            btn_home = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(lbl_usuarioEmail);
            panel1.Controls.Add(btn_salvarNovaSenha);
            panel1.Controls.Add(chk_mostrarSenha_redefinirSenha);
            panel1.Controls.Add(txt_confirmarSenha_redefinirSenha);
            panel1.Controls.Add(txt_novaSenha_redefinirSenha);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lbl_novaSenha);
            panel1.Controls.Add(lbl_redefinirSenha);
            panel1.Location = new Point(251, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(706, 426);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // lbl_usuarioEmail
            // 
            lbl_usuarioEmail.AutoSize = true;
            lbl_usuarioEmail.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_usuarioEmail.Location = new Point(71, 187);
            lbl_usuarioEmail.Name = "lbl_usuarioEmail";
            lbl_usuarioEmail.Size = new Size(61, 18);
            lbl_usuarioEmail.TabIndex = 8;
            lbl_usuarioEmail.Text = "E-mail: ";
            lbl_usuarioEmail.Click += lbl_usuarioEmail_Click;
            // 
            // btn_salvarNovaSenha
            // 
            btn_salvarNovaSenha.BackColor = Color.FromArgb(242, 101, 34);
            btn_salvarNovaSenha.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_salvarNovaSenha.ForeColor = Color.White;
            btn_salvarNovaSenha.Location = new Point(304, 256);
            btn_salvarNovaSenha.Name = "btn_salvarNovaSenha";
            btn_salvarNovaSenha.Size = new Size(133, 30);
            btn_salvarNovaSenha.TabIndex = 7;
            btn_salvarNovaSenha.Text = "Salvar Senha";
            btn_salvarNovaSenha.UseVisualStyleBackColor = false;
            btn_salvarNovaSenha.Click += btn_salvarNovaSenha_Click;
            // 
            // chk_mostrarSenha_redefinirSenha
            // 
            chk_mostrarSenha_redefinirSenha.AutoSize = true;
            chk_mostrarSenha_redefinirSenha.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chk_mostrarSenha_redefinirSenha.Location = new Point(576, 131);
            chk_mostrarSenha_redefinirSenha.Name = "chk_mostrarSenha_redefinirSenha";
            chk_mostrarSenha_redefinirSenha.Size = new Size(129, 22);
            chk_mostrarSenha_redefinirSenha.TabIndex = 6;
            chk_mostrarSenha_redefinirSenha.Text = "Mostrar Senha";
            chk_mostrarSenha_redefinirSenha.UseVisualStyleBackColor = true;
            chk_mostrarSenha_redefinirSenha.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // txt_confirmarSenha_redefinirSenha
            // 
            txt_confirmarSenha_redefinirSenha.Font = new Font("Arial", 12F);
            txt_confirmarSenha_redefinirSenha.Location = new Point(203, 132);
            txt_confirmarSenha_redefinirSenha.Name = "txt_confirmarSenha_redefinirSenha";
            txt_confirmarSenha_redefinirSenha.Size = new Size(353, 26);
            txt_confirmarSenha_redefinirSenha.TabIndex = 5;
            txt_confirmarSenha_redefinirSenha.TextChanged += txt_confirmarSenha_redefinirSenha_TextChanged;
            // 
            // txt_novaSenha_redefinirSenha
            // 
            txt_novaSenha_redefinirSenha.Font = new Font("Arial", 12F);
            txt_novaSenha_redefinirSenha.Location = new Point(203, 84);
            txt_novaSenha_redefinirSenha.Name = "txt_novaSenha_redefinirSenha";
            txt_novaSenha_redefinirSenha.Size = new Size(348, 26);
            txt_novaSenha_redefinirSenha.TabIndex = 4;
            txt_novaSenha_redefinirSenha.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F);
            label1.Location = new Point(71, 135);
            label1.Name = "label1";
            label1.Size = new Size(126, 18);
            label1.TabIndex = 3;
            label1.Text = "Confirmar Senha";
            // 
            // lbl_novaSenha
            // 
            lbl_novaSenha.AutoSize = true;
            lbl_novaSenha.Font = new Font("Arial", 12F);
            lbl_novaSenha.Location = new Point(71, 92);
            lbl_novaSenha.Name = "lbl_novaSenha";
            lbl_novaSenha.Size = new Size(93, 18);
            lbl_novaSenha.TabIndex = 2;
            lbl_novaSenha.Text = "Nova Senha";
            // 
            // lbl_redefinirSenha
            // 
            lbl_redefinirSenha.AutoSize = true;
            lbl_redefinirSenha.Font = new Font("Arial Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_redefinirSenha.ForeColor = Color.FromArgb(14, 79, 114);
            lbl_redefinirSenha.Location = new Point(188, 21);
            lbl_redefinirSenha.Name = "lbl_redefinirSenha";
            lbl_redefinirSenha.Size = new Size(349, 45);
            lbl_redefinirSenha.TabIndex = 1;
            lbl_redefinirSenha.Text = "REDEFINIR SENHA";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(26, 58, 90);
            panel2.Controls.Add(btn_home);
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
            pictureBox1.Location = new Point(12, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(227, 121);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // btn_logout
            // 
            btn_logout.BackColor = Color.FromArgb(242, 101, 34);
            btn_logout.FlatAppearance.BorderSize = 0;
            btn_logout.FlatStyle = FlatStyle.Flat;
            btn_logout.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            btn_logout.ForeColor = Color.White;
            btn_logout.Location = new Point(-3, 347);
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
            btn_verPerfil.Location = new Point(-3, 303);
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
            btn_novoOrcamento.Location = new Point(-3, 219);
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
            btn_gerenciarServico.Location = new Point(-3, 261);
            btn_gerenciarServico.Name = "btn_gerenciarServico";
            btn_gerenciarServico.Size = new Size(246, 36);
            btn_gerenciarServico.TabIndex = 3;
            btn_gerenciarServico.Text = "Editar Serviços";
            btn_gerenciarServico.TextAlign = ContentAlignment.MiddleLeft;
            btn_gerenciarServico.UseVisualStyleBackColor = false;
            btn_gerenciarServico.Click += btn_gerenciarServico_Click;
            // 
            // btn_home
            // 
            btn_home.BackColor = Color.FromArgb(242, 101, 34);
            btn_home.FlatAppearance.BorderSize = 0;
            btn_home.FlatStyle = FlatStyle.Flat;
            btn_home.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_home.ForeColor = Color.White;
            btn_home.Location = new Point(0, 177);
            btn_home.Name = "btn_home";
            btn_home.Size = new Size(246, 36);
            btn_home.TabIndex = 10;
            btn_home.Text = "Home";
            btn_home.TextAlign = ContentAlignment.MiddleLeft;
            btn_home.UseVisualStyleBackColor = false;
            btn_home.Click += btn_home_Click;
            // 
            // RedefinirSenha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1183, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "RedefinirSenha";
            Text = "RedefinirSenha";
            Load += RedefinirSenha_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lbl_novaSenha;
        private Label lbl_redefinirSenha;
        private TextBox txt_confirmarSenha_redefinirSenha;
        private TextBox txt_novaSenha_redefinirSenha;
        private Label label1;
        private CheckBox chk_mostrarSenha_redefinirSenha;
        private Button btn_salvarNovaSenha;
        private Label lbl_usuarioEmail;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button btn_logout;
        private Button btn_verPerfil;
        private Button btn_novoOrcamento;
        private Button btn_gerenciarServico;
        private Button btn_home;
    }
}