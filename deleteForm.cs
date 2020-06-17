using System;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace CompanyForm
{
    public partial class deleteForm : Form
    {
        //const string connectionString = "Server=DESKTOP-JN32FB5;Database=Company; User ID=sa; password=9797";
        static string connectionString = "";
        IConnection newConnection = new Program();
        public deleteForm()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["connection_string"].ConnectionString;
        }
        private void btn_delete(object sender, EventArgs e)
        {
            string query = $"SP_Employee_Delete";
           
            try
            {
                if (!string.IsNullOrWhiteSpace(textID.Text))
                {

                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("id", textID.Text);
                            cmd.CommandType = System.Data.CommandType.StoredProcedure;
                            cmd.ExecuteNonQuery();
                        }
                    }

                    // newConnection.DatabaseConnection(query);
                    MessageBox.Show("Deleted Successfully");
                }
                else
                    MessageBox.Show("Please enter an ID to be deleted !");
                textID.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a valid ID number");
            }

        }

        private void deleteForm_Load(object sender, EventArgs e)
        {

        }

     /*   private void btn_back(object sender, EventArgs e)
        {
            FirstForm form = new FirstForm();
            Program.GoBack(this, form);
            //WindowState = FormWindowState.Minimized;
        }
     */
        private void btn_display(object sender, EventArgs e)
        {
            newConnection.DisplayAll(dataGridEmployee);
        }

  
    }
}
