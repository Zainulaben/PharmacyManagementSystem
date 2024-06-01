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
    public partial class PatientDashboard : Form
    {
        private int patient_ID;
        public PatientDashboard(int id)
        {
            InitializeComponent();
            this.patient_ID = id;
            LoadPendingOrders();
            LoadTopMedicine();
        }

        private void PatientDashboard_Load(object sender, EventArgs e)
        {

        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginP().Show();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            new PatientOrderMedicine(patient_ID).Show();
            this.Hide();
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            new PatientAccount(patient_ID).Show();
            this.Hide();
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            new PatientMessage(patient_ID).Show();
            this.Hide();
        }

        private void LoadPendingOrders()
        {
            using (MySqlConnection conn = new MySqlConnection(Class1.connstring))
            {
                conn.Open();
                String sql = "SELECT COUNT(*) FROM order_table WHERE patient_ID = @patientID AND status = 'Pending'";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@patientID", patient_ID);
                    long pendingOrders = (long)cmd.ExecuteScalar();
                    numberofpendingorder.Text = $"Pending Orders: {pendingOrders}";
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
                            topmedicineuse.Text = "Top Medicine : " + topMedicineName;
                        }
                        else
                        {
                            topmedicineuse.Text = "No medicine";
                        }
                    }
                }
            }
        }
    }
}
