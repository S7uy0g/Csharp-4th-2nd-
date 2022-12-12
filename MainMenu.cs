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
            dataGridView1.Hide();
        }
        //Booking Button
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Show();
        }
    }
}
