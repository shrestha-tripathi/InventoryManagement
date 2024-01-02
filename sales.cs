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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Configuration;

namespace InventoryManagement
{
    public partial class sales : Form
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["DBConnectionStringMySQL"].ConnectionString;
        MySqlConnection conn = new MySqlConnection(connectionString);

        DataTable datTab = new DataTable();

        int total = 0;

        public sales()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void sales_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            datTab.Clear();
            datTab.Columns.Add("Product");
            datTab.Columns.Add("Price");
            datTab.Columns.Add("Quantity");
            datTab.Columns.Add("Total");

        }

        private void textBox3_KeyUp(object sender, KeyEventArgs e)
        {
            listBox1.Visible = true;

            listBox1.Items.Clear();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from stock where product_name like('" + textBox3.Text + "%')";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                listBox1.Items.Add(dr["product_name"].ToString());
            }

        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                listBox1.Focus();
                listBox1.SelectedIndex = 0;
            }
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                this.listBox1.SelectedIndex = this.listBox1.SelectedIndex + 1;

            }
            if (e.KeyCode == Keys.Up)
            {
                this.listBox1.SelectedIndex = this.listBox1.SelectedIndex - 1;

            }
            if (e.KeyCode == Keys.Enter)
            {
                textBox3.Text = listBox1.SelectedItem.ToString();
                listBox1.Visible = false;
                textBox4.Focus();

            }

        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select top 1 * from purchase_master where product_name='" + textBox3.Text + "' order by id desc";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                textBox4.Text = dr["product_price"].ToString();
            }

        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            try
            {
                textBox6.Text = Convert.ToString(Convert.ToInt32(textBox4.Text) * Convert.ToInt32(textBox5.Text));
            }
            catch (Exception ex)
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int stock = 0;

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from stock where product_name='" + textBox3.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                stock = Convert.ToInt32(dr["product_qty"].ToString());
            }

            if (Convert.ToInt32(textBox5.Text) > stock)
            {
                MessageBox.Show("This much quantity is not available in the stock!");
            }
            else
            {
                DataRow dr = datTab.NewRow();
                dr["Product"] = textBox3.Text;
                dr["Price"] = textBox4.Text;
                dr["Quantity"] = textBox5.Text;
                dr["Total"] = textBox6.Text;
                datTab.Rows.Add(dr);
                dataGridView1.DataSource = datTab;

                total = total + Convert.ToInt32(dr["Total"].ToString());

                label10.Text = Convert.ToString(total);

            }

            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                total = 0;
                datTab.Rows.RemoveAt(Convert.ToInt32(dataGridView1.CurrentCell.RowIndex.ToString()));

                foreach (DataRow dr in datTab.Rows)
                {
                    total = total + Convert.ToInt32(dr["Total"].ToString());
                }
                label10.Text = Convert.ToString(total);
            }
            catch (Exception ex)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string orderId = "";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into order_user (firstname, lastname, billtype, purchase_date) values('" + textBox1.Text + "', '" + textBox2.Text + "', '" + comboBox1.Text + "', '" + dateTimePicker1.Value.ToString("dd/mm/yyyy") + "')";
            cmd.ExecuteNonQuery();

            MySqlCommand cmd2 = conn.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select top 1 * from order_user order by id desc";
            cmd2.ExecuteNonQuery();

            DataTable dt2 = new DataTable();
            MySqlDataAdapter da2 = new MySqlDataAdapter(cmd2);
            da2.Fill(dt2);
            foreach (DataRow dr in dt2.Rows)
            {
                orderId = dr["id"].ToString();
            }


            foreach (DataRow dr in datTab.Rows)
            {
                int qty = 0;
                string pname = "";

                MySqlCommand cmd3 = conn.CreateCommand();
                cmd3.CommandType = CommandType.Text;
                cmd3.CommandText = "insert into order_item (order_id, product, price, qty, total) values('" + orderId.ToString() + "', '" + dr["Product"].ToString() + "', '" + dr["Price"].ToString() + "', '" + dr["Quantity"].ToString() + "', '" + dr["Total"].ToString() + "')";
                cmd3.ExecuteNonQuery();

                qty = Convert.ToInt32(dr["Quantity"].ToString());
                pname = dr["Product"].ToString();

                MySqlCommand cmd4 = conn.CreateCommand();
                cmd4.CommandType = CommandType.Text;
                cmd4.CommandText = "update stock set product_qty=product_qty-" + qty + " where product_name='" + pname.ToString() + "'";
                cmd4.ExecuteNonQuery();
            }

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            label10.Text = "0";

            datTab.Clear();
            dataGridView1.DataSource = datTab;

            MessageBox.Show("Record inserted successfully!");

        }
    }
}
