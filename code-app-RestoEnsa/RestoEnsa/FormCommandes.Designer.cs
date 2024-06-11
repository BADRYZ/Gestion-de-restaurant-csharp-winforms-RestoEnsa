namespace RestoEnsa
{
    partial class FormCommandes
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCommandes));
            label1 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            tableLayoutPanel1 = new TableLayoutPanel();
            textBoxFacture = new TextBox();
            textBoxPlats = new TextBox();
            textBoxNumeroTable = new TextBox();
            label6 = new Label();
            label2 = new Label();
            textBoxNumeroCommande = new TextBox();
            comboBoxChef = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            saveButton = new Button();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            chefsButton = new Button();
            CommandesButton = new Button();
            ServeursButton = new Button();
            pictureBox4 = new PictureBox();
            PlatsButton = new Button();
            CalendrierButton = new Button();
            button1 = new Button();
            panel2 = new Panel();
            label7 = new Label();
            panel4 = new Panel();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Stencil", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(210, 131);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(234, 41);
            label1.TabIndex = 2;
            label1.Text = "Commandes";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.None;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.10506F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60.89494F));
            tableLayoutPanel1.Controls.Add(textBoxFacture, 1, 3);
            tableLayoutPanel1.Controls.Add(textBoxPlats, 1, 2);
            tableLayoutPanel1.Controls.Add(textBoxNumeroTable, 1, 1);
            tableLayoutPanel1.Controls.Add(label6, 0, 4);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(textBoxNumeroCommande, 1, 0);
            tableLayoutPanel1.Controls.Add(comboBoxChef, 1, 4);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(label5, 0, 2);
            tableLayoutPanel1.Location = new Point(279, 348);
            tableLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50.5618F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 49.4382F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanel1.Size = new Size(599, 237);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // textBoxFacture
            // 
            textBoxFacture.Anchor = AnchorStyles.None;
            textBoxFacture.BackColor = SystemColors.Window;
            textBoxFacture.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxFacture.Location = new Point(238, 151);
            textBoxFacture.Margin = new Padding(4, 5, 4, 5);
            textBoxFacture.Name = "textBoxFacture";
            textBoxFacture.ReadOnly = true;
            textBoxFacture.Size = new Size(357, 28);
            textBoxFacture.TabIndex = 8;
            // 
            // textBoxPlats
            // 
            textBoxPlats.Anchor = AnchorStyles.None;
            textBoxPlats.BackColor = SystemColors.Window;
            textBoxPlats.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPlats.Location = new Point(238, 100);
            textBoxPlats.Margin = new Padding(4, 5, 4, 5);
            textBoxPlats.Name = "textBoxPlats";
            textBoxPlats.ReadOnly = true;
            textBoxPlats.Size = new Size(357, 28);
            textBoxPlats.TabIndex = 7;
            textBoxPlats.TextChanged += textBoxPlats_TextChanged;
            // 
            // textBoxNumeroTable
            // 
            textBoxNumeroTable.Anchor = AnchorStyles.None;
            textBoxNumeroTable.BackColor = SystemColors.Window;
            textBoxNumeroTable.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNumeroTable.Location = new Point(238, 50);
            textBoxNumeroTable.Margin = new Padding(4, 5, 4, 5);
            textBoxNumeroTable.Name = "textBoxNumeroTable";
            textBoxNumeroTable.ReadOnly = true;
            textBoxNumeroTable.Size = new Size(357, 28);
            textBoxNumeroTable.TabIndex = 6;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.Font = new Font("Stencil", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(4, 190);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(226, 44);
            label6.TabIndex = 4;
            label6.Text = "Chef";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.Font = new Font("Stencil", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(4, 3);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(226, 37);
            label2.TabIndex = 0;
            label2.Text = "Numéro Commande";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxNumeroCommande
            // 
            textBoxNumeroCommande.Anchor = AnchorStyles.None;
            textBoxNumeroCommande.BackColor = SystemColors.Window;
            textBoxNumeroCommande.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNumeroCommande.Location = new Point(238, 7);
            textBoxNumeroCommande.Margin = new Padding(4, 5, 4, 5);
            textBoxNumeroCommande.Name = "textBoxNumeroCommande";
            textBoxNumeroCommande.ReadOnly = true;
            textBoxNumeroCommande.Size = new Size(357, 28);
            textBoxNumeroCommande.TabIndex = 5;
            textBoxNumeroCommande.TextChanged += textBoxNumeroCommande_TextChanged;
            // 
            // comboBoxChef
            // 
            comboBoxChef.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxChef.FormattingEnabled = true;
            comboBoxChef.Location = new Point(238, 193);
            comboBoxChef.Margin = new Padding(4, 5, 4, 5);
            comboBoxChef.Name = "comboBoxChef";
            comboBoxChef.Size = new Size(357, 30);
            comboBoxChef.TabIndex = 9;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.Font = new Font("Stencil", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(4, 144);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(226, 42);
            label4.TabIndex = 2;
            label4.Text = "Facture";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.Font = new Font("Stencil", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(4, 43);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(226, 42);
            label3.TabIndex = 1;
            label3.Text = "Numéro Table";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.Font = new Font("Stencil", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(4, 97);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(226, 34);
            label5.TabIndex = 3;
            label5.Text = "Plats";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.Black;
            saveButton.Font = new Font("Microsoft Sans Serif", 12F);
            saveButton.ForeColor = SystemColors.ButtonHighlight;
            saveButton.Location = new Point(476, 600);
            saveButton.Margin = new Padding(4, 5, 4, 5);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(215, 46);
            saveButton.TabIndex = 5;
            saveButton.Text = "Sauvegarder";
            saveButton.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Window;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(268, 172);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(660, 166);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            panel1.Location = new Point(1, 2);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(194, 731);
            panel1.TabIndex = 25;
            // 
            // chefsButton
            // 
            chefsButton.BackColor = Color.Black;
            chefsButton.ForeColor = SystemColors.ButtonHighlight;
            chefsButton.Image = Properties.Resources.chef__1_;
            chefsButton.Location = new Point(-10, 398);
            chefsButton.Margin = new Padding(2, 2, 2, 2);
            chefsButton.Name = "chefsButton";
            chefsButton.Size = new Size(204, 64);
            chefsButton.TabIndex = 19;
            chefsButton.Text = "Chefs";
            chefsButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            chefsButton.UseVisualStyleBackColor = false;
            chefsButton.Click += chefsButton_Click;
            // 
            // CommandesButton
            // 
            CommandesButton.BackColor = Color.FromArgb(100, 0, 100);
            CommandesButton.ForeColor = SystemColors.ButtonHighlight;
            CommandesButton.Image = Properties.Resources.commander_de_la_nourriture__1_;
            CommandesButton.Location = new Point(-6, 332);
            CommandesButton.Margin = new Padding(2, 2, 2, 2);
            CommandesButton.Name = "CommandesButton";
            CommandesButton.Size = new Size(204, 64);
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
            ServeursButton.Location = new Point(-6, 134);
            ServeursButton.Margin = new Padding(2, 2, 2, 2);
            ServeursButton.Name = "ServeursButton";
            ServeursButton.Size = new Size(210, 64);
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
            pictureBox4.Location = new Point(134, 70);
            pictureBox4.Margin = new Padding(2, 2, 2, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(140, 57);
            pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox4.TabIndex = 14;
            pictureBox4.TabStop = false;
            // 
            // PlatsButton
            // 
            PlatsButton.BackColor = Color.Black;
            PlatsButton.ForeColor = SystemColors.ButtonHighlight;
            PlatsButton.Image = Properties.Resources.cuisine__1_;
            PlatsButton.Location = new Point(-10, 198);
            PlatsButton.Margin = new Padding(2, 2, 2, 2);
            PlatsButton.Name = "PlatsButton";
            PlatsButton.Size = new Size(210, 64);
            PlatsButton.TabIndex = 4;
            PlatsButton.Text = "Plats";
            PlatsButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            PlatsButton.UseVisualStyleBackColor = false;
            PlatsButton.Click += PlatsButton_Click;
            // 
            // CalendrierButton
            // 
            CalendrierButton.BackColor = Color.Black;
            CalendrierButton.ForeColor = SystemColors.ButtonHighlight;
            CalendrierButton.Image = Properties.Resources.calendrier;
            CalendrierButton.Location = new Point(-2, 263);
            CalendrierButton.Margin = new Padding(2, 2, 2, 2);
            CalendrierButton.Name = "CalendrierButton";
            CalendrierButton.Size = new Size(210, 64);
            CalendrierButton.TabIndex = 3;
            CalendrierButton.Text = "Calendrier";
            CalendrierButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            CalendrierButton.UseVisualStyleBackColor = false;
            CalendrierButton.Click += CalendrierButton_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Cursor = Cursors.Hand;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(-9, 70);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(210, 64);
            button1.TabIndex = 2;
            button1.Text = "HOME";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(label7);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(199, 2);
            panel2.Margin = new Padding(2, 2, 2, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(817, 118);
            panel2.TabIndex = 26;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.WhiteSmoke;
            label7.Font = new Font("Stencil", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ImageAlign = ContentAlignment.MiddleRight;
            label7.Location = new Point(237, 32);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(300, 44);
            label7.TabIndex = 5;
            label7.Text = "Espace Admin ";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Location = new Point(-14, 1);
            panel4.Margin = new Padding(2, 2, 2, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(834, 18);
            panel4.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(64, 0, 64);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(pictureBox3);
            panel3.Location = new Point(664, 10);
            panel3.Margin = new Padding(2, 2, 2, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(102, 108);
            panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.logo1;
            pictureBox1.Location = new Point(17, 6);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.cornerRight;
            pictureBox2.Location = new Point(51, 38);
            pictureBox2.Margin = new Padding(2, 2, 2, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(163, 73);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.cornerLeft;
            pictureBox3.Location = new Point(-24, -1);
            pictureBox3.Margin = new Padding(2, 2, 2, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(117, 122);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // FormCommandes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1010, 660);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(saveButton);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormCommandes";
            Text = "Form1";
            Load += FormCommandes_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNumeroCommande;
        private System.Windows.Forms.TextBox textBoxFacture;
        private System.Windows.Forms.TextBox textBoxPlats;
        private System.Windows.Forms.TextBox textBoxNumeroTable;
        private System.Windows.Forms.ComboBox comboBoxChef;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Panel panel1;
        private Button ServeursButton;
        private PictureBox pictureBox4;
        private Button PlatsButton;
        private Button CalendrierButton;
        private Button button1;
        private Panel panel2;
        private Label label7;
        private Panel panel4;
        private Panel panel3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button chefsButton;
        private Button CommandesButton;
    }
}

