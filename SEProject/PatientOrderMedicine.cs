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
    public partial class PatientOrderMedicine : Form
    {
        private int patient_ID;
        public PatientOrderMedicine(int ID)
        {
            InitializeComponent();
            patient_ID = ID;
            LoadAllMedicines();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            new PatientDashboard(patient_ID).Show();
            this.Hide();
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            new LoginP().Show();
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

        private void search_Click(object sender, EventArgs e)
        {
            if(medicinename.Text=="" || medicinetype.Text == "")
            {
                MessageBox.Show("Enter medicine name and type");
            }
            else if(medicinename.Text=="Medicine Name")
            {
                MessageBox.Show("Invalid medicine name");
            }
            else if(medicinetype.Text=="Medicine Type")
            {
                MessageBox.Show("Invalid Medicine Type");
            }
            else
            {
                LoadMedicineData();
            }
        }

        private void order_Click(object sender, EventArgs e)
        {
            if (medicinename.Text == "" || medicinetype.Text == "" || quantity.Text == "")
            {
                MessageBox.Show("Fill all fields");
            }
            else if (medicinename.Text == "Medicine Name")
            {
                MessageBox.Show("Invalid medicine name");
            }
            else if (medicinetype.Text == "Medicine Type")
            {
                MessageBox.Show("Invalid Medicine Type");
            }
            else if (quantity.Text == "Quantity" || !int.TryParse(quantity.Text, out _))
            {
                MessageBox.Show("Enter valid quantity");
            }
            else
            {
                bool flag = false;
                using (MySqlConnection conn = new MySqlConnection(Class1.connstring))
                {
                    conn.Open();

                    String sql1 = "Select * from medicine where name=@name AND type=@type AND status = 'Exists'";
                    using (MySqlCommand cmd1 = new MySqlCommand(sql1, conn))
                    {
                        cmd1.Parameters.AddWithValue("@name", medicinename.Text);
                        cmd1.Parameters.AddWithValue("@type", medicinetype.Text);
                        MySqlDataReader reader1 = cmd1.ExecuteReader();
                        while (reader1.Read())
                        {
                            int availableQuantity = int.Parse(reader1["quantity"].ToString());
                            int orderedQuantity = int.Parse(quantity.Text);

                            if (availableQuantity >= orderedQuantity)
                            {
                                int ID = int.Parse(reader1["ID"].ToString());
                                reader1.Close();

                                String sql2 = "Insert into order_table(patient_ID,order_date,status) values (@patientID,@orderdate,@status)";
                                MySqlCommand cmd2 = new MySqlCommand(sql2, conn);
                                cmd2.Parameters.AddWithValue("@patientID", patient_ID);
                                cmd2.Parameters.AddWithValue("@orderdate", DateTime.Now);
                                cmd2.Parameters.AddWithValue("@status", "Pending");
                                cmd2.ExecuteNonQuery();

                                long orderID = cmd2.LastInsertedId;

                                sql2 = "Insert into medicine_order(Order_ID,Medicine_ID,Quantity) values (@orderid,@medicineid,@quantity)";
                                MySqlCommand cmd3 = new MySqlCommand(sql2, conn);
                                cmd3.Parameters.AddWithValue("@orderid", orderID);
                                cmd3.Parameters.AddWithValue("@medicineid", ID);
                                cmd3.Parameters.AddWithValue("@quantity", orderedQuantity);
                                cmd3.ExecuteNonQuery();

                                sql2 = "UPDATE medicine SET quantity = quantity - @orderedQuantity WHERE ID = @medicineID";
                                MySqlCommand cmd4 = new MySqlCommand(sql2, conn);
                                cmd4.Parameters.AddWithValue("@orderedQuantity", orderedQuantity);
                                cmd4.Parameters.AddWithValue("@medicineID", ID);
                                cmd4.ExecuteNonQuery();

                                sql2 = "INSERT INTO messages(patient_ID, message) VALUES (@patientID, @message)";
                                MySqlCommand cmd5 = new MySqlCommand(sql2, conn);
                                cmd5.Parameters.AddWithValue("@patientID", patient_ID);
                                cmd5.Parameters.AddWithValue("@message", "Order Placed. Wait for it to be approved.");
                                cmd5.ExecuteNonQuery();

                                MessageBox.Show("Medicine Ordered Successfully");
                                flag = true;
                                medicinename.Text = "Medicine Name";
                                medicinetype.Text = "Medicine Type";
                                quantity.Text = "Quantity";
                                LoadAllMedicines();
                                break;
                            }
                            else
                            {
                                MessageBox.Show("Not enough quantity");
                                flag = true;
                            }
                        }
                    }
                }
                if (!flag)
                {
                    MessageBox.Show("Medicine does not exist");
                }
            }
        }


        private void KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void LoadMedicineData()
        {
            using (MySqlConnection conn = new MySqlConnection(Class1.connstring))
            {
                conn.Open();

                String sql1 = "Select * from medicine where name=@name AND type=@type AND status = 'Exists'";
                using (MySqlCommand cmd1 = new MySqlCommand(sql1, conn))
                {
                    cmd1.Parameters.AddWithValue("@name", medicinename.Text);
                    cmd1.Parameters.AddWithValue("@type", medicinetype.Text);
                    using (MySqlDataReader reader1 = cmd1.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader1);
                        gunaDataGridView1.DataSource = dataTable;

                    }
                }
            }
        }

        private void LoadAllMedicines()
        {
            using (MySqlConnection conn = new MySqlConnection(Class1.connstring))
            {
                conn.Open();

                String sql1 = "Select * from medicine where status = 'Exists'";
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

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = gunaDataGridView1.Rows[e.RowIndex];

                medicinename.Text = selectedRow.Cells["name"].Value.ToString();
                medicinetype.Text = selectedRow.Cells["type"].Value.ToString();
            }
        }
    }
}
