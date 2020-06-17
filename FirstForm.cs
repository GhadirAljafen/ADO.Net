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

namespace CompanyForm
{
    public partial class FirstForm : Form
    {
        const string connectionString = "Server=DESKTOP-JN32FB5;Database=Company; User ID=sa; password=9797";
        /// <summary>
        IConnection newConnection = new Program();
        public FirstForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Form1 baseForm = new Form1();
            insertForm form = new insertForm();
            form.Show();
            WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            deleteForm form = new deleteForm();
            form.Show();
            WindowState = FormWindowState.Minimized;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            updateForm form = new updateForm();
            form.Show();
            WindowState = FormWindowState.Minimized;

        }

        private void btn_display(object sender, EventArgs e)
        {
            newConnection.DisplayAll(dataGridEmployee);
        }
    }
}
