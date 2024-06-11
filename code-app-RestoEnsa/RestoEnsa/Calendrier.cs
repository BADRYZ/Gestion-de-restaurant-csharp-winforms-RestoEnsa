using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoEnsa
{
    public partial class calendrier : Form
    {
        public static int _month, _year;
        public static int g_month, g_year;

        public calendrier()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            showdays(DateTime.Now.Month, DateTime.Now.Year);
        }
        public void Form1_Load_public()
        {
            showdays(DateTime.Now.Month, DateTime.Now.Year);
        }

        private void mois_Click(object sender, EventArgs e)
        {

        }

        private void next_Click(object sender, EventArgs e)
        {
            _month += 1;
            if (_month > 12)
            {
                _month = 1;
                _year += 1;
            }
            showdays(_month, _year);
            g_month = _month;
            g_year = _year;

        }

        private void precedent_Click(object sender, EventArgs e)
        {
            _month -= 1;
            if (_month < 1)
            {
                _month = 12;
                _year -= 1;
            }
            showdays(_month, _year);
            g_month = _month;
            g_year = _year;
        }

        private void showdays(int month, int year)
        {
            flowLayoutPanel1.Controls.Clear();
            _month = month;
            _year = year;
            string monthName = new DateTimeFormatInfo().GetMonthName(month);
            mois.Text = $"{monthName} {year}";

            // Fetch shifts from the database
            var shifts = GetShifts();

            DateTime start = new DateTime(year, month, 1);
            int daysInMonth = DateTime.DaysInMonth(year, month);
            int startDayOfWeek = Convert.ToInt32(start.DayOfWeek);

            // Fill empty days for the first week
            for (int i = 0; i < startDayOfWeek; i++)
            {
                ucdays emptyDay = new ucdays("", []);
                flowLayoutPanel1.Controls.Add(emptyDay);
            }

            // Fill the days of the month
            for (int day = 1; day <= daysInMonth; day++)
            {
                DateTime currentDate = new DateTime(year, month, day);
                var dayShifts = shifts.ContainsKey(currentDate) ? shifts[currentDate] : new List<string>();
                ucdays dayControl = new ucdays(day.ToString(), dayShifts);
                //dayControl.displayR(dayControl);
                flowLayoutPanel1.Controls.Add(dayControl);
            }
        }




        private Dictionary<DateTime, List<string>> GetShifts()
        {
            string connString = "server=localhost;user id=root;password=;database=restoensa";
            var shifts = new Dictionary<DateTime, List<string>>();

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT serveur.nom, shift_serveur.id_shift, shift_serveur.date FROM serveur JOIN shift_serveur ON serveur.id = shift_serveur.id_serveur ORDER BY shift_serveur.date, serveur.nom";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string serveurNom = reader["nom"] != DBNull.Value ? reader["nom"].ToString() : "Unknown";
                        int shiftId = reader["id_shift"] != DBNull.Value ? Convert.ToInt32(reader["id_shift"]) : 0;
                        DateTime shiftDate = reader["date"] != DBNull.Value ? Convert.ToDateTime(reader["date"]) : DateTime.MinValue;

                        if (shiftDate == DateTime.MinValue) continue; // Skip if date is not valid

                        string record = $"{serveurNom}-{shiftId}";

                        if (!shifts.ContainsKey(shiftDate))
                        {
                            shifts[shiftDate] = new List<string>();
                        }
                        shifts[shiftDate].Add(record);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la récupération des données : " + ex.Message);
                }
            }

            return shifts;
        }



        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ServeursButton_Click(object sender, EventArgs e)
        {

            Form1 Serveur = new Form1();
            Serveur.Show();
            this.Hide(); // Hides the current form
        }

        private void PlatsButton_Click(object sender, EventArgs e)
        {
            Form2 Plats = new Form2();
            Plats.Show();
            this.Hide(); // Hides the current form
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

        private void CalendrierButton_Click(object sender, EventArgs e)
        {
            calendrier calendar = new calendrier();
            calendar.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void refreshbutton_Click(object sender, EventArgs e)
        {
            Form1_Load_public();
        }
    }

}
