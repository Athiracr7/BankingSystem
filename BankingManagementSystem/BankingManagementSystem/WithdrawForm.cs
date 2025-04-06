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
    public partial class WithdrawForm : Form
    {

        private int userId;
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=NewDatabase;Integrated Security=True";

        public WithdrawForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtamount.Text, out decimal amount) && amount > 0)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlTransaction transaction = con.BeginTransaction();

                    try
                    {
                        // ✅ Step 1: Get AccountID and current Balance
                        SqlCommand getAccCmd = new SqlCommand(
                            "SELECT AccountID, Balance FROM Accounts WHERE UserID = @UserID", con, transaction);
                        getAccCmd.Parameters.AddWithValue("@UserID", userId);

                        SqlDataReader reader = getAccCmd.ExecuteReader();

                        if (!reader.Read())
                            throw new Exception("Account not found.");

                        int accountId = Convert.ToInt32(reader["AccountID"]);
                        decimal currentBalance = Convert.ToDecimal(reader["Balance"]);
                        reader.Close();

                        // 🚫 Step 2: Check if balance is enough
                        if (currentBalance < amount)
                            throw new Exception("Insufficient balance.");

                        // ✅ Step 3: Subtract from balance
                        SqlCommand updateCmd = new SqlCommand(
                            "UPDATE Accounts SET Balance = Balance - @Amount WHERE AccountID = @AccountID", con, transaction);
                        updateCmd.Parameters.AddWithValue("@Amount", amount);
                        updateCmd.Parameters.AddWithValue("@AccountID", accountId);
                        updateCmd.ExecuteNonQuery();

                        // ✅ Step 4: Log transaction
                        SqlCommand logCmd = new SqlCommand(
                            @"INSERT INTO Transactions (AccountID, TransactionType, Amount, TransactionDate)
                      VALUES (@AccountID, 'Withdraw', @Amount, GETDATE())", con, transaction);
                        logCmd.Parameters.AddWithValue("@AccountID", accountId);
                        logCmd.Parameters.AddWithValue("@Amount", amount);
                        logCmd.ExecuteNonQuery();

                        transaction.Commit();
                        MessageBox.Show("Withdrawal successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Withdrawal failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
