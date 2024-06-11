namespace RestoEnsa
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            chefsButton = new Button();
            CommandesButton = new Button();
            ServeursButton = new Button();
            pictureBox4 = new PictureBox();
            PaltsButton = new Button();
            button2 = new Button();
            button1 = new Button();
            VisualiserServer = new Panel();
            RendementPanel = new Panel();
            panel9 = new Panel();
            label14 = new Label();
            RendementF = new TextBox();
            button5 = new Button();
            NoteShift = new TextBox();
            panel10 = new Panel();
            label10 = new Label();
            button8 = new Button();
            NoteSet = new TextBox();
            NomSer = new TextBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            Rendement = new Button();
            panel6 = new Panel();
            label4 = new Label();
            button7 = new Button();
            Supprimer = new Button();
            listView1 = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            panel2 = new Panel();
            label2 = new Label();
            panel4 = new Panel();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            button6 = new Button();
            panel5 = new Panel();
            label1 = new Label();
            AjouterServeurPanel = new Panel();
            panel7 = new Panel();
            AjouterServer = new Button();
            Mdp = new TextBox();
            Login = new TextBox();
            Nom = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            VisualiserServer.SuspendLayout();
            RendementPanel.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            panel6.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel5.SuspendLayout();
            AjouterServeurPanel.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 0, 64);
            panel1.Controls.Add(chefsButton);
            panel1.Controls.Add(CommandesButton);
            panel1.Controls.Add(ServeursButton);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(PaltsButton);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(240, 798);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // chefsButton
            // 
            chefsButton.BackColor = Color.Black;
            chefsButton.ForeColor = SystemColors.ButtonHighlight;
            chefsButton.Image = Properties.Resources.chef__1_;
            chefsButton.Location = new Point(-10, 500);
            chefsButton.Name = "chefsButton";
            chefsButton.Size = new Size(255, 80);
            chefsButton.TabIndex = 23;
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
            CommandesButton.Location = new Point(-5, 416);
            CommandesButton.Name = "CommandesButton";
            CommandesButton.Size = new Size(255, 81);
            CommandesButton.TabIndex = 22;
            CommandesButton.Text = "Commandes";
            CommandesButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            CommandesButton.UseVisualStyleBackColor = false;
            CommandesButton.Click += CommandesButton_Click;
            // 
            // ServeursButton
            // 
            ServeursButton.BackColor = Color.FromArgb(100, 0, 100);
            ServeursButton.ForeColor = SystemColors.ButtonHighlight;
            ServeursButton.Image = Properties.Resources.serveur;
            ServeursButton.Location = new Point(-8, 168);
            ServeursButton.Name = "ServeursButton";
            ServeursButton.Size = new Size(262, 80);
            ServeursButton.TabIndex = 15;
            ServeursButton.Text = "Serveurs";
            ServeursButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            ServeursButton.UseVisualStyleBackColor = false;
            ServeursButton.Click += button4_Click;
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
            pictureBox4.Click += pictureBox4_Click;
            // 
            // PaltsButton
            // 
            PaltsButton.BackColor = Color.Black;
            PaltsButton.ForeColor = SystemColors.ButtonHighlight;
            PaltsButton.Image = Properties.Resources.cuisine__1_;
            PaltsButton.Location = new Point(-13, 251);
            PaltsButton.Name = "PaltsButton";
            PaltsButton.Size = new Size(262, 80);
            PaltsButton.TabIndex = 4;
            PaltsButton.Text = "Plats";
            PaltsButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            PaltsButton.UseVisualStyleBackColor = false;
            PaltsButton.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Image = Properties.Resources.calendrier;
            button2.Location = new Point(-3, 333);
            button2.Name = "button2";
            button2.Size = new Size(262, 80);
            button2.TabIndex = 3;
            button2.Text = "Calendrier";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
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
            button1.Click += button1_Click;
            // 
            // VisualiserServer
            // 
            VisualiserServer.BorderStyle = BorderStyle.FixedSingle;
            VisualiserServer.Controls.Add(RendementPanel);
            VisualiserServer.Controls.Add(Rendement);
            VisualiserServer.Controls.Add(panel6);
            VisualiserServer.Controls.Add(Supprimer);
            VisualiserServer.Controls.Add(listView1);
            VisualiserServer.Location = new Point(242, 188);
            VisualiserServer.Name = "VisualiserServer";
            VisualiserServer.Size = new Size(1007, 610);
            VisualiserServer.TabIndex = 23;
            VisualiserServer.Paint += VisualiserServer_Paint;
            // 
            // RendementPanel
            // 
            RendementPanel.Controls.Add(panel9);
            RendementPanel.Controls.Add(button5);
            RendementPanel.Controls.Add(NoteShift);
            RendementPanel.Controls.Add(panel10);
            RendementPanel.Controls.Add(button8);
            RendementPanel.Controls.Add(NoteSet);
            RendementPanel.Controls.Add(NomSer);
            RendementPanel.Controls.Add(label11);
            RendementPanel.Controls.Add(label12);
            RendementPanel.Controls.Add(label13);
            RendementPanel.Location = new Point(5, -1);
            RendementPanel.Name = "RendementPanel";
            RendementPanel.Size = new Size(979, 587);
            RendementPanel.TabIndex = 28;
            RendementPanel.Paint += RendementPanel_Paint;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(64, 0, 64);
            panel9.Controls.Add(label14);
            panel9.Controls.Add(RendementF);
            panel9.Location = new Point(165, 338);
            panel9.Name = "panel9";
            panel9.Size = new Size(650, 113);
            panel9.TabIndex = 24;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = SystemColors.ButtonHighlight;
            label14.Location = new Point(26, 44);
            label14.Name = "label14";
            label14.Size = new Size(152, 25);
            label14.TabIndex = 21;
            label14.Text = "Rendement Final :";
            // 
            // RendementF
            // 
            RendementF.BorderStyle = BorderStyle.FixedSingle;
            RendementF.Enabled = false;
            RendementF.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RendementF.Location = new Point(366, 35);
            RendementF.Margin = new Padding(6, 3, 3, 3);
            RendementF.Name = "RendementF";
            RendementF.Size = new Size(241, 35);
            RendementF.TabIndex = 22;
            RendementF.Text = "Test";
            // 
            // button5
            // 
            button5.BackColor = Color.Black;
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(751, 503);
            button5.Name = "button5";
            button5.Size = new Size(183, 53);
            button5.TabIndex = 23;
            button5.Text = "Valider";
            button5.TextImageRelation = TextImageRelation.ImageBeforeText;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click_1;
            // 
            // NoteShift
            // 
            NoteShift.BorderStyle = BorderStyle.FixedSingle;
            NoteShift.Enabled = false;
            NoteShift.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NoteShift.Location = new Point(345, 166);
            NoteShift.Margin = new Padding(6, 3, 3, 3);
            NoteShift.Name = "NoteShift";
            NoteShift.Size = new Size(254, 35);
            NoteShift.TabIndex = 18;
            // 
            // panel10
            // 
            panel10.BackColor = Color.WhiteSmoke;
            panel10.BorderStyle = BorderStyle.FixedSingle;
            panel10.Controls.Add(label10);
            panel10.ForeColor = SystemColors.ActiveCaptionText;
            panel10.Location = new Point(1, 4);
            panel10.Name = "panel10";
            panel10.Size = new Size(962, 59);
            panel10.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Stencil", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(93, 13);
            label10.Name = "label10";
            label10.Size = new Size(353, 33);
            label10.TabIndex = 4;
            label10.Text = "Rendement du Serveur";
            // 
            // button8
            // 
            button8.BackColor = Color.Black;
            button8.ForeColor = SystemColors.ButtonHighlight;
            button8.Location = new Point(751, 141);
            button8.Name = "button8";
            button8.Size = new Size(160, 97);
            button8.TabIndex = 20;
            button8.Text = "Calculer rendement";
            button8.TextImageRelation = TextImageRelation.ImageBeforeText;
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click_2;
            // 
            // NoteSet
            // 
            NoteSet.BorderStyle = BorderStyle.FixedSingle;
            NoteSet.Location = new Point(345, 250);
            NoteSet.Name = "NoteSet";
            NoteSet.Size = new Size(254, 31);
            NoteSet.TabIndex = 19;
            // 
            // NomSer
            // 
            NomSer.BorderStyle = BorderStyle.FixedSingle;
            NomSer.Enabled = false;
            NomSer.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NomSer.Location = new Point(345, 90);
            NomSer.Margin = new Padding(6, 3, 3, 3);
            NomSer.Name = "NomSer";
            NomSer.Size = new Size(254, 35);
            NomSer.TabIndex = 17;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(41, 169);
            label11.Name = "label11";
            label11.Size = new Size(241, 25);
            label11.TabIndex = 16;
            label11.Text = "Note Calculée depuis Shifts : ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(41, 256);
            label12.Name = "label12";
            label12.Size = new Size(138, 25);
            label12.TabIndex = 15;
            label12.Text = "Note Attribuée :";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(41, 90);
            label13.Name = "label13";
            label13.Size = new Size(125, 25);
            label13.TabIndex = 14;
            label13.Text = "Nom Serveur :";
            // 
            // Rendement
            // 
            Rendement.BackColor = Color.Black;
            Rendement.ForeColor = SystemColors.ButtonHighlight;
            Rendement.Location = new Point(380, 526);
            Rendement.Name = "Rendement";
            Rendement.Size = new Size(262, 60);
            Rendement.TabIndex = 7;
            Rendement.Text = "Rendement";
            Rendement.TextImageRelation = TextImageRelation.ImageBeforeText;
            Rendement.UseVisualStyleBackColor = false;
            Rendement.Click += Rendement_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.WhiteSmoke;
            panel6.Controls.Add(label4);
            panel6.Controls.Add(button7);
            panel6.ForeColor = SystemColors.ActiveCaptionText;
            panel6.Location = new Point(13, 8);
            panel6.Name = "panel6";
            panel6.Size = new Size(958, 59);
            panel6.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Stencil", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(93, 13);
            label4.Name = "label4";
            label4.Size = new Size(320, 33);
            label4.TabIndex = 4;
            label4.Text = "Visualiser Serveurs";
            // 
            // button7
            // 
            button7.BackColor = Color.Black;
            button7.ForeColor = SystemColors.ButtonHighlight;
            button7.Location = new Point(700, 0);
            button7.Name = "button7";
            button7.Size = new Size(262, 61);
            button7.TabIndex = 4;
            button7.Text = "Ajouter serveur";
            button7.TextImageRelation = TextImageRelation.ImageBeforeText;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // Supprimer
            // 
            Supprimer.BackColor = Color.Black;
            Supprimer.ForeColor = SystemColors.ButtonHighlight;
            Supprimer.Location = new Point(665, 526);
            Supprimer.Name = "Supprimer";
            Supprimer.Size = new Size(262, 60);
            Supprimer.TabIndex = 5;
            Supprimer.Text = "Supprimer";
            Supprimer.TextImageRelation = TextImageRelation.ImageBeforeText;
            Supprimer.UseVisualStyleBackColor = false;
            Supprimer.Click += button8_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader1, columnHeader2, columnHeader3 });
            listView1.FullRowSelect = true;
            listView1.HideSelection = true;
            listView1.Location = new Point(69, 85);
            listView1.Name = "listView1";
            listView1.Size = new Size(858, 425);
            listView1.TabIndex = 0;
            listView1.TileSize = new Size(328, 100);
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "ID";
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Nom";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Login";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Mot De Passe";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 200;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(242, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(995, 182);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint_2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.WhiteSmoke;
            label2.Font = new Font("Stencil", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ImageAlign = ContentAlignment.MiddleRight;
            label2.Location = new Point(293, 77);
            label2.Name = "label2";
            label2.Size = new Size(352, 52);
            label2.TabIndex = 5;
            label2.Text = "Espace Admin ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Location = new Point(-17, 1);
            panel4.Name = "panel4";
            panel4.Size = new Size(1012, 22);
            panel4.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(64, 0, 64);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(pictureBox3);
            panel3.Location = new Point(832, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(132, 164);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.logo1;
            pictureBox1.Location = new Point(14, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(103, 106);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.cornerRight;
            pictureBox2.Location = new Point(64, 42);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(248, 123);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.cornerLeft;
            pictureBox3.Location = new Point(-51, 8);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(195, 198);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Black;
            button6.ForeColor = SystemColors.ButtonHighlight;
            button6.Location = new Point(833, 35);
            button6.Name = "button6";
            button6.Size = new Size(147, 67);
            button6.TabIndex = 14;
            button6.Text = "Visualiser serveurs";
            button6.TextImageRelation = TextImageRelation.ImageBeforeText;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.WhiteSmoke;
            panel5.Controls.Add(label1);
            panel5.ForeColor = SystemColors.ActiveCaptionText;
            panel5.Location = new Point(41, 110);
            panel5.Name = "panel5";
            panel5.Size = new Size(342, 59);
            panel5.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 12);
            label1.Name = "label1";
            label1.Size = new Size(313, 33);
            label1.TabIndex = 4;
            label1.Text = "Ajouter Un Serveur";
            label1.Click += label1_Click;
            // 
            // AjouterServeurPanel
            // 
            AjouterServeurPanel.BorderStyle = BorderStyle.FixedSingle;
            AjouterServeurPanel.Controls.Add(panel5);
            AjouterServeurPanel.Controls.Add(button6);
            AjouterServeurPanel.Controls.Add(panel7);
            AjouterServeurPanel.Location = new Point(225, 188);
            AjouterServeurPanel.Name = "AjouterServeurPanel";
            AjouterServeurPanel.Size = new Size(1038, 624);
            AjouterServeurPanel.TabIndex = 6;
            // 
            // panel7
            // 
            panel7.Controls.Add(AjouterServer);
            panel7.Controls.Add(Mdp);
            panel7.Controls.Add(Login);
            panel7.Controls.Add(Nom);
            panel7.Controls.Add(label6);
            panel7.Controls.Add(label5);
            panel7.Controls.Add(label3);
            panel7.Location = new Point(34, 158);
            panel7.Name = "panel7";
            panel7.Size = new Size(852, 400);
            panel7.TabIndex = 24;
            // 
            // AjouterServer
            // 
            AjouterServer.BackColor = Color.Black;
            AjouterServer.ForeColor = SystemColors.ButtonHighlight;
            AjouterServer.Location = new Point(631, 323);
            AjouterServer.Name = "AjouterServer";
            AjouterServer.Size = new Size(183, 54);
            AjouterServer.TabIndex = 27;
            AjouterServer.Text = "Ajouter";
            AjouterServer.TextImageRelation = TextImageRelation.ImageBeforeText;
            AjouterServer.UseVisualStyleBackColor = false;
            AjouterServer.Click += AjouterServer_Click_1;
            // 
            // Mdp
            // 
            Mdp.BorderStyle = BorderStyle.FixedSingle;
            Mdp.Location = new Point(275, 217);
            Mdp.Name = "Mdp";
            Mdp.Size = new Size(326, 31);
            Mdp.TabIndex = 26;
            // 
            // Login
            // 
            Login.BorderStyle = BorderStyle.FixedSingle;
            Login.Location = new Point(275, 136);
            Login.Name = "Login";
            Login.Size = new Size(326, 31);
            Login.TabIndex = 25;
            // 
            // Nom
            // 
            Nom.BorderStyle = BorderStyle.FixedSingle;
            Nom.Location = new Point(275, 51);
            Nom.Name = "Nom";
            Nom.Size = new Size(326, 31);
            Nom.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 136);
            label6.Name = "label6";
            label6.Size = new Size(70, 25);
            label6.TabIndex = 23;
            label6.Text = "Login : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 217);
            label5.Name = "label5";
            label5.Size = new Size(134, 25);
            label5.TabIndex = 22;
            label5.Text = "Mot de passe : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 51);
            label3.Name = "label3";
            label3.Size = new Size(134, 25);
            label3.TabIndex = 21;
            label3.Text = "Nom Complet :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1239, 797);
            Controls.Add(VisualiserServer);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(AjouterServeurPanel);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            VisualiserServer.ResumeLayout(false);
            RendementPanel.ResumeLayout(false);
            RendementPanel.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            AjouterServeurPanel.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private Panel panel3;
        private Button button1;
        private Button PaltsButton;
        private Button button2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private Button ServeursButton;
        private Button button6;
        private Panel panel5;
        private Label label1;
        private Panel VisualiserServer;
        private Button Supprimer;
        private Button button7;
        private ListView listView1;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Panel AjouterServeurPanel;
        private Panel panel7;
        public Button AjouterServer;
        public TextBox Mdp;
        public TextBox Login;
        public TextBox Nom;
        public Label label6;
        public Label label5;
        public Label label3;
        private Panel panel6;
        private Label label4;
        private Button Rendement;
        private Panel RendementPanel;
        private Panel panel9;
        public Label label14;
        public TextBox RendementF;
        public Button button5;
        public TextBox NoteShift;
        private Panel panel10;
        private Label label10;
        public Button button8;
        public TextBox NoteSet;
        public TextBox NomSer;
        public Label label11;
        public Label label12;
        public Label label13;
        private Button chefsButton;
        private Button CommandesButton;
    }
}
