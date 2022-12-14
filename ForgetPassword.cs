using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace CsharpForm
{
   
    public partial class ForgetPassword : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source = .\SQLEXPRESS; Initial Catalog = FMLProject; Integrated Security = True");
        //SqlConnection conn = new SqlConnection(@"Data Source=GWTN141-4;Initial Catalog=FMLProject;Integrated Security=True");
        public ForgetPassword()
        {
            InitializeComponent();
        }
        //Whole ForgetPassword Form Function
        private void Form2_Load(object sender, EventArgs e)
        {

        }
        //Change Password Button Function
        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            string getEmail=Email.Text;
            string getPhoneNo = PhoneNo.Text;
            string getPassword = oPassword.Text;
            string conPassword = nPassword.Text;
            if(getPassword!=conPassword)
            {
                errorProvider1.SetError(oPassword, "Not the same Password");
                errorProvider1.SetError(nPassword, "Not the same Password");
                MessageBox.Show("Not the same password");
            }
            else
            {
                //string query1 = "Select Email From UserAdmin WHERE Email='" + getEmail + "'";
                string query1 = "Select Email From User_Admin WHERE Email='" + getEmail + "'";
                /*SqlCommand cmd1 = new SqlCommand(query1, conn);
                cmd1.ExecuteNonQuery();*/
                SqlCommand sqlCommand = new SqlCommand(query1, conn);
                string data = (string)sqlCommand.ExecuteScalar();
                if (getEmail == data.ToString())
                {
                    string query2 = "UPDATE User_Admin SET Email='" + getEmail + "',contact='" + getPhoneNo + "',FMLPassword='" + getPassword + "' WHERE Email='" + getEmail + "'";
                    //string query2 = "UPDATE UserAdmin SET Email='" + getEmail + "',PhoneNo='" + getPhoneNo + "',FMLPassword='" + getPassword + "' WHERE Email='" + getEmail + "'";
                    SqlCommand cmd2 = new SqlCommand(query2, conn);
                    cmd2.ExecuteNonQuery();
                }
                MessageBox.Show("Updated Successfully");
                conn.Close();
            }
            
        }
        //Find PhoneNo Button function
        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            string getContact = FindNo.Text;
            //string query = "Select Email,PhoneNo From UserAdmin WHERE PhoneNo='" + getContact + "'";
            string query = "Select Email,contact From User_Admin WHERE contact='" + getContact + "'";
            SqlCommand sqlCommand = new SqlCommand(query, conn);
            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                string data1 = dt.Rows[0]["Email"].ToString();
                string data2 = dt.Rows[0]["contact"].ToString();
                //string data2 = dt.Rows[0]["PhoneNo"].ToString();
                Email.Text = data1;
                PhoneNo.Text = data2;
            }
            else
            {
                MessageBox.Show("Account Doesnot Exist");
            }
            conn.Close();
        }
        //New Password Text Function
        private void oPassword_TextChanged(object sender, EventArgs e)
        {

        }
        //Confirm Password Text Function
        private void nPassword_TextChanged(object sender, EventArgs e)
        {
            if(oPassword.Text!=nPassword.Text)
            {
                errorProvider1.SetError(oPassword, "Not the same Password");
                errorProvider1.SetError(nPassword, "Not the same Password");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
        //Phone No logo function
        private void label6_Click(object sender, EventArgs e)
        {

        }
        //Phone No Text Function
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

            conn.Open();
            string getPhone = FindNo.Text;
            //string query = "SELECT PhoneNO from UserAdmin where PhoneNo='" + getPhone + "'";
            string query = "SELECT contact from User_Admin where contact='" + getPhone + "'";
            SqlCommand sqlCommand = new SqlCommand(query, conn);
            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count <= 0)
            {
                errorProvider1.SetError(FindNo, "Does Not Exist");
            }
            else
            {
                errorProvider1.Clear();
            }
            conn.Close();
        }
        //Main Girl Logo Function
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        //Forget your Password Whole Place Function
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        //Forget Your Password Logo Function
        private void label1_Click(object sender, EventArgs e)
        {

        }
        //Email Logo Function
        private void label5_Click(object sender, EventArgs e)
        {

        }
        //Email Text Function
        private void Email_TextChanged(object sender, EventArgs e)
        {

        }
        //Phone No Logo Function
        private void label2_Click(object sender, EventArgs e)
        {

        }
        //Phone No Text Function
        private void PhoneNo_TextChanged(object sender, EventArgs e)
        {

        }
        //New Password Logo function
        private void label3_Click(object sender, EventArgs e)
        {

        }
        //Confirm Password Logo Function
        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
