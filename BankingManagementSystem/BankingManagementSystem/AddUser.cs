using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BankingManagementSystem
{
    public partial class AddUser : Form
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=NewDatabase;Integrated Security=True";

        public AddUser()
        {
            InitializeComponent();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void pswd_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bal_TextChanged(object sender, EventArgs e)
        {

        }

        public void LoadUsers()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Users", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

            }
        }

        public event EventHandler UserAddedSuccessfully;

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "INSERT INTO Users (Name, Email, Password, Balance, Role) VALUES (@Name, @Email, @Password, @Balance, 'User')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Name", name.Text);
                cmd.Parameters.AddWithValue("@Email", email.Text);
                cmd.Parameters.AddWithValue("@Password", pswd.Text);
                cmd.Parameters.AddWithValue("@Balance", Convert.ToDecimal(Bal.Text));

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("User added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close(); // ✅ this now works because it's a Form


        }
    }
}
