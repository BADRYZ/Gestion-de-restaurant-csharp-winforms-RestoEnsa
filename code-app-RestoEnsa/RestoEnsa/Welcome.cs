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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Welcome_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            login weleco = new login(1);
            this.Hide();

            weleco.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            login weleco = new login(2);
            this.Hide();
            weleco.ShowDialog();


        }
    }
}
