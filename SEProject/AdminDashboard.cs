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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
            LoadTotalSale();
            LoadTotalPatients();
            LoadTopMedicine();
            LoadPendingOrder();
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginP().Show();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminMedicine().Show();
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminPatient().Show();
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminOrderRequest().Show();
        }

        private void gunaPictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminOrderRequest().Show();
        }

        private void gunaGradient2Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaGradient2Panel4_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            new AdminOrderRequest().Show();
        }

        private void LoadTotalPatients()
        {
            using (MySqlConnection conn = new MySqlConnection(Class1.connstring))
            {
                conn.Open();
                String sql = "SELECT COUNT(*) FROM patient WHERE status = @status";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@status", "Exists");
                    long totalPatients = (long)cmd.ExecuteScalar();
                    totalpatient.Text = "Total Patients : " + totalPatients.ToString();
                }
            }
        }

        private void LoadTopMedicine()
        {
            using (MySqlConnection conn = new MySqlConnection(Class1.connstring))
            {
                conn.Open();
                String sql = "SELECT m.name, COUNT(mo.Medicine_ID) as OrderCount " +
                             "FROM medicine m " +
                             "JOIN medicine_order mo ON m.ID = mo.Medicine_ID " +
                             "GROUP BY m.ID " +
                             "ORDER BY OrderCount DESC " +
                             "LIMIT 1";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string topMedicineName = reader["name"].ToString();
                            topmedicine.Text = "Top Medicine : " + topMedicineName;
                        }
                        else
                        {
                            topmedicine.Text = "No medicine";
                        }
                    }
                }
            }
        }

        private void LoadTotalSale()
        {
            using (MySqlConnection conn = new MySqlConnection(Class1.connstring))
            {
                conn.Open();
                String sql = "SELECT COUNT(*) FROM order_table WHERE status = 'Completed' OR status = 'Approved'";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    long totalSale = (long)cmd.ExecuteScalar();
                    totalsale.Text = "Total Sale : "+totalSale.ToString();
                }
            }
        }

        private void LoadPendingOrder()
        {
            using (MySqlConnection conn = new MySqlConnection(Class1.connstring))
            {
                conn.Open();
                String sql = "SELECT COUNT(*) FROM order_table WHERE status = 'Pending'";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    long pendingOrders = (long)cmd.ExecuteScalar();
                    numberofpendingorder.Text = "Pending orders : "+pendingOrders.ToString();
                }
            }
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void gunaGradient2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
