using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RestoEnsa
{
    public partial class FormCommandes : Form
    {

        private MySqlConnection connection;
        string connectionString = "Server=localhost; Database=restoensa; User ID=root; Password=;";


        public FormCommandes()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            // Connect to MySQL database
            connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            dataGridView1.SelectionChanged += dataGridView_SelectionChanged;

            LoadData();
            LoadChefs();

            saveButton.Click += saveButton_Click;


        }

        public void LoadData()
        {
            // dataGridView1.
            // Query to fetch data from commande table with chef's name
            string query = "SELECT c.id AS 'Num Commande', c.id_table AS 'Num Table', c.facture AS 'Facture', ch.nom AS 'Chef' FROM commande c LEFT JOIN chef ch ON c.id_chef = ch.id ORDER BY c.id DESC";

            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dataTable = new DataTable();

            try
            {
                adapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    // Bind data to DataGridView
                    dataGridView1.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("No data found in the DataTable.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }



        private void LoadChefs()
        {
            try
            {
                string query = "SELECT id, nom FROM chef";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int chefId = reader.GetInt32("id");
                    string chefName = reader.GetString("nom");
                    comboBoxChef.Items.Add(new ChefItem(chefId, chefName));
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading chefs: " + ex.Message);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // Check if a row is selected in the DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected commande row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Get the selected chef from the ComboBox
                ChefItem selectedChef = comboBoxChef.SelectedItem as ChefItem;
                if (selectedChef != null)
                {
                    int chefId = selectedChef.Id;

                    // Update the id_chef of the selected commande row
                    int commandeId = Convert.ToInt32(selectedRow.Cells["Num Commande"].Value);
                    UpdateCommandeChefId(commandeId, chefId);
                }
                else
                {
                    MessageBox.Show("Please select a chef from the ComboBox.");
                }
            }
            else
            {
                MessageBox.Show("Please select a row in the DataGridView.");
            }
        }

        private void UpdateCommandeChefId(int commandeId, int chefId)
        {
            try
            {
                string query = "UPDATE commande SET id_chef = @chefId WHERE id = @commandeId";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@chefId", chefId);
                command.Parameters.AddWithValue("@commandeId", commandeId);
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Chef ID updated successfully.");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Failed to update Chef ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating Chef ID: " + ex.Message);
            }
        }


        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int commandeId = Convert.ToInt32(selectedRow.Cells["Num Commande"].Value);
                textBoxNumeroCommande.Text = commandeId.ToString();
                textBoxNumeroTable.Text = selectedRow.Cells["Num Table"].Value.ToString();
                textBoxFacture.Text = selectedRow.Cells["Facture"].Value.ToString();

                // Populate ComboBox based on selected chef name
                // string chefName = selectedRow.Cells["Chef"].Value.ToString();
                // comboBoxChef.SelectedItem = comboBoxChef.Items.Cast<ChefItem>().FirstOrDefault(item => item.Name == chefName);

                // Populate textBoxPlats
                PopulatePlatsTextBox(commandeId);
            }
        }


        private void PopulatePlatsTextBox(int commandeId)
        {
            try
            {
                // Initialize plats string
                string plats = "";

                // Query to fetch plats related to the selected commande row
                string query = "SELECT plat.nom " +
                               "FROM plat " +
                               "JOIN commande_plat ON plat.id = commande_plat.id_plat " +
                               "WHERE commande_plat.id_commande = @commandeId";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@commandeId", commandeId);
                MySqlDataReader reader = command.ExecuteReader();

                // Concatenate plats names
                while (reader.Read())
                {
                    if (plats != "")
                    {
                        plats += ", ";
                    }
                    plats += reader.GetString("nom");
                }

                reader.Close();

                // Set the plats text in the textBoxPlats
                textBoxPlats.Text = plats;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching plats: " + ex.Message);
            }
        }



        // Dispose resources when form is closed
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            connection.Close();
            connection.Dispose();
        }

        private void chefsButton_Clicked(object sender, EventArgs e)
        {
            ChefsForm chefsForm = new ChefsForm();
            chefsForm.Show();
            // this.Close();
        }

        private void FormCommandes_Load(object sender, EventArgs e)
        {

        }

        private void textBoxPlats_TextChanged(object sender, EventArgs e)
        {

        }

        private void ServeursButton_Click(object sender, EventArgs e)
        {
            Form1 Serveurs = new Form1();
            Serveurs.Show();
            this.Hide();

        }

        private void PlatsButton_Click(object sender, EventArgs e)
        {
            Form2 Plats = new Form2();
            Plats.Show();
            this.Hide();
        }

        private void CommandesButton_Click(object sender, EventArgs e)
        {

        }

        private void chefsButton_Click(object sender, EventArgs e)
        {
            ChefsForm chefsForm = new ChefsForm();
            chefsForm.Show();
            this.Hide();
        }

        private void textBoxNumeroCommande_TextChanged(object sender, EventArgs e)
        {

        }

        private void CalendrierButton_Click(object sender, EventArgs e)
        {

            calendrier calendar = new calendrier();
            calendar.Show();
            this.Hide();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

    public class ChefItem
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ChefItem(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return Name; // Display the name in the ComboBox
        }
    }
}
