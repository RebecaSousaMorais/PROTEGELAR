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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lbl_login = new Label();
            lbl_Email_login = new Label();
            lbl_Senha_login = new Label();
            txt_email_login = new TextBox();
            txt_senha_login = new TextBox();
            panel1 = new Panel();
            chk_mostrarSenha_login = new CheckBox();
            pictureBox1 = new PictureBox();
            lbl_esqueceuSenha_Login = new Label();
            btn_criarConta_login = new Button();
            btn_entrar_login = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl_login
            // 
            lbl_login.AutoSize = true;
            lbl_login.Font = new Font("Arial Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_login.ForeColor = Color.FromArgb(27, 79, 114);
            lbl_login.Location = new Point(223, 196);
            lbl_login.Name = "lbl_login";
            lbl_login.Size = new Size(133, 45);
            lbl_login.TabIndex = 0;
            lbl_login.Text = "LOGIN";
            lbl_login.Click += lbl_login_Click;
            // 
            // lbl_Email_login
            // 
            lbl_Email_login.AutoSize = true;
            lbl_Email_login.Font = new Font("Arial", 12F);
            lbl_Email_login.Location = new Point(103, 275);
            lbl_Email_login.Name = "lbl_Email_login";
            lbl_Email_login.Size = new Size(53, 18);
            lbl_Email_login.TabIndex = 1;
            lbl_Email_login.Text = "E-mail";
            lbl_Email_login.Click += lbl_Email_login_Click;
            // 
            // lbl_Senha_login
            // 
            lbl_Senha_login.AutoSize = true;
            lbl_Senha_login.Font = new Font("Arial", 12F);
            lbl_Senha_login.Location = new Point(103, 316);
            lbl_Senha_login.Name = "lbl_Senha_login";
            lbl_Senha_login.Size = new Size(53, 18);
            lbl_Senha_login.TabIndex = 2;
            lbl_Senha_login.Text = "Senha";
            lbl_Senha_login.Click += lbl_Senha_login_Click;
            // 
            // txt_email_login
            // 
            txt_email_login.Font = new Font("Arial", 12F);
            txt_email_login.Location = new Point(159, 272);
            txt_email_login.Name = "txt_email_login";
            txt_email_login.Size = new Size(307, 26);
            txt_email_login.TabIndex = 3;
            txt_email_login.TextChanged += txt_email_login_TextChanged;
            // 
            // txt_senha_login
            // 
            txt_senha_login.Font = new Font("Arial", 12F);
            txt_senha_login.Location = new Point(159, 313);
            txt_senha_login.Name = "txt_senha_login";
            txt_senha_login.Size = new Size(307, 26);
            txt_senha_login.TabIndex = 4;
            txt_senha_login.TextChanged += txt_senha_login_TextChanged;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(chk_mostrarSenha_login);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lbl_esqueceuSenha_Login);
            panel1.Controls.Add(btn_criarConta_login);
            panel1.Controls.Add(btn_entrar_login);
            panel1.Controls.Add(txt_senha_login);
            panel1.Controls.Add(lbl_login);
            panel1.Controls.Add(lbl_Senha_login);
            panel1.Controls.Add(txt_email_login);
            panel1.Controls.Add(lbl_Email_login);
            panel1.Location = new Point(188, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(626, 513);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // chk_mostrarSenha_login
            // 
            chk_mostrarSenha_login.AutoSize = true;
            chk_mostrarSenha_login.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chk_mostrarSenha_login.Location = new Point(475, 312);
            chk_mostrarSenha_login.Name = "chk_mostrarSenha_login";
            chk_mostrarSenha_login.Size = new Size(129, 22);
            chk_mostrarSenha_login.TabIndex = 9;
            chk_mostrarSenha_login.Text = "Mostrar Senha";
            chk_mostrarSenha_login.UseVisualStyleBackColor = true;
            chk_mostrarSenha_login.CheckedChanged += chk_mostrarSenha_login_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(194, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(201, 159);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // lbl_esqueceuSenha_Login
            // 
            lbl_esqueceuSenha_Login.AutoSize = true;
            lbl_esqueceuSenha_Login.Font = new Font("Arial", 12F);
            lbl_esqueceuSenha_Login.Location = new Point(159, 342);
            lbl_esqueceuSenha_Login.Name = "lbl_esqueceuSenha_Login";
            lbl_esqueceuSenha_Login.Size = new Size(146, 18);
            lbl_esqueceuSenha_Login.TabIndex = 7;
            lbl_esqueceuSenha_Login.Text = "Esqueceu a senha?";
            lbl_esqueceuSenha_Login.Click += lbl_esqueceuSenha_Login_Click;
            // 
            // btn_criarConta_login
            // 
            btn_criarConta_login.BackColor = Color.FromArgb(242, 101, 34);
            btn_criarConta_login.Font = new Font("Arial", 12F);
            btn_criarConta_login.ForeColor = Color.White;
            btn_criarConta_login.Location = new Point(394, 418);
            btn_criarConta_login.Name = "btn_criarConta_login";
            btn_criarConta_login.Size = new Size(105, 29);
            btn_criarConta_login.TabIndex = 6;
            btn_criarConta_login.Text = "Criar Conta";
            btn_criarConta_login.UseVisualStyleBackColor = false;
            btn_criarConta_login.Click += btn_criarConta_login_Click;
            // 
            // btn_entrar_login
            // 
            btn_entrar_login.BackColor = Color.FromArgb(242, 101, 34);
            btn_entrar_login.Font = new Font("Arial", 12F);
            btn_entrar_login.ForeColor = Color.White;
            btn_entrar_login.Location = new Point(132, 418);
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
            ClientSize = new Size(999, 560);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
        private CheckBox chk_mostrarSenha_login;
    }
}
