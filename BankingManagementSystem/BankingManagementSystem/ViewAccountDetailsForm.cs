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
    public partial class ViewAccountDetailsForm : Form
    {
        private int userId;
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=NewDatabase;Integrated Security=True";

        public ViewAccountDetailsForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            LoadAccountDetails();
        }

        private void LoadAccountDetails()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = @"SELECT FullName, Email, AccountNumber, Balance, PhoneNumber 
                             FROM Accounts 
                             WHERE UserID = @UserID";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@UserID", userId);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtname.Text = reader["FullName"].ToString();
                    txtemail.Text = reader["Email"].ToString();
                    txtaccnum.Text = reader["AccountNumber"].ToString();
                    txtbal.Text = reader["Balance"].ToString();
                    txtphn.Text = reader["PhoneNumber"].ToString();
                }
                else
                {
                    MessageBox.Show("Account not found.");
                }
            }
        }
    }
}
