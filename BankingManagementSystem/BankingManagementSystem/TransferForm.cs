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
using Microsoft.VisualBasic.ApplicationServices;

namespace BankingManagementSystem
{
    public partial class TransferForm : Form
    {
        private int userId;
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=NewDatabase;Integrated Security=True";

        public TransferForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            string recipientAccNo = txtRecipientAccNo.Text.Trim();

            if (!decimal.TryParse(txtAmount.Text, out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Enter a valid amount.");
                return;
            }

            if (string.IsNullOrWhiteSpace(recipientAccNo))
            {
                MessageBox.Show("Enter recipient's account number.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlTransaction transaction = con.BeginTransaction();

                try
                {
                    // 🔍 Step 1: Get sender's account ID and balance
                    SqlCommand getSenderCmd = new SqlCommand(
                        "SELECT AccountID, Balance FROM Accounts WHERE UserID = @UserID", con, transaction);
                    getSenderCmd.Parameters.AddWithValue("@UserID", userId);

                    SqlDataReader reader = getSenderCmd.ExecuteReader();

                    if (!reader.Read())
                        throw new Exception("Your account not found.");

                    int senderAccountId = Convert.ToInt32(reader["AccountID"]);
                    decimal senderBalance = Convert.ToDecimal(reader["Balance"]);
                    reader.Close();

                    // ❌ Check balance
                    if (senderBalance < amount)
                        throw new Exception("Insufficient balance.");

                    // 🔍 Step 2: Get recipient's AccountID
                    SqlCommand getRecipientCmd = new SqlCommand(
                        "SELECT AccountID FROM Accounts WHERE AccountNumber = @AccNo", con, transaction);
                    getRecipientCmd.Parameters.AddWithValue("@AccNo", recipientAccNo);

                    object recResult = getRecipientCmd.ExecuteScalar();

                    if (recResult == null)
                        throw new Exception("Recipient account not found.");

                    int recipientAccountId = Convert.ToInt32(recResult);

                    // 👥 Step 3: Perform transfer
                    // ➖ Deduct from sender
                    SqlCommand deductCmd = new SqlCommand(
                        "UPDATE Accounts SET Balance = Balance - @Amount WHERE AccountID = @SenderID", con, transaction);
                    deductCmd.Parameters.AddWithValue("@Amount", amount);
                    deductCmd.Parameters.AddWithValue("@SenderID", senderAccountId);
                    deductCmd.ExecuteNonQuery();

                    // ➕ Add to recipient
                    SqlCommand creditCmd = new SqlCommand(
                        "UPDATE Accounts SET Balance = Balance + @Amount WHERE AccountID = @RecipientID", con, transaction);
                    creditCmd.Parameters.AddWithValue("@Amount", amount);
                    creditCmd.Parameters.AddWithValue("@RecipientID", recipientAccountId);
                    creditCmd.ExecuteNonQuery();

                    // 📝 Step 4: Log transaction
                    SqlCommand logTransferCmd = new SqlCommand(
                        @"INSERT INTO Transactions (AccountID, TransactionType, Amount, TransactionDate, RecipientAccount)
                  VALUES (@SenderID, 'Transfer', @Amount, GETDATE(), @RecipientAccNo)",
                        con, transaction);
                    logTransferCmd.Parameters.AddWithValue("@SenderID", senderAccountId);
                    logTransferCmd.Parameters.AddWithValue("@Amount", amount);
                    logTransferCmd.Parameters.AddWithValue("@RecipientAccNo", recipientAccNo);
                    logTransferCmd.ExecuteNonQuery();

                    transaction.Commit();
                    MessageBox.Show("Transfer successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Transfer failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
