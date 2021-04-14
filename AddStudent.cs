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
    public partial class AddStudent : Form
    {
        SqlConnection conn;
        public AddStudent()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            var genValue = "";
            if (rbMale.Checked)
            {
                genValue = "male";
            }
            else
            {
                genValue = "female";
            }

            try
            {
                conn = new SqlConnection("Data Source=DESKTOP-QG8ONMB;Initial Catalog=StudentManagementSystem;Integrated Security=True");

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = "Insert into [addStudent] (name, address, email, phone, cnic, gender) values ('"+ txtName.Text +"', '"+ txtAddress.Text +"', '"+ txtEmail.Text +"', '"+ txtPhone.Text +"', '"+ txtCNIC.Text +"', '"+ genValue +"')";
                sqlCommand.Connection = conn;

                conn.Open();
                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Student Enter Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
