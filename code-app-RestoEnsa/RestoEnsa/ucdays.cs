using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace RestoEnsa
{
    public partial class ucdays : UserControl
    {
        public static string g_day;
        private string _day;

        public ucdays(string day, List<string> shifts)
        {
            InitializeComponent();
            _day = day;
            label1.Text = _day;

            // Display the shifts
            foreach (var shift in shifts)
            {
                
                display.Text = shift;
                display.AutoSize = true;
                //panel1.Controls.Add(shiftLabel);
            }

            // Ensure that clicking on the label or the panel triggers the event
            this.Click += ucdays_Click;
            label1.Click += ucdays_Click;
            panel1.Click += ucdays_Click;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // This event is likely empty if you don't have specific drawing logic.
        }

        private void ucdays_Click(object sender, EventArgs e)
        {
            g_day = _day; // Update the global day if necessary
            ajouter formAjouter = new ajouter(_day, calendrier._month, calendrier._year);
            formAjouter.ShowDialog(); // Use ShowDialog for a modal window
        }

        private const string connString = "server=localhost;user id=root;password=;database=restoensa";
     

        private void label1_Click(object sender, EventArgs e)
        {
            // Handle label click if necessary
        }
    }
}
