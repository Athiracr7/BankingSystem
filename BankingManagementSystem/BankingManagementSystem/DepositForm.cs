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
    public partial class DepositForm : Form
    {

        private int userId;

        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=NewDatabase;Integrated Security=True";

        public DepositForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btndeposit_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtamount.Text, out decimal amount) && amount > 0)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlTransaction transaction = con.BeginTransaction();

                    try
                    {
                        // ✅ Step 1: Get AccountID using UserID
                        SqlCommand getAccCmd = new SqlCommand(
                            "SELECT AccountID FROM Accounts WHERE UserID = @UserID", con, transaction);
                        getAccCmd.Parameters.AddWithValue("@UserID", userId);

                        object accResult = getAccCmd.ExecuteScalar();

                        if (accResult == null)
                            throw new Exception("Account not found for this user.");

                        int accountId = Convert.ToInt32(accResult);

                        // ✅ Step 2: Update Balance in Accounts
                        SqlCommand updateBalanceCmd = new SqlCommand(
                            "UPDATE Accounts SET Balance = Balance + @Amount WHERE AccountID = @AccountID",
                            con, transaction);
                        updateBalanceCmd.Parameters.AddWithValue("@Amount", amount);
                        updateBalanceCmd.Parameters.AddWithValue("@AccountID", accountId);
                        updateBalanceCmd.ExecuteNonQuery();

                        // ✅ Step 3: Insert transaction record in Transactions table
                        SqlCommand logTransactionCmd = new SqlCommand(
                            @"INSERT INTO Transactions (AccountID, TransactionType, Amount, TransactionDate)
                      VALUES (@AccountID, 'Deposit', @Amount, GETDATE())",
                            con, transaction);
                        logTransactionCmd.Parameters.AddWithValue("@AccountID", accountId);
                        logTransactionCmd.Parameters.AddWithValue("@Amount", amount);
                        logTransactionCmd.ExecuteNonQuery();

                        transaction.Commit();
                        MessageBox.Show("Deposit successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Deposit failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid amount.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
