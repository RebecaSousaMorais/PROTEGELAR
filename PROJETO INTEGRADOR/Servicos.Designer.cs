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
            panel1 = new Panel();
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
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
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
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 426);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // btn_voltar_servico
            // 
            btn_voltar_servico.BackColor = Color.FromArgb(242, 101, 34);
            btn_voltar_servico.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_voltar_servico.ForeColor = Color.White;
            btn_voltar_servico.Location = new Point(608, 75);
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
            lbl_observacoes.Location = new Point(170, 255);
            lbl_observacoes.Name = "lbl_observacoes";
            lbl_observacoes.Size = new Size(101, 18);
            lbl_observacoes.TabIndex = 13;
            lbl_observacoes.Text = "Observações";
            // 
            // lbl_altura
            // 
            lbl_altura.AutoSize = true;
            lbl_altura.Font = new Font("Arial", 12F);
            lbl_altura.Location = new Point(193, 212);
            lbl_altura.Name = "lbl_altura";
            lbl_altura.Size = new Size(48, 18);
            lbl_altura.TabIndex = 12;
            lbl_altura.Text = "Altura";
            // 
            // lbl_largura
            // 
            lbl_largura.AutoSize = true;
            lbl_largura.Font = new Font("Arial", 12F);
            lbl_largura.Location = new Point(193, 169);
            lbl_largura.Name = "lbl_largura";
            lbl_largura.Size = new Size(62, 18);
            lbl_largura.TabIndex = 11;
            lbl_largura.Text = "Largura";
            // 
            // lbl_servico
            // 
            lbl_servico.AutoSize = true;
            lbl_servico.Font = new Font("Arial", 12F);
            lbl_servico.Location = new Point(193, 127);
            lbl_servico.Name = "lbl_servico";
            lbl_servico.Size = new Size(61, 18);
            lbl_servico.TabIndex = 10;
            lbl_servico.Text = "Serviço";
            // 
            // lbl_categoria
            // 
            lbl_categoria.AutoSize = true;
            lbl_categoria.Font = new Font("Arial", 12F);
            lbl_categoria.Location = new Point(193, 89);
            lbl_categoria.Name = "lbl_categoria";
            lbl_categoria.Size = new Size(78, 18);
            lbl_categoria.TabIndex = 9;
            lbl_categoria.Text = "Categoria";
            // 
            // txt_observacoes
            // 
            txt_observacoes.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_observacoes.Location = new Point(274, 252);
            txt_observacoes.Multiline = true;
            txt_observacoes.Name = "txt_observacoes";
            txt_observacoes.Size = new Size(233, 62);
            txt_observacoes.TabIndex = 8;
            txt_observacoes.TextChanged += txt_observacoes_TextChanged;
            // 
            // btn_editarServico
            // 
            btn_editarServico.BackColor = Color.FromArgb(242, 101, 34);
            btn_editarServico.Font = new Font("Arial", 12F);
            btn_editarServico.ForeColor = Color.White;
            btn_editarServico.Location = new Point(608, 27);
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
            lbl_precoOrcamento.Font = new Font("Arial", 12F);
            lbl_precoOrcamento.Location = new Point(634, 348);
            lbl_precoOrcamento.Name = "lbl_precoOrcamento";
            lbl_precoOrcamento.Size = new Size(122, 18);
            lbl_precoOrcamento.TabIndex = 6;
            lbl_precoOrcamento.Text = "Preço: R$ 00,00";
            lbl_precoOrcamento.Click += lbl_precoOrcamento_Click;
            // 
            // btn_salvarOrcamento
            // 
            btn_salvarOrcamento.BackColor = Color.FromArgb(242, 101, 34);
            btn_salvarOrcamento.Font = new Font("Arial", 12F);
            btn_salvarOrcamento.ForeColor = Color.White;
            btn_salvarOrcamento.Location = new Point(299, 334);
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
            txt_altura.Location = new Point(274, 209);
            txt_altura.Name = "txt_altura";
            txt_altura.Size = new Size(233, 26);
            txt_altura.TabIndex = 4;
            // 
            // txt_largura
            // 
            txt_largura.Font = new Font("Arial", 12F);
            txt_largura.Location = new Point(274, 166);
            txt_largura.Name = "txt_largura";
            txt_largura.Size = new Size(233, 26);
            txt_largura.TabIndex = 3;
            // 
            // cmb_servico
            // 
            cmb_servico.Font = new Font("Arial", 12F);
            cmb_servico.FormattingEnabled = true;
            cmb_servico.Location = new Point(274, 124);
            cmb_servico.Name = "cmb_servico";
            cmb_servico.Size = new Size(298, 26);
            cmb_servico.TabIndex = 2;
            cmb_servico.SelectedIndexChanged += cmb_servico_SelectedIndexChanged;
            // 
            // cmb_categoria
            // 
            cmb_categoria.Font = new Font("Arial", 12F);
            cmb_categoria.FormattingEnabled = true;
            cmb_categoria.Location = new Point(274, 86);
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
            lbl_servicos.Location = new Point(49, 14);
            lbl_servicos.Name = "lbl_servicos";
            lbl_servicos.Size = new Size(202, 45);
            lbl_servicos.TabIndex = 0;
            lbl_servicos.Text = "SERVIÇOS";
            // 
            // Servicos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Servicos";
            Text = "Servicos";
            Load += Servicos_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
    }
}