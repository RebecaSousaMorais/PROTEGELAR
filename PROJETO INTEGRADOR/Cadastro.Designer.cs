namespace PROJETO_INTEGRADOR
{
    partial class Cadastro
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
            chk_mostrarSenha_cadastro = new CheckBox();
            btn_voltar_cadastro = new Button();
            btn_criarConta_cadastro = new Button();
            txt_confirmarSenha_cadastro = new TextBox();
            txt_senha_cadastro = new TextBox();
            txt_endResidencial_cadastro = new TextBox();
            txt_telefone_cadastro = new TextBox();
            txt_email_cadastro = new TextBox();
            txt_nomeCompleto_cadastro = new TextBox();
            lbl_confirmarSenha_cadastro = new Label();
            lbl_senha_cadastro = new Label();
            lbl_endResidencial = new Label();
            lbl_telefone_cadastro = new Label();
            lbl_email_cadastro = new Label();
            lbl_nomeCompleto_cadastro = new Label();
            lbl_cadastro = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(chk_mostrarSenha_cadastro);
            panel1.Controls.Add(btn_voltar_cadastro);
            panel1.Controls.Add(btn_criarConta_cadastro);
            panel1.Controls.Add(txt_confirmarSenha_cadastro);
            panel1.Controls.Add(txt_senha_cadastro);
            panel1.Controls.Add(txt_endResidencial_cadastro);
            panel1.Controls.Add(txt_telefone_cadastro);
            panel1.Controls.Add(txt_email_cadastro);
            panel1.Controls.Add(txt_nomeCompleto_cadastro);
            panel1.Controls.Add(lbl_confirmarSenha_cadastro);
            panel1.Controls.Add(lbl_senha_cadastro);
            panel1.Controls.Add(lbl_endResidencial);
            panel1.Controls.Add(lbl_telefone_cadastro);
            panel1.Controls.Add(lbl_email_cadastro);
            panel1.Controls.Add(lbl_nomeCompleto_cadastro);
            panel1.Controls.Add(lbl_cadastro);
            panel1.Location = new Point(83, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(643, 391);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // chk_mostrarSenha_cadastro
            // 
            chk_mostrarSenha_cadastro.AutoSize = true;
            chk_mostrarSenha_cadastro.Font = new Font("Arial", 12F);
            chk_mostrarSenha_cadastro.Location = new Point(497, 237);
            chk_mostrarSenha_cadastro.Name = "chk_mostrarSenha_cadastro";
            chk_mostrarSenha_cadastro.Size = new Size(129, 22);
            chk_mostrarSenha_cadastro.TabIndex = 15;
            chk_mostrarSenha_cadastro.Text = "Mostrar Senha";
            chk_mostrarSenha_cadastro.UseVisualStyleBackColor = true;
            chk_mostrarSenha_cadastro.CheckedChanged += chk_mostrarSenha_cadastro_CheckedChanged;
            // 
            // btn_voltar_cadastro
            // 
            btn_voltar_cadastro.BackColor = Color.FromArgb(242, 101, 34);
            btn_voltar_cadastro.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_voltar_cadastro.ForeColor = Color.White;
            btn_voltar_cadastro.Location = new Point(310, 336);
            btn_voltar_cadastro.Name = "btn_voltar_cadastro";
            btn_voltar_cadastro.Size = new Size(139, 32);
            btn_voltar_cadastro.TabIndex = 14;
            btn_voltar_cadastro.Text = "Voltar";
            btn_voltar_cadastro.UseVisualStyleBackColor = false;
            btn_voltar_cadastro.Click += btn_voltar_cadastro_Click;
            // 
            // btn_criarConta_cadastro
            // 
            btn_criarConta_cadastro.BackColor = Color.FromArgb(242, 101, 34);
            btn_criarConta_cadastro.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_criarConta_cadastro.ForeColor = Color.White;
            btn_criarConta_cadastro.Location = new Point(88, 336);
            btn_criarConta_cadastro.Name = "btn_criarConta_cadastro";
            btn_criarConta_cadastro.Size = new Size(139, 32);
            btn_criarConta_cadastro.TabIndex = 13;
            btn_criarConta_cadastro.Text = "Criar Conta";
            btn_criarConta_cadastro.UseVisualStyleBackColor = false;
            btn_criarConta_cadastro.Click += btn_criarConta_cadastro_Click;
            // 
            // txt_confirmarSenha_cadastro
            // 
            txt_confirmarSenha_cadastro.Font = new Font("Arial", 12F);
            txt_confirmarSenha_cadastro.Location = new Point(198, 276);
            txt_confirmarSenha_cadastro.Name = "txt_confirmarSenha_cadastro";
            txt_confirmarSenha_cadastro.Size = new Size(262, 26);
            txt_confirmarSenha_cadastro.TabIndex = 12;
            txt_confirmarSenha_cadastro.TextChanged += txt_confirmarSenha_cadastro_TextChanged;
            // 
            // txt_senha_cadastro
            // 
            txt_senha_cadastro.Font = new Font("Arial", 12F);
            txt_senha_cadastro.Location = new Point(198, 235);
            txt_senha_cadastro.Name = "txt_senha_cadastro";
            txt_senha_cadastro.Size = new Size(262, 26);
            txt_senha_cadastro.TabIndex = 11;
            txt_senha_cadastro.TextChanged += txt_senha_cadastro_TextChanged;
            // 
            // txt_endResidencial_cadastro
            // 
            txt_endResidencial_cadastro.Font = new Font("Arial", 12F);
            txt_endResidencial_cadastro.Location = new Point(198, 193);
            txt_endResidencial_cadastro.Name = "txt_endResidencial_cadastro";
            txt_endResidencial_cadastro.Size = new Size(262, 26);
            txt_endResidencial_cadastro.TabIndex = 10;
            txt_endResidencial_cadastro.TextChanged += txt_endResidencial_cadastro_TextChanged;
            // 
            // txt_telefone_cadastro
            // 
            txt_telefone_cadastro.Font = new Font("Arial", 12F);
            txt_telefone_cadastro.Location = new Point(198, 157);
            txt_telefone_cadastro.Name = "txt_telefone_cadastro";
            txt_telefone_cadastro.Size = new Size(262, 26);
            txt_telefone_cadastro.TabIndex = 9;
            txt_telefone_cadastro.TextChanged += txt_telefone_cadastro_TextChanged;
            // 
            // txt_email_cadastro
            // 
            txt_email_cadastro.Font = new Font("Arial", 12F);
            txt_email_cadastro.Location = new Point(198, 122);
            txt_email_cadastro.Name = "txt_email_cadastro";
            txt_email_cadastro.Size = new Size(262, 26);
            txt_email_cadastro.TabIndex = 8;
            txt_email_cadastro.TextChanged += txt_email_cadastro_TextChanged;
            // 
            // txt_nomeCompleto_cadastro
            // 
            txt_nomeCompleto_cadastro.Font = new Font("Arial", 12F);
            txt_nomeCompleto_cadastro.Location = new Point(198, 81);
            txt_nomeCompleto_cadastro.Name = "txt_nomeCompleto_cadastro";
            txt_nomeCompleto_cadastro.Size = new Size(262, 26);
            txt_nomeCompleto_cadastro.TabIndex = 7;
            txt_nomeCompleto_cadastro.TextChanged += txt_nomeCompleto_cadastro_TextChanged;
            // 
            // lbl_confirmarSenha_cadastro
            // 
            lbl_confirmarSenha_cadastro.AutoSize = true;
            lbl_confirmarSenha_cadastro.Font = new Font("Arial", 12F);
            lbl_confirmarSenha_cadastro.Location = new Point(67, 279);
            lbl_confirmarSenha_cadastro.Name = "lbl_confirmarSenha_cadastro";
            lbl_confirmarSenha_cadastro.Size = new Size(126, 18);
            lbl_confirmarSenha_cadastro.TabIndex = 6;
            lbl_confirmarSenha_cadastro.Text = "Confirmar Senha";
            // 
            // lbl_senha_cadastro
            // 
            lbl_senha_cadastro.AutoSize = true;
            lbl_senha_cadastro.Font = new Font("Arial", 12F);
            lbl_senha_cadastro.Location = new Point(67, 238);
            lbl_senha_cadastro.Name = "lbl_senha_cadastro";
            lbl_senha_cadastro.Size = new Size(53, 18);
            lbl_senha_cadastro.TabIndex = 5;
            lbl_senha_cadastro.Text = "Senha";
            // 
            // lbl_endResidencial
            // 
            lbl_endResidencial.AutoSize = true;
            lbl_endResidencial.Font = new Font("Arial", 12F);
            lbl_endResidencial.Location = new Point(31, 196);
            lbl_endResidencial.Name = "lbl_endResidencial";
            lbl_endResidencial.Size = new Size(162, 18);
            lbl_endResidencial.TabIndex = 4;
            lbl_endResidencial.Text = "Endereço Residencial";
            lbl_endResidencial.Click += lbl_endResidencial_Click;
            // 
            // lbl_telefone_cadastro
            // 
            lbl_telefone_cadastro.AutoSize = true;
            lbl_telefone_cadastro.Font = new Font("Arial", 12F);
            lbl_telefone_cadastro.Location = new Point(67, 160);
            lbl_telefone_cadastro.Name = "lbl_telefone_cadastro";
            lbl_telefone_cadastro.Size = new Size(66, 18);
            lbl_telefone_cadastro.TabIndex = 3;
            lbl_telefone_cadastro.Text = "Telefone";
            // 
            // lbl_email_cadastro
            // 
            lbl_email_cadastro.AutoSize = true;
            lbl_email_cadastro.Font = new Font("Arial", 12F);
            lbl_email_cadastro.Location = new Point(67, 125);
            lbl_email_cadastro.Name = "lbl_email_cadastro";
            lbl_email_cadastro.Size = new Size(53, 18);
            lbl_email_cadastro.TabIndex = 2;
            lbl_email_cadastro.Text = "E-mail";
            // 
            // lbl_nomeCompleto_cadastro
            // 
            lbl_nomeCompleto_cadastro.AutoSize = true;
            lbl_nomeCompleto_cadastro.Font = new Font("Arial", 12F);
            lbl_nomeCompleto_cadastro.Location = new Point(67, 84);
            lbl_nomeCompleto_cadastro.Name = "lbl_nomeCompleto_cadastro";
            lbl_nomeCompleto_cadastro.Size = new Size(122, 18);
            lbl_nomeCompleto_cadastro.TabIndex = 1;
            lbl_nomeCompleto_cadastro.Text = "Nome Completo";
            // 
            // lbl_cadastro
            // 
            lbl_cadastro.AutoSize = true;
            lbl_cadastro.Font = new Font("Arial Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_cadastro.ForeColor = Color.FromArgb(27, 79, 114);
            lbl_cadastro.Location = new Point(198, 31);
            lbl_cadastro.Name = "lbl_cadastro";
            lbl_cadastro.Size = new Size(216, 45);
            lbl_cadastro.TabIndex = 0;
            lbl_cadastro.Text = "CADASTRO";
            lbl_cadastro.Click += label1_Click;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Cadastro";
            Text = "Cadastro";
            Load += Cadastro_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lbl_cadastro;
        private TextBox txt_endResidencial_cadastro;
        private TextBox txt_telefone_cadastro;
        private TextBox txt_email_cadastro;
        private TextBox txt_nomeCompleto_cadastro;
        private Label lbl_confirmarSenha_cadastro;
        private Label lbl_senha_cadastro;
        private Label lbl_endResidencial;
        private Label lbl_telefone_cadastro;
        private Label lbl_email_cadastro;
        private Label lbl_nomeCompleto_cadastro;
        private Button btn_voltar_cadastro;
        private Button btn_criarConta_cadastro;
        private TextBox txt_confirmarSenha_cadastro;
        private TextBox txt_senha_cadastro;
        private CheckBox chk_mostrarSenha_cadastro;
    }
}