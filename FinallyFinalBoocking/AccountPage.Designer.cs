namespace FinallyFinalBoocking
{
    partial class AccountPage
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            exit3 = new Button();
            logOutbttn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            panel2 = new Panel();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(12, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(170, 167);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.LightGray;
            textBox4.Enabled = false;
            textBox4.ForeColor = Color.Black;
            textBox4.Location = new Point(5, 127);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(160, 32);
            textBox4.TabIndex = 3;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.LightGray;
            textBox3.Enabled = false;
            textBox3.ForeColor = Color.Black;
            textBox3.Location = new Point(5, 93);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(160, 32);
            textBox3.TabIndex = 2;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.LightGray;
            textBox2.Enabled = false;
            textBox2.ForeColor = Color.Black;
            textBox2.Location = new Point(5, 60);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(160, 32);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LightGray;
            textBox1.Enabled = false;
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(5, 27);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(160, 32);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // exit3
            // 
            exit3.BackColor = Color.RoyalBlue;
            exit3.FlatAppearance.BorderSize = 0;
            exit3.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
            exit3.FlatStyle = FlatStyle.Flat;
            exit3.ForeColor = Color.White;
            exit3.Location = new Point(3, 48);
            exit3.Name = "exit3";
            exit3.Size = new Size(159, 30);
            exit3.TabIndex = 4;
            exit3.Text = "Exit";
            exit3.UseVisualStyleBackColor = false;
            exit3.Click += exit3_Click;
            // 
            // logOutbttn
            // 
            logOutbttn.BackColor = Color.RoyalBlue;
            logOutbttn.FlatAppearance.BorderSize = 0;
            logOutbttn.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
            logOutbttn.FlatStyle = FlatStyle.Flat;
            logOutbttn.ForeColor = Color.White;
            logOutbttn.Location = new Point(3, 12);
            logOutbttn.Name = "logOutbttn";
            logOutbttn.Size = new Size(159, 30);
            logOutbttn.TabIndex = 3;
            logOutbttn.Text = "Log Out";
            logOutbttn.UseVisualStyleBackColor = false;
            logOutbttn.Click += logOutbttn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(42, 15);
            label1.Name = "label1";
            label1.Size = new Size(133, 25);
            label1.TabIndex = 2;
            label1.Text = "Your Account";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(510, 15);
            label2.Name = "label2";
            label2.Size = new Size(143, 25);
            label2.TabIndex = 3;
            label2.Text = "Your Bookings";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(59, 233);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 4;
            label3.Text = "Actions";
            label3.Click += label3_Click;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Location = new Point(202, 53);
            panel1.Name = "panel1";
            panel1.Size = new Size(727, 464);
            panel1.TabIndex = 7;
            panel1.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.Location = new Point(3, 81);
            button1.Name = "button1";
            button1.Size = new Size(159, 30);
            button1.TabIndex = 8;
            button1.Text = "Admin Page";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Controls.Add(logOutbttn);
            panel2.Controls.Add(exit3);
            panel2.Location = new Point(12, 279);
            panel2.Name = "panel2";
            panel2.Size = new Size(170, 121);
            panel2.TabIndex = 8;
            // 
            // AccountPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(952, 546);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 10F);
            Name = "AccountPage";
            Text = "Account Page";
            Load += AccountPage_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button exit3;
        private Button logOutbttn;
        private Panel panel1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
        private Panel panel2;
    }
}
