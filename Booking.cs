﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CsharpForm
{

    /*CREATE TABLE Booking(
        fullName VARCHAR(30) NOT NULL,
        Contact VARCHAR(20) NOT NULL,
        BookingDate VARCHAR(30),
	    SHour INT NOT NULL,
        SMin INT NOT NULL,
	    SAMPM VARCHAR(5) NOT NULL,
        EHour INT NOT NULL,
	    EMin INT NOT NULL,
        EAMPM VARCHAR(5) NOT NULL,
        GStart VARCHAR(10),
	    GEnd VARCHAR(10)
    );*/
    public partial class Booking : UserControl
    {
        //Suyog Lab Database
        //SqlConnection conn = new SqlConnection(@"Data Source=GWTN141-4;Initial Catalog=signUp;Integrated Security=True");
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-LHHH1S3\SQLEXPRESS;Initial Catalog=signUp;Integrated Security=True");



        //Rohan Legion database
        //SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-3ORSUC9H;Initial Catalog=signUp;Integrated Security=True");
        //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-CLLMDVB\SQLEXPRESS;Initial Catalog=signUp;Integrated Security=True");
        public Booking()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            conn.Open();
            string getName=FullName.Text;
            string getContact=Contact.Text;
            string getDate = dateTimePicker1.Value.ToString();
            int getStartH = Int32.Parse(SHour.Text);
            int getStartM = Int32.Parse(SMin.Text);
            string getSAMPM =SAMPM.Text;
            int getEndH = Int32.Parse(Ehour.Text);
            int getEndM=Int32.Parse(EMin.Text);
            string getEAMPM = EAMPM.Text;
            string getStart = getStartH.ToString()+":"+getStartM.ToString()+getSAMPM;
            string getEnd = getEndH.ToString() + ":" + getEndM.ToString()+getEAMPM;
            /*if (getStartH > 12)
            {
                errorProvider1.SetError(SHour, "Wrong Input");
            }*/
            string query = "Insert into Booking values('" + getName + "','" + getContact + "','" + getDate + "','" + getStartH + "','"+ getStartM + "','"+ getSAMPM + "','" + getEndH + "','"+ getEndM + "','"+ getEAMPM + "','"+ getStart + "','"+ getEnd +"')";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            DisplayData();
        }

        private void DisplayData()
        {
            conn.Open();
            dataGridView1.Refresh();
            string query = "Select fullName,Contact,BookingDate,GStart,GEnd from Booking";
            SqlCommand sqlCommand = new SqlCommand(query, conn);
            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            string getFind = findBox.Text;
            string query = "Select fullName,Contact,BookingDate,SHour,SMin,SAMPM,EHour,EMin,EAMPM from Booking where Contact='" + getFind + "'";
            SqlCommand sqlCommand = new SqlCommand(query, conn);
            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                string getFullName = dt.Rows[0]["fullName"].ToString();
                string getContact = dt.Rows[0]["Contact"].ToString();
                string getBookingDate = dt.Rows[0]["BookingDate"].ToString();
                DateTime DT = DateTime.Parse(getBookingDate);
                string getPSHour = dt.Rows[0]["SHour"].ToString();
                string getPSMin = dt.Rows[0]["SMin"].ToString();
                string getSAMPM = dt.Rows[0]["SAMPM"].ToString();
                string getPEHour = dt.Rows[0]["EHour"].ToString();
                string getPEMin = dt.Rows[0]["EMin"].ToString();
                string getEAMPM = dt.Rows[0]["EAMPM"].ToString();
               /* int getSHour = Int32.Parse(getPSHour);
                int getSMin = Int32.Parse(getPSMin);
                int getEHour = Int32.Parse(getPEHour);
                int getEMin = Int32.Parse(getPEMin);*/
                FullName.Text = getFullName;
                Contact.Text = getContact;
                dateTimePicker1.Value = DT;
                SHour.Text = getPSHour;
                SMin.Text = getPSMin;
                SAMPM.Text = getSAMPM;
                Ehour.Text = getPEHour;
                EMin.Text = getPEMin;
                EAMPM.Text = getEAMPM;
            }
            else
            {
                errorProvider1.SetError(findBox, "No Such Data");
            }
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            string Gstart = SHour.Text + ":" + SMin.Text + SAMPM.Text;
            string Gend = Ehour.Text + ":" + EMin.Text + EAMPM.Text;
            string Uquery = "Update Booking set fullName='" + FullName.Text + "',Contact='" + Contact.Text + "',BookingDate='" + dateTimePicker1.Value.ToString() + "',SHour='" + Int32.Parse(SHour.Text) + "',SMin='" + Int32.Parse(SMin.Text) + "',SAMPM='"+ SAMPM.Text +"',EHour='"+ Int32.Parse(Ehour.Text)+"',EMin='"+ Int32.Parse(EMin.Text)+"',EAMPM='"+EAMPM.Text+ "',GStart='" + Gstart + "',GEnd='" + Gend + "'";
            SqlCommand cmd = new SqlCommand(Uquery, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            DisplayData();

        }
    }
}
