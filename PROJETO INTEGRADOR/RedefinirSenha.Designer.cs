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
            panel1 = new Panel();
            chk_mostrarSenha_redefinirSenha = new CheckBox();
            txt_confirmarSenha_redefinirSenha = new TextBox();
            txt_novaSenha_redefinirSenha = new TextBox();
            label1 = new Label();
            lbl_novaSenha = new Label();
            lbl_redefinirSenha = new Label();
            btn_salvarNovaSenha = new Button();
            lbl_usuarioEmail = new Label();
            panel1.SuspendLayout();
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
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 426);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
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
            txt_confirmarSenha_redefinirSenha.PasswordChar = '*';
            txt_confirmarSenha_redefinirSenha.Size = new Size(353, 26);
            txt_confirmarSenha_redefinirSenha.TabIndex = 5;
            txt_confirmarSenha_redefinirSenha.TextChanged += txt_confirmarSenha_redefinirSenha_TextChanged;
            // 
            // txt_novaSenha_redefinirSenha
            // 
            txt_novaSenha_redefinirSenha.Font = new Font("Arial", 12F);
            txt_novaSenha_redefinirSenha.Location = new Point(203, 84);
            txt_novaSenha_redefinirSenha.Name = "txt_novaSenha_redefinirSenha";
            txt_novaSenha_redefinirSenha.PasswordChar = '*';
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
            // btn_salvarNovaSenha
            // 
            btn_salvarNovaSenha.BackColor = Color.FromArgb(242, 101, 34);
            btn_salvarNovaSenha.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_salvarNovaSenha.ForeColor = Color.White;
            btn_salvarNovaSenha.Location = new Point(312, 288);
            btn_salvarNovaSenha.Name = "btn_salvarNovaSenha";
            btn_salvarNovaSenha.Size = new Size(133, 30);
            btn_salvarNovaSenha.TabIndex = 7;
            btn_salvarNovaSenha.Text = "Salvar Senha";
            btn_salvarNovaSenha.UseVisualStyleBackColor = false;
            btn_salvarNovaSenha.Click += btn_salvarNovaSenha_Click;
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
            // RedefinirSenha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "RedefinirSenha";
            Text = "RedefinirSenha";
            Load += RedefinirSenha_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
    }
}