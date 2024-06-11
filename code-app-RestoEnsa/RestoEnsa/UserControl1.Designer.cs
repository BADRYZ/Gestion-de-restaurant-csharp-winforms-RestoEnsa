namespace RestoEnsa
{
    partial class Supprimercat
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
            AjouterPlat = new Panel();
            label1 = new Label();
            comboBox1 = new ComboBox();
            button6 = new Button();
            button5 = new Button();
            Prix = new TextBox();
            NomPlat = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            Categories = new Panel();
            button2 = new Button();
            button1 = new Button();
            label19 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            description2 = new DataGridViewTextBoxColumn();
            CatImage = new DataGridViewImageColumn();
            modifierCategori = new Panel();
            label2 = new Label();
            VIEWBUTTON = new Button();
            label15 = new Label();
            pictureBoxCategorie = new PictureBox();
            addImage = new Button();
            modifier = new Button();
            description = new TextBox();
            Nomcate = new TextBox();
            label16 = new Label();
            label18 = new Label();
            AjouterPlat.SuspendLayout();
            Categories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            modifierCategori.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCategorie).BeginInit();
            SuspendLayout();
            // 
            // AjouterPlat
            // 
            AjouterPlat.Controls.Add(label1);
            AjouterPlat.Controls.Add(comboBox1);
            AjouterPlat.Controls.Add(button6);
            AjouterPlat.Controls.Add(button5);
            AjouterPlat.Controls.Add(Prix);
            AjouterPlat.Controls.Add(NomPlat);
            AjouterPlat.Controls.Add(label6);
            AjouterPlat.Controls.Add(label5);
            AjouterPlat.Controls.Add(label3);
            AjouterPlat.Location = new Point(12, 19);
            AjouterPlat.Name = "AjouterPlat";
            AjouterPlat.Size = new Size(977, 524);
            AjouterPlat.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 24);
            label1.Name = "label1";
            label1.Size = new Size(256, 33);
            label1.TabIndex = 4;
            label1.Text = "Ajouter Un Plat";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(343, 175);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(219, 33);
            comboBox1.TabIndex = 21;
            // 
            // button6
            // 
            button6.BackColor = Color.Gainsboro;
            button6.ForeColor = SystemColors.ButtonHighlight;
            button6.Image = Properties.Resources.plus__1_;
            button6.Location = new Point(588, 169);
            button6.Name = "button6";
            button6.Size = new Size(42, 43);
            button6.TabIndex = 14;
            button6.TextImageRelation = TextImageRelation.ImageBeforeText;
            button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Black;
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(664, 372);
            button5.Name = "button5";
            button5.Size = new Size(183, 70);
            button5.TabIndex = 20;
            button5.Text = "Ajouter";
            button5.TextImageRelation = TextImageRelation.ImageBeforeText;
            button5.UseVisualStyleBackColor = false;
            // 
            // Prix
            // 
            Prix.BorderStyle = BorderStyle.FixedSingle;
            Prix.Location = new Point(343, 335);
            Prix.Name = "Prix";
            Prix.Size = new Size(219, 31);
            Prix.TabIndex = 19;
            // 
            // NomPlat
            // 
            NomPlat.BorderStyle = BorderStyle.FixedSingle;
            NomPlat.Location = new Point(343, 254);
            NomPlat.Name = "NomPlat";
            NomPlat.Size = new Size(219, 31);
            NomPlat.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(39, 255);
            label6.Name = "label6";
            label6.Size = new Size(52, 25);
            label6.TabIndex = 16;
            label6.Text = "Nom";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 335);
            label5.Name = "label5";
            label5.Size = new Size(40, 25);
            label5.TabIndex = 15;
            label5.Text = "Prix";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 169);
            label3.Name = "label3";
            label3.Size = new Size(88, 25);
            label3.TabIndex = 14;
            label3.Text = "Categorie";
            // 
            // Categories
            // 
            Categories.Controls.Add(button2);
            Categories.Controls.Add(button1);
            Categories.Controls.Add(label19);
            Categories.Controls.Add(dataGridView1);
            Categories.Location = new Point(1030, 43);
            Categories.Name = "Categories";
            Categories.Size = new Size(974, 518);
            Categories.TabIndex = 35;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(719, 435);
            button2.Name = "button2";
            button2.Size = new Size(192, 53);
            button2.TabIndex = 24;
            button2.Text = "Modier";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(515, 435);
            button1.Name = "button1";
            button1.Size = new Size(185, 53);
            button1.TabIndex = 23;
            button1.Text = "Supprimer";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Stencil", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label19.Location = new Point(14, 29);
            label19.Name = "label19";
            label19.Size = new Size(179, 33);
            label19.TabIndex = 4;
            label19.Text = "Categories";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.FromArgb(64, 0, 64);
            dataGridView1.ColumnHeadersHeight = 33;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, description2, CatImage });
            dataGridView1.Location = new Point(95, 79);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(761, 333);
            dataGridView1.TabIndex = 21;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "nom";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            // 
            // description2
            // 
            description2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            description2.HeaderText = "description";
            description2.MinimumWidth = 8;
            description2.Name = "description2";
            // 
            // CatImage
            // 
            CatImage.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CatImage.HeaderText = "visualisation";
            CatImage.MinimumWidth = 8;
            CatImage.Name = "CatImage";
            // 
            // modifierCategori
            // 
            modifierCategori.Controls.Add(label2);
            modifierCategori.Controls.Add(VIEWBUTTON);
            modifierCategori.Controls.Add(label15);
            modifierCategori.Controls.Add(pictureBoxCategorie);
            modifierCategori.Controls.Add(addImage);
            modifierCategori.Controls.Add(modifier);
            modifierCategori.Controls.Add(description);
            modifierCategori.Controls.Add(Nomcate);
            modifierCategori.Controls.Add(label16);
            modifierCategori.Controls.Add(label18);
            modifierCategori.Location = new Point(12, 574);
            modifierCategori.Name = "modifierCategori";
            modifierCategori.Size = new Size(969, 500);
            modifierCategori.TabIndex = 36;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 326);
            label2.Name = "label2";
            label2.Size = new Size(111, 25);
            label2.TabIndex = 23;
            label2.Text = "Description :";
            // 
            // VIEWBUTTON
            // 
            VIEWBUTTON.BackColor = Color.Black;
            VIEWBUTTON.ForeColor = SystemColors.ButtonHighlight;
            VIEWBUTTON.Location = new Point(833, 31);
            VIEWBUTTON.Name = "VIEWBUTTON";
            VIEWBUTTON.Size = new Size(116, 70);
            VIEWBUTTON.TabIndex = 22;
            VIEWBUTTON.Text = "VIEW";
            VIEWBUTTON.TextImageRelation = TextImageRelation.ImageBeforeText;
            VIEWBUTTON.UseVisualStyleBackColor = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Stencil", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(20, 31);
            label15.Name = "label15";
            label15.Size = new Size(302, 33);
            label15.TabIndex = 4;
            label15.Text = "Modifier categorie";
            // 
            // pictureBoxCategorie
            // 
            pictureBoxCategorie.Image = Properties.Resources.logo;
            pictureBoxCategorie.Location = new Point(322, 270);
            pictureBoxCategorie.Name = "pictureBoxCategorie";
            pictureBoxCategorie.Size = new Size(138, 118);
            pictureBoxCategorie.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCategorie.TabIndex = 21;
            pictureBoxCategorie.TabStop = false;
            // 
            // addImage
            // 
            addImage.BackColor = Color.Black;
            addImage.ForeColor = SystemColors.ButtonHighlight;
            addImage.Location = new Point(515, 314);
            addImage.Name = "addImage";
            addImage.Size = new Size(219, 49);
            addImage.TabIndex = 14;
            addImage.Text = "Ajouter image";
            addImage.TextImageRelation = TextImageRelation.ImageBeforeText;
            addImage.UseVisualStyleBackColor = false;
            // 
            // modifier
            // 
            modifier.BackColor = Color.Black;
            modifier.ForeColor = SystemColors.ButtonHighlight;
            modifier.Location = new Point(686, 419);
            modifier.Name = "modifier";
            modifier.Size = new Size(263, 58);
            modifier.TabIndex = 20;
            modifier.Text = "Modifier";
            modifier.TextImageRelation = TextImageRelation.ImageBeforeText;
            modifier.UseVisualStyleBackColor = false;
            // 
            // description
            // 
            description.BorderStyle = BorderStyle.FixedSingle;
            description.Location = new Point(322, 160);
            description.Multiline = true;
            description.Name = "description";
            description.Size = new Size(219, 71);
            description.TabIndex = 18;
            // 
            // Nomcate
            // 
            Nomcate.BorderStyle = BorderStyle.FixedSingle;
            Nomcate.Location = new Point(322, 100);
            Nomcate.Name = "Nomcate";
            Nomcate.Size = new Size(219, 31);
            Nomcate.TabIndex = 17;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(51, 206);
            label16.Name = "label16";
            label16.Size = new Size(111, 25);
            label16.TabIndex = 16;
            label16.Text = "Description :";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(51, 106);
            label18.Name = "label18";
            label18.Size = new Size(142, 25);
            label18.TabIndex = 14;
            label18.Text = "Nom Categorie :";
            // 
            // Supprimercat
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(modifierCategori);
            Controls.Add(Categories);
            Controls.Add(AjouterPlat);
            Name = "Supprimercat";
            Size = new Size(2110, 1491);
            AjouterPlat.ResumeLayout(false);
            AjouterPlat.PerformLayout();
            Categories.ResumeLayout(false);
            Categories.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            modifierCategori.ResumeLayout(false);
            modifierCategori.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCategorie).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel AjouterPlat;
        private Label label1;
        private ComboBox comboBox1;
        private Button button6;
        public Button button5;
        public TextBox Prix;
        public TextBox NomPlat;
        public Label label6;
        public Label label5;
        public Label label3;
        private Panel Categories;
        private Label label19;
        private DataGridView dataGridView1;
        private Panel AjouterCategori;
        private Button VIEWBUTTON;
        private Label label15;
        private PictureBox pictureBoxCategorie;
        private Button addImage;
        public Button button10;
        public TextBox description;
        public TextBox Nomcate;
        public Label label16;
        public Label label18;
        public Label label2;
        private Button button2;
        private Button button1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn description2;
        private DataGridViewImageColumn CatImage;
        private Panel modifierCategori;
        public Button modifier;
    }
}
