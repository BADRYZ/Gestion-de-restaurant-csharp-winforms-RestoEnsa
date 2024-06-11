//library mysql ajouté dans reference


using MySql.Data.MySqlClient;
namespace RestoEnsa
{
    public partial class Form1 : Form
    {
        int id_server = 0;
        string connectionString = "Server=localhost; Database=restoensa; User ID=root; Password=;";

        public Form1()
        {

            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            fetch_data();
            RendementPanel.Hide();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome w = new Welcome();
            w.ShowDialog();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {


        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            fetch_data();
            VisualiserServer.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {





        }

        private void button7_Click(object sender, EventArgs e)
        {
            AjouterServeurPanel.Show();
            VisualiserServer.Hide();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            fetch_data();
            VisualiserServer.Show();
        }

        private void fetch_data()
        {


            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT id,nom, login, mdp FROM serveur";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            listView1.Items.Clear();

                            if (listView1.Columns.Count == 0)
                            {
                                listView1.Columns.Add("Id", 100);

                                listView1.Columns.Add("Nom", 100);
                                listView1.Columns.Add("Login", 100);
                                listView1.Columns.Add("Mot de passe", 100);
                            }

                            while (reader.Read())
                            {

                                ListViewItem item = new ListViewItem(reader["id"].ToString());
                                item.SubItems.Add(reader["nom"].ToString());
                                item.SubItems.Add(reader["login"].ToString());
                                item.SubItems.Add(reader["mdp"].ToString());
                                listView1.Items.Add(item);
                            }
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Erreur de connexion à la base de données : {ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Une erreur s'est produite : {ex.Message}");
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int id = 0;
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                id = int.Parse(selectedItem.Text);

            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "DELETE FROM serveur WHERE id = @id";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User deleted successfully.");
                            fetch_data();
                        }
                        else
                        {
                            MessageBox.Show("User not found.");
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Erreur de connexion à la base de données : {ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Une erreur s'est produite : {ex.Message}");
                }

            }
        }



        private void VisualiserServer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AjouterServer_Click(object sender, EventArgs e)
        {

        }

        private void AjouterServer_Click_1(object sender, EventArgs e)
        {
            // Récupération des valeurs des champs de texte
            string mdp = Mdp.Text;
            string login = Login.Text;
            string nom = Nom.Text;

            if (string.IsNullOrWhiteSpace(mdp) || string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(nom))
            {
                MessageBox.Show("Tous les champs doivent être remplis.");
                return;
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();



                    string checkQuery = "SELECT COUNT(*) FROM serveur WHERE login = @login";

                    using (MySqlCommand checkCommand = new MySqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@login", login);

                        int loginCount = Convert.ToInt32(checkCommand.ExecuteScalar());

                        if (loginCount > 0)
                        {
                            MessageBox.Show("Le login existe déjà. Veuillez en choisir un autre.");
                        }
                        else
                        {
                            string insertQuery = "INSERT INTO serveur (mdp, login, nom) VALUES (@mdp, @login, @nom)";

                            using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection))
                            {
                                insertCommand.Parameters.AddWithValue("@mdp", mdp);
                                insertCommand.Parameters.AddWithValue("@login", login);
                                insertCommand.Parameters.AddWithValue("@nom", nom);

                                int result = insertCommand.ExecuteNonQuery();

                                if (result > 0)
                                {
                                    MessageBox.Show("Insertion réussie");
                                    Mdp.Text = "";
                                    Login.Text = "";
                                    Nom.Text = "";
                                }
                                else
                                {
                                    MessageBox.Show("Échec de l'insertion");
                                }
                            }
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Erreur de connexion à la base de données : {ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Une erreur s'est produite : {ex.Message}");
                }
            }

        }

        private void Rendement_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                this.id_server = int.Parse(selectedItem.Text);
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // Fetching server's name
                        string nameQuery = "SELECT nom FROM serveur WHERE id = @id";

                        using (MySqlCommand nameCommand = new MySqlCommand(nameQuery, connection))
                        {
                            nameCommand.Parameters.AddWithValue("@id", id_server);
                            object nameResult = nameCommand.ExecuteScalar();

                            if (nameResult != null)
                            {
                                string name = nameResult.ToString();
                                NomSer.Text = name;
                            }
                            else
                            {
                                MessageBox.Show("Server with the specified ID not found.");
                                return; // Exit method if server not found
                            }
                        }

                        // Fetching shifts and calculating rendement
                        string shiftQuery = "SELECT id_shift FROM shift_serveur WHERE id_serveur = @id";

                        using (MySqlCommand shiftCommand = new MySqlCommand(shiftQuery, connection))
                        {
                            shiftCommand.Parameters.AddWithValue("@id", id_server);
                            using (MySqlDataReader reader = shiftCommand.ExecuteReader())
                            {
                                int noteSum = 0;
                                while (reader.Read())
                                {
                                    int idShift = reader.GetInt32("id_shift");
                                    // Calculate note based on id_shift
                                    int note = (idShift % 2 == 0) ? 2 : 1;
                                    noteSum += note;
                                }

                                // Display the sum of notes as rendement
                                NoteShift.Text = noteSum.ToString();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}");
                    }
                    finally
                    {
                        connection.Close(); // Close the connection after usage
                    }
                }

                RendementPanel.Show();

            }
            else
            {
                MessageBox.Show("Choisir Un Serveur pour calculer le rendement.");
            }
        }



        private void button8_Click_2(object sender, EventArgs e)
        {
            Double NoteS = int.Parse(NoteShift.Text);
            Double NoteAttr = int.Parse(NoteSet.Text);
            Double Calculated = NoteS * 0.75 + NoteAttr * 0.25;

            RendementF.Text = Calculated.ToString();

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            double rendement_final = double.Parse(RendementF.Text);

            // Check if a server is selected
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                int server_id = int.Parse(selectedItem.Text);

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // Update the serveur table with rendement_final for the selected server
                        string updateQuery = "UPDATE serveur SET rendement = @rendement_final WHERE id = @server_id";

                        using (MySqlCommand command = new MySqlCommand(updateQuery, connection))
                        {
                            command.Parameters.AddWithValue("@rendement_final", rendement_final);
                            command.Parameters.AddWithValue("@server_id", server_id);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Rendement final updated successfully.");
                            }
                            else
                            {
                                MessageBox.Show("No server found with the specified ID.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}");
                    }
                    finally
                    {
                        connection.Close(); // Close the connection after usage
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a server to update its rendement final.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 Plat = new Form2();
            Plat.Show();
            this.Hide(); // Hides the current form
        }

        private void RendementPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Commandes_Click(object sender, EventArgs e)
        {
            FormCommandes commandes = new FormCommandes();

            commandes.Show();
            this.Hide();
        }

        private void CommandesButton_Click(object sender, EventArgs e)
        {
            FormCommandes commandes = new FormCommandes();
            commandes.Show();
            this.Hide();
        }

        private void chefsButton_Click(object sender, EventArgs e)
        {
            ChefsForm chefsForm = new ChefsForm();
            chefsForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                calendrier calendar = new calendrier();
                calendar.Show();
                this.Hide();
           
        }
    }
}

