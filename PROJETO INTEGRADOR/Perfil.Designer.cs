namespace PROJETO_INTEGRADOR
{
    partial class Perfil
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
            lbl_perfil = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lbl_perfil);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 426);
            panel1.TabIndex = 0;
            // 
            // lbl_perfil
            // 
            lbl_perfil.AutoSize = true;
            lbl_perfil.Font = new Font("Arial Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_perfil.ForeColor = Color.FromArgb(14, 79, 114);
            lbl_perfil.Location = new Point(238, 12);
            lbl_perfil.Name = "lbl_perfil";
            lbl_perfil.Size = new Size(258, 45);
            lbl_perfil.TabIndex = 1;
            lbl_perfil.Text = "MEUS DADOS";
            lbl_perfil.Click += lbl_perfil_Click;
            // 
            // Perfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Perfil";
            Text = "Perfil";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lbl_perfil;
    }
}