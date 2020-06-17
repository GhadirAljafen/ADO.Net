using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CompanyForm
{
    public class Program : IConnection
    {

        //const string connectionString = "Server=DESKTOP-JN32FB5;Database=Company; User ID=sa; password=9797";

        static string connectionString ="";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FirstForm());
        }
     /*   public static void GoBack(Form current, Form back)
        {
            current.Close();
            // current.Hide();
            //  current.Dispose();
            back.Show();
        }
     */
        public void DisplayAll(DataGridView dataGrid) {
            connectionString = ConfigurationManager.ConnectionStrings["connection_string"].ConnectionString;
            //string query = $"SP_Employee_Select_All";
            string query = "select * from [Employee]; select [Emp_Name] from [Employee]";
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {

                        // cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {


                            if (reader.HasRows)
                            {
                                DataTable table = new DataTable();
                                table.Load(reader);
                                dataGrid.DataSource = table;
                            }
                            
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
