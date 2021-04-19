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
    public partial class AddCourses : Form
    {
        SqlConnection conn;
        public AddCourses()
        {
            InitializeComponent();
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            //in database, your data will be in the form of relational data
            //in dataset, your data will be in the form of objects

            conn = new SqlConnection("Data Source=DESKTOP-QG8ONMB;Initial Catalog=StudentManagementSystem;Integrated Security=True");

            DataSet dataSet = new DataSet();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from [addCourses]", conn);

            //two methods to add data (Fill, Update)
            sqlDataAdapter.Fill(dataSet, "[addCourses]");

            DataRow dataRow = dataSet.Tables["[addCourses]"].NewRow();
        }
    }
}
