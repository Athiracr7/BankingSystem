namespace BankingManagementSystem
{
    partial class UserDashBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnacdtl = new Button();
            btndepositonclk = new Button();
            btnwithdrawonclk = new Button();
            btntfronclk = new Button();
            btntranhisonclk = new Button();
            btnupdateonclk = new Button();
            SuspendLayout();
            // 
            // btnacdtl
            // 
            btnacdtl.BackColor = Color.DarkOrange;
            btnacdtl.Location = new Point(12, 110);
            btnacdtl.Name = "btnacdtl";
            btnacdtl.Size = new Size(206, 139);
            btnacdtl.TabIndex = 0;
            btnacdtl.Text = "View Account Details";
            btnacdtl.UseVisualStyleBackColor = false;
            btnacdtl.Click += btnacdtl_Click;
            // 
            // btndepositonclk
            // 
            btndepositonclk.BackColor = Color.DarkOrange;
            btndepositonclk.Location = new Point(297, 110);
            btndepositonclk.Name = "btndepositonclk";
            btndepositonclk.Size = new Size(206, 139);
            btndepositonclk.TabIndex = 1;
            btndepositonclk.Text = "Deposit Money";
            btndepositonclk.UseVisualStyleBackColor = false;
            btndepositonclk.Click += btndepositonclk_Click;
            // 
            // btnwithdrawonclk
            // 
            btnwithdrawonclk.BackColor = Color.DarkOrange;
            btnwithdrawonclk.Cursor = Cursors.SizeNS;
            btnwithdrawonclk.Location = new Point(582, 110);
            btnwithdrawonclk.Name = "btnwithdrawonclk";
            btnwithdrawonclk.Size = new Size(206, 139);
            btnwithdrawonclk.TabIndex = 2;
            btnwithdrawonclk.Text = "Withdraw Money\n\n";
            btnwithdrawonclk.UseVisualStyleBackColor = false;
            btnwithdrawonclk.Click += button2_Click;
            // 
            // btntfronclk
            // 
            btntfronclk.BackColor = Color.DarkOrange;
            btntfronclk.Location = new Point(12, 255);
            btntfronclk.Name = "btntfronclk";
            btntfronclk.Size = new Size(206, 139);
            btntfronclk.TabIndex = 3;
            btntfronclk.Text = "Transfer Money";
            btntfronclk.UseVisualStyleBackColor = false;
            btntfronclk.Click += btntfronclk_Click;
            // 
            // btntranhisonclk
            // 
            btntranhisonclk.BackColor = Color.DarkOrange;
            btntranhisonclk.Location = new Point(297, 255);
            btntranhisonclk.Name = "btntranhisonclk";
            btntranhisonclk.Size = new Size(206, 139);
            btntranhisonclk.TabIndex = 4;
            btntranhisonclk.Text = "View Transaction History";
            btntranhisonclk.UseVisualStyleBackColor = false;
            btntranhisonclk.Click += btntranhisonclk_Click;
            // 
            // btnupdateonclk
            // 
            btnupdateonclk.BackColor = Color.DarkOrange;
            btnupdateonclk.Location = new Point(582, 255);
            btnupdateonclk.Name = "btnupdateonclk";
            btnupdateonclk.Size = new Size(206, 139);
            btnupdateonclk.TabIndex = 5;
            btnupdateonclk.Text = "Update Personal Details";
            btnupdateonclk.UseVisualStyleBackColor = false;
            btnupdateonclk.Click += btnupdateonclk_Click;
            // 
            // UserDashBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(btnupdateonclk);
            Controls.Add(btntranhisonclk);
            Controls.Add(btntfronclk);
            Controls.Add(btnwithdrawonclk);
            Controls.Add(btndepositonclk);
            Controls.Add(btnacdtl);
            Name = "UserDashBoard";
            Text = "UserDashBoard";
            ResumeLayout(false);
        }

        #endregion

        private Button btnacdtl;
        private Button btndepositonclk;
        private Button btnwithdrawonclk;
        private Button btntfronclk;
        private Button btntranhisonclk;
        private Button btnupdateonclk;
    }
}