using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEProject
{
    public partial class AdminPatient : Form
    {
        public AdminPatient()
        {
            InitializeComponent();
            LoadPatientData();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminMedicine().Show();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminDashboard().Show();
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginP().Show();
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminOrderRequest().Show();
        }


        private void add_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(Class1.connstring);
            conn.ConnectionString = Class1.connstring;
            conn.Open();

            if (patientname.Text =="" || password.Text =="" || username.Text == "")
            {
                MessageBox.Show("Fill All Fields");
            }
            else if (patientname.Text == "Patient Name")
            {
                MessageBox.Show("Invalid patient name");
            }
            else if (password.Text == "Password")
            {
                MessageBox.Show("Invalid password");
            }
            else if (username.Text == "User Name")
            {
                MessageBox.Show("Invalid username");
            }
            else
            {
                bool flag = true;
                string sql = "Select * from patient where status = 'Exists'";
                MySqlCommand cmd = new MySqlCommand(sql,conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["username"].ToString() == username.Text && reader["name"].ToString() == patientname.Text && reader["password"].ToString() == password.Text)
                    {
                        MessageBox.Show("Patient Already Exists");
                        flag = false;
                        break;
                    }
                    else if (reader["username"].ToString() == username.Text)
                    {
                        MessageBox.Show("Username Already Exists");
                        flag = false;
                        break;
                    }
                }

                reader.Close();

                if (flag)
                {
                    if(IsPasswordValid(password.Text))
                    {
                        sql = "Insert into patient(username,name,password,status) values(@username,@name,@password,@status)";
                        cmd = new MySqlCommand(sql, conn);

                        IDbDataParameter username1 = cmd.CreateParameter();
                        username1.ParameterName = "@username";
                        username1.Value = username.Text;
                        cmd.Parameters.Add(username1);

                        IDbDataParameter name1 = cmd.CreateParameter();
                        name1.ParameterName = "@name";
                        name1.Value = patientname.Text;
                        cmd.Parameters.Add(name1);

                        IDbDataParameter password1 = cmd.CreateParameter();
                        password1.ParameterName = "@password";
                        password1.Value = password.Text;
                        cmd.Parameters.Add(password1);

                        IDbDataParameter status1 = cmd.CreateParameter();
                        status1.ParameterName = "@status";
                        status1.Value = "Exists";
                        cmd.Parameters.Add(status1);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Patient added successfully");
                        patientname.Text = "Patient Name";
                        username.Text = "Username";
                        password.Text = "Password";
                    }
                }
                
            }

            LoadPatientData();
            conn.Close();


        }

        public static bool IsPasswordValid(string password)
        {
            if (password.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long.");
                return false;
            }
            else if (!Regex.IsMatch(password, @"^(?=.*[a-zA-Z])(?=.*\d)"))
            {
                MessageBox.Show("Password must contain both letters and numbers.");
                return false;
            }

            return true;
        }

        private void LoadPatientData()
        {
            using (MySqlConnection conn = new MySqlConnection(Class1.connstring))
            {
                conn.Open();

                String sql1 = "Select * from patient";
                using (MySqlCommand cmd1 = new MySqlCommand(sql1, conn))
                {
                    using (MySqlDataReader reader1 = cmd1.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader1);
                        gunaDataGridView1.DataSource = dataTable;
                    }
                }
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (patientname.Text == "" || password.Text == "" || username.Text == "")
            {
                MessageBox.Show("Fill All Fields");
            }
            else
            {
                bool flag = false;
                using (MySqlConnection conn = new MySqlConnection(Class1.connstring))
                {
                    conn.Open();
                    string sql = "UPDATE patient SET status = @status WHERE username = @username AND name=@name AND password=@password";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username.Text);
                        cmd.Parameters.AddWithValue("@name", patientname.Text);
                        cmd.Parameters.AddWithValue("@password", password.Text);
                        cmd.Parameters.AddWithValue("@status", "Deleted");

                        try
                        {
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Data deleted successfully.");

                                string updateOrderSql = "UPDATE order_table SET status = 'Cancelled' WHERE patient_ID = @patientID AND status = 'Pending'";
                                using (MySqlCommand updateOrderCmd = new MySqlCommand(updateOrderSql, conn))
                                {
                                    updateOrderCmd.Parameters.AddWithValue("@patientID", GetPatientID(username.Text, patientname.Text, password.Text));
                                    updateOrderCmd.ExecuteNonQuery();
                                }

                                patientname.Text = "Patient Name";
                                username.Text = "Username";
                                password.Text = "Password";
                                LoadPatientData();
                                flag = true;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error deleting data: " + ex.Message);
                        }
                    }
                }
                if (!flag)
                {
                    MessageBox.Show("Patient does not exist");
                }
            }
        }

        private int GetPatientID(string username, string name, string password)
        {
            using (MySqlConnection conn = new MySqlConnection(Class1.connstring))
            {
                conn.Open();
                string sql = "SELECT ID FROM patient WHERE username = @username AND name = @name AND password = @password";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@password", password);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        return -1;
                    }
                }
            }
        }


        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = gunaDataGridView1.Rows[e.RowIndex];

                patientname.Text = selectedRow.Cells["name"].Value.ToString();
                username.Text = selectedRow.Cells["username"].Value.ToString();
                password.Text = selectedRow.Cells["password"].Value.ToString();
            }
        }
    }
}
