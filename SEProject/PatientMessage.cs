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
    public partial class PatientMessage : Form
    {
        private int patient_ID;
        public PatientMessage(int patient_ID)
        {
            InitializeComponent();
            this.patient_ID = patient_ID;
            LoadMessages();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            new PatientDashboard(patient_ID).Show();
            this.Hide();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            new PatientOrderMedicine(patient_ID).Show();
            this.Hide();
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PatientAccount(patient_ID).Show();
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginP().Show();
        }

        private void LoadMessages()
        {
            using (MySqlConnection conn = new MySqlConnection(Class1.connstring))
            {
                conn.Open();

                String sql1 = "Select * from messages where Patient_ID = @patientid";
                using (MySqlCommand cmd1 = new MySqlCommand(sql1, conn))
                {
                    cmd1.Parameters.AddWithValue("@patientid", patient_ID);
                    using (MySqlDataReader reader1 = cmd1.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader1);
                        gunaDataGridView1.DataSource = dataTable;
                    }
                }
            }
        }
    }
}
