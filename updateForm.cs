using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CompanyForm
{
    public partial class updateForm : Form
    {

       // const string connectionString = "Server=DESKTOP-JN32FB5;Database=Company; User ID=sa; password=9797";
       static string connectionString = "";
        IConnection newConnection = new Program();
        public updateForm()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["connection_string"].ConnectionString;
        }


        private void btn_update(object sender, EventArgs e)
        {
            string query = $"SP_Employee_Update";
            try
            {

                if (!string.IsNullOrWhiteSpace(textAmount.Text) || !string.IsNullOrWhiteSpace(textDepartment.Text))
                {

                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@Amount", textAmount.Text);
                            cmd.Parameters.AddWithValue("@Department", textDepartment.Text);
                            cmd.CommandType = System.Data.CommandType.StoredProcedure;
                            cmd.ExecuteNonQuery();
                        }
                    }
                  //  newConnection.DatabaseConnection(query);
                    MessageBox.Show("Updated Successfully");
                }
                else MessageBox.Show("Please fill the fields");
                textAmount.Clear();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

      /*  private void btn_back(object sender, EventArgs e)
        {
           
            FirstForm form = new FirstForm();
            Program.GoBack(this, form);
            //WindowState = FormWindowState.Minimized;
        }
      */
        private void btn_display(object sender, EventArgs e)
        {
            //  newConnection.DisplayAll(dataGridEmployee);

            connectionString = ConfigurationManager.ConnectionStrings["connection_string"].ConnectionString;
            string query = $"SP_Employee_Select_Where";
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("Department", textDepartment.Text);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            DataTable table = new DataTable();
                            table.Load(reader);
                            dataGridEmployee.DataSource = table;
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
