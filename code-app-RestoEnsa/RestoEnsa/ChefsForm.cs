using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using RestoEnsa;

namespace RestoEnsa
{
    public partial class ChefsForm : Form
    {
        private MySqlConnection connection;
        string connectionString = "Server=localhost; Database=restoensa; User ID=root; Password=;";
        public ChefsForm()
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

            // Fill the dataGridView1 with data from the chef table
            FillDataGridView();
            ChefsForm_Load();

            // Attach event handlers
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
            saveButton.Click += SaveButton_Click;
            // cancelButton.Click += DeleteButton_Click;
        }

        // Method to fill the dataGridView1 with data from the chef table
        private void FillDataGridView()
        {
            try
            {
                string query = "SELECT id, nom FROM chef";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                textBoxNumeroChef.Text = selectedRow.Cells["id"].Value.ToString();
                textBoxNomChef.Text = selectedRow.Cells["nom"].Value.ToString();
            }
        }

        private void ChefsForm_Load()
        {
            // Fetch the maximum id from the chef table and increment it by 1
            int nextId = GetNextChefId();
            textBoxNumeroChef.Text = nextId.ToString();
        }

        private int GetNextChefId()
        {
            int nextId = 1; // Default value if no records exist
            try
            {
                string query = "SELECT MAX(id) FROM chef";
                MySqlCommand command = new MySqlCommand(query, connection);
                object result = command.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    nextId = Convert.ToInt32(result) + 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching next Chef ID: " + ex.Message);
            }
            return nextId;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            int chefId = Convert.ToInt32(textBoxNumeroChef.Text);
            string chefName = textBoxNomChef.Text.Trim();

            // Check if the chef with provided ID already exists
            bool chefExists = CheckChefExists(chefId);

            if (chefExists)
            {
                // Update the existing chef
                UpdateChef(chefId, chefName);
            }
            else
            {
                // Insert a new chef
                InsertChef(chefId, chefName);
            }
            FillDataGridView();
            clearInputs();
        }

        private bool CheckChefExists(int chefId)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM chef WHERE id = @chefId";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@chefId", chefId);
                int count = Convert.ToInt32(command.ExecuteScalar());
                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking Chef existence: " + ex.Message);
                return false;
            }
        }

        private void UpdateChef(int chefId, string chefName)
        {
            try
            {
                string query = "UPDATE chef SET nom = @chefName WHERE id = @chefId";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@chefId", chefId);
                command.Parameters.AddWithValue("@chefName", chefName);
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Chef updated successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating Chef: " + ex.Message);
            }
        }

        private void InsertChef(int chefId, string chefName)
        {
            try
            {
                string query = "INSERT INTO chef (id, nom) VALUES (@chefId, @chefName)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@chefId", chefId);
                command.Parameters.AddWithValue("@chefName", chefName);
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("New Chef inserted successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting new Chef: " + ex.Message);
            }
        }

        // Event handler for deleteButton click
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "DELETE FROM chef WHERE id = @id";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", textBoxNumeroChef.Text);
                command.ExecuteNonQuery();

                MessageBox.Show("Chef deleted successfully.");
                FillDataGridView(); // Refresh dataGridView1
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting chef: " + ex.Message);
            }
            clearInputs();
        }

        // Dispose resources when form is closed
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            connection.Close();
            connection.Dispose();
        }

        private void button1_Clicked(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            // this.Close(); // Close the current form
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            clearInputs();
        }

        private void clearInputs()
        {
            ChefsForm_Load();
            textBoxNomChef.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
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

        private void CalendrierButton_Click(object sender, EventArgs e)
        {
            calendrier calendar = new calendrier();
            calendar.Show();
            this.Hide();

        }

        private void CommandesButton_Click(object sender, EventArgs e)
        {
            FormCommandes commandes = new FormCommandes();
            commandes.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
