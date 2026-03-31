namespace PROJETO_INTEGRADOR
{
    partial class RecuperarSenha
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
            btn_voltar_recuperarSenha = new Button();
            lbl_textoRecSenha = new Label();
            btn_recuperarSenha = new Button();
            lbl_email_recSenha = new Label();
            txt_email_recuperarSenha = new TextBox();
            lbl_recuperarSenha = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(btn_voltar_recuperarSenha);
            panel1.Controls.Add(lbl_textoRecSenha);
            panel1.Controls.Add(btn_recuperarSenha);
            panel1.Controls.Add(lbl_email_recSenha);
            panel1.Controls.Add(txt_email_recuperarSenha);
            panel1.Controls.Add(lbl_recuperarSenha);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 426);
            panel1.TabIndex = 0;
            // 
            // btn_voltar_recuperarSenha
            // 
            btn_voltar_recuperarSenha.BackColor = Color.FromArgb(242, 101, 34);
            btn_voltar_recuperarSenha.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_voltar_recuperarSenha.ForeColor = Color.White;
            btn_voltar_recuperarSenha.Location = new Point(374, 221);
            btn_voltar_recuperarSenha.Name = "btn_voltar_recuperarSenha";
            btn_voltar_recuperarSenha.Size = new Size(139, 32);
            btn_voltar_recuperarSenha.TabIndex = 15;
            btn_voltar_recuperarSenha.Text = "Voltar";
            btn_voltar_recuperarSenha.UseVisualStyleBackColor = false;
            btn_voltar_recuperarSenha.Click += btn_voltar_recuperarSenha_Click;
            // 
            // lbl_textoRecSenha
            // 
            lbl_textoRecSenha.AutoSize = true;
            lbl_textoRecSenha.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_textoRecSenha.Location = new Point(231, 103);
            lbl_textoRecSenha.Name = "lbl_textoRecSenha";
            lbl_textoRecSenha.Size = new Size(282, 18);
            lbl_textoRecSenha.TabIndex = 4;
            lbl_textoRecSenha.Text = "Insira seu email para recuperar a senha";
            // 
            // btn_recuperarSenha
            // 
            btn_recuperarSenha.BackColor = Color.FromArgb(242, 101, 34);
            btn_recuperarSenha.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_recuperarSenha.ForeColor = Color.White;
            btn_recuperarSenha.Location = new Point(215, 221);
            btn_recuperarSenha.Name = "btn_recuperarSenha";
            btn_recuperarSenha.Size = new Size(141, 31);
            btn_recuperarSenha.TabIndex = 3;
            btn_recuperarSenha.Text = "Recuperar Senha";
            btn_recuperarSenha.UseVisualStyleBackColor = false;
            btn_recuperarSenha.Click += btn_recuperarSenha_Click;
            // 
            // lbl_email_recSenha
            // 
            lbl_email_recSenha.AutoSize = true;
            lbl_email_recSenha.Location = new Point(152, 160);
            lbl_email_recSenha.Name = "lbl_email_recSenha";
            lbl_email_recSenha.Size = new Size(41, 15);
            lbl_email_recSenha.TabIndex = 2;
            lbl_email_recSenha.Text = "E-mail";
            // 
            // txt_email_recuperarSenha
            // 
            txt_email_recuperarSenha.Location = new Point(215, 157);
            txt_email_recuperarSenha.Name = "txt_email_recuperarSenha";
            txt_email_recuperarSenha.Size = new Size(298, 23);
            txt_email_recuperarSenha.TabIndex = 1;
            // 
            // lbl_recuperarSenha
            // 
            lbl_recuperarSenha.AutoSize = true;
            lbl_recuperarSenha.Font = new Font("Arial Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_recuperarSenha.ForeColor = Color.FromArgb(14, 79, 114);
            lbl_recuperarSenha.Location = new Point(185, 17);
            lbl_recuperarSenha.Name = "lbl_recuperarSenha";
            lbl_recuperarSenha.Size = new Size(377, 45);
            lbl_recuperarSenha.TabIndex = 0;
            lbl_recuperarSenha.Text = "RECUPERAR SENHA";
            // 
            // RecuperarSenha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "RecuperarSenha";
            Text = "RecuperarSenha";
            Load += RecuperarSenha_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lbl_recuperarSenha;
        private Label lbl_email_recSenha;
        private TextBox txt_email_recuperarSenha;
        private Button btn_recuperarSenha;
        private Label lbl_textoRecSenha;
        private Button btn_voltar_recuperarSenha;
    }
}