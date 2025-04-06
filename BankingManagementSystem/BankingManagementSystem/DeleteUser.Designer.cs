namespace BankingManagementSystem
{
    partial class DeleteUser
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
            txtUserId = new TextBox();
            btnSearchUser = new Button();
            panel1 = new Panel();
            lblBalance = new TextBox();
            lblEmail = new TextBox();
            lblName = new TextBox();
            btnedit = new Button();
            btndlt = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtUserId
            // 
            txtUserId.BackColor = Color.DarkOrange;
            txtUserId.BorderStyle = BorderStyle.FixedSingle;
            txtUserId.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtUserId.Location = new Point(205, 65);
            txtUserId.Name = "txtUserId";
            txtUserId.Size = new Size(228, 27);
            txtUserId.TabIndex = 0;
            txtUserId.Text = "Enter id";
            // 
            // btnSearchUser
            // 
            btnSearchUser.BackColor = Color.DarkOrange;
            btnSearchUser.Location = new Point(439, 63);
            btnSearchUser.Name = "btnSearchUser";
            btnSearchUser.Size = new Size(64, 29);
            btnSearchUser.TabIndex = 1;
            btnSearchUser.Text = "Search";
            btnSearchUser.UseVisualStyleBackColor = false;
            btnSearchUser.Click += btnSearchUser_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOrange;
            panel1.Controls.Add(lblBalance);
            panel1.Controls.Add(lblEmail);
            panel1.Controls.Add(lblName);
            panel1.Location = new Point(205, 120);
            panel1.Name = "panel1";
            panel1.Size = new Size(298, 178);
            panel1.TabIndex = 2;
            // 
            // lblBalance
            // 
            lblBalance.BackColor = Color.DarkOrange;
            lblBalance.BorderStyle = BorderStyle.FixedSingle;
            lblBalance.Location = new Point(26, 132);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(252, 27);
            lblBalance.TabIndex = 2;
            // 
            // lblEmail
            // 
            lblEmail.BackColor = Color.DarkOrange;
            lblEmail.BorderStyle = BorderStyle.FixedSingle;
            lblEmail.Location = new Point(26, 77);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(252, 27);
            lblEmail.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.BackColor = Color.DarkOrange;
            lblName.BorderStyle = BorderStyle.FixedSingle;
            lblName.Location = new Point(26, 21);
            lblName.Name = "lblName";
            lblName.Size = new Size(252, 27);
            lblName.TabIndex = 0;
            lblName.TextChanged += textBox1_TextChanged;
            // 
            // btnedit
            // 
            btnedit.BackColor = Color.DarkOrange;
            btnedit.Location = new Point(205, 321);
            btnedit.Name = "btnedit";
            btnedit.Size = new Size(94, 29);
            btnedit.TabIndex = 3;
            btnedit.Text = "EDIT";
            btnedit.UseVisualStyleBackColor = false;
            btnedit.Click += btnedit_Click;
            // 
            // btndlt
            // 
            btndlt.BackColor = Color.DarkOrange;
            btndlt.Location = new Point(409, 321);
            btndlt.Name = "btndlt";
            btndlt.Size = new Size(94, 29);
            btndlt.TabIndex = 4;
            btndlt.Text = "DELETE";
            btndlt.UseVisualStyleBackColor = false;
            btndlt.Click += btndlt_Click;
            // 
            // DeleteUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(btndlt);
            Controls.Add(btnedit);
            Controls.Add(panel1);
            Controls.Add(btnSearchUser);
            Controls.Add(txtUserId);
            Name = "DeleteUser";
            Text = "DeleteUser";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUserId;
        private Button btnSearchUser;
        private Panel panel1;
        private TextBox lblBalance;
        private TextBox lblEmail;
        private TextBox lblName;
        private Button btnedit;
        private Button btndlt;
    }
}