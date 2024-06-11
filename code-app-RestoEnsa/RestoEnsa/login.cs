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

namespace RestoEnsa
{

    public partial class login : Form
    {
        private MySqlConnection connection;
        string connectionString = "Server=localhost; Database=restoensa; User ID=root; Password=;";
        public int Role_user;

        public login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public login(int role)
        {
            connection = new MySqlConnection(connectionString);

            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            if (role == 1)
            {
                Role.Text = "Admin";
                Role_user = 1;


            }
            else
            {
                Role.Text = "Serveur";
                Role_user = 2;

            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Welcome welcome = new Welcome();
            this.Hide();
            welcome.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Serveur serveur = new Serveur();
            serveur.Show();


        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            // Get username and password from textboxes
            string username = usernametextBox.Text;
            string password = passwordBox.Text; // Ensure you are getting the password from the correct textbox

            // Connection string (update with your database details)

            // Define the SQL connection
            using (connection)
            {
                // Determine the query based on Role_user
                string query = Role_user == 1 ?
                    "SELECT * FROM admin WHERE login = @Username AND mdp = @Password" :
                    "SELECT * FROM serveur WHERE login = @Username AND mdp = @Password";

                // Create the SQL command
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Add parameters to prevent SQL injection
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    try
                    {
                        // Open the connection
                        connection.Open();

                        // Execute the command and check if any rows are returned
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows) // Check if any rows are returned
                            {
                                // Successful login
                                if (Role_user == 1)
                                {
                                    Form1 admin = new Form1();
                                    admin.Show();
                                }
                                else
                                {
                                    Serveur serveur = new Serveur();
                                    serveur.Show();
                                }
                            }
                            else
                            {
                                // Show error message if credentials are invalid
                                MessageBox.Show("Invalid username or password.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle any errors that occur during the database operation
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        }


        private void usernametextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
