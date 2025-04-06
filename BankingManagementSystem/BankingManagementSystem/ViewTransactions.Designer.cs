namespace BankingManagementSystem
{
    partial class ViewTransactions
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
            label1 = new Label();
            label2 = new Label();
            search = new TextBox();
            btnsearch = new Button();
            dataGridView1 = new DataGridView();
            btnreset = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkOrange;
            label1.Location = new Point(289, 33);
            label1.Name = "label1";
            label1.Size = new Size(239, 31);
            label1.TabIndex = 0;
            label1.Text = "VIEW TRANSACTION";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(86, 135);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 1;
            label2.Text = "User Id";
            // 
            // search
            // 
            search.BackColor = SystemColors.ButtonFace;
            search.Location = new Point(231, 132);
            search.Name = "search";
            search.Size = new Size(248, 27);
            search.TabIndex = 2;
            // 
            // btnsearch
            // 
            btnsearch.BackColor = Color.DarkOrange;
            btnsearch.Location = new Point(540, 130);
            btnsearch.Name = "btnsearch";
            btnsearch.Size = new Size(94, 29);
            btnsearch.TabIndex = 3;
            btnsearch.Text = "Search";
            btnsearch.UseVisualStyleBackColor = false;
            btnsearch.Click += btnsearch_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ScrollBar;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(86, 194);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(648, 188);
            dataGridView1.TabIndex = 4;
            // 
            // btnreset
            // 
            btnreset.BackColor = Color.DarkOrange;
            btnreset.Location = new Point(640, 130);
            btnreset.Name = "btnreset";
            btnreset.Size = new Size(94, 29);
            btnreset.TabIndex = 5;
            btnreset.Text = "Reset";
            btnreset.UseVisualStyleBackColor = false;
            btnreset.Click += btnreset_Click;
            // 
            // ViewTransactions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(btnreset);
            Controls.Add(dataGridView1);
            Controls.Add(btnsearch);
            Controls.Add(search);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ViewTransactions";
            Text = "ViewTransactions";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox search;
        private Button btnsearch;
        private DataGridView dataGridView1;
        private Button btnreset;
    }
}