namespace BankingManagementSystem
{
    partial class UpdateProfileForm
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
            panel1 = new Panel();
            txtname = new TextBox();
            txtemail = new TextBox();
            txtpswd = new TextBox();
            btnUpdate = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOrange;
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(txtpswd);
            panel1.Controls.Add(txtemail);
            panel1.Controls.Add(txtname);
            panel1.Location = new Point(80, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(632, 371);
            panel1.TabIndex = 0;
            // 
            // txtname
            // 
            txtname.BackColor = Color.DarkOrange;
            txtname.BorderStyle = BorderStyle.FixedSingle;
            txtname.Location = new Point(51, 66);
            txtname.Name = "txtname";
            txtname.Size = new Size(391, 27);
            txtname.TabIndex = 0;
            // 
            // txtemail
            // 
            txtemail.BackColor = Color.DarkOrange;
            txtemail.BorderStyle = BorderStyle.FixedSingle;
            txtemail.Location = new Point(51, 129);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(391, 27);
            txtemail.TabIndex = 1;
            // 
            // txtpswd
            // 
            txtpswd.BackColor = Color.DarkOrange;
            txtpswd.BorderStyle = BorderStyle.FixedSingle;
            txtpswd.Location = new Point(51, 191);
            txtpswd.Name = "txtpswd";
            txtpswd.Size = new Size(391, 27);
            txtpswd.TabIndex = 2;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.ActiveCaptionText;
            btnUpdate.Location = new Point(51, 277);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // UpdateProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            ForeColor = SystemColors.Control;
            Name = "UpdateProfileForm";
            Text = "UpdateProfileForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnUpdate;
        private TextBox txtpswd;
        private TextBox txtemail;
        private TextBox txtname;
    }
}