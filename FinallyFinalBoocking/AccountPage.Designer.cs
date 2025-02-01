namespace FinallyFinalBoocking
{
    partial class AccountPage
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
            accountNameTextBOx = new TextBox();
            bookingCounterTextBox = new TextBox();
            accountPasswordTextBox = new TextBox();
            groupBox3 = new GroupBox();
            exit3 = new Button();
            cancelBtn = new Button();
            statusTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(accountNameTextBOx);
            groupBox1.Controls.Add(bookingCounterTextBox);
            groupBox1.Controls.Add(accountPasswordTextBox);
            groupBox1.Location = new Point(12, 56);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(140, 135);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // accountNameTextBOx
            // 
            accountNameTextBOx.Enabled = false;
            accountNameTextBOx.Location = new Point(6, 28);
            accountNameTextBOx.Multiline = true;
            accountNameTextBOx.Name = "accountNameTextBOx";
            accountNameTextBOx.ReadOnly = true;
            accountNameTextBOx.Size = new Size(128, 31);
            accountNameTextBOx.TabIndex = 6;
            accountNameTextBOx.TextChanged += accountNameTextBOx_TextChanged;
            // 
            // bookingCounterTextBox
            // 
            bookingCounterTextBox.Enabled = false;
            bookingCounterTextBox.Location = new Point(6, 98);
            bookingCounterTextBox.Multiline = true;
            bookingCounterTextBox.Name = "bookingCounterTextBox";
            bookingCounterTextBox.ReadOnly = true;
            bookingCounterTextBox.Size = new Size(128, 31);
            bookingCounterTextBox.TabIndex = 5;
            bookingCounterTextBox.TextChanged += bookingCounterTextBox_TextChanged;
            // 
            // accountPasswordTextBox
            // 
            accountPasswordTextBox.Enabled = false;
            accountPasswordTextBox.Location = new Point(6, 65);
            accountPasswordTextBox.Multiline = true;
            accountPasswordTextBox.Name = "accountPasswordTextBox";
            accountPasswordTextBox.ReadOnly = true;
            accountPasswordTextBox.Size = new Size(128, 31);
            accountPasswordTextBox.TabIndex = 4;
            accountPasswordTextBox.TextChanged += accountPasswordTextBox_TextChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(exit3);
            groupBox3.Controls.Add(cancelBtn);
            groupBox3.Controls.Add(statusTextBox);
            groupBox3.Location = new Point(726, 56);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(140, 135);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // exit3
            // 
            exit3.Location = new Point(6, 98);
            exit3.Name = "exit3";
            exit3.Size = new Size(128, 31);
            exit3.TabIndex = 4;
            exit3.Text = "Exit";
            exit3.UseVisualStyleBackColor = true;
            exit3.Click += exit3_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(6, 65);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(128, 31);
            cancelBtn.TabIndex = 3;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // statusTextBox
            // 
            statusTextBox.Enabled = false;
            statusTextBox.Location = new Point(6, 28);
            statusTextBox.Multiline = true;
            statusTextBox.Name = "statusTextBox";
            statusTextBox.ReadOnly = true;
            statusTextBox.Size = new Size(128, 31);
            statusTextBox.TabIndex = 2;
            statusTextBox.TextChanged += statusTextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 16);
            label1.Name = "label1";
            label1.Size = new Size(52, 21);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(413, 16);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(772, 16);
            label3.Name = "label3";
            label3.Size = new Size(52, 21);
            label3.TabIndex = 4;
            label3.Text = "label3";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Location = new Point(158, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(562, 382);
            panel1.TabIndex = 7;
            panel1.Paint += panel1_Paint;
            // 
            // AccountPage
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 528);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Name = "AccountPage";
            Text = "AccountPage";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private TextBox statusTextBox;
        private TextBox bookingCounterTextBox;
        private TextBox accountPasswordTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button exit3;
        private Button cancelBtn;
        private TextBox accountNameTextBOx;
        private Panel panel1;
    }
}