namespace RestoEnsa
{
    partial class Menu
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
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            Categorie = new ComboBox();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            Plat = new ComboBox();
            listCommande = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            Add = new MaterialSkin.Controls.MaterialFlatButton();
            Save = new MaterialSkin.Controls.MaterialFlatButton();
            Facture = new MaterialSkin.Controls.MaterialFlatButton();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            qte = new NumericUpDown();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            PrixTotal = new MaterialSkin.Controls.MaterialLabel();
            Delete = new MaterialSkin.Controls.MaterialFlatButton();
            NEW = new MaterialSkin.Controls.MaterialFlatButton();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label7 = new Label();
            panel4 = new Panel();
            ((System.ComponentModel.ISupportInitialize)qte).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.BackColor = Color.Transparent;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 11F);
            materialLabel1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel1.Location = new Point(32, 212);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(183, 24);
            materialLabel1.TabIndex = 0;
            materialLabel1.Text = "Choose the category";
            // 
            // Categorie
            // 
            Categorie.AllowDrop = true;
            Categorie.FormattingEnabled = true;
            Categorie.Location = new Point(288, 210);
            Categorie.Margin = new Padding(3, 4, 3, 4);
            Categorie.Name = "Categorie";
            Categorie.Size = new Size(121, 28);
            Categorie.TabIndex = 2;
            Categorie.SelectedIndexChanged += Categorie_SelectedIndexChanged;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.BackColor = Color.Transparent;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 11F);
            materialLabel2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel2.Location = new Point(32, 324);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(43, 24);
            materialLabel2.TabIndex = 2;
            materialLabel2.Text = "Plat";
            // 
            // Plat
            // 
            Plat.FormattingEnabled = true;
            Plat.Location = new Point(288, 324);
            Plat.Margin = new Padding(3, 4, 3, 4);
            Plat.Name = "Plat";
            Plat.Size = new Size(121, 28);
            Plat.TabIndex = 3;
            Plat.SelectedIndexChanged += Plat_SelectedIndexChanged;
            // 
            // listCommande
            // 
            listCommande.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listCommande.Location = new Point(483, 210);
            listCommande.Margin = new Padding(3, 4, 3, 4);
            listCommande.Name = "listCommande";
            listCommande.Size = new Size(326, 329);
            listCommande.TabIndex = 4;
            listCommande.UseCompatibleStateImageBehavior = false;
            listCommande.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Plats";
            columnHeader1.Width = 105;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Prix";
            columnHeader2.Width = 86;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Quantiité";
            columnHeader3.Width = 95;
            // 
            // Add
            // 
            Add.AutoSize = true;
            Add.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Add.BackColor = Color.WhiteSmoke;
            Add.Depth = 0;
            Add.Location = new Point(53, 521);
            Add.Margin = new Padding(4, 7, 4, 7);
            Add.MouseState = MaterialSkin.MouseState.HOVER;
            Add.Name = "Add";
            Add.Primary = false;
            Add.Size = new Size(162, 36);
            Add.TabIndex = 5;
            Add.Text = "Ajouter un plat";
            Add.UseVisualStyleBackColor = false;
            Add.Click += Add_Click;
            // 
            // Save
            // 
            Save.AutoSize = true;
            Save.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Save.Depth = 0;
            Save.Location = new Point(510, 625);
            Save.Margin = new Padding(4, 7, 4, 7);
            Save.MouseState = MaterialSkin.MouseState.HOVER;
            Save.Name = "Save";
            Save.Primary = false;
            Save.Size = new Size(124, 36);
            Save.TabIndex = 6;
            Save.Text = "ENREGISTRER";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // Facture
            // 
            Facture.AutoSize = true;
            Facture.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Facture.Depth = 0;
            Facture.Location = new Point(275, 521);
            Facture.Margin = new Padding(4, 7, 4, 7);
            Facture.MouseState = MaterialSkin.MouseState.HOVER;
            Facture.Name = "Facture";
            Facture.Primary = false;
            Facture.Size = new Size(178, 36);
            Facture.TabIndex = 7;
            Facture.Text = "Calculer le total";
            Facture.UseVisualStyleBackColor = true;
            Facture.Click += Facture_Click;
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.BackColor = Color.Transparent;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 11F);
            materialLabel3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel3.Location = new Point(32, 423);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(95, 24);
            materialLabel3.TabIndex = 8;
            materialLabel3.Text = "Quantite : ";
            // 
            // qte
            // 
            qte.Location = new Point(288, 425);
            qte.Margin = new Padding(3, 4, 3, 4);
            qte.Name = "qte";
            qte.Size = new Size(120, 27);
            qte.TabIndex = 9;
            qte.Value = new decimal(new int[] { 1, 0, 0, 0 });
            qte.ValueChanged += qte_ValueChanged;
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 11F);
            materialLabel4.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel4.Location = new Point(500, 564);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(68, 24);
            materialLabel4.TabIndex = 10;
            materialLabel4.Text = "Total : ";
            // 
            // PrixTotal
            // 
            PrixTotal.AutoSize = true;
            PrixTotal.Depth = 0;
            PrixTotal.Font = new Font("Roboto", 11F);
            PrixTotal.ForeColor = Color.FromArgb(222, 0, 0, 0);
            PrixTotal.Location = new Point(658, 576);
            PrixTotal.MouseState = MaterialSkin.MouseState.HOVER;
            PrixTotal.Name = "PrixTotal";
            PrixTotal.Size = new Size(0, 24);
            PrixTotal.TabIndex = 11;
            // 
            // Delete
            // 
            Delete.AutoSize = true;
            Delete.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Delete.Depth = 0;
            Delete.Location = new Point(681, 625);
            Delete.Margin = new Padding(4, 7, 4, 7);
            Delete.MouseState = MaterialSkin.MouseState.HOVER;
            Delete.Name = "Delete";
            Delete.Primary = false;
            Delete.Size = new Size(108, 36);
            Delete.TabIndex = 12;
            Delete.Text = "SUPPRIMER";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // NEW
            // 
            NEW.AutoSize = true;
            NEW.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            NEW.Depth = 0;
            NEW.Location = new Point(145, 625);
            NEW.Margin = new Padding(4, 7, 4, 7);
            NEW.MouseState = MaterialSkin.MouseState.HOVER;
            NEW.Name = "NEW";
            NEW.Primary = false;
            NEW.Size = new Size(199, 36);
            NEW.TabIndex = 13;
            NEW.Text = "NOUVELLE COMMANDE";
            NEW.UseVisualStyleBackColor = true;
            NEW.Click += NEW_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(Delete);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(Save);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(861, 690);
            panel2.TabIndex = 29;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(725, 18);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(98, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Stencil", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(352, 130);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(87, 32);
            label1.TabIndex = 30;
            label1.Text = "Menu";
            label1.TextAlign = ContentAlignment.MiddleCenter;
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
            label7.Size = new Size(340, 44);
            label7.TabIndex = 5;
            label7.Text = "Espace Serveur";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Location = new Point(-14, 1);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(874, 18);
            panel4.TabIndex = 3;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(861, 690);
            Controls.Add(NEW);
            Controls.Add(PrixTotal);
            Controls.Add(materialLabel4);
            Controls.Add(qte);
            Controls.Add(materialLabel3);
            Controls.Add(Facture);
            Controls.Add(Add);
            Controls.Add(listCommande);
            Controls.Add(Plat);
            Controls.Add(materialLabel2);
            Controls.Add(Categorie);
            Controls.Add(materialLabel1);
            Controls.Add(panel2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Menu";
            Text = "Menu";
            Load += Menu_Load;
            ((System.ComponentModel.ISupportInitialize)qte).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.ComboBox Categorie;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.ComboBox Plat;
        private System.Windows.Forms.ListView listCommande;
        private MaterialSkin.Controls.MaterialFlatButton Add;
        private MaterialSkin.Controls.MaterialFlatButton Save;
        private MaterialSkin.Controls.MaterialFlatButton Facture;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.NumericUpDown qte;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel PrixTotal;
        private MaterialSkin.Controls.MaterialFlatButton Delete;
        private MaterialSkin.Controls.MaterialFlatButton NEW;
        private Panel panel2;
        private Label label7;
        private Panel panel4;
        private PictureBox pictureBox1;
        private Label label1;
    }
}