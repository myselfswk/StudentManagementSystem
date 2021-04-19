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

namespace StudentManagementSystem
{
    public partial class ModifyCourses : Form
    {
        SqlConnection conn;
        public ModifyCourses()
        {
            InitializeComponent();
        }

        private void ModifyCourses_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection("Data Source=DESKTOP-QG8ONMB;Initial Catalog=StudentManagementSystem;Integrated Security=True");

                DataSet dataSet = new DataSet();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from [addCourses]", conn);

                //two methods to add data (Fill, Update)
                sqlDataAdapter.Fill(dataSet, "[addCourses]");

                lbCourses.DataSource = dataSet.Tables["[addCourses]"];

                //display member: data which is shown on UI
                //value member: data which is working on backend
                lbCourses.DisplayMember = "title";
                lbCourses.ValueMember = "id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}
