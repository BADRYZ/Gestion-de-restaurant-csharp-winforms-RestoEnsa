namespace RestoEnsa
{
    partial class ChefsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChefsForm));
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            textBoxNomChef = new TextBox();
            label3 = new Label();
            textBoxNumeroChef = new TextBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            tableLayoutPanel3 = new TableLayoutPanel();
            cancelButton = new Button();
            saveButton = new Button();
            deleteButton = new Button();
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
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel3.SuspendLayout();
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
            label1.Location = new Point(211, 138);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(282, 40);
            label1.TabIndex = 3;
            label1.Text = "Chefs";
            label1.Click += label1_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.None;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.10506F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60.89494F));
            tableLayoutPanel2.Controls.Add(textBoxNomChef, 1, 1);
            tableLayoutPanel2.Controls.Add(label3, 0, 1);
            tableLayoutPanel2.Controls.Add(textBoxNumeroChef, 1, 0);
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Location = new Point(240, 438);
            tableLayoutPanel2.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50.5618F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 49.4382F));
            tableLayoutPanel2.Size = new Size(686, 152);
            tableLayoutPanel2.TabIndex = 5;
            // 
            // textBoxNomChef
            // 
            textBoxNomChef.Anchor = AnchorStyles.None;
            textBoxNomChef.BackColor = SystemColors.Window;
            textBoxNomChef.Font = new Font("Microsoft Sans Serif", 12F);
            textBoxNomChef.Location = new Point(273, 99);
            textBoxNomChef.Margin = new Padding(4, 5, 4, 5);
            textBoxNomChef.Name = "textBoxNomChef";
            textBoxNomChef.Size = new Size(408, 30);
            textBoxNomChef.TabIndex = 6;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(4, 85);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(260, 57);
            label3.TabIndex = 1;
            label3.Text = "Nom Chef";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxNumeroChef
            // 
            textBoxNumeroChef.Anchor = AnchorStyles.None;
            textBoxNumeroChef.BackColor = SystemColors.Window;
            textBoxNumeroChef.Font = new Font("Microsoft Sans Serif", 12F);
            textBoxNumeroChef.Location = new Point(273, 23);
            textBoxNumeroChef.Margin = new Padding(4, 5, 4, 5);
            textBoxNumeroChef.Name = "textBoxNumeroChef";
            textBoxNumeroChef.ReadOnly = true;
            textBoxNumeroChef.Size = new Size(408, 30);
            textBoxNumeroChef.TabIndex = 5;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(4, 9);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(260, 57);
            label2.TabIndex = 0;
            label2.Text = "Numéro Chef";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Window;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(240, 182);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(686, 226);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.17094F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 59.82906F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 211F));
            tableLayoutPanel3.Controls.Add(cancelButton, 1, 0);
            tableLayoutPanel3.Controls.Add(saveButton, 0, 0);
            tableLayoutPanel3.Controls.Add(deleteButton, 1, 0);
            tableLayoutPanel3.Location = new Point(252, 614);
            tableLayoutPanel3.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.Padding = new Padding(6, 0, 6, 0);
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(668, 75);
            tableLayoutPanel3.TabIndex = 8;
            tableLayoutPanel3.Paint += tableLayoutPanel3_Paint;
            // 
            // cancelButton
            // 
            cancelButton.Anchor = AnchorStyles.None;
            cancelButton.BackColor = Color.Black;
            cancelButton.FlatAppearance.BorderSize = 0;
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancelButton.ForeColor = SystemColors.Control;
            cancelButton.Location = new Point(459, 8);
            cancelButton.Margin = new Padding(4, 5, 4, 5);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(194, 59);
            cancelButton.TabIndex = 4;
            cancelButton.Text = "Annuler";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // saveButton
            // 
            saveButton.Anchor = AnchorStyles.None;
            saveButton.BackColor = Color.Black;
            saveButton.FlatAppearance.BorderSize = 0;
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saveButton.ForeColor = SystemColors.Control;
            saveButton.Location = new Point(10, 10);
            saveButton.Margin = new Padding(4, 5, 4, 5);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(170, 54);
            saveButton.TabIndex = 3;
            saveButton.Text = "Sauvegarder";
            saveButton.UseVisualStyleBackColor = false;
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.None;
            deleteButton.BackColor = Color.Black;
            deleteButton.FlatAppearance.BorderSize = 0;
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteButton.ForeColor = SystemColors.Control;
            deleteButton.Location = new Point(226, 9);
            deleteButton.Margin = new Padding(4, 5, 4, 5);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(182, 56);
            deleteButton.TabIndex = 5;
            deleteButton.Text = "Supprimer";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += DeleteButton_Click;
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
            panel1.Location = new Point(2, 3);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(194, 731);
            panel1.TabIndex = 26;
            // 
            // chefsButton
            // 
            chefsButton.BackColor = Color.FromArgb(100, 0, 100);
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
            // 
            // CommandesButton
            // 
            CommandesButton.BackColor = Color.Black;
            CommandesButton.ForeColor = SystemColors.ButtonHighlight;
            CommandesButton.Image = Properties.Resources.commander_de_la_nourriture__1_;
            CommandesButton.Location = new Point(-6, 332);
            CommandesButton.Margin = new Padding(2, 2, 2, 2);
            CommandesButton.Name = "CommandesButton";
            CommandesButton.Size = new Size(204, 65);
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
            panel2.Location = new Point(193, 3);
            panel2.Margin = new Padding(2, 2, 2, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(821, 118);
            panel2.TabIndex = 27;
            panel2.Paint += panel2_Paint;
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
            pictureBox1.Image = Properties.Resources.logo;
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
            // ChefsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 717);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(dataGridView1);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ChefsForm";
            Text = "ChefsForm";
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox textBoxNomChef;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNumeroChef;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button deleteButton;
        private Panel panel1;
        private Button chefsButton;
        private Button CommandesButton;
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
    }
}