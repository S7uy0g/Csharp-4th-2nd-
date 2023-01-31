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

namespace CsharpForm
{
    public partial class MainMenu : Form
    {
        //Rohan Legion database
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-3ORSUC9H;Initial Catalog=signUp;Integrated Security=True");
        public MainMenu()
        {
            InitializeComponent();
        }
        //Try - Nice try
        //Main Menu main Form
        private void MainMenu_Load(object sender, EventArgs e)
        {
            home1.Show();
            employee1.Hide();
            booking1.Hide();
            inventory1.Hide();
            /*dataGridView1.Hide();*/
        }
        //Booking Button
        private void button1_Click(object sender, EventArgs e)
        {
            home1.Show();
            employee1.Hide();
            booking1.Hide();
            inventory1.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            booking1.Show();
            employee1.Hide();
            home1.Hide();
            inventory1.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            booking1.Hide();
            employee1.Show();
            home1.Hide();
            inventory1.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            home1.Hide();
            employee1.Hide();
            booking1.Hide();
            inventory1.Show();
        }
    }
}
