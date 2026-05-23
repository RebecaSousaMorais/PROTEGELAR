namespace PROJETO_INTEGRADOR
{
    partial class Servicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Servicos));
            panel1 = new Panel();
            txt_cpfCliente = new MaskedTextBox();
            txt_nomeCliente = new TextBox();
            lbl_cpfCliente = new Label();
            lbl_nomeCliente = new Label();
            btn_voltar_servico = new Button();
            lbl_observacoes = new Label();
            lbl_altura = new Label();
            lbl_largura = new Label();
            lbl_servico = new Label();
            lbl_categoria = new Label();
            txt_observacoes = new TextBox();
            btn_editarServico = new Button();
            lbl_precoOrcamento = new Label();
            btn_salvarOrcamento = new Button();
            txt_altura = new TextBox();
            txt_largura = new TextBox();
            cmb_servico = new ComboBox();
            cmb_categoria = new ComboBox();
            lbl_servicos = new Label();
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
            panel1.Controls.Add(txt_cpfCliente);
            panel1.Controls.Add(txt_nomeCliente);
            panel1.Controls.Add(lbl_cpfCliente);
            panel1.Controls.Add(lbl_nomeCliente);
            panel1.Controls.Add(btn_voltar_servico);
            panel1.Controls.Add(lbl_observacoes);
            panel1.Controls.Add(lbl_altura);
            panel1.Controls.Add(lbl_largura);
            panel1.Controls.Add(lbl_servico);
            panel1.Controls.Add(lbl_categoria);
            panel1.Controls.Add(txt_observacoes);
            panel1.Controls.Add(btn_editarServico);
            panel1.Controls.Add(lbl_precoOrcamento);
            panel1.Controls.Add(btn_salvarOrcamento);
            panel1.Controls.Add(txt_altura);
            panel1.Controls.Add(txt_largura);
            panel1.Controls.Add(cmb_servico);
            panel1.Controls.Add(cmb_categoria);
            panel1.Controls.Add(lbl_servicos);
            panel1.Location = new Point(252, 14);
            panel1.Name = "panel1";
            panel1.Size = new Size(1038, 515);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // txt_cpfCliente
            // 
            txt_cpfCliente.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_cpfCliente.Location = new Point(156, 124);
            txt_cpfCliente.Mask = "000.000.-00";
            txt_cpfCliente.Name = "txt_cpfCliente";
            txt_cpfCliente.Size = new Size(270, 26);
            txt_cpfCliente.TabIndex = 20;
            txt_cpfCliente.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // txt_nomeCliente
            // 
            txt_nomeCliente.Font = new Font("Arial", 12F);
            txt_nomeCliente.Location = new Point(156, 88);
            txt_nomeCliente.Name = "txt_nomeCliente";
            txt_nomeCliente.Size = new Size(270, 26);
            txt_nomeCliente.TabIndex = 18;
            txt_nomeCliente.TextChanged += textBox1_TextChanged;
            // 
            // lbl_cpfCliente
            // 
            lbl_cpfCliente.AutoSize = true;
            lbl_cpfCliente.Font = new Font("Arial", 12F);
            lbl_cpfCliente.Location = new Point(47, 127);
            lbl_cpfCliente.Name = "lbl_cpfCliente";
            lbl_cpfCliente.Size = new Size(94, 18);
            lbl_cpfCliente.TabIndex = 17;
            lbl_cpfCliente.Text = "CPF Cliente";
            // 
            // lbl_nomeCliente
            // 
            lbl_nomeCliente.AutoSize = true;
            lbl_nomeCliente.Font = new Font("Arial", 12F);
            lbl_nomeCliente.Location = new Point(47, 93);
            lbl_nomeCliente.Name = "lbl_nomeCliente";
            lbl_nomeCliente.Size = new Size(103, 18);
            lbl_nomeCliente.TabIndex = 16;
            lbl_nomeCliente.Text = "Nome Cliente";
            // 
            // btn_voltar_servico
            // 
            btn_voltar_servico.BackColor = Color.FromArgb(242, 101, 34);
            btn_voltar_servico.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_voltar_servico.ForeColor = Color.White;
            btn_voltar_servico.Location = new Point(501, 75);
            btn_voltar_servico.Name = "btn_voltar_servico";
            btn_voltar_servico.Size = new Size(127, 32);
            btn_voltar_servico.TabIndex = 15;
            btn_voltar_servico.Text = "Voltar";
            btn_voltar_servico.UseVisualStyleBackColor = false;
            btn_voltar_servico.Click += btn_voltar_servico_Click;
            // 
            // lbl_observacoes
            // 
            lbl_observacoes.AutoSize = true;
            lbl_observacoes.Font = new Font("Arial", 12F);
            lbl_observacoes.Location = new Point(24, 330);
            lbl_observacoes.Name = "lbl_observacoes";
            lbl_observacoes.Size = new Size(101, 18);
            lbl_observacoes.TabIndex = 13;
            lbl_observacoes.Text = "Observações";
            // 
            // lbl_altura
            // 
            lbl_altura.AutoSize = true;
            lbl_altura.Font = new Font("Arial", 12F);
            lbl_altura.Location = new Point(24, 287);
            lbl_altura.Name = "lbl_altura";
            lbl_altura.Size = new Size(75, 18);
            lbl_altura.TabIndex = 12;
            lbl_altura.Text = "Altura (m)";
            // 
            // lbl_largura
            // 
            lbl_largura.AutoSize = true;
            lbl_largura.Font = new Font("Arial", 12F);
            lbl_largura.Location = new Point(24, 244);
            lbl_largura.Name = "lbl_largura";
            lbl_largura.Size = new Size(89, 18);
            lbl_largura.TabIndex = 11;
            lbl_largura.Text = "Largura (m)";
            // 
            // lbl_servico
            // 
            lbl_servico.AutoSize = true;
            lbl_servico.Font = new Font("Arial", 12F);
            lbl_servico.Location = new Point(47, 202);
            lbl_servico.Name = "lbl_servico";
            lbl_servico.Size = new Size(61, 18);
            lbl_servico.TabIndex = 10;
            lbl_servico.Text = "Serviço";
            // 
            // lbl_categoria
            // 
            lbl_categoria.AutoSize = true;
            lbl_categoria.Font = new Font("Arial", 12F);
            lbl_categoria.Location = new Point(47, 164);
            lbl_categoria.Name = "lbl_categoria";
            lbl_categoria.Size = new Size(78, 18);
            lbl_categoria.TabIndex = 9;
            lbl_categoria.Text = "Categoria";
            // 
            // txt_observacoes
            // 
            txt_observacoes.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_observacoes.Location = new Point(128, 327);
            txt_observacoes.Multiline = true;
            txt_observacoes.Name = "txt_observacoes";
            txt_observacoes.Size = new Size(298, 69);
            txt_observacoes.TabIndex = 8;
            txt_observacoes.TextChanged += txt_observacoes_TextChanged;
            // 
            // btn_editarServico
            // 
            btn_editarServico.BackColor = Color.FromArgb(242, 101, 34);
            btn_editarServico.Font = new Font("Arial", 12F);
            btn_editarServico.ForeColor = Color.White;
            btn_editarServico.Location = new Point(501, 27);
            btn_editarServico.Name = "btn_editarServico";
            btn_editarServico.Size = new Size(127, 32);
            btn_editarServico.TabIndex = 7;
            btn_editarServico.Text = "Editar Serviços";
            btn_editarServico.UseVisualStyleBackColor = false;
            btn_editarServico.Click += btn_editarServico_Click;
            // 
            // lbl_precoOrcamento
            // 
            lbl_precoOrcamento.AutoSize = true;
            lbl_precoOrcamento.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_precoOrcamento.ForeColor = Color.Black;
            lbl_precoOrcamento.Location = new Point(485, 442);
            lbl_precoOrcamento.Name = "lbl_precoOrcamento";
            lbl_precoOrcamento.Size = new Size(169, 24);
            lbl_precoOrcamento.TabIndex = 6;
            lbl_precoOrcamento.Text = "Preço: R$ 00,00";
            lbl_precoOrcamento.Click += lbl_precoOrcamento_Click;
            // 
            // btn_salvarOrcamento
            // 
            btn_salvarOrcamento.BackColor = Color.FromArgb(242, 101, 34);
            btn_salvarOrcamento.Font = new Font("Arial", 12F);
            btn_salvarOrcamento.ForeColor = Color.White;
            btn_salvarOrcamento.Location = new Point(192, 445);
            btn_salvarOrcamento.Name = "btn_salvarOrcamento";
            btn_salvarOrcamento.Size = new Size(168, 32);
            btn_salvarOrcamento.TabIndex = 5;
            btn_salvarOrcamento.Text = "Salvar Orçamento";
            btn_salvarOrcamento.UseVisualStyleBackColor = false;
            btn_salvarOrcamento.Click += btn_salvarOrcamento_Click;
            // 
            // txt_altura
            // 
            txt_altura.Font = new Font("Arial", 12F);
            txt_altura.Location = new Point(128, 284);
            txt_altura.Name = "txt_altura";
            txt_altura.Size = new Size(298, 26);
            txt_altura.TabIndex = 4;
            txt_altura.TextChanged += txt_altura_TextChanged;
            // 
            // txt_largura
            // 
            txt_largura.Font = new Font("Arial", 12F);
            txt_largura.Location = new Point(128, 241);
            txt_largura.Name = "txt_largura";
            txt_largura.Size = new Size(298, 26);
            txt_largura.TabIndex = 3;
            txt_largura.TextChanged += txt_largura_TextChanged;
            // 
            // cmb_servico
            // 
            cmb_servico.Font = new Font("Arial", 12F);
            cmb_servico.FormattingEnabled = true;
            cmb_servico.Location = new Point(128, 199);
            cmb_servico.Name = "cmb_servico";
            cmb_servico.Size = new Size(298, 26);
            cmb_servico.TabIndex = 2;
            cmb_servico.SelectedIndexChanged += cmb_servico_SelectedIndexChanged;
            // 
            // cmb_categoria
            // 
            cmb_categoria.Font = new Font("Arial", 12F);
            cmb_categoria.FormattingEnabled = true;
            cmb_categoria.Location = new Point(128, 161);
            cmb_categoria.Name = "cmb_categoria";
            cmb_categoria.Size = new Size(298, 26);
            cmb_categoria.TabIndex = 1;
            cmb_categoria.SelectedIndexChanged += cmb_categoria_SelectedIndexChanged;
            // 
            // lbl_servicos
            // 
            lbl_servicos.AutoSize = true;
            lbl_servicos.BackColor = SystemColors.Control;
            lbl_servicos.Font = new Font("Arial Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_servicos.ForeColor = Color.FromArgb(24, 79, 114);
            lbl_servicos.Location = new Point(24, 27);
            lbl_servicos.Name = "lbl_servicos";
            lbl_servicos.Size = new Size(202, 45);
            lbl_servicos.TabIndex = 0;
            lbl_servicos.Text = "SERVIÇOS";
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
            panel2.Size = new Size(246, 556);
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
            // 
            // Servicos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1290, 556);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Servicos";
            Text = "Servicos";
            Load += Servicos_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btn_editarServico;
        private Label lbl_precoOrcamento;
        private Button btn_salvarOrcamento;
        private TextBox txt_altura;
        private TextBox txt_largura;
        private ComboBox cmb_servico;
        private ComboBox cmb_categoria;
        private Label lbl_servicos;
        private TextBox txt_observacoes;
        private Label lbl_observacoes;
        private Label lbl_altura;
        private Label lbl_largura;
        private Label lbl_servico;
        private Label lbl_categoria;
        private Button btn_voltar_servico;
        private Label lbl_cpfCliente;
        private Label lbl_nomeCliente;
        private TextBox txt_nomeCliente;
        private MaskedTextBox txt_cpfCliente;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button btn_logout;
        private Button btn_verPerfil;
        private Button btn_novoOrcamento;
        private Button btn_gerenciarServico;
    }
}