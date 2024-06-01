using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEProject
{
    public partial class PatientAccount : Form
    {
        private int patient_ID;
        public PatientAccount(int id)
        {
            InitializeComponent();
            this.patient_ID = id;
            LoadData();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PatientOrderMedicine(patient_ID).Show();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            new PatientDashboard(patient_ID).Show();
            this.Hide();
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            new PatientMessage(patient_ID).Show();
            this.Hide();
        }
        
        private void gunaButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginP().Show();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if(name.Text=="" || username.Text=="" || password.Text=="")
            {
                MessageBox.Show("Fill all fields");
            }
            else if (name.Text == "Name")
            {
                MessageBox.Show("Invalid Name");
            }
            else if (username.Text == "Username")
            {
                MessageBox.Show("Invalid Username");
            }
            else if (password.Text == "Password")
            {
                MessageBox.Show("Invalid Password");
            }
            else
            {
                using (MySqlConnection conn = new MySqlConnection(Class1.connstring))
                {
                    conn.Open();
                    String sql = "UPDATE patient SET name=@name, username=@username, password=@password WHERE ID=@patientID";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", name.Text);
                        cmd.Parameters.AddWithValue("@username", username.Text);
                        cmd.Parameters.AddWithValue("@password", password.Text);
                        cmd.Parameters.AddWithValue("@patientID", patient_ID);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Account information updated successfully");
                        }
                        else
                        {
                            MessageBox.Show("Failed to update account information");
                        }
                    }
                }
            }
        }

        private void LoadData()
        {
            using (MySqlConnection conn = new MySqlConnection(Class1.connstring))
            {
                conn.Open();
                String sql = "SELECT * FROM patient WHERE ID = @patientID";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@patientID", patient_ID);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            name.Text = reader["name"].ToString();
                            username.Text = reader["username"].ToString();
                            password.Text = reader["password"].ToString();
                        }
                    }
                }
            }
        }

    }
}
