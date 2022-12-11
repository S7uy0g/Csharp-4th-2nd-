using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsharpForm
{
    public partial class signUpForm : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
            (
                int nLeft,
                int nTop,
                int nRight,
                int nBottom,
                int nWidthEllipse,
                int nHeightEllipse
            );
        public signUpForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void signUpForm_Load(object sender, EventArgs e)
        {
            panel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width, panel2.Height, 40, 40));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fName_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void email_TextBox_TextChanged(object sender, EventArgs e)
        {
            string userEmail = email_TextBox.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string userFirstName = firstName.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string userMiddelName = middleName.Text;
        }

        private void lastName_TextChanged(object sender, EventArgs e)
        {
            string userLastName = lastName.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string day = ageDay.Text;
        }

        private void ageMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            string month = ageMonth.Text;
        }

        private void password_TextBox_TextChanged(object sender, EventArgs e)
        {
            string password = password_TextBox.Text;
        }

        private void confirm_TextBox_TextChanged(object sender, EventArgs e)
        {
            string confirm = confirm_TextBox.Text;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void signUp_Click(object sender, EventArgs e)
        {

        }
    }
}
