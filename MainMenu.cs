using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsharpForm
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        //Try - Nice try
        //Main Menu main Form
        private void MainMenu_Load(object sender, EventArgs e)
        {
            /*dataGridView1.Hide();*/
        }
        //Booking Button
        private void button1_Click(object sender, EventArgs e)
        {
            home.Show();
            /*dataGridView1.Show();*/

        }

        private void button2_Click(object sender, EventArgs e)
        {
            home.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            home.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            home.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            home.Show();
        }
    }
}
