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

namespace BankingManagementSystem
{
    public partial class LoginForm : Form
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=NewDatabase;Integrated Security=True";
        public LoginForm()
        {
            InitializeComponent();
            this.Load += LoginForm_Load;
            this.Resize += LoginForm_Resize;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            CenterLoginPanel();
        }

        private void LoginForm_Resize(object sender, EventArgs e)
        {
            CenterLoginPanel();
        }

        private void CenterLoginPanel()
        {
            LoginPanel.Left = (this.ClientSize.Width - LoginPanel.Width) / 2;
            LoginPanel.Top = (this.ClientSize.Height - LoginPanel.Height) / 2;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT UserID, Role FROM Users WHERE Email=@username AND Password=@password";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@username", txtusername.Text);
                cmd.Parameters.AddWithValue("@password", txtpswd.Text);  // Password hashing recommended

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    int userIdFromLogin = Convert.ToInt32(reader["UserID"]);
                    string role = reader["Role"].ToString();

                    if (role == "Admin")
                    {
                        AdminDashboard adminForm = new AdminDashboard();
                        adminForm.Show();
                    }
                    else
                    {
                        UserDashBoard userForm = new UserDashBoard(userIdFromLogin);
                        userForm.Show();
                    }
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Email or Password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }   
    }
}
