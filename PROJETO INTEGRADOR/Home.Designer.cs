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
            pictureBox1 = new PictureBox();
            btn_logout = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl_Home
            // 
            lbl_Home.AutoSize = true;
            lbl_Home.Font = new Font("Arial Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Home.ForeColor = Color.FromArgb(27, 79, 114);
            lbl_Home.Location = new Point(192, 47);
            lbl_Home.Name = "lbl_Home";
            lbl_Home.Size = new Size(236, 45);
            lbl_Home.TabIndex = 1;
            lbl_Home.Text = "BEM VINDO!";
            lbl_Home.Click += lbl_Home_Click;
            // 
            // btn_novoOrcamento
            // 
            btn_novoOrcamento.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_novoOrcamento.Location = new Point(85, 273);
            btn_novoOrcamento.Name = "btn_novoOrcamento";
            btn_novoOrcamento.Size = new Size(151, 23);
            btn_novoOrcamento.TabIndex = 2;
            btn_novoOrcamento.Text = "Novo Orçamento";
            btn_novoOrcamento.UseVisualStyleBackColor = true;
            // 
            // btn_gerenciarServico
            // 
            btn_gerenciarServico.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_gerenciarServico.Location = new Point(353, 273);
            btn_gerenciarServico.Name = "btn_gerenciarServico";
            btn_gerenciarServico.Size = new Size(172, 23);
            btn_gerenciarServico.TabIndex = 3;
            btn_gerenciarServico.Text = "Gerenciar Serviços";
            btn_gerenciarServico.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_logout);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lbl_Home);
            panel1.Controls.Add(btn_gerenciarServico);
            panel1.Controls.Add(btn_novoOrcamento);
            panel1.Location = new Point(63, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(676, 393);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(207, 95);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(202, 163);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // btn_logout
            // 
            btn_logout.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_logout.Location = new Point(529, 38);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(80, 23);
            btn_logout.TabIndex = 6;
            btn_logout.Text = "Sair";
            btn_logout.UseVisualStyleBackColor = true;
            btn_logout.Click += btn_logout_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Home";
            Text = "Home";
            Load += Home_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lbl_Home;
        private Button btn_novoOrcamento;
        private Button btn_gerenciarServico;
        private Panel panel1;
        private Button btn_logout;
        private PictureBox pictureBox1;
    }
}