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
            contactBtn = new Button();
            commentBtn = new Button();
            buyBtn = new Button();
            textBox2 = new TextBox();
            hotelNameLabel = new Label();
            submitBtn = new Button();
            reload2 = new Button();
            exit2 = new Button();
            hotelInfoLabel = new Label();
            descriptionTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)personalpictureBox).BeginInit();
            SuspendLayout();
            // 
            // personalpictureBox
            // 
            personalpictureBox.Location = new Point(11, 83);
            personalpictureBox.Name = "personalpictureBox";
            personalpictureBox.Size = new Size(200, 200);
            personalpictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            personalpictureBox.TabIndex = 10;
            personalpictureBox.TabStop = false;
            // 
            // contactBtn
            // 
            contactBtn.BackColor = Color.RoyalBlue;
            contactBtn.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            contactBtn.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
            contactBtn.FlatStyle = FlatStyle.Flat;
            contactBtn.ForeColor = Color.White;
            contactBtn.Location = new Point(257, 508);
            contactBtn.Name = "contactBtn";
            contactBtn.Size = new Size(140, 34);
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
            commentBtn.Location = new Point(494, 508);
            commentBtn.Name = "commentBtn";
            commentBtn.Size = new Size(140, 34);
            commentBtn.TabIndex = 6;
            commentBtn.Text = "Leave a Comment";
            commentBtn.UseVisualStyleBackColor = false;
            commentBtn.Click += commentBtn_Click;
            // 
            // buyBtn
            // 
            buyBtn.BackColor = Color.RoyalBlue;
            buyBtn.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            buyBtn.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
            buyBtn.FlatStyle = FlatStyle.Flat;
            buyBtn.ForeColor = Color.White;
            buyBtn.Location = new Point(11, 508);
            buyBtn.Name = "buyBtn";
            buyBtn.Size = new Size(140, 34);
            buyBtn.TabIndex = 5;
            buyBtn.Text = "Go to Checkout";
            buyBtn.UseVisualStyleBackColor = false;
            buyBtn.Click += buyBtn_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(11, 571);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(623, 63);
            textBox2.TabIndex = 4;
            // 
            // hotelNameLabel
            // 
            hotelNameLabel.AutoSize = true;
            hotelNameLabel.Font = new Font("Arial", 14F, FontStyle.Bold);
            hotelNameLabel.Location = new Point(233, 18);
            hotelNameLabel.Name = "hotelNameLabel";
            hotelNameLabel.Size = new Size(217, 29);
            hotelNameLabel.TabIndex = 3;
            hotelNameLabel.Text = "Name of the Hotel";
            // 
            // submitBtn
            // 
            submitBtn.BackColor = Color.RoyalBlue;
            submitBtn.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            submitBtn.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
            submitBtn.FlatStyle = FlatStyle.Flat;
            submitBtn.ForeColor = Color.White;
            submitBtn.Location = new Point(257, 659);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(140, 34);
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
            reload2.Location = new Point(11, 659);
            reload2.Name = "reload2";
            reload2.Size = new Size(140, 34);
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
            exit2.Location = new Point(494, 659);
            exit2.Name = "exit2";
            exit2.Size = new Size(140, 34);
            exit2.TabIndex = 0;
            exit2.Text = "Exit";
            exit2.UseVisualStyleBackColor = false;
            exit2.Click += exit2_Click;
            // 
            // hotelInfoLabel
            // 
            hotelInfoLabel.AutoSize = true;
            hotelInfoLabel.Location = new Point(689, 83);
            hotelInfoLabel.Name = "hotelInfoLabel";
            hotelInfoLabel.Size = new Size(0, 20);
            hotelInfoLabel.TabIndex = 11;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(11, 325);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.ReadOnly = true;
            descriptionTextBox.ScrollBars = ScrollBars.Vertical;
            descriptionTextBox.Size = new Size(623, 153);
            descriptionTextBox.TabIndex = 13;
            // 
            // PropertysPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(651, 724);
            Controls.Add(descriptionTextBox);
            Controls.Add(hotelInfoLabel);
            Controls.Add(exit2);
            Controls.Add(reload2);
            Controls.Add(submitBtn);
            Controls.Add(hotelNameLabel);
            Controls.Add(textBox2);
            Controls.Add(buyBtn);
            Controls.Add(commentBtn);
            Controls.Add(contactBtn);
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
        private Button contactBtn;
        private Button commentBtn;
        private Button buyBtn;
        private TextBox textBox2;
        private Label hotelNameLabel;
        private Button submitBtn;
        private Button reload2;
        private Button exit2;
        private Label hotelInfoLabel;
        private TextBox descriptionTextBox;
    }
}

