namespace PROJETO_INTEGRADOR
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            lbl_Home = new Label();
            btn_novoOrcamento = new Button();
            btn_gerenciarServico = new Button();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            col_cliente = new DataGridViewTextBoxColumn();
            col_data = new DataGridViewTextBoxColumn();
            col_total = new DataGridViewTextBoxColumn();
            btn_logout = new Button();
            btn_verPerfil = new Button();
            panel2 = new Panel();
            btn_home = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl_Home
            // 
            lbl_Home.AutoSize = true;
            lbl_Home.Font = new Font("Arial Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Home.ForeColor = Color.FromArgb(27, 79, 114);
            lbl_Home.Location = new Point(316, 29);
            lbl_Home.Name = "lbl_Home";
            lbl_Home.Size = new Size(236, 45);
            lbl_Home.TabIndex = 1;
            lbl_Home.Text = "BEM VINDO!";
            lbl_Home.Click += lbl_Home_Click;
            // 
            // btn_novoOrcamento
            // 
            btn_novoOrcamento.BackColor = Color.FromArgb(242, 101, 34);
            btn_novoOrcamento.FlatAppearance.BorderSize = 0;
            btn_novoOrcamento.FlatStyle = FlatStyle.Flat;
            btn_novoOrcamento.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_novoOrcamento.ForeColor = Color.White;
            btn_novoOrcamento.Location = new Point(0, 200);
            btn_novoOrcamento.Name = "btn_novoOrcamento";
            btn_novoOrcamento.Size = new Size(246, 36);
            btn_novoOrcamento.TabIndex = 2;
            btn_novoOrcamento.Text = "Novo Orçamento";
            btn_novoOrcamento.TextAlign = ContentAlignment.MiddleLeft;
            btn_novoOrcamento.UseVisualStyleBackColor = false;
            btn_novoOrcamento.Click += btn_novoOrcamento_Click;
            // 
            // btn_gerenciarServico
            // 
            btn_gerenciarServico.BackColor = Color.FromArgb(242, 101, 34);
            btn_gerenciarServico.FlatAppearance.BorderSize = 0;
            btn_gerenciarServico.FlatStyle = FlatStyle.Flat;
            btn_gerenciarServico.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            btn_gerenciarServico.ForeColor = Color.White;
            btn_gerenciarServico.Location = new Point(0, 242);
            btn_gerenciarServico.Name = "btn_gerenciarServico";
            btn_gerenciarServico.Size = new Size(246, 36);
            btn_gerenciarServico.TabIndex = 3;
            btn_gerenciarServico.Text = "Editar Serviços";
            btn_gerenciarServico.TextAlign = ContentAlignment.MiddleLeft;
            btn_gerenciarServico.UseVisualStyleBackColor = false;
            btn_gerenciarServico.Click += btn_gerenciarServico_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(lbl_Home);
            panel1.Location = new Point(245, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(870, 550);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { col_cliente, col_data, col_total });
            dataGridView1.Location = new Point(95, 214);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(558, 304);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // col_cliente
            // 
            col_cliente.DataPropertyName = "nome_cliente";
            col_cliente.HeaderText = "Cliente";
            col_cliente.Name = "col_cliente";
            col_cliente.ReadOnly = true;
            col_cliente.Width = 120;
            // 
            // col_data
            // 
            col_data.DataPropertyName = "data_criacao";
            col_data.HeaderText = "Data";
            col_data.Name = "col_data";
            col_data.ReadOnly = true;
            col_data.Width = 120;
            // 
            // col_total
            // 
            col_total.DataPropertyName = "valor_total";
            col_total.HeaderText = "Valor Total";
            col_total.Name = "col_total";
            col_total.ReadOnly = true;
            col_total.Width = 120;
            // 
            // btn_logout
            // 
            btn_logout.BackColor = Color.FromArgb(242, 101, 34);
            btn_logout.FlatAppearance.BorderSize = 0;
            btn_logout.FlatStyle = FlatStyle.Flat;
            btn_logout.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            btn_logout.ForeColor = Color.White;
            btn_logout.Location = new Point(0, 328);
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
            btn_verPerfil.Location = new Point(0, 284);
            btn_verPerfil.Name = "btn_verPerfil";
            btn_verPerfil.Size = new Size(246, 38);
            btn_verPerfil.TabIndex = 7;
            btn_verPerfil.Text = "Perfil";
            btn_verPerfil.TextAlign = ContentAlignment.MiddleLeft;
            btn_verPerfil.UseVisualStyleBackColor = false;
            btn_verPerfil.Click += btn_verPerfil_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(26, 58, 90);
            panel2.Controls.Add(btn_home);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(btn_logout);
            panel2.Controls.Add(btn_verPerfil);
            panel2.Controls.Add(btn_novoOrcamento);
            panel2.Controls.Add(btn_gerenciarServico);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(246, 549);
            panel2.TabIndex = 5;
            panel2.Paint += panel2_Paint;
            // 
            // btn_home
            // 
            btn_home.BackColor = Color.FromArgb(242, 101, 34);
            btn_home.FlatAppearance.BorderSize = 0;
            btn_home.FlatStyle = FlatStyle.Flat;
            btn_home.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_home.ForeColor = Color.White;
            btn_home.Location = new Point(0, 158);
            btn_home.Name = "btn_home";
            btn_home.Size = new Size(246, 36);
            btn_home.TabIndex = 9;
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
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1113, 549);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Home";
            Text = "Home";
            Load += Home_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lbl_Home;
        private Button btn_novoOrcamento;
        private Button btn_gerenciarServico;
        private Panel panel1;
        private Button btn_logout;
        private Button btn_verPerfil;
        private Panel panel2;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn col_cliente;
        private DataGridViewTextBoxColumn col_data;
        private DataGridViewTextBoxColumn col_total;
        private Button btn_home;
    }
}