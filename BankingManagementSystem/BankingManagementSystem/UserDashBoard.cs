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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BankingManagementSystem
{
    public partial class UserDashBoard : Form
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=NewDatabase;Integrated Security=True";


        private int loggedInUserId;
        public UserDashBoard(int userId)
        {
            InitializeComponent();
            loggedInUserId = userId;
        }

        //******************** WithDraw Form button **************************\\
        private void button2_Click(object sender, EventArgs e)
        {
            WithdrawForm withdrawForm = new WithdrawForm(loggedInUserId);
            withdrawForm.ShowDialog();
        }

        //*************************************************************************\\




        //**************************** Deposit Form Button ************************\\
        private void btndepositonclk_Click(object sender, EventArgs e)
        {
            DepositForm depositForm = new DepositForm(loggedInUserId);
            depositForm.ShowDialog();
        }

        //***************************************************************************\\




        //********************************* Account details ****************************\\

        private void btnacdtl_Click(object sender, EventArgs e)
        {
            ViewAccountDetailsForm accountForm = new ViewAccountDetailsForm(loggedInUserId);
            accountForm.ShowDialog();
        }
        
        //********************************************************************************************\\



        // *************************************** Transfer Moneyy  Form *********************************\\
        private void btntfronclk_Click(object sender, EventArgs e)
        {
            TransferForm transferForm = new TransferForm(loggedInUserId);
            transferForm.ShowDialog();
        }
    
        //********************************************************************************************\\

        private void btntranhisonclk_Click(object sender, EventArgs e)
        {
            TransactionHistoryForm form = new TransactionHistoryForm(loggedInUserId); // pass it here!
            form.ShowDialog();
        }

        private void btnupdateonclk_Click(object sender, EventArgs e)
        {
            UpdateProfileForm form = new UpdateProfileForm(loggedInUserId); // pass it in
            form.ShowDialog();
        }
    }
}
