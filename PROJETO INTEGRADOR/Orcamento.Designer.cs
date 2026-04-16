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
            panel1 = new Panel();
            btn_novoOrcamento = new Button();
            lbl_valorTotal = new Label();
            btn_salvarOrcamento = new Button();
            lbl_OrcamentoFinal = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.AutoScroll = true;
            panel1.Controls.Add(btn_novoOrcamento);
            panel1.Controls.Add(lbl_valorTotal);
            panel1.Controls.Add(btn_salvarOrcamento);
            panel1.Controls.Add(lbl_OrcamentoFinal);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 426);
            panel1.TabIndex = 0;
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
            lbl_valorTotal.Location = new Point(140, 259);
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
            // Orcamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Orcamento";
            Text = "Orcamento";
            Load += Orcamento_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lbl_OrcamentoFinal;
        private Button btn_salvarOrcamento;
        private Button btn_novoOrcamento;
        private Label lbl_valorTotal;
    }
}