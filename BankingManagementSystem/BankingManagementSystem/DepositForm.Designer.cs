namespace BankingManagementSystem
{
    partial class DepositForm
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
            btndeposit = new Button();
            label1 = new Label();
            txtamount = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOrange;
            panel1.Controls.Add(btndeposit);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtamount);
            panel1.Location = new Point(109, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(564, 298);
            panel1.TabIndex = 0;
            // 
            // btndeposit
            // 
            btndeposit.BackColor = SystemColors.ActiveCaptionText;
            btndeposit.ForeColor = SystemColors.ButtonHighlight;
            btndeposit.Location = new Point(133, 170);
            btndeposit.Name = "btndeposit";
            btndeposit.Size = new Size(147, 48);
            btndeposit.TabIndex = 2;
            btndeposit.Text = "Deposit";
            btndeposit.UseVisualStyleBackColor = false;
            btndeposit.Click += btndeposit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(37, 99);
            label1.Name = "label1";
            label1.Size = new Size(125, 20);
            label1.TabIndex = 1;
            label1.Text = "Enter the Amount";
            label1.Click += label1_Click;
            // 
            // txtamount
            // 
            txtamount.BackColor = Color.DarkOrange;
            txtamount.BorderStyle = BorderStyle.FixedSingle;
            txtamount.Location = new Point(230, 97);
            txtamount.Name = "txtamount";
            txtamount.Size = new Size(290, 27);
            txtamount.TabIndex = 0;
            // 
            // DepositForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "DepositForm";
            Text = "DepositForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txtamount;
        private Button btndeposit;
    }
}