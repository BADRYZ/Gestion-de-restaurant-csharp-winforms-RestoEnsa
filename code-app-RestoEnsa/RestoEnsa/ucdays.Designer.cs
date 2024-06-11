namespace RestoEnsa
{
    partial class ucdays
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            display = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 19);
            label1.Name = "label1";
            label1.Size = new Size(32, 25);
            label1.TabIndex = 0;
            label1.Text = "00";
            label1.Click += label1_Click;
            // 
            // display
            // 
            display.AutoSize = true;
            display.Font = new Font("Microsoft Sans Serif", 6F, FontStyle.Bold, GraphicsUnit.Point, 0);
            display.ForeColor = Color.Red;
            display.Location = new Point(15, 71);
            display.Name = "display";
            display.Size = new Size(0, 15);
            display.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(display);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(107, 123);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // ucdays
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "ucdays";
            Padding = new Padding(1);
            Size = new Size(125, 115);
            Click += ucdays_Click;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label display;
        private System.Windows.Forms.Panel panel1;
    }
}
