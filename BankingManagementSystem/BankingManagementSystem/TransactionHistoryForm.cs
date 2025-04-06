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
    public partial class TransactionHistoryForm : Form
    {
        private int userId;
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=NewDatabase;Integrated Security=True";

        public TransactionHistoryForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            LoadTransactionHistory();
        }

        private void LoadTransactionHistory()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // Step 1: Get AccountID from UserID
                SqlCommand getAccCmd = new SqlCommand(
                    "SELECT AccountID FROM Accounts WHERE UserID = @UserID", con);
                getAccCmd.Parameters.AddWithValue("@UserID", userId);

                object accIdObj = getAccCmd.ExecuteScalar();

                if (accIdObj == null)
                {
                    MessageBox.Show("No account found for this user.");
                    return;
                }

                int accountId = Convert.ToInt32(accIdObj);

                // Step 2: Get all transactions for that account
                SqlCommand getTxnCmd = new SqlCommand(
                    @"SELECT TransactionID, TransactionType, Amount, TransactionDate, RecipientAccount
              FROM Transactions
              WHERE AccountID = @AccountID
              ORDER BY TransactionDate DESC", con);
                getTxnCmd.Parameters.AddWithValue("@AccountID", accountId);

                SqlDataAdapter adapter = new SqlDataAdapter(getTxnCmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvTransactions.DataSource = dt;
            }
        }

    }
}
