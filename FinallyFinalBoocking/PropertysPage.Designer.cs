namespace FinallyFinalBoocking
{
    partial class PropertysPage
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
            personalpictureBox = new PictureBox();
            descriptionPoloniaTextBox = new TextBox();
            reserveBtn = new Button();
            contactBtn = new Button();
            commentBtn = new Button();
            buyBtn = new Button();
            textBox2 = new TextBox();
            hotelNameLabel = new Label();
            submitBtn = new Button();
            reload2 = new Button();
            exit2 = new Button();
            ((System.ComponentModel.ISupportInitialize)personalpictureBox).BeginInit();
            SuspendLayout();
            // 
            // personalpictureBox
            // 
            personalpictureBox.Location = new Point(12, 87);
            personalpictureBox.Name = "personalpictureBox";
            personalpictureBox.Size = new Size(225, 210);
            personalpictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            personalpictureBox.TabIndex = 10;
            personalpictureBox.TabStop = false;
            personalpictureBox.Click += personalpictureBox_Click;
            // 
            // descriptionPoloniaTextBox
            // 
            descriptionPoloniaTextBox.BackColor = Color.LightGray;
            descriptionPoloniaTextBox.Enabled = false;
            descriptionPoloniaTextBox.Location = new Point(12, 362);
            descriptionPoloniaTextBox.Multiline = true;
            descriptionPoloniaTextBox.Name = "descriptionPoloniaTextBox";
            descriptionPoloniaTextBox.Size = new Size(926, 160);
            descriptionPoloniaTextBox.TabIndex = 9;
            descriptionPoloniaTextBox.TextChanged += descriptionTextBox_TextChanged;
            // 
            // reserveBtn
            // 
            reserveBtn.BackColor = Color.RoyalBlue;
            reserveBtn.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            reserveBtn.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
            reserveBtn.FlatStyle = FlatStyle.Flat;
            reserveBtn.ForeColor = Color.White;
            reserveBtn.Location = new Point(775, 542);
            reserveBtn.Name = "reserveBtn";
            reserveBtn.Size = new Size(163, 43);
            reserveBtn.TabIndex = 8;
            reserveBtn.Text = "Reserve";
            reserveBtn.UseVisualStyleBackColor = false;
            // 
            // contactBtn
            // 
            contactBtn.BackColor = Color.RoyalBlue;
            contactBtn.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            contactBtn.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
            contactBtn.FlatStyle = FlatStyle.Flat;
            contactBtn.ForeColor = Color.White;
            contactBtn.Location = new Point(274, 542);
            contactBtn.Name = "contactBtn";
            contactBtn.Size = new Size(163, 43);
            contactBtn.TabIndex = 7;
            contactBtn.Text = "Contact Us";
            contactBtn.UseVisualStyleBackColor = false;
            contactBtn.Click += contactBtn_Click;
            // 
            // commentBtn
            // 
            commentBtn.BackColor = Color.RoyalBlue;
            commentBtn.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            commentBtn.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
            commentBtn.FlatStyle = FlatStyle.Flat;
            commentBtn.ForeColor = Color.White;
            commentBtn.Location = new Point(530, 542);
            commentBtn.Name = "commentBtn";
            commentBtn.Size = new Size(163, 43);
            commentBtn.TabIndex = 6;
            commentBtn.Text = "Leave a Comment";
            commentBtn.UseVisualStyleBackColor = false;
            // 
            // buyBtn
            // 
            buyBtn.BackColor = Color.RoyalBlue;
            buyBtn.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            buyBtn.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
            buyBtn.FlatStyle = FlatStyle.Flat;
            buyBtn.ForeColor = Color.White;
            buyBtn.Location = new Point(12, 542);
            buyBtn.Name = "buyBtn";
            buyBtn.Size = new Size(163, 43);
            buyBtn.TabIndex = 5;
            buyBtn.Text = "Go to Checkout";
            buyBtn.UseVisualStyleBackColor = false;
            buyBtn.Click += buyBtn_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 714);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(926, 121);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // hotelNameLabel
            // 
            hotelNameLabel.AutoSize = true;
            hotelNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            hotelNameLabel.Location = new Point(383, 9);
            hotelNameLabel.Name = "hotelNameLabel";
            hotelNameLabel.Size = new Size(204, 30);
            hotelNameLabel.TabIndex = 3;
            hotelNameLabel.Text = "Name of the Hotel";
            hotelNameLabel.Click += hotelNameLabel_Click;
            // 
            // submitBtn
            // 
            submitBtn.BackColor = Color.RoyalBlue;
            submitBtn.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            submitBtn.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
            submitBtn.FlatStyle = FlatStyle.Flat;
            submitBtn.ForeColor = Color.White;
            submitBtn.Location = new Point(329, 857);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(290, 31);
            submitBtn.TabIndex = 2;
            submitBtn.Text = "Submit";
            submitBtn.UseVisualStyleBackColor = false;
            submitBtn.Click += submitBtn_Click;
            // 
            // reload2
            // 
            reload2.BackColor = Color.RoyalBlue;
            reload2.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            reload2.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
            reload2.FlatStyle = FlatStyle.Flat;
            reload2.ForeColor = Color.White;
            reload2.Location = new Point(12, 857);
            reload2.Name = "reload2";
            reload2.Size = new Size(290, 31);
            reload2.TabIndex = 1;
            reload2.Text = "Reload";
            reload2.UseVisualStyleBackColor = false;
            reload2.Click += reload2_Click;
            // 
            // exit2
            // 
            exit2.BackColor = Color.RoyalBlue;
            exit2.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            exit2.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
            exit2.FlatStyle = FlatStyle.Flat;
            exit2.ForeColor = Color.White;
            exit2.Location = new Point(648, 857);
            exit2.Name = "exit2";
            exit2.Size = new Size(290, 31);
            exit2.TabIndex = 0;
            exit2.Text = "Exit";
            exit2.UseVisualStyleBackColor = false;
            exit2.Click += exit2_Click;
            // 
            // PropertysPage
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(953, 921);
            Controls.Add(exit2);
            Controls.Add(reload2);
            Controls.Add(submitBtn);
            Controls.Add(hotelNameLabel);
            Controls.Add(textBox2);
            Controls.Add(buyBtn);
            Controls.Add(commentBtn);
            Controls.Add(contactBtn);
            Controls.Add(reserveBtn);
            Controls.Add(descriptionPoloniaTextBox);
            Controls.Add(personalpictureBox);
            Name = "PropertysPage";
            Text = "Property";
            Load += PropertysPage_Load;
            ((System.ComponentModel.ISupportInitialize)personalpictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox personalpictureBox;
        private TextBox descriptionPoloniaTextBox;
        private Button reserveBtn;
        private Button contactBtn;
        private Button commentBtn;
        private Button buyBtn;
        private TextBox textBox2;
        private Label hotelNameLabel;
        private Button submitBtn;
        private Button reload2;
        private Button exit2;
    }
}

