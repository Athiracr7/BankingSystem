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
    public partial class DeleteUser : Form
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=NewDatabase;Integrated Security=True";

        public DeleteUser()
        {
            InitializeComponent();
        }

        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserId.Text))
            {
                MessageBox.Show("Please enter a User ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int userId;
            if (!int.TryParse(txtUserId.Text, out userId))
            {
                MessageBox.Show("Invalid User ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT Name, Email, Balance FROM Users WHERE UserID = @UserID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@UserID", userId);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lblName.Text = "Name: " + reader["Name"].ToString();
                    lblEmail.Text = "Email: " + reader["Email"].ToString();
                    lblBalance.Text = "Balance: $" + reader["Balance"].ToString();
                }
                else
                {
                    MessageBox.Show("User not found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblName.Text = lblEmail.Text = lblBalance.Text = "";
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btndlt_Click(object sender, EventArgs e)
        {
            int userId;
            if (!int.TryParse(txtUserId.Text, out userId))
            {
                MessageBox.Show("Please enter a valid User ID first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this user?",
                                          "Confirm Delete",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Users WHERE UserID = @UserID", con);
                    cmd.Parameters.AddWithValue("@UserID", userId);
                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("User deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lblName.Text = lblEmail.Text = lblBalance.Text = "";
                        txtUserId.Text = "";

                    }
                    else
                    {
                        MessageBox.Show("User not found or already deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtUserId.Text, out int userId))
            {
                MessageBox.Show("Enter a valid User ID.");
                return;
            }

            if (string.IsNullOrWhiteSpace(lblName.Text) ||
                string.IsNullOrWhiteSpace(lblEmail.Text) ||
                string.IsNullOrWhiteSpace(lblBalance.Text))
            {
                MessageBox.Show("All fields are required.");
                return;
            }

            if (!decimal.TryParse(lblBalance.Text, out decimal balance))
            {
                MessageBox.Show("Enter a valid balance amount.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string updateQuery = "UPDATE Users SET Name = @Name, Email = @Email, Balance = @Balance WHERE UserID = @UserID";
                SqlCommand cmd = new SqlCommand(updateQuery, con);
                cmd.Parameters.AddWithValue("@Name", lblName.Text);
                cmd.Parameters.AddWithValue("@Email", lblEmail.Text);
                cmd.Parameters.AddWithValue("@Balance", balance);
                cmd.Parameters.AddWithValue("@UserID", userId);

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("User updated successfully!");
                    //LoadUsers(); // Optional refresh
                }
                else
                {
                    MessageBox.Show("Update failed.");
                }
            }
        }
    }
}
