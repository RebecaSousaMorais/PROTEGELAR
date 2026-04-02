namespace PROJETO_INTEGRADOR
{
    partial class Editar_Servicos
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
            dataGridView1 = new DataGridView();
            col_nomeServico = new DataGridViewTextBoxColumn();
            col_preco = new DataGridViewTextBoxColumn();
            col_categoria = new DataGridViewTextBoxColumn();
            col_editar = new DataGridViewTextBoxColumn();
            col_excluir = new DataGridViewTextBoxColumn();
            btn_voltar_servicos = new Button();
            lbl_editarServicos = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(btn_novoOrcamento);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(btn_voltar_servicos);
            panel1.Controls.Add(lbl_editarServicos);
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
            btn_novoOrcamento.Location = new Point(520, 348);
            btn_novoOrcamento.Name = "btn_novoOrcamento";
            btn_novoOrcamento.Size = new Size(153, 28);
            btn_novoOrcamento.TabIndex = 3;
            btn_novoOrcamento.Text = "Novo Orçamento";
            btn_novoOrcamento.UseVisualStyleBackColor = false;
            btn_novoOrcamento.Click += btn_novoOrcamento_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { col_nomeServico, col_preco, col_categoria, col_editar, col_excluir });
            dataGridView1.Location = new Point(131, 88);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(542, 150);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // col_nomeServico
            // 
            col_nomeServico.HeaderText = "Nome do Serviço";
            col_nomeServico.Name = "col_nomeServico";
            // 
            // col_preco
            // 
            col_preco.HeaderText = "Preço m²";
            col_preco.Name = "col_preco";
            // 
            // col_categoria
            // 
            col_categoria.HeaderText = "Categoria";
            col_categoria.Name = "col_categoria";
            // 
            // col_editar
            // 
            col_editar.HeaderText = "Editar";
            col_editar.Name = "col_editar";
            // 
            // col_excluir
            // 
            col_excluir.HeaderText = "Excluir";
            col_excluir.Name = "col_excluir";
            // 
            // btn_voltar_servicos
            // 
            btn_voltar_servicos.BackColor = Color.FromArgb(242, 101, 34);
            btn_voltar_servicos.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_voltar_servicos.ForeColor = Color.White;
            btn_voltar_servicos.Location = new Point(23, 88);
            btn_voltar_servicos.Name = "btn_voltar_servicos";
            btn_voltar_servicos.Size = new Size(75, 28);
            btn_voltar_servicos.TabIndex = 1;
            btn_voltar_servicos.Text = "Voltar";
            btn_voltar_servicos.UseVisualStyleBackColor = false;
            btn_voltar_servicos.Click += btn_voltar_servicos_Click;
            // 
            // lbl_editarServicos
            // 
            lbl_editarServicos.AutoSize = true;
            lbl_editarServicos.BackColor = SystemColors.Control;
            lbl_editarServicos.Font = new Font("Arial Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_editarServicos.ForeColor = Color.FromArgb(24, 79, 114);
            lbl_editarServicos.Location = new Point(213, 13);
            lbl_editarServicos.Name = "lbl_editarServicos";
            lbl_editarServicos.Size = new Size(344, 45);
            lbl_editarServicos.TabIndex = 0;
            lbl_editarServicos.Text = "EDITAR SERVIÇOS";
            lbl_editarServicos.Click += label1_Click;
            // 
            // Editar_Servicos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Editar_Servicos";
            Text = "Editar_Servicos";
            Load += Editar_Servicos_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lbl_editarServicos;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn col_nomeServico;
        private DataGridViewTextBoxColumn col_preco;
        private DataGridViewTextBoxColumn col_categoria;
        private DataGridViewTextBoxColumn col_editar;
        private DataGridViewTextBoxColumn col_excluir;
        private Button btn_voltar_servicos;
        private Button btn_novoOrcamento;
    }
}