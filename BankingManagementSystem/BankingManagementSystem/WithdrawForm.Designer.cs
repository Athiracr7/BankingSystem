namespace BankingManagementSystem
{
    partial class WithdrawForm
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
            button1 = new Button();
            txtamount = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOrange;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txtamount);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(142, 66);
            panel1.Name = "panel1";
            panel1.Size = new Size(503, 311);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(189, 174);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Withdraw";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtamount
            // 
            txtamount.BackColor = Color.DarkOrange;
            txtamount.BorderStyle = BorderStyle.FixedSingle;
            txtamount.Location = new Point(93, 124);
            txtamount.Name = "txtamount";
            txtamount.Size = new Size(304, 27);
            txtamount.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 80);
            label1.Name = "label1";
            label1.Size = new Size(270, 20);
            label1.TabIndex = 0;
            label1.Text = "Enter the amount you want to withdraw";
            label1.Click += label1_Click;
            // 
            // WithdrawForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "WithdrawForm";
            Text = "WithdrawForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button1;
        private TextBox txtamount;
    }
}