namespace BankingManagementSystem
{
    partial class TransferForm
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
            RecipientAccNo = new Label();
            txtRecipientAccNo = new TextBox();
            label1 = new Label();
            txtAmount = new TextBox();
            btnTransfer = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOrange;
            panel1.Controls.Add(btnTransfer);
            panel1.Controls.Add(txtAmount);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtRecipientAccNo);
            panel1.Controls.Add(RecipientAccNo);
            panel1.Location = new Point(161, 57);
            panel1.Name = "panel1";
            panel1.Size = new Size(448, 329);
            panel1.TabIndex = 0;
            // 
            // RecipientAccNo
            // 
            RecipientAccNo.AutoSize = true;
            RecipientAccNo.Location = new Point(21, 83);
            RecipientAccNo.Name = "RecipientAccNo";
            RecipientAccNo.Size = new Size(115, 20);
            RecipientAccNo.TabIndex = 0;
            RecipientAccNo.Text = "RecipientAccNo";
            // 
            // txtRecipientAccNo
            // 
            txtRecipientAccNo.BackColor = Color.DarkOrange;
            txtRecipientAccNo.BorderStyle = BorderStyle.FixedSingle;
            txtRecipientAccNo.Location = new Point(142, 76);
            txtRecipientAccNo.Name = "txtRecipientAccNo";
            txtRecipientAccNo.Size = new Size(255, 27);
            txtRecipientAccNo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 145);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 2;
            label1.Text = "Amount";
            // 
            // txtAmount
            // 
            txtAmount.BackColor = Color.DarkOrange;
            txtAmount.BorderStyle = BorderStyle.FixedSingle;
            txtAmount.Location = new Point(142, 143);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(255, 27);
            txtAmount.TabIndex = 3;
            // 
            // btnTransfer
            // 
            btnTransfer.BackColor = SystemColors.ActiveCaptionText;
            btnTransfer.ForeColor = SystemColors.Control;
            btnTransfer.Location = new Point(142, 217);
            btnTransfer.Name = "btnTransfer";
            btnTransfer.Size = new Size(94, 29);
            btnTransfer.TabIndex = 4;
            btnTransfer.Text = "Transfer";
            btnTransfer.UseVisualStyleBackColor = false;
            btnTransfer.Click += btnTransfer_Click;
            // 
            // TransferForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "TransferForm";
            Text = "TransferForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnTransfer;
        private TextBox txtAmount;
        private Label label1;
        private TextBox txtRecipientAccNo;
        private Label RecipientAccNo;
    }
}