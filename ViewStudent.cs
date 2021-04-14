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
    public partial class ViewStudent : Form
    {
        SqlConnection conn;
        public ViewStudent()
        {
            InitializeComponent();
        }

        private void ViewStudent_Load(object sender, EventArgs e)
        {
            updateList();
        }

        private void updateList()
        {
            lbViewdData.Items.Clear();

            //Connected Architecture
            try
            {
                conn = new SqlConnection("Data Source=DESKTOP-QG8ONMB;Initial Catalog=StudentManagementSystem;Integrated Security=True");

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = "select * from [addStudent]";
                sqlCommand.Connection = conn;

                conn.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    lbViewdData.Items.Add(reader["name"]);
                }
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

        private void lbViewdData_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbViewdData_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection("Data Source=DESKTOP-QG8ONMB;Initial Catalog=StudentManagementSystem;Integrated Security=True");

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = "Select * From [addStudent] where Name = '"+ lbViewdData.SelectedItem +"'";
                sqlCommand.Connection = conn;

                conn.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    txtName.Text = sqlDataReader["name"].ToString();
                    txtAddress.Text = sqlDataReader["address"].ToString();
                    txtEmail.Text = sqlDataReader["email"].ToString();
                    txtPhone.Text = sqlDataReader["phone"].ToString();
                    txtCNIC.Text = sqlDataReader["cnic"].ToString();

                    if (sqlDataReader["gender"].ToString().Equals("male"))
                    {
                        rbMale.Checked = true;
                    }
                    else
                    {
                        rbFemale.Checked = true;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
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
                sqlCommand.CommandText = "Update [addStudent] Set name = '"+ txtName.Text +"', address = '"+ txtAddress.Text +"', email = '"+ txtEmail.Text +"', phone = '"+ txtPhone.Text +"', cnic = '"+ txtCNIC.Text +"', gender = '"+ genValue +"' where name = '"+ lbViewdData.SelectedItem +"'";
                sqlCommand.Connection = conn;

                conn.Open();
                sqlCommand.ExecuteNonQuery();

                updateList();

                MessageBox.Show("Student is Updated");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection("Data Source=DESKTOP-QG8ONMB;Initial Catalog=StudentManagementSystem;Integrated Security=True");

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = "Delete from [addStudent] where name = '"+ lbViewdData.SelectedItem +"'";
                sqlCommand.Connection = conn;

                conn.Open();
                sqlCommand.ExecuteNonQuery();

                updateList();

                txtName.Text = txtAddress.Text = txtEmail.Text = txtPhone.Text = txtCNIC.Text = "";
                MessageBox.Show("Student is Deleted");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
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
