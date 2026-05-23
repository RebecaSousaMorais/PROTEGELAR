namespace PROJETO_INTEGRADOR
{
    partial class Orcamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Orcamento));
            panel1 = new Panel();
            btn_voltar = new Button();
            btn_novoOrcamento = new Button();
            lbl_valorTotal = new Label();
            btn_salvarOrcamento = new Button();
            lbl_OrcamentoFinal = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            btn_logout = new Button();
            btn_verPerfil = new Button();
            button1 = new Button();
            btn_gerenciarServico = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.AutoScroll = true;
            panel1.Controls.Add(btn_voltar);
            panel1.Controls.Add(btn_novoOrcamento);
            panel1.Controls.Add(lbl_valorTotal);
            panel1.Controls.Add(btn_salvarOrcamento);
            panel1.Controls.Add(lbl_OrcamentoFinal);
            panel1.Location = new Point(350, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 364);
            panel1.TabIndex = 0;
            // 
            // btn_voltar
            // 
            btn_voltar.BackColor = Color.FromArgb(242, 101, 34);
            btn_voltar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_voltar.ForeColor = Color.White;
            btn_voltar.Location = new Point(622, 75);
            btn_voltar.Name = "btn_voltar";
            btn_voltar.Size = new Size(75, 36);
            btn_voltar.TabIndex = 5;
            btn_voltar.Text = "Voltar";
            btn_voltar.UseVisualStyleBackColor = false;
            btn_voltar.Click += btn_voltar_Click;
            // 
            // btn_novoOrcamento
            // 
            btn_novoOrcamento.BackColor = Color.FromArgb(242, 101, 34);
            btn_novoOrcamento.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_novoOrcamento.ForeColor = Color.White;
            btn_novoOrcamento.Location = new Point(427, 319);
            btn_novoOrcamento.Name = "btn_novoOrcamento";
            btn_novoOrcamento.Size = new Size(155, 36);
            btn_novoOrcamento.TabIndex = 4;
            btn_novoOrcamento.Text = "Novo Orçamento";
            btn_novoOrcamento.UseVisualStyleBackColor = false;
            btn_novoOrcamento.Click += btn_novoOrcamento_Click;
            // 
            // lbl_valorTotal
            // 
            lbl_valorTotal.Anchor = AnchorStyles.None;
            lbl_valorTotal.AutoSize = true;
            lbl_valorTotal.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_valorTotal.Location = new Point(140, 228);
            lbl_valorTotal.Name = "lbl_valorTotal";
            lbl_valorTotal.Size = new Size(130, 19);
            lbl_valorTotal.TabIndex = 3;
            lbl_valorTotal.Text = "VALOR TOTAL: ";
            // 
            // btn_salvarOrcamento
            // 
            btn_salvarOrcamento.BackColor = Color.FromArgb(242, 101, 34);
            btn_salvarOrcamento.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_salvarOrcamento.ForeColor = Color.White;
            btn_salvarOrcamento.Location = new Point(223, 319);
            btn_salvarOrcamento.Name = "btn_salvarOrcamento";
            btn_salvarOrcamento.Size = new Size(158, 36);
            btn_salvarOrcamento.TabIndex = 2;
            btn_salvarOrcamento.Text = "Salvar Orçamento";
            btn_salvarOrcamento.UseVisualStyleBackColor = false;
            btn_salvarOrcamento.Click += btn_salvarOrcamento_Click;
            // 
            // lbl_OrcamentoFinal
            // 
            lbl_OrcamentoFinal.AutoSize = true;
            lbl_OrcamentoFinal.Font = new Font("Arial Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_OrcamentoFinal.ForeColor = Color.FromArgb(14, 79, 114);
            lbl_OrcamentoFinal.Location = new Point(279, 15);
            lbl_OrcamentoFinal.Name = "lbl_OrcamentoFinal";
            lbl_OrcamentoFinal.Size = new Size(251, 45);
            lbl_OrcamentoFinal.TabIndex = 1;
            lbl_OrcamentoFinal.Text = "ORÇAMENTO";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(26, 58, 90);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(btn_logout);
            panel2.Controls.Add(btn_verPerfil);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(btn_gerenciarServico);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(246, 565);
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
            // button1
            // 
            button1.BackColor = Color.FromArgb(242, 101, 34);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 140);
            button1.Name = "button1";
            button1.Size = new Size(246, 36);
            button1.TabIndex = 2;
            button1.Text = "Novo Orçamento";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
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
            // Orcamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1129, 565);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Orcamento";
            Text = "Orcamento";
            Load += Orcamento_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lbl_OrcamentoFinal;
        private Button btn_salvarOrcamento;
        private Button btn_novoOrcamento;
        private Label lbl_valorTotal;
        private Button btn_voltar;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button btn_logout;
        private Button btn_verPerfil;
        private Button button1;
        private Button btn_gerenciarServico;
    }
}