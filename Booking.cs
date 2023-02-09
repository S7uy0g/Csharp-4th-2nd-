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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CsharpForm
{
    public partial class Booking : UserControl
    {
        //Suyog Lab Database
        SqlConnection conn = new SqlConnection(@"Data Source=GWTN141-4;Initial Catalog=signUp;Integrated Security=True");
        //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-LHHH1S3\SQLEXPRESS;Initial Catalog=signUp;Integrated Security=True");



        //Rohan Legion database
        //SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-3ORSUC9H;Initial Catalog=signUp;Integrated Security=True");
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
            if (getStartH > 12||getStartH<1|| getStartM > 60 || getStartM < 0 || getEndH > 12 || getStartH < 1 || getStartM > 60 || getStartM < 0)
            {
                errorProvider1.SetError(SHour, "Wrong Input");
            }
            else
            {
                string query = "Insert into Booking values('" + getName + "','" + getContact + "','" + getDate + "','" + getStartH + "','" + getStartM + "','" + getSAMPM + "','" + getEndH + "','" + getEndM + "','" + getEAMPM + "','" + getStart + "','" + getEnd + "')";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
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
    }
}
