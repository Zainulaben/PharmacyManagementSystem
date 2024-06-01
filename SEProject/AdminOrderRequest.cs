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
    public partial class AdminOrderRequest : Form
    {
        public AdminOrderRequest()
        {
            InitializeComponent();
            LoadOrdersData("null");
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminPatient().Show();
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

        private void show_Click(object sender, EventArgs e)
        {
            if(ordertype.Text=="Order Type")
            {
                MessageBox.Show("Invalid Order Type");
            }
            else
            {
                LoadOrdersData(ordertype.Text);
            }
        }

        private void LoadOrdersData(string order_type)
        {
            using (MySqlConnection conn = new MySqlConnection(Class1.connstring))
            {
                conn.Open();

                String sql1 = "Select * from order_table";
                if (order_type != "null")
                {
                    sql1 = "Select * from order_table where status=@status";
                }
                using (MySqlCommand cmd1 = new MySqlCommand(sql1, conn))
                {
                    if (order_type != "null")
                    {
                        cmd1.Parameters.AddWithValue("@status", order_type);
                    }

                    using (MySqlDataReader reader1 = cmd1.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader1);
                        gunaDataGridView1.DataSource = dataTable;
                    }
                }
            }
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex == 3)
            {
                object cellValue = gunaDataGridView1.Rows[e.RowIndex].Cells[3].Value;
                if (cellValue != null && cellValue.ToString() == "Pending")
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                    var buttonBounds = new Rectangle(e.CellBounds.X + 2, e.CellBounds.Y + 2, e.CellBounds.Width - 4, e.CellBounds.Height - 4);
                    ControlPaint.DrawButton(e.Graphics, buttonBounds, ButtonState.Normal);
                    TextRenderer.DrawText(e.Graphics, "Approve", e.CellStyle.Font, buttonBounds, e.CellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter);

                    e.Handled = true;
                }
            }
        }

        private void gunaDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.RowIndex >= 0)
            {
                if (gunaDataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Pending")
                {
                    int ID = int.Parse(gunaDataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    int patient_ID = int.Parse(gunaDataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                    using (MySqlConnection conn = new MySqlConnection(Class1.connstring))
                    {
                        conn.Open();
                        String sql2 = "INSERT INTO messages(patient_ID, message) VALUES (@patientID, @message)";
                        MySqlCommand cmd5 = new MySqlCommand(sql2, conn);
                        cmd5.Parameters.AddWithValue("@patientID", patient_ID);
                        cmd5.Parameters.AddWithValue("@message", "Order Approved. Wait for it to be recieved.");
                        cmd5.ExecuteNonQuery();

                        string updateQuery = "UPDATE order_table SET status = @status WHERE ID = @orderId";
                        using (MySqlCommand cmd = new MySqlCommand(updateQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@status", "Approved");
                            cmd.Parameters.AddWithValue("@orderId", ID);

                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            LoadOrdersData("null");
        }
    }
}
