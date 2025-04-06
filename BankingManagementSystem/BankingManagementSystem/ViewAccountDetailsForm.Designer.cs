namespace BankingManagementSystem
{
    partial class ViewAccountDetailsForm
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
            labelname = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtname = new TextBox();
            txtemail = new TextBox();
            txtaccnum = new TextBox();
            txtbal = new TextBox();
            txtphn = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOrange;
            panel1.Controls.Add(txtphn);
            panel1.Controls.Add(txtbal);
            panel1.Controls.Add(txtaccnum);
            panel1.Controls.Add(txtemail);
            panel1.Controls.Add(txtname);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(labelname);
            panel1.Location = new Point(80, 49);
            panel1.Name = "panel1";
            panel1.Size = new Size(639, 360);
            panel1.TabIndex = 0;
            // 
            // labelname
            // 
            labelname.AutoSize = true;
            labelname.Location = new Point(42, 79);
            labelname.Name = "labelname";
            labelname.Size = new Size(49, 20);
            labelname.TabIndex = 0;
            labelname.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 118);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 156);
            label3.Name = "label3";
            label3.Size = new Size(121, 20);
            label3.TabIndex = 2;
            label3.Text = "Account Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 195);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 3;
            label4.Text = "Balance";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 238);
            label5.Name = "label5";
            label5.Size = new Size(108, 20);
            label5.TabIndex = 4;
            label5.Text = "Phone Number";
            // 
            // txtname
            // 
            txtname.BackColor = Color.DarkOrange;
            txtname.BorderStyle = BorderStyle.None;
            txtname.Location = new Point(208, 76);
            txtname.Name = "txtname";
            txtname.Size = new Size(323, 20);
            txtname.TabIndex = 5;
            // 
            // txtemail
            // 
            txtemail.BackColor = Color.DarkOrange;
            txtemail.BorderStyle = BorderStyle.None;
            txtemail.Location = new Point(208, 115);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(323, 20);
            txtemail.TabIndex = 6;
            // 
            // txtaccnum
            // 
            txtaccnum.BackColor = Color.DarkOrange;
            txtaccnum.BorderStyle = BorderStyle.None;
            txtaccnum.Location = new Point(208, 153);
            txtaccnum.Name = "txtaccnum";
            txtaccnum.Size = new Size(323, 20);
            txtaccnum.TabIndex = 7;
            // 
            // txtbal
            // 
            txtbal.BackColor = Color.DarkOrange;
            txtbal.BorderStyle = BorderStyle.None;
            txtbal.Location = new Point(208, 192);
            txtbal.Name = "txtbal";
            txtbal.Size = new Size(323, 20);
            txtbal.TabIndex = 8;
            // 
            // txtphn
            // 
            txtphn.BackColor = Color.DarkOrange;
            txtphn.BorderStyle = BorderStyle.None;
            txtphn.Location = new Point(208, 235);
            txtphn.Name = "txtphn";
            txtphn.Size = new Size(323, 20);
            txtphn.TabIndex = 9;
            // 
            // ViewAccountDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "ViewAccountDetailsForm";
            Text = "ViewAccountDetailsForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtphn;
        private TextBox txtbal;
        private TextBox txtaccnum;
        private TextBox txtemail;
        private TextBox txtname;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label labelname;
    }
}