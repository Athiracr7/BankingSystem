namespace BankingManagementSystem
{
    partial class LoginForm
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
            LoginPanel = new Panel();
            linkLabel1 = new LinkLabel();
            Login = new Button();
            txtpswd = new TextBox();
            txtusername = new TextBox();
            Password = new Label();
            UserName = new Label();
            label1 = new Label();
            LoginPanel.SuspendLayout();
            SuspendLayout();
            // 
            // LoginPanel
            // 
            LoginPanel.AllowDrop = true;
            LoginPanel.BackColor = Color.DarkOrange;
            LoginPanel.Controls.Add(linkLabel1);
            LoginPanel.Controls.Add(Login);
            LoginPanel.Controls.Add(txtpswd);
            LoginPanel.Controls.Add(txtusername);
            LoginPanel.Controls.Add(Password);
            LoginPanel.Controls.Add(UserName);
            LoginPanel.Controls.Add(label1);
            LoginPanel.Location = new Point(239, 48);
            LoginPanel.Name = "LoginPanel";
            LoginPanel.Size = new Size(300, 324);
            LoginPanel.TabIndex = 0;
            LoginPanel.Paint += panel1_Paint;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(118, 251);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(60, 20);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forgot?";
            // 
            // Login
            // 
            Login.BackColor = SystemColors.ActiveCaptionText;
            Login.ForeColor = SystemColors.Control;
            Login.Location = new Point(95, 219);
            Login.Name = "Login";
            Login.Size = new Size(111, 29);
            Login.TabIndex = 5;
            Login.Text = "LOGIN";
            Login.UseVisualStyleBackColor = false;
            Login.Click += Login_Click;
            // 
            // txtpswd
            // 
            txtpswd.BackColor = Color.DarkOrange;
            txtpswd.BorderStyle = BorderStyle.FixedSingle;
            txtpswd.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtpswd.Location = new Point(103, 143);
            txtpswd.Name = "txtpswd";
            txtpswd.Size = new Size(180, 27);
            txtpswd.TabIndex = 4;
            txtpswd.Text = "Password";
            txtpswd.TextChanged += textBox1_TextChanged;
            txtpswd.UseSystemPasswordChar = true;
            // 
            // txtusername
            // 
            txtusername.BackColor = Color.DarkOrange;
            txtusername.BorderStyle = BorderStyle.FixedSingle;
            txtusername.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtusername.ForeColor = SystemColors.InactiveCaptionText;
            txtusername.Location = new Point(103, 98);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(180, 27);
            txtusername.TabIndex = 3;
            txtusername.Text = "Enter your email";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(16, 144);
            Password.Name = "Password";
            Password.Size = new Size(70, 20);
            Password.TabIndex = 2;
            Password.Text = "Password";
            // 
            // UserName
            // 
            UserName.AutoSize = true;
            UserName.Location = new Point(16, 101);
            UserName.Name = "UserName";
            UserName.Size = new Size(46, 20);
            UserName.TabIndex = 1;
            UserName.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(71, 26);
            label1.Name = "label1";
            label1.Size = new Size(158, 20);
            label1.TabIndex = 0;
            label1.Text = "Login to Your Account";
            label1.Click += label1_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(LoginPanel);
            Name = "LoginForm";
            Text = "LoginForm";
            LoginPanel.ResumeLayout(false);
            LoginPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel LoginPanel;
        private Label label1;
        private Label Password;
        private Label UserName;
        private TextBox txtpswd;
        private TextBox txtusername;
        private Button Login;
        private LinkLabel linkLabel1;
    }
}