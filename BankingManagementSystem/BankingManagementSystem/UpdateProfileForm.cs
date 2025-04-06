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
    public partial class UpdateProfileForm : Form
    {
        private int userId;
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=NewDatabase;Integrated Security=True";

        public UpdateProfileForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            LoadUserInfo();
        }


        private void LoadUserInfo()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT FullName, Email, PhoneNumber FROM Accounts WHERE UserID = @UserID", con);
                cmd.Parameters.AddWithValue("@UserID", userId);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtname.Text = reader["FullName"]?.ToString();
                    txtemail.Text = reader["Email"]?.ToString();
                    txtpswd.Text = reader["PhoneNumber"]?.ToString();
                }
                else
                {
                    MessageBox.Show("User account not found.");
                }

                reader.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string Name = txtname.Text.Trim();
            string email = txtemail.Text.Trim();
            string phn = txtpswd.Text.Trim();

            if (string.IsNullOrWhiteSpace(Name) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Full name and Email cannot be empty.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(
                    @"UPDATE Accounts 
              SET FullName = @FullName, Email = @Email, PhoneNumber = @PhoneNumber 
              WHERE UserID = @UserID", con);

                cmd.Parameters.AddWithValue("@FullName", Name);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@PhoneNumber", phn);
                cmd.Parameters.AddWithValue("@UserID", userId);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Information updated successfully!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to update. Try again.");
                }
            }
        }
    }
}
