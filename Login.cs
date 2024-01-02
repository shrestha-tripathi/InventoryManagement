using System.Data;
using System.Text;
using System.Security.Cryptography;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace InventoryManagement
{
    public partial class login : Form
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["DBConnectionStringMySQL"].ConnectionString;
        MySqlConnection conn = new MySqlConnection(connectionString);
        public login()
        {
            InitializeComponent();
        }

        /*
        private void button1_Click_1(object sender, EventArgs e)
        {
            int i = 0;
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from registration where username = '" + textBox1.Text + "' and password = '" + textBox2.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());
            if (i == 0)
            {
                MessageBox.Show("Username or Password is Incorrect!");
            }
            else
            {
                this.Hide();
                MDIParent1 mdi = new MDIParent1();
                mdi.Show();
            }

        }
        */

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password + "shrestha"));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashedBytes.Length; i++)
                {
                    builder.Append(hashedBytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Int64 i = 0;
            string Query = "select count(*) from registration where username = @username and password = @password";
            
            
            try
            {
                MySqlCommand cmd = new MySqlCommand(Query, conn);
                cmd.Parameters.AddWithValue("@username", textBox1.Text.ToString());
                cmd.Parameters.AddWithValue("@password", HashPassword(textBox2.Text.ToString()));
                i = (Int64)cmd.ExecuteScalar();
            }
            catch (MySqlException ex)
            {
                // Handle exceptions
                // Example: Log the exception
                Console.WriteLine("SQL Error: " + ex.Message);
            }
            if (i == 0)
            {
                MessageBox.Show("Username or Password is Incorrect!");
            }
            else
            {
                if (textBox1.Text.ToString() == "admin")
                {
                    this.Hide();
                    MDIParent1 mdi = new MDIParent1();
                    mdi.Show();
                }
                else
                {
                    this.Hide();
                    MDIParent2 mdi = new MDIParent2();
                    mdi.Show();
                }
                
            }

        }

        private void login_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}