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
using static System.ComponentModel.Design.ObjectSelectorEditor;



/*
use signUp;
CREATE TABLE signUp_Table(
	first_name VARCHAR(50) NOT NULL,
    middle_name VARCHAR(50),
	last_name VARCHAR(50) NOT NULL,
    contact_no VARCHAR(50) NOT NULL,
    futsal_name VARCHAR(50) NOT NULL,
    field_no INT NOT NULL,
    game_price INT NOT NULL,
    email VARCHAR(60) NOT NULL,
    admin_password VARCHAR(60) NOT NULL
);

SELECT* FROM signUp_Table;*/




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
/*            this.FormBorderStyle = FormBorderStyle.None;*/  //use for deleting the topbar of the window form 

            signUp2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, signUp2.Width, signUp2.Height, 30, 30));//sign up rounded shape
            panel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width, panel2.Height, 60, 60));//Panel rounded shape
            panel2.BackColor = Color.FromArgb(100, 0, 0, 0); // used for transplarant bg for the sign up panel
        }
        //SignUpLabel
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
        //EmailTextBox
        private void email_TextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void lastName_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ageMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        //PasswordTextbox
        private void password_TextBox_TextChanged(object sender, EventArgs e)
        {
            
        }
        //confirmPasswordTextbox
        private void confirm_TextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
        }
        //signupButton
        private void signUp_Click(object sender, EventArgs e)
        {
            string FutsalName = textBox1.Text;
            string NoFields = textBox2.Text;
            string ContactNo = textBox3.Text;
            string Email = email_TextBox.Text;
            if (password_TextBox.Text != confirm_TextBox.Text)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(password_TextBox, "Not Same");
                errorProvider1.SetError(confirm_TextBox, "Not Same");
            }
            else if (password_TextBox.Text ==string.Empty && confirm_TextBox.Text==string.Empty)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(password_TextBox, "Null");
                errorProvider1.SetError(confirm_TextBox, "Null");
            }
            else
            {
                errorProvider1.Clear();
                MessageBox.Show("Nice one");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        //FutsalNameLabel
        private void label2_Click_1(object sender, EventArgs e)
        {

        }
        //NoOfFieldsTextbox
        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }
        //FutsalNameTextbox
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        //ContactNoTextbox
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        //NoOffieldsLabel
        private void label2_Click_2(object sender, EventArgs e)
        {

        }
        //ContactNoLabel
        private void label3_Click_1(object sender, EventArgs e)
        {

        }
        //EmailLabel
        private void label5_Click(object sender, EventArgs e)
        {

        }
        //PasswordLabel
        private void label4_Click(object sender, EventArgs e)
        {

        }
        //ConfirmPasswordLabel
        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
