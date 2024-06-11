using MaterialSkin.Controls;
using MySql.Data.MySqlClient;
using RestoEnsa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoEnsa
{
    public partial class Menu : Form
    {
        static DbManager db = new DbManager();
        static MySqlConnection con = db.getConnection();
        static double total = 0.0;
        static string id_table;
        public Menu(string id)
        {
            id_table = id;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            // ADD ITEMS TO CATEGORIE
            string query1 = "SELECT id, nom FROM categorie";

            try
            {
                con.Open();

                using (MySqlCommand command = new MySqlCommand(query1, con))
                {

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {

                        DataTable categoriesTable = new DataTable();

                        adapter.Fill(categoriesTable);


                        Categorie.Items.Clear();


                        foreach (DataRow row in categoriesTable.Rows)
                        {

                            Categorie.Items.Add(row["nom"]);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                Console.WriteLine("Error: " + ex.Message);
            }


            Plat.Items.Clear();
            Plat.SelectedItem = null;







        }

        private void Categorie_SelectedIndexChanged(object sender, EventArgs e)
        {

            // ADD ITEMS TO PLATS
            Plat.Items.Clear();
            Plat.SelectedItem = null;
            Plat.Text = "";


            if (Categorie.SelectedItem != null)
            {
                string selectedCategory = Categorie.SelectedItem.ToString();
                //MessageBox.Show(selectedCategory);
                string query2 = "SELECT plat.nom FROM plat, categorie where plat.id_categorie = categorie.id and categorie.nom = @selectedCategory  ";

                try
                {

                    using (MySqlCommand command = new MySqlCommand(query2, con))
                    {

                        command.Parameters.AddWithValue("@SelectedCategory", selectedCategory);
                        //MessageBox.Show("inside the comm");

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            //MessageBox.Show("inside the adapter");
                            DataTable platsTable = new DataTable();

                            adapter.Fill(platsTable);


                            Plat.Items.Clear();


                            foreach (DataRow row in platsTable.Rows)
                            {
                                //MessageBox.Show(row["nom"].ToString());
                                Plat.Items.Add(row["nom"]);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine("Error: " + ex.Message);
                }
            }

        }

        private void Plat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {

            string SelectedPlat = (string)Plat.SelectedItem;
            ListViewItem item = new ListViewItem();
            item.Text = SelectedPlat;
            


            string query1 = "SELECT prix FROM plat WHERE plat.nom = @SelectedPlat";

            try
            {

                using (MySqlCommand command = new MySqlCommand(query1, con))
                {
                    command.Parameters.AddWithValue("@SelectedPlat", SelectedPlat);

                    
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        string prix = result.ToString();
                        

                        item.SubItems.Add(prix.ToString());
                       
                    }
                }
                item.SubItems.Add(qte.Value.ToString());
                listCommande.Items.Add(item);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                Console.WriteLine("Error: " + ex.Message);
            }

        }


        private void Save_Click(object sender, EventArgs e)
        {
            

            string queryInsertCommande = "INSERT INTO `commande`(`id_table`, `facture`, `id_chef`, `reglee`) VALUES (@id_table, @total, NULL, '0'); SELECT LAST_INSERT_ID();";
            string queryInsertCommandePlat = "INSERT INTO `commande_plat`(`id_plat`, `id_commande`) VALUES (@idPlat, @idCommande)";

            try
            {

                using (MySqlCommand command = new MySqlCommand(queryInsertCommande, con))
                {
                    command.Parameters.AddWithValue("@total", total);
                    command.Parameters.AddWithValue("@id_table", id_table);

                    int commandeId = Convert.ToInt32(command.ExecuteScalar());

                    if (commandeId != 0)
                    {
                        MessageBox.Show("Commande saved successfully with ID: " + commandeId);

                        // Insert into the commande_plat table for each plat in the listCommande
                        for (int i = 0; i < listCommande.Items.Count; i += 2)
                        {
                            
                            string platName = listCommande.Items[i].Text;
                            //MessageBox.Show(platName);
                            string queryGetPlatId = "SELECT id FROM plat WHERE nom = @platName";

                            using (MySqlCommand cmdGetPlatId = new MySqlCommand(queryGetPlatId, con))
                            {
                                cmdGetPlatId.Parameters.AddWithValue("@platName", platName);
                                int platId = Convert.ToInt32(cmdGetPlatId.ExecuteScalar());

                                using (MySqlCommand cmdInsertCommandePlat = new MySqlCommand(queryInsertCommandePlat, con))
                                {
                                    cmdInsertCommandePlat.Parameters.AddWithValue("@idPlat", platId);
                                    cmdInsertCommandePlat.Parameters.AddWithValue("@idCommande", commandeId);
                                    cmdInsertCommandePlat.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void Facture_Click(object sender, EventArgs e)
        {
            total = 0.0;

           
            foreach (ListViewItem item in listCommande.Items)
            {

                double prix;
                int qte;
                if (double.TryParse(item.SubItems[1].Text, out prix) && int.TryParse(item.SubItems[2].Text, out qte))
                {
                    total += prix * qte;
                }
            }



            PrixTotal.Text = total.ToString();

            //MessageBox.Show("Total : " + total.ToString());
        }

        private void qte_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (listCommande.SelectedItems.Count > 0)
            {
          
                foreach (ListViewItem selectedItem in listCommande.SelectedItems)
                {
                    // Remove the selected item from the ListView
                    listCommande.Items.Remove(selectedItem);
                }
            }
        }

        private void NEW_Click(object sender, EventArgs e)
        {
            con.Close();
            this.Hide();
            Serveur serverDash = new Serveur();
            serverDash.ShowDialog();
        }
    }
}
