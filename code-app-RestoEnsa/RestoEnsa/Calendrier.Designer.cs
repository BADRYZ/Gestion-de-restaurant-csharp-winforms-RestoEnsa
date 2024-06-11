namespace RestoEnsa
{
    partial class calendrier
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calendrier));
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            mois = new Label();
            next = new Button();
            precedent = new Button();
            panel1 = new Panel();
            chefsButton = new Button();
            CommandesButton = new Button();
            ServeursButton = new Button();
            pictureBox4 = new PictureBox();
            PlatsButton = new Button();
            CalendrierButton = new Button();
            button1 = new Button();
            panel2 = new Panel();
            label8 = new Label();
            panel4 = new Panel();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel5 = new Panel();
            refreshbutton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(260, 315);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(941, 596);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(270, 287);
            label1.Name = "label1";
            label1.Size = new Size(51, 25);
            label1.TabIndex = 1;
            label1.Text = "lundi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(394, 287);
            label2.Name = "label2";
            label2.Size = new Size(58, 25);
            label2.TabIndex = 2;
            label2.Text = "mardi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(527, 287);
            label3.Name = "label3";
            label3.Size = new Size(81, 25);
            label3.TabIndex = 3;
            label3.Text = "mercredi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(670, 287);
            label4.Name = "label4";
            label4.Size = new Size(50, 25);
            label4.TabIndex = 4;
            label4.Text = "jeudi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(791, 287);
            label5.Name = "label5";
            label5.Size = new Size(81, 25);
            label5.TabIndex = 5;
            label5.Text = "vendredi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(930, 287);
            label6.Name = "label6";
            label6.Size = new Size(69, 25);
            label6.TabIndex = 6;
            label6.Text = "samedi";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1056, 287);
            label7.Name = "label7";
            label7.Size = new Size(89, 25);
            label7.TabIndex = 7;
            label7.Text = "dimanche";
            // 
            // mois
            // 
            mois.AutoSize = true;
            mois.Font = new Font("Stencil", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mois.ForeColor = SystemColors.ButtonHighlight;
            mois.Location = new Point(65, 31);
            mois.Name = "mois";
            mois.Size = new Size(79, 26);
            mois.TabIndex = 8;
            mois.Text = "moins";
            mois.Click += mois_Click;
            // 
            // next
            // 
            next.Location = new Point(438, 24);
            next.Name = "next";
            next.Size = new Size(96, 41);
            next.TabIndex = 9;
            next.Text = "->";
            next.UseVisualStyleBackColor = true;
            next.Click += next_Click;
            // 
            // precedent
            // 
            precedent.Location = new Point(336, 24);
            precedent.Name = "precedent";
            precedent.Size = new Size(96, 41);
            precedent.TabIndex = 10;
            precedent.Text = "<-";
            precedent.UseVisualStyleBackColor = true;
            precedent.Click += precedent_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 0, 64);
            panel1.Controls.Add(chefsButton);
            panel1.Controls.Add(CommandesButton);
            panel1.Controls.Add(ServeursButton);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(PlatsButton);
            panel1.Controls.Add(CalendrierButton);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(0, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(242, 914);
            panel1.TabIndex = 27;
            // 
            // chefsButton
            // 
            chefsButton.BackColor = Color.Black;
            chefsButton.ForeColor = SystemColors.ButtonHighlight;
            chefsButton.Image = Properties.Resources.chef__1_;
            chefsButton.Location = new Point(-13, 498);
            chefsButton.Name = "chefsButton";
            chefsButton.Size = new Size(255, 80);
            chefsButton.TabIndex = 19;
            chefsButton.Text = "Chefs";
            chefsButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            chefsButton.UseVisualStyleBackColor = false;
            chefsButton.Click += chefsButton_Click;
            // 
            // CommandesButton
            // 
            CommandesButton.BackColor = Color.Black;
            CommandesButton.ForeColor = SystemColors.ButtonHighlight;
            CommandesButton.Image = Properties.Resources.commander_de_la_nourriture__1_;
            CommandesButton.Location = new Point(-3, 415);
            CommandesButton.Name = "CommandesButton";
            CommandesButton.Size = new Size(255, 81);
            CommandesButton.TabIndex = 18;
            CommandesButton.Text = "Commandes";
            CommandesButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            CommandesButton.UseVisualStyleBackColor = false;
            CommandesButton.Click += CommandesButton_Click;
            // 
            // ServeursButton
            // 
            ServeursButton.BackColor = Color.Black;
            ServeursButton.ForeColor = SystemColors.ButtonHighlight;
            ServeursButton.Image = Properties.Resources.serveur;
            ServeursButton.Location = new Point(-8, 168);
            ServeursButton.Name = "ServeursButton";
            ServeursButton.Size = new Size(262, 80);
            ServeursButton.TabIndex = 15;
            ServeursButton.Text = "Serveurs";
            ServeursButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            ServeursButton.UseVisualStyleBackColor = false;
            ServeursButton.Click += ServeursButton_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(64, 0, 64);
            pictureBox4.Image = Properties.Resources.cornerLeft;
            pictureBox4.Location = new Point(167, 88);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(175, 71);
            pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox4.TabIndex = 14;
            pictureBox4.TabStop = false;
            // 
            // PlatsButton
            // 
            PlatsButton.BackColor = Color.Black;
            PlatsButton.ForeColor = SystemColors.ButtonHighlight;
            PlatsButton.Image = Properties.Resources.cuisine__1_;
            PlatsButton.Location = new Point(-13, 248);
            PlatsButton.Name = "PlatsButton";
            PlatsButton.Size = new Size(262, 80);
            PlatsButton.TabIndex = 4;
            PlatsButton.Text = "Plats";
            PlatsButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            PlatsButton.UseVisualStyleBackColor = false;
            PlatsButton.Click += PlatsButton_Click;
            // 
            // CalendrierButton
            // 
            CalendrierButton.BackColor = Color.FromArgb(100, 0, 100);
            CalendrierButton.ForeColor = SystemColors.ButtonHighlight;
            CalendrierButton.Image = Properties.Resources.calendrier;
            CalendrierButton.Location = new Point(-3, 329);
            CalendrierButton.Name = "CalendrierButton";
            CalendrierButton.Size = new Size(262, 80);
            CalendrierButton.TabIndex = 3;
            CalendrierButton.Text = "Calendrier";
            CalendrierButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            CalendrierButton.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Cursor = Cursors.Hand;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(-11, 88);
            button1.Name = "button1";
            button1.Size = new Size(262, 80);
            button1.TabIndex = 2;
            button1.Text = "HOME";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(label8);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(243, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1026, 147);
            panel2.TabIndex = 28;
            panel2.Paint += panel2_Paint;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.WhiteSmoke;
            label8.Font = new Font("Stencil", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ImageAlign = ContentAlignment.MiddleRight;
            label8.Location = new Point(296, 40);
            label8.Name = "label8";
            label8.Size = new Size(352, 52);
            label8.TabIndex = 5;
            label8.Text = "Espace Admin ";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Location = new Point(-17, 1);
            panel4.Name = "panel4";
            panel4.Size = new Size(1043, 22);
            panel4.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(64, 0, 64);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(pictureBox3);
            panel3.Location = new Point(830, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(128, 135);
            panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.logo1;
            pictureBox1.Location = new Point(21, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(86, 88);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.cornerRight;
            pictureBox2.Location = new Point(64, 47);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(204, 91);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.cornerLeft;
            pictureBox3.Location = new Point(-30, -1);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(146, 153);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(64, 0, 64);
            panel5.Controls.Add(precedent);
            panel5.Controls.Add(next);
            panel5.Controls.Add(mois);
            panel5.Location = new Point(404, 177);
            panel5.Name = "panel5";
            panel5.Size = new Size(615, 83);
            panel5.TabIndex = 29;
            // 
            // refreshbutton
            // 
            refreshbutton.Location = new Point(1093, 202);
            refreshbutton.Name = "refreshbutton";
            refreshbutton.Size = new Size(96, 40);
            refreshbutton.TabIndex = 30;
            refreshbutton.Text = "refresh";
            refreshbutton.UseVisualStyleBackColor = true;
            refreshbutton.Click += refreshbutton_Click;
            // 
            // calendrier
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1273, 919);
            Controls.Add(refreshbutton);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
            Name = "calendrier";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label mois;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button precedent;
        private Panel panel1;
        private Button chefsButton;
        private Button CommandesButton;
        private Button ServeursButton;
        private PictureBox pictureBox4;
        private Button PlatsButton;
        private Button CalendrierButton;
        private Button button1;
        private Panel panel2;
        private Label label8;
        private Panel panel4;
        private Panel panel3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Panel panel5;
        private Button refreshbutton;
    }
}

