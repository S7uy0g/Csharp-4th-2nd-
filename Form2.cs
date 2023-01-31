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

namespace CsharpForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            /*pictureBox1.Invalidate();*/
            pictureBox1.Parent.Refresh();
            openFileDialog.Filter = "Image Files (*.bmp, *.jpg, *.jpeg, *.png)|*.bmp;*.jpg;*.jpeg;*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            SqlConnection conn = new SqlConnection(@"Data Source=GWTN141-4;Initial Catalog=signUp;Integrated Security=True");
            //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-LHHH1S3\SQLEXPRESS;Initial Catalog=signUp;Integrated Security=True");
            conn.Open();
            string queryString = "INSERT INTO Images (ImageName, ImageData) VALUES (@ImageName, @ImageData)";
            using (SqlCommand command = new SqlCommand(queryString, conn))
                {
                    command.Parameters.AddWithValue("@ImageName",Path.GetFileName(openFileDialog.FileName));
                    command.Parameters.AddWithValue("@ImageData", Path.GetFullPath(openFileDialog.FileName));
                    command.ExecuteNonQuery();
                }
            conn.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
