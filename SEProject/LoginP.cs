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
    public partial class LoginP : Form
    {
        public LoginP()
        {
            InitializeComponent();
        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void gunaLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new LoginA().Show();
        }

        private void login_Click(object sender, EventArgs e)
        {
            //string connstring = "server=localhost;uid=root;pwd=root;database=pms";
            MySqlConnection conn = new MySqlConnection(Class1.connstring);
            conn.ConnectionString = Class1.connstring;
            conn.Open();
            string sql = "Select * from patient where status = 'Exists'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            bool flag = true;
            while (reader.Read())
            {
                if(username.Text=="" || password.Text == "")
                {
                    MessageBox.Show("Fill all fields");
                }
                else
                {
                    if (reader["username"].ToString()==username.Text && reader["password"].ToString()==password.Text)
                    {
                        flag = true;
                        new PatientDashboard(int.Parse(reader["ID"].ToString())).Show();
                        this.Hide();
                        break;
                    }
                    else
                    {
                        flag = false;
                    }
                }
            }
            if (!flag)
            {
                MessageBox.Show("Invalid username or password");
            }
        }
    }
}
