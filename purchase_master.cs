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
using System.Configuration;

namespace InventoryManagement
{
    public partial class purchase_master : Form
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["DBConnectionStringMySQL"].ConnectionString;
        MySqlConnection conn = new MySqlConnection(connectionString);

        public purchase_master()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void purchase_master_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            fill_product_name();
            fill_dealer_name();

        }

        public void fill_product_name()
        {
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from product_names";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr["product_name"].ToString());
            }


        }

        public void fill_dealer_name()
        {
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from dealer_info";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox2.Items.Add(dr["dealer_name"].ToString());
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from product_names where product_name='" + comboBox1.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                label3.Text = dr["units"].ToString();
            }


        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            MySqlCommand cmd1 = conn.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select * from stock where product_name='" + comboBox1.Text + "'";
            cmd1.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd1);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());

            if (i == 0)
            {
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into purchase_master (product_name, product_qty, product_unit, product_price, product_total, purchase_date, purchase_party_name, purchase_type, expiry_date, profit) values('" + comboBox1.Text + "', '" + textBox1.Text + "', '" + label3.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + dateTimePicker1.Value.ToString("dd-MM-yyyy") + "', '" + comboBox2.Text + "', '" + comboBox3.Text + "', '" + dateTimePicker2.Value.ToString("dd-MM-yyyy") + "', '" + textBox4.Text + "')";
                cmd.ExecuteNonQuery();

                MySqlCommand cmd2 = conn.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "insert into stock (product_name, product_qty, product_unit) values('" + comboBox1.Text + "', '" + textBox1.Text + "', '" + label3.Text + "')";
                cmd2.ExecuteNonQuery();

            }
            else
            {
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into purchase_master (product_name, product_qty, product_unit, product_price, product_total, purchase_date, purchase_party_name, purchase_type, expiry_date, profit) values('" + comboBox1.Text + "', '" + textBox1.Text + "', '" + label3.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + dateTimePicker1.Value.ToString("dd-MM-yyyy") + "', '" + comboBox2.Text + "', '" + comboBox3.Text + "', '" + dateTimePicker2.Value.ToString("dd-MM-yyyy") + "', '" + textBox4.Text + "')";
                cmd.ExecuteNonQuery();

                MySqlCommand cmd2 = conn.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "update stock set product_qty=product_qty + '" + textBox1.Text + "' where product_name='" + comboBox1.Text + "' ";
                cmd2.ExecuteNonQuery();

            }




            MessageBox.Show("Purchase done successfully!");

        }
    }
}
