namespace BankingManagementSystem
{
    partial class AdminDashboard
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
            groupBox1 = new GroupBox();
            btneduser = new Button();
            btnadduser = new Button();
            groupBox2 = new GroupBox();
            btnreport = new Button();
            btnview = new Button();
            Admindash = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btneduser);
            groupBox1.Controls.Add(btnadduser);
            groupBox1.ForeColor = SystemColors.Control;
            groupBox1.Location = new Point(12, 139);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(352, 222);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "User Management";
            // 
            // btneduser
            // 
            btneduser.BackColor = Color.DarkOrange;
            btneduser.ForeColor = SystemColors.ActiveCaptionText;
            btneduser.Location = new Point(96, 125);
            btneduser.Name = "btneduser";
            btneduser.Size = new Size(154, 81);
            btneduser.TabIndex = 2;
            btneduser.Text = "Edit/Delete User";
            btneduser.UseVisualStyleBackColor = false;
            btneduser.Click += btneduser_Click;
            // 
            // btnadduser
            // 
            btnadduser.BackColor = Color.DarkOrange;
            btnadduser.ForeColor = SystemColors.ActiveCaptionText;
            btnadduser.Location = new Point(96, 26);
            btnadduser.Name = "btnadduser";
            btnadduser.Size = new Size(154, 81);
            btnadduser.TabIndex = 1;
            btnadduser.Text = "AddUser";
            btnadduser.UseVisualStyleBackColor = false;
            btnadduser.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnreport);
            groupBox2.Controls.Add(btnview);
            groupBox2.ForeColor = SystemColors.Control;
            groupBox2.Location = new Point(438, 139);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(350, 222);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Transaction Management";
            // 
            // btnreport
            // 
            btnreport.BackColor = Color.DarkOrange;
            btnreport.ForeColor = SystemColors.ActiveCaptionText;
            btnreport.Location = new Point(98, 125);
            btnreport.Name = "btnreport";
            btnreport.Size = new Size(154, 81);
            btnreport.TabIndex = 1;
            btnreport.Text = "Report";
            btnreport.UseVisualStyleBackColor = false;
            btnreport.Click += button5_Click;
            // 
            // btnview
            // 
            btnview.BackColor = Color.DarkOrange;
            btnview.ForeColor = SystemColors.ActiveCaptionText;
            btnview.Location = new Point(98, 26);
            btnview.Name = "btnview";
            btnview.Size = new Size(154, 81);
            btnview.TabIndex = 0;
            btnview.Text = "View Transaction";
            btnview.UseVisualStyleBackColor = false;
            btnview.Click += btnview_Click;
            // 
            // Admindash
            // 
            Admindash.AutoSize = true;
            Admindash.BackColor = Color.Transparent;
            Admindash.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Admindash.ForeColor = Color.DarkOrange;
            Admindash.Location = new Point(275, 27);
            Admindash.Name = "Admindash";
            Admindash.Size = new Size(241, 31);
            Admindash.TabIndex = 1;
            Admindash.Text = "ADMIN DASHBOARD";
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(Admindash);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "AdminDashboard";
            Text = "AdminDashboard";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnadduser;
        private Button btneduser;
        private Button btnreport;
        private Button btnview;
        private Label Admindash;
    }
}