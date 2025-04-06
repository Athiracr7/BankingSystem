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
    public partial class ViewTransactions : Form
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=NewDatabase;Integrated Security=True";

        public ViewTransactions()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ViewTransactions_Load(object sender, EventArgs e)
        {
            LoadAllTransactions();
        }

        private void LoadAllTransactions()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Transactions ORDER BY TransactionDate DESC", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(search.Text, out int userId))
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Transactions t join Accounts a on t.AccountID = a.AccountID WHERE a.UserID = @UserID ORDER BY TransactionDate DESC", con);
                    da.SelectCommand.Parameters.AddWithValue("@UserID", userId);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid User ID.");
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            search.Clear();
            LoadAllTransactions();
        }
    }
}
