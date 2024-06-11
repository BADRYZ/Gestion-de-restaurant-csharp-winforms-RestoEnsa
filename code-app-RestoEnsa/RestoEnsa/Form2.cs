using Google.Protobuf;
using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static RestoEnsa.Form2;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RestoEnsa
{

    public partial class Form2 : Form
    {
        string connectionString = "Server=localhost; Database=restoensa; User ID=root; Password=;";
        List<Panel> panelList = new List<Panel>();
        int id_catego = 0;
        public Form2()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            LoadCategories();



        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelList[1].BringToFront();

            Form1 Serveur = new Form1();
            Serveur.Show();
            this.Hide(); // Hides the current form
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelList[0].BringToFront();

        }
        public class ComboBoxItem
        {
            public string Name { get; set; }
            public int Id { get; set; }

            public ComboBoxItem(int id, string name)
            {
                Id = id;
                Name = name;
            }

            public override string ToString()
            {
                return Name; // This is what will be displayed in the ComboBox
            }
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            panelList.Add(AjouterPlat);
            panelList.Add(AjouterCategori);
            panelList.Add(Categories);

            panelList[0].BringToFront();




            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                string selectQuery = "SELECT id, nom FROM categorie";
                connection.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = reader.GetInt32("id");
                    string name = reader.GetString("nom");
                    comboBox1.Items.Add(new ComboBoxItem(id, name));
                }
                reader.Close(); // Always close the reader when done
                connection.Close(); // Close the connection when done
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void button6_Click_1(object sender, EventArgs e)
        {

            panelList[1].BringToFront();



        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void button5_Click_1(object sender, EventArgs e)
        {

            int selectedCategoryId = 0;
            if (comboBox1.SelectedItem is ComboBoxItem selectedItem)
            {
                selectedCategoryId = selectedItem.Id;
                //MessageBox.Show($"Selected Category ID: {selectedCategoryId}");
            }
            String Nom = NomPlat.Text;
            String prix = Prix.Text;
            //should add some data controle here

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {


                try
                {
                    string insertQuery = "INSERT INTO plat (id_categorie, nom, prix) VALUES (@id, @nom, @prix)";

                    connection.Open();
                    using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@id", selectedCategoryId);
                        insertCommand.Parameters.AddWithValue("@nom", Nom);
                        insertCommand.Parameters.AddWithValue("@prix", Double.Parse(prix));

                        int result = insertCommand.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Insertion réussie");
                            NomPlat.Text = "";
                            NomPlat.Text = "";
                            comboBox1.SelectedItem = "";
                        }
                        else
                        {
                            MessageBox.Show("Échec de l'insertion");
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


        private void button10_Click(object sender, EventArgs e)
        {




        }

        private void LoadCategories()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string selectQuery = "SELECT id, nom, description, image FROM categorie";
                    using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                    {
                        MySqlDataReader reader = command.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        dataGridView1.Rows.Clear();
                        if (dt.Rows.Count > 0)
                        {
                            foreach (DataRow row in dt.Rows)
                            {
                                string id = row["id"].ToString();
                                string name = row["nom"].ToString();
                                string description = row["description"].ToString();
                                byte[] imgBytes = row["image"] as byte[];

                                Image image = null;
                                if (imgBytes != null && imgBytes.Length > 0)
                                {
                                    // Resize the image to fit the cell
                                    image = ByteArrayToThumbnailImage(imgBytes, 250, 200);
                                }
                                else
                                {
                                    image = Properties.Resources.logo1;
                                }
                                dataGridView1.Rows.Add(id, name, description, image);
                                dataGridView1.RowTemplate.Height = 205;

                            }
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private Image ByteArrayToThumbnailImage(byte[] byteArray, int width, int height)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                Image originalImage = Image.FromStream(ms);
                Image thumbnailImage = originalImage.GetThumbnailImage(width, height, () => false, IntPtr.Zero);
                return thumbnailImage;
            }
        }

        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }





        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }






        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addImage_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBoxCategorie.Image = new Bitmap(ofd.FileName);


            }
        }




        private void Categories_Paint(object sender, PaintEventArgs e)
        {

        }


        private void VIEWBUTTON_Click_3(object sender, EventArgs e)
        {
            LoadCategories();
            panelList[2].BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void AjouterPlat_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Suppcat_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Get the ID of the selected row
                int categoryId = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                // Confirm deletion with the user
                DialogResult result = MessageBox.Show("Are you sure you want to delete this category?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Perform deletion from the database
                    DeleteCategory(categoryId);
                }
            }
            else
            {
                MessageBox.Show("Please select a category to delete.", "No Category Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DeleteCategory(int categoryId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Create SQL query to delete the category
                    string deleteQuery = "DELETE FROM categorie WHERE id = @id";

                    // Execute the query
                    using (MySqlCommand command = new MySqlCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@id", categoryId);
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Category deleted successfully.", "Deletion Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Refresh the DataGridView to reflect the changes
                            LoadCategories();
                        }
                        else
                        {
                            MessageBox.Show("Category deletion failed.", "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void modifycat_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Get the ID of the selected row
                id_catego = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string selectQuery = "SELECT nom, description, image FROM categorie where id = @categoryId";
                        using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                        {
                            command.Parameters.AddWithValue("@categoryId", id_catego);
                            MySqlDataReader reader = command.ExecuteReader();

                            if (reader.Read())
                            {
                                // Fill text boxes
                                CatModitext.Text = reader.GetString("nom");
                                DescModiftxt.Text = reader.GetString("description");

                                // Fill picture box
                                byte[] imgBytes = reader["image"] as byte[];
                                if (imgBytes != null && imgBytes.Length > 0)
                                {
                                    pictureBox5.Image = ByteArrayToThumbnailImage(imgBytes, 250, 200);
                                }
                                else
                                {
                                    pictureBox5.Image = Properties.Resources.logo1; // Clear picture box if image is null
                                }
                            }
                            else
                            {
                                MessageBox.Show("Aucune catégorie trouvée avec l'ID spécifié.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Une erreur est survenue : {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une catégorie à modifier.");
            }

            // Bring the modification panel to the front
            modifierCategori.BringToFront();
        }

        private void addImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBoxCategorie.Image = new Bitmap(ofd.FileName);


            }
        }

        private void AjouterCategori_Paint(object sender, PaintEventArgs e)
        {

        }
        //POUR AJOUTER CATEGORIE
        private void button10_Click_1(object sender, EventArgs e)
        {
        }

        private void button10_Click_2(object sender, EventArgs e)
        {

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {

                    connection.Open();

                    // SQL query to insert the image into the database
                    string insertQuery = "INSERT INTO categorie (nom, description, image) VALUES (@nom, @description, @image)";

                    using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                    {
                        byte[] imgBytes = ImageToByteArray(pictureBoxCategorie.Image);

                        // Add parameters to avoid SQL injection
                        command.Parameters.AddWithValue("@nom", Nomcate.Text);
                        command.Parameters.AddWithValue("@description", description.Text);
                        command.Parameters.AddWithValue("@image", imgBytes);

                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Insertion réussie");
                        }
                        else
                        {
                            MessageBox.Show("Échec de l'insertion");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }

            }
        }

        private void button10_Click_3(object sender, EventArgs e)
        {

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {

                    connection.Open();

                    // SQL query to insert the image into the database
                    string insertQuery = "INSERT INTO categorie (nom, description, image) VALUES (@nom, @description, @image)";

                    using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                    {
                        byte[] imgBytes = ImageToByteArray(pictureBoxCategorie.Image);

                        // Add parameters to avoid SQL injection
                        command.Parameters.AddWithValue("@nom", Nomcate.Text);
                        command.Parameters.AddWithValue("@description", description.Text);
                        command.Parameters.AddWithValue("@image", imgBytes);

                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Insertion réussie");
                        }
                        else
                        {
                            MessageBox.Show("Échec de l'insertion");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }

            }
        }

        private void Ajoutermodif_Click(object sender, EventArgs e)
        {

        }

        private void Ajoutermodif_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox5.Image = new Bitmap(ofd.FileName);


            }
        }

        private void modifier_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    string updateQuery = "UPDATE categorie SET nom= @nom, description= @description, image= @image WHERE id= @catego_id";

                    connection.Open();
                    using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection))
                    {
                        byte[] imgBytes = ImageToByteArray(pictureBox5.Image);

                        updateCommand.Parameters.AddWithValue("@catego_id", id_catego); // Ensure id_catego is set correctly
                        updateCommand.Parameters.AddWithValue("@nom", CatModitext.Text); // Use CatModitext for the name
                        updateCommand.Parameters.AddWithValue("@description", DescModiftxt.Text); // Use DescModiftxt for the description
                        updateCommand.Parameters.AddWithValue("@image", imgBytes);

                        int result = updateCommand.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Modification réussie");
                            CatModitext.Text = ""; // Clear the name text box
                            DescModiftxt.Text = ""; // Clear the description text box
                            //pictureBox5.Image = null; // Clear the picture box
                            panelList[2].BringToFront(); // Bring the appropriate panel to the front
                        }
                        else
                        {
                            MessageBox.Show("Échec de la modification");
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

        private void AjouterCategorieButton_Click(object sender, EventArgs e)
        {
            panelList[1].BringToFront();

        }

        
        

        private void AjouterPlatButton_Click(object sender, EventArgs e)
        {
            panelList[0].BringToFront();

        }

       

      
    }

}











