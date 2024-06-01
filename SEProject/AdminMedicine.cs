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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SEProject
{
    public partial class AdminMedicine : Form
    {
        public AdminMedicine()
        {
            InitializeComponent();
            LoadMedicineData();
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

        private void AdminMedicine_Load(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(Class1.connstring);
            conn.ConnectionString = Class1.connstring;
            conn.Open();

            if (medicinename.Text == "" || medicinetype.Text == "" || quantity.Text == "" || price.Text=="")
            {
                MessageBox.Show("Fill All Fields");
            }
            else if (medicinename.Text == "Medicine Name")
            {
                MessageBox.Show("Invalid medicine name");
            }
            else if (medicinetype.Text == "Medicine Type")
            {
                MessageBox.Show("Invalid medicine type");
            }
            else if (quantity.Text == "Quantity" || !int.TryParse(quantity.Text, out _))
            {
                MessageBox.Show("Invalid quantity");
            }
            else if (price.Text == "Price" || !int.TryParse(price.Text, out _))
            {
                MessageBox.Show("Invalid Price");
            }
            else
            {
                bool flag = true;
                string sql = "Select * from medicine where status='Exists'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["name"].ToString() == medicinename.Text)
                    {
                        MessageBox.Show("Medicine Name Already Exists");
                        flag = false;
                        break;
                    }
                }

                reader.Close();

                if (flag)
                {
                    sql = "Insert into medicine(name,type,quantity,price,status) values (@name,@type,@quantity,@price,@status)";
                    cmd = new MySqlCommand(sql, conn);

                    IDbDataParameter name1 = cmd.CreateParameter();
                    name1.ParameterName = "@name";
                    name1.Value = medicinename.Text;
                    cmd.Parameters.Add(name1);

                    IDbDataParameter type1 = cmd.CreateParameter();
                    type1.ParameterName = "@type";
                    type1.Value = medicinetype.Text;
                    cmd.Parameters.Add(type1);

                    IDbDataParameter quantity1 = cmd.CreateParameter();
                    quantity1.ParameterName = "@quantity";
                    quantity1.Value = int.Parse(quantity.Text.ToString());
                    cmd.Parameters.Add(quantity1);

                    IDbDataParameter price1 = cmd.CreateParameter();
                    price1.ParameterName = "@price";
                    price1.Value = int.Parse(price.Text.ToString());
                    cmd.Parameters.Add(price1);

                    IDbDataParameter status1 = cmd.CreateParameter();
                    status1.ParameterName = "@status";
                    status1.Value = "Exists";
                    cmd.Parameters.Add(status1);
                    cmd.ExecuteReader();

                    MessageBox.Show("Medicine added successfully");
                    medicinename.Text = "Medicine Name";
                    medicinetype.Text = "Medicine Type";
                    quantity.Text = "Quantity";
                    price.Text = "Price";
                }

            }

            LoadMedicineData();
            conn.Close();
        }

        private void LoadMedicineData()
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

        private void delete_Click(object sender, EventArgs e)
        {
            if (medicinename.Text == "")
            {
                MessageBox.Show("Enter medicine name");
            }
            else
            {
                bool flag = false;
                if (medicinetype.Text == "" || quantity.Text == "" || price.Text == "")
                {
                    using (MySqlConnection conn = new MySqlConnection(Class1.connstring))
                    {
                        conn.Open();
                        string sql = "UPDATE medicine SET status = 'Deleted' WHERE name = @name AND status = 'Exists'";
                        using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@name", medicinename.Text);

                            try
                            {
                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Data deleted successfully.");
                                    medicinename.Text = "Medicine Name";
                                    medicinetype.Text = "Medicine Type";
                                    quantity.Text = "Quantity";
                                    price.Text = "Price";
                                    UpdateOrderStatusForDeletedMedicine(medicinename.Text);
                                    LoadMedicineData();
                                    flag = true;
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error deleting data: " + ex.Message);
                            }
                        }
                    }
                }
                else
                {
                    using (MySqlConnection conn = new MySqlConnection(Class1.connstring))
                    {
                        conn.Open();
                        string sql = "UPDATE medicine SET status = 'Deleted' WHERE name = @name AND type=@type AND quantity=@quantity AND price=@price AND status='Exists'";
                        using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@name", medicinename.Text);
                            cmd.Parameters.AddWithValue("@type", medicinetype.Text);
                            cmd.Parameters.AddWithValue("@quantity", int.Parse(quantity.Text));
                            cmd.Parameters.AddWithValue("@price", int.Parse(price.Text));

                            try
                            {
                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Data deleted successfully.");
                                    medicinename.Text = "Medicine Name";
                                    medicinetype.Text = "Medicine Type";
                                    quantity.Text = "Quantity";
                                    price.Text = "Price";
                                    UpdateOrderStatusForDeletedMedicine(medicinename.Text);
                                    LoadMedicineData();
                                    flag = true;
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error deleting data: " + ex.Message);
                            }
                        }
                    }
                }
                if (!flag)
                {
                    MessageBox.Show("Medicine does not exists");
                }
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if (medicinename.Text == "" || medicinetype.Text == "" || quantity.Text == "" || price.Text == "")
            {
                MessageBox.Show("Fill all fields");
            }
            else
            {
                MySqlConnection conn = new MySqlConnection(Class1.connstring);
                conn.ConnectionString = Class1.connstring;
                conn.Open();
                string sql = "Select * from medicine where status = 'Exists'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                bool flag = false;
                while (reader.Read())
                {
                    if (reader["name"].ToString() == medicinename.Text)
                    {
                        string updateQuery = "UPDATE medicine SET type = @type, price = @price,quantity= quantity + @quantity WHERE name=@name AND status = 'Exists'";

                        using (cmd = new MySqlCommand(updateQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@name", medicinename.Text);
                            cmd.Parameters.AddWithValue("@type", medicinetype.Text);
                            cmd.Parameters.AddWithValue("@quantity", int.Parse(quantity.Text));
                            cmd.Parameters.AddWithValue("@price", int.Parse(price.Text));
                            reader.Close();
                            cmd.ExecuteNonQuery();
                        }
                        flag = true;
                        MessageBox.Show("Medicine Edited Successfully");
                        LoadMedicineData();
                        break;
                    }

                }
                if (!flag)
                {
                    MessageBox.Show("Medicine does not exists");
                }
                
            }
        }

        private void UpdateOrderStatusForDeletedMedicine(string medicineName)
        {
            using (MySqlConnection conn = new MySqlConnection(Class1.connstring))
            {
                conn.Open();
                string updateOrderSql = "UPDATE order_table ot " +
                                        "JOIN medicine_order mo ON ot.ID = mo.Order_ID " +
                                        "JOIN medicine m ON mo.Medicine_ID = m.ID " +
                                        "SET ot.status = 'Cancelled' " +
                                        "WHERE m.name = @medicineName AND ot.status = 'Pending' AND ot.status = 'Approved'";
                using (MySqlCommand updateOrderCmd = new MySqlCommand(updateOrderSql, conn))
                {
                    updateOrderCmd.Parameters.AddWithValue("@medicineName", medicineName);
                    updateOrderCmd.ExecuteNonQuery();
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
                quantity.Text = selectedRow.Cells["quantity"].Value.ToString();
                price.Text = selectedRow.Cells["price"].Value.ToString();
            }
        }

        private void KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }

}
