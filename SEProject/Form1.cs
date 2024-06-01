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
    public partial class Form1 : Form
    {
        int statringpoint = 0;
        public Form1()
        {
            InitializeComponent();
            UpdateOrdersData();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            statringpoint += 1;
            bunifuCircleProgressbar1.Value = statringpoint;
            if (bunifuCircleProgressbar1.Value == 100)
            {
                bunifuCircleProgressbar1.Value = 0;
                timer1.Stop();
                this.Hide();
                new LoginP().Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void UpdateOrdersData()
        {
            using (MySqlConnection conn = new MySqlConnection(Class1.connstring))
            {
                conn.Open();

                String updateStatusSQL = "UPDATE order_table SET status = 'Completed' WHERE order_date <= DATE_SUB(CURDATE(), INTERVAL 2 DAY) AND status = 'Pending'";
                using (MySqlCommand updateStatusCmd = new MySqlCommand(updateStatusSQL, conn))
                {
                    int rowsAffected = updateStatusCmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        String completedOrdersSQL = "SELECT DISTINCT patient_ID FROM order_table WHERE status = 'Completed'";
                        using (MySqlCommand completedOrdersCmd = new MySqlCommand(completedOrdersSQL, conn))
                        {
                            using (MySqlDataReader reader = completedOrdersCmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    int completedPatientID = int.Parse(reader["patient_ID"].ToString());

                                    String insertMessageSQL = "INSERT INTO messages(patient_ID, message) VALUES (@patientID, @message)";
                                    using (MySqlCommand insertMessageCmd = new MySqlCommand(insertMessageSQL, conn))
                                    {
                                        insertMessageCmd.Parameters.AddWithValue("@patientID", completedPatientID);
                                        insertMessageCmd.Parameters.AddWithValue("@message", "Order Completed");
                                        insertMessageCmd.ExecuteNonQuery();
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }


    }
}
