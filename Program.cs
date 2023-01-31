using System.Data.SqlClient;
namespace CsharpForm
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            //Suyog Database
            //SqlConnection conn = new SqlConnection(@"Data Source=GWTN141-4;Initial Catalog=signUp;Integrated Security=True");
            //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-LHHH1S3\SQLEXPRESS;Initial Catalog=signUp;Integrated Security=True");

            //Rohan Database
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-CLLMDVB\SQLEXPRESS;Initial Catalog=signUp;Integrated Security=True");

            ApplicationConfiguration.Initialize();
            conn.Open();
            string query = "SELECT count(*) from signUp_Table";
            //Rohan SQL Code
            //string query = "SELECT name,FMLPassword from UserAdmin where name='" + getMail + "'AND FMLPassword='" + getPassword + "'";
            SqlCommand sqlCommand = new SqlCommand(query, conn);
            int count=Convert.ToInt32(sqlCommand.ExecuteScalar());
            if (count > 0)
            {
                Application.Run(new Form1());
            }
            else
            {
                Application.Run(new signUpForm());
            }
        }
    }
}