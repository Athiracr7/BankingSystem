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
    public partial class AdminDashboard : Form
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=NewDatabase;Integrated Security=True";

        public AdminDashboard()
        {
            InitializeComponent();

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

        private void LoadTransactions()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Transactions", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AddUser addUserForm = new AddUser();
            addUserForm.ShowDialog(); // This pauses the current form until AddUser is closed

            //LoadUsers();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // You can update this later to open your report form
            MessageBox.Show("No Report To Show!!!");
        }


        //private void btndtuser_Click(object sender, EventArgs e)
        //{
        //    int userId = Convert.ToInt32(txtUserId.Text);
        //    using (SqlConnection con = new SqlConnection(connectionString))
        //    {
        //        con.Open();
        //        SqlCommand cmd = new SqlCommand("DELETE FROM Users WHERE UserID = @UserID", con);
        //        cmd.Parameters.AddWithValue("@UserID", userId);
        //        cmd.ExecuteNonQuery();
        //        LoadUsers();
        //    }
        //}

        private void btneduser_Click(object sender, EventArgs e)
        {
            DeleteUser dltUserForm = new DeleteUser();
            dltUserForm.ShowDialog();
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            ViewTransactions viewForm = new ViewTransactions(); // could also be a UserControl
            viewForm.Show();
        }
    }
}
