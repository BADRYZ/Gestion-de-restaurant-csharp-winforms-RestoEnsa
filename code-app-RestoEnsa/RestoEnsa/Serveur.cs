using Bunifu.Framework.UI;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;
using RestoEnsa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RestoEnsa
{
    public partial class Serveur : Form
    {
        static DbManager db = new DbManager();
        static MySqlConnection con = db.getConnection();

        static DataTable TableNonReglee;

        public Serveur()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DbManager db = new DbManager();
            MySqlConnection con = db.getConnection();
            Image reservedIcon = Properties.Resources.reserved__1_;
            checkReglee();
            AjouterIconeAuxBoutons(TableNonReglee, tab1, tab2, tab3, tab4, tab5, tab6);
            
        }

        private void Form1_load_public()
        {
            DbManager db = new DbManager();
            MySqlConnection con = db.getConnection();
            Image reservedIcon = Properties.Resources.reserved__1_;
            checkReglee();
            AjouterIconeAuxBoutons(TableNonReglee, tab1, tab2, tab3, tab4, tab5, tab6);
        }

        private void tab4_Click(object sender, EventArgs e)
        {

            BunifuFlatButton b = (BunifuFlatButton)sender;
            string id_table = b.Tag.ToString();
            this.Hide();
            Menu menu = new Menu(id_table);
            menu.ShowDialog();
        }

      
        private void tab4_DoubleClick(object sender, EventArgs e)
        {

            BunifuFlatButton b = (BunifuFlatButton)sender;
            string id_table = b.Tag.ToString();
            con.Open();
            string query1 = "UPDATE commande SET reglee = 1 WHERE id_table =  " + id_table;

            try
            {
                MySqlCommand command = new MySqlCommand(query1, con);
                command.ExecuteNonQuery();
                con.Close();
                this.Hide();
                Serveur form = new Serveur(); 
                form.Show();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void checkReglee()
        {
            string query1 = "SELECT id_table FROM commande WHERE reglee=0";

            try
            {


                using (MySqlCommand command = new MySqlCommand(query1, con))
                {

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {

                        TableNonReglee = new DataTable();

                        adapter.Fill(TableNonReglee);





                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        void AjouterIconeAuxBoutons(DataTable dataTable, params Bunifu.Framework.UI.BunifuFlatButton[] boutons)
        {
            foreach (Bunifu.Framework.UI.BunifuFlatButton bouton in boutons)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                   
                    if (row["id_table"].ToString() == bouton.Tag.ToString())
                    {
                        bouton.Iconimage = global::RestoEnsa.Properties.Resources.reserved__1_;
                        bouton.ButtonText = $"           Table   {bouton.Tag.ToString()}"; 
                        bouton.Text = $"            Table   {bouton.Tag.ToString()}"; 
                        bouton.IconVisible = true;
                        bouton.IconZoom = 70D;
                        bouton.TextAlign = ContentAlignment.TopCenter;
                        bouton.Click -= tab4_Click;
                        bouton.Enabled = false; 
                        break; 
                    }
                }
            }
        }
       






    }
}
