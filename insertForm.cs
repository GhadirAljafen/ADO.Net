using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
namespace CompanyForm
{
   
    public partial class insertForm : Form
    {
        //string con_string = System.Configuration.ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

        // const string connectionString = "Server=DESKTOP-JN32FB5;Database=Company; User ID=sa; password=9797";
        static string connectionString = "";
        IConnection newConnection = new Program();
        public insertForm()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["connection_string"].ConnectionString;
        }
        private void insertForm_Load(object sender, EventArgs e)
        {
        }
        private void btn_insert(object sender, EventArgs e)
        {
           // string query = $"insert into [Employee] ([Emp_Name],[Emp_Last_Name],[Department], [Age], [Salary])" +
              //  $" values ('{textName.Text}','{textLastName.Text}','{textDepartment.Text}','{textAge.Text}','{textSalary.Text}')";
            string query = $"SP_Employee_Insert";
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {

                    if (
                        !string.IsNullOrWhiteSpace(textName.Text) &&
                        !string.IsNullOrWhiteSpace(textLastName.Text) &&
                        !string.IsNullOrWhiteSpace(textSalary.Text) &&
                        !string.IsNullOrWhiteSpace(textDepartment.Text) &&
                        !string.IsNullOrWhiteSpace(textAge.Text))
                    {
                        con.Open();
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@Emp_name", textName.Text);
                            cmd.Parameters.AddWithValue("@Emp_Last_Name", textLastName.Text);
                            cmd.Parameters.AddWithValue("@Department", textDepartment.Text);
                            cmd.Parameters.AddWithValue("@Age", textAge.Text);
                            cmd.Parameters.AddWithValue("@Salary", textSalary.Text);
                            cmd.CommandType = System.Data.CommandType.StoredProcedure;
                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Added Successfully");
                        textAge.Clear();
                        textDepartment.Clear();
                        textLastName.Clear();
                        textName.Clear();
                        textSalary.Clear();
                    }
                    else MessageBox.Show("Please fill the fields");

                }
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
            
        }

        /*
        private void btn_back(object sender, EventArgs e)
        {
           FirstForm form = new FirstForm();
           Program.GoBack(this, form);
        }
        */
        private void btn_display(object sender, EventArgs e)
        {
            newConnection.DisplayAll(dataGridEmployee);
        }

    }
}
