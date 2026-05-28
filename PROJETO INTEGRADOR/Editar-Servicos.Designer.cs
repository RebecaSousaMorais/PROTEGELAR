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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editar_Servicos));
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            col_id = new DataGridViewTextBoxColumn();
            col_nomeServico = new DataGridViewTextBoxColumn();
            col_preco = new DataGridViewTextBoxColumn();
            col_categoria = new DataGridViewTextBoxColumn();
            col_editar = new DataGridViewButtonColumn();
            col_excluir = new DataGridViewButtonColumn();
            lbl_editarServicos = new Label();
            panel2 = new Panel();
            btn_home = new Button();
            pictureBox1 = new PictureBox();
            btn_logout = new Button();
            btn_verPerfil = new Button();
            button1 = new Button();
            btn_gerenciarServico = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(lbl_editarServicos);
            panel1.Location = new Point(243, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(902, 598);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { col_id, col_nomeServico, col_preco, col_categoria, col_editar, col_excluir });
            dataGridView1.Location = new Point(85, 61);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(719, 373);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // col_id
            // 
            col_id.DataPropertyName = "id_servico";
            col_id.HeaderText = "ID";
            col_id.Name = "col_id";
            col_id.Visible = false;
            // 
            // col_nomeServico
            // 
            col_nomeServico.DataPropertyName = "nome_servico";
            col_nomeServico.HeaderText = "Nome do Serviço";
            col_nomeServico.Name = "col_nomeServico";
            col_nomeServico.Width = 180;
            // 
            // col_preco
            // 
            col_preco.DataPropertyName = "preco_m2";
            col_preco.HeaderText = "Preço m²";
            col_preco.Name = "col_preco";
            // 
            // col_categoria
            // 
            col_categoria.DataPropertyName = "categoria";
            col_categoria.HeaderText = "Categoria";
            col_categoria.Name = "col_categoria";
            // 
            // col_editar
            // 
            col_editar.HeaderText = "✏️";
            col_editar.Name = "col_editar";
            col_editar.Resizable = DataGridViewTriState.True;
            col_editar.SortMode = DataGridViewColumnSortMode.Automatic;
            col_editar.Text = "✏️";
            col_editar.UseColumnTextForButtonValue = true;
            col_editar.Width = 130;
            // 
            // col_excluir
            // 
            col_excluir.HeaderText = "🗑️";
            col_excluir.Name = "col_excluir";
            col_excluir.Resizable = DataGridViewTriState.True;
            col_excluir.SortMode = DataGridViewColumnSortMode.Automatic;
            col_excluir.Text = "🗑️";
            col_excluir.UseColumnTextForButtonValue = true;
            col_excluir.Width = 130;
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
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(26, 58, 90);
            panel2.Controls.Add(btn_home);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(btn_logout);
            panel2.Controls.Add(btn_verPerfil);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(btn_gerenciarServico);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(246, 623);
            panel2.TabIndex = 6;
            // 
            // btn_home
            // 
            btn_home.BackColor = Color.FromArgb(242, 101, 34);
            btn_home.FlatAppearance.BorderSize = 0;
            btn_home.FlatStyle = FlatStyle.Flat;
            btn_home.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_home.ForeColor = Color.White;
            btn_home.Location = new Point(0, 214);
            btn_home.Name = "btn_home";
            btn_home.Size = new Size(246, 36);
            btn_home.TabIndex = 10;
            btn_home.Text = "Home";
            btn_home.TextAlign = ContentAlignment.MiddleLeft;
            btn_home.UseVisualStyleBackColor = false;
            btn_home.Click += btn_home_Click;
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
            btn_logout.Location = new Point(0, 384);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(246, 38);
            btn_logout.TabIndex = 6;
            btn_logout.Text = "Sair";
            btn_logout.TextAlign = ContentAlignment.MiddleLeft;
            btn_logout.UseVisualStyleBackColor = false;
            btn_logout.Click += btn_logout_Click;
            // 
            // btn_verPerfil
            // 
            btn_verPerfil.BackColor = Color.FromArgb(242, 101, 34);
            btn_verPerfil.FlatAppearance.BorderSize = 0;
            btn_verPerfil.FlatStyle = FlatStyle.Flat;
            btn_verPerfil.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            btn_verPerfil.ForeColor = Color.White;
            btn_verPerfil.Location = new Point(0, 340);
            btn_verPerfil.Name = "btn_verPerfil";
            btn_verPerfil.Size = new Size(246, 38);
            btn_verPerfil.TabIndex = 7;
            btn_verPerfil.Text = "Perfil";
            btn_verPerfil.TextAlign = ContentAlignment.MiddleLeft;
            btn_verPerfil.UseVisualStyleBackColor = false;
            btn_verPerfil.Click += btn_verPerfil_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(242, 101, 34);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 256);
            button1.Name = "button1";
            button1.Size = new Size(246, 36);
            button1.TabIndex = 2;
            button1.Text = "Novo Orçamento";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btn_gerenciarServico
            // 
            btn_gerenciarServico.BackColor = Color.FromArgb(242, 101, 34);
            btn_gerenciarServico.FlatAppearance.BorderSize = 0;
            btn_gerenciarServico.FlatStyle = FlatStyle.Flat;
            btn_gerenciarServico.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            btn_gerenciarServico.ForeColor = Color.White;
            btn_gerenciarServico.Location = new Point(0, 298);
            btn_gerenciarServico.Name = "btn_gerenciarServico";
            btn_gerenciarServico.Size = new Size(246, 36);
            btn_gerenciarServico.TabIndex = 3;
            btn_gerenciarServico.Text = "Editar Serviços";
            btn_gerenciarServico.TextAlign = ContentAlignment.MiddleLeft;
            btn_gerenciarServico.UseVisualStyleBackColor = false;
            btn_gerenciarServico.Click += btn_gerenciarServico_Click;
            // 
            // Editar_Servicos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1157, 623);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Editar_Servicos";
            Text = "Editar_Servicos";
            Load += Editar_Servicos_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lbl_editarServicos;
        private DataGridView dataGridView1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button btn_logout;
        private Button btn_verPerfil;
        private Button button1;
        private Button btn_gerenciarServico;
        private DataGridViewTextBoxColumn col_id;
        private DataGridViewTextBoxColumn col_nomeServico;
        private DataGridViewTextBoxColumn col_preco;
        private DataGridViewTextBoxColumn col_categoria;
        private DataGridViewButtonColumn col_editar;
        private DataGridViewButtonColumn col_excluir;
        private Button btn_home;
    }
}