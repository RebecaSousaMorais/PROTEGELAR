namespace PROJETO_INTEGRADOR
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_login = new Label();
            lbl_Email_login = new Label();
            lbl_Senha_login = new Label();
            txt_email_login = new TextBox();
            txt_senha_login = new TextBox();
            panel1 = new Panel();
            lbl_esqueceuSenha_Login = new Label();
            btn_criarConta_login = new Button();
            btn_entrar_login = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_login
            // 
            lbl_login.AutoSize = true;
            lbl_login.Font = new Font("Arial Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_login.ForeColor = Color.FromArgb(27, 79, 114);
            lbl_login.Location = new Point(162, 49);
            lbl_login.Name = "lbl_login";
            lbl_login.Size = new Size(133, 45);
            lbl_login.TabIndex = 0;
            lbl_login.Text = "LOGIN";
            lbl_login.Click += lbl_login_Click;
            // 
            // lbl_Email_login
            // 
            lbl_Email_login.AutoSize = true;
            lbl_Email_login.Location = new Point(42, 128);
            lbl_Email_login.Name = "lbl_Email_login";
            lbl_Email_login.Size = new Size(41, 15);
            lbl_Email_login.TabIndex = 1;
            lbl_Email_login.Text = "E-mail";
            lbl_Email_login.Click += lbl_Email_login_Click;
            // 
            // lbl_Senha_login
            // 
            lbl_Senha_login.AutoSize = true;
            lbl_Senha_login.Location = new Point(42, 169);
            lbl_Senha_login.Name = "lbl_Senha_login";
            lbl_Senha_login.Size = new Size(39, 15);
            lbl_Senha_login.TabIndex = 2;
            lbl_Senha_login.Text = "Senha";
            lbl_Senha_login.Click += lbl_Senha_login_Click;
            // 
            // txt_email_login
            // 
            txt_email_login.Location = new Point(98, 125);
            txt_email_login.Name = "txt_email_login";
            txt_email_login.Size = new Size(280, 23);
            txt_email_login.TabIndex = 3;
            txt_email_login.TextChanged += txt_email_login_TextChanged;
            // 
            // txt_senha_login
            // 
            txt_senha_login.Location = new Point(98, 166);
            txt_senha_login.Name = "txt_senha_login";
            txt_senha_login.Size = new Size(280, 23);
            txt_senha_login.TabIndex = 4;
            txt_senha_login.TextChanged += txt_senha_login_TextChanged;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(lbl_esqueceuSenha_Login);
            panel1.Controls.Add(btn_criarConta_login);
            panel1.Controls.Add(btn_entrar_login);
            panel1.Controls.Add(txt_senha_login);
            panel1.Controls.Add(lbl_login);
            panel1.Controls.Add(lbl_Senha_login);
            panel1.Controls.Add(txt_email_login);
            panel1.Controls.Add(lbl_Email_login);
            panel1.Location = new Point(184, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(458, 343);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // lbl_esqueceuSenha_Login
            // 
            lbl_esqueceuSenha_Login.AutoSize = true;
            lbl_esqueceuSenha_Login.Location = new Point(98, 192);
            lbl_esqueceuSenha_Login.Name = "lbl_esqueceuSenha_Login";
            lbl_esqueceuSenha_Login.Size = new Size(105, 15);
            lbl_esqueceuSenha_Login.TabIndex = 7;
            lbl_esqueceuSenha_Login.Text = "Esqueceu a senha?";
            lbl_esqueceuSenha_Login.Click += lbl_esqueceuSenha_Login_Click;
            // 
            // btn_criarConta_login
            // 
            btn_criarConta_login.BackColor = Color.FromArgb(242, 101, 34);
            btn_criarConta_login.ForeColor = Color.White;
            btn_criarConta_login.Location = new Point(260, 272);
            btn_criarConta_login.Name = "btn_criarConta_login";
            btn_criarConta_login.Size = new Size(95, 29);
            btn_criarConta_login.TabIndex = 6;
            btn_criarConta_login.Text = "Criar Conta";
            btn_criarConta_login.UseVisualStyleBackColor = false;
            btn_criarConta_login.Click += btn_criarConta_login_Click;
            // 
            // btn_entrar_login
            // 
            btn_entrar_login.BackColor = Color.FromArgb(242, 101, 34);
            btn_entrar_login.ForeColor = Color.White;
            btn_entrar_login.Location = new Point(86, 272);
            btn_entrar_login.Name = "btn_entrar_login";
            btn_entrar_login.Size = new Size(95, 29);
            btn_entrar_login.TabIndex = 5;
            btn_entrar_login.Text = "Entrar";
            btn_entrar_login.UseVisualStyleBackColor = false;
            btn_entrar_login.Click += btn_entrar_login_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lbl_login;
        private Label lbl_Email_login;
        private Label lbl_Senha_login;
        private TextBox txt_email_login;
        private TextBox txt_senha_login;
        private Panel panel1;
        private Button btn_criarConta_login;
        private Button btn_entrar_login;
        private Label lbl_esqueceuSenha_Login;
    }
}
