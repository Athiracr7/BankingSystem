namespace BankingManagementSystem
{
    partial class AddUser
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            button1 = new Button();
            email = new TextBox();
            pswd = new TextBox();
            Bal = new TextBox();
            name = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOrange;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(email);
            panel1.Controls.Add(pswd);
            panel1.Controls.Add(Bal);
            panel1.Controls.Add(name);
            panel1.Location = new Point(32, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(360, 331);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(139, 279);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "ADD USER";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // email
            // 
            email.BackColor = Color.DarkOrange;
            email.BorderStyle = BorderStyle.FixedSingle;
            email.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            email.Location = new Point(31, 94);
            email.Name = "email";
            email.Size = new Size(307, 27);
            email.TabIndex = 3;
            email.Text = "Email";
            email.TextChanged += email_TextChanged;
            // 
            // pswd
            // 
            pswd.BackColor = Color.DarkOrange;
            pswd.BorderStyle = BorderStyle.FixedSingle;
            pswd.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            pswd.Location = new Point(31, 161);
            pswd.Name = "pswd";
            pswd.Size = new Size(307, 27);
            pswd.TabIndex = 2;
            pswd.Text = "Password";
            pswd.TextChanged += pswd_TextChanged;
            // 
            // Bal
            // 
            Bal.BackColor = Color.DarkOrange;
            Bal.BorderStyle = BorderStyle.FixedSingle;
            Bal.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Bal.Location = new Point(31, 226);
            Bal.Name = "Bal";
            Bal.Size = new Size(307, 27);
            Bal.TabIndex = 1;
            Bal.Text = "Balance";
            Bal.TextChanged += Bal_TextChanged;
            // 
            // name
            // 
            name.BackColor = Color.DarkOrange;
            name.BorderStyle = BorderStyle.FixedSingle;
            name.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            name.Location = new Point(31, 31);
            name.Name = "name";
            name.Size = new Size(307, 27);
            name.TabIndex = 0;
            name.Text = "Name";
            name.TextChanged += name_TextChanged;
            // 
            // AddUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(428, 422);
            Controls.Add(panel1);
            Name = "AddUser";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox email;
        private TextBox name;
        private TextBox pswd;
        private TextBox Bal;
        private Button button1;
    }
}
