using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SEProject
{
    public partial class LoginA : Form
    {
        public LoginA()
        {
            InitializeComponent();
            //password.Text = "";
        }

        private void gunaLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new LoginP().Show();
        }

        private void login_Click(object sender, EventArgs e)
        {
            //string connstring = "server=localhost;uid=root;pwd=root;database=pms";
            MySqlConnection conn = new MySqlConnection(Class1.connstring);
            conn.ConnectionString = Class1.connstring;
            conn.Open();
            string sql = "Select * from admin_table";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            if(password.Text!="")
            {
                if ((""+reader["password"]) == password.Text)
                {
                    this.Hide();
                    new AdminDashboard().Show();
                }
                else
                {
                    MessageBox.Show("Password Incorrect");
                    password.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Fill password field");
                password.Text = "";
            }
            
        }
    }
}
