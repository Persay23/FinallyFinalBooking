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

            personalpictureBox.Location = new Point(11, 83);
            personalpictureBox.Name = "personalpictureBox";
            personalpictureBox.Size = new Size(200, 200);
            personalpictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            personalpictureBox.TabStop = false;
            personalpictureBox.Click += personalpictureBox_Click;

            descriptionPoloniaTextBox.BackColor = Color.LightGray;
            descriptionPoloniaTextBox.Enabled = false;
            descriptionPoloniaTextBox.Location = new Point(11, 345);
            descriptionPoloniaTextBox.Multiline = true;
            descriptionPoloniaTextBox.Size = new Size(824, 153);
            descriptionPoloniaTextBox.TextChanged += descriptionTextBox_TextChanged;

            reserveBtn.BackColor = Color.RoyalBlue;
            reserveBtn.FlatStyle = FlatStyle.Flat;
            reserveBtn.ForeColor = Color.White;
            reserveBtn.Location = new Point(631, 680);
            reserveBtn.Size = new Size(145, 41);
            reserveBtn.Text = "Reserve";
            reserveBtn.UseVisualStyleBackColor = false;
            reserveBtn.FlatStyle = FlatStyle.Flat;
            reserveBtn.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            reserveBtn.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;


            contactBtn.BackColor = Color.RoyalBlue;
            contactBtn.FlatStyle = FlatStyle.Flat;
            contactBtn.ForeColor = Color.White;
            contactBtn.Location = new Point(631, 755);
            contactBtn.Size = new Size(145, 41);
            contactBtn.Text = "Contact Us";
            contactBtn.UseVisualStyleBackColor = false;
            contactBtn.Click += contactBtn_Click;
            contactBtn.FlatStyle = FlatStyle.Flat;
            contactBtn.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            contactBtn.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;


            commentBtn.BackColor = Color.RoyalBlue;
            commentBtn.FlatStyle = FlatStyle.Flat;
            commentBtn.ForeColor = Color.White;
            commentBtn.Location = new Point(631, 605);
            commentBtn.Size = new Size(145, 41);
            commentBtn.Text = "Leave a Comment";
            commentBtn.UseVisualStyleBackColor = false;
            commentBtn.FlatStyle = FlatStyle.Flat;
            commentBtn.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            commentBtn.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;


            buyBtn.BackColor = Color.RoyalBlue;
            buyBtn.FlatStyle = FlatStyle.Flat;
            buyBtn.ForeColor = Color.White;
            buyBtn.Location = new Point(631, 530);
            buyBtn.Size = new Size(145, 41);
            buyBtn.Text = "Go to Checkout";
            buyBtn.UseVisualStyleBackColor = false;
            buyBtn.Click += buyBtn_Click;
            buyBtn.FlatStyle = FlatStyle.Flat;
            buyBtn.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            buyBtn.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;


            textBox2.Location = new Point(11, 530);
            textBox2.Multiline = true;
            textBox2.Size = new Size(569, 266);
            textBox2.TextChanged += textBox2_TextChanged;

            hotelNameLabel.AutoSize = true;
            hotelNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            hotelNameLabel.Location = new Point(365, 15);
            hotelNameLabel.Text = "Name of the Hotel";

            submitBtn.BackColor = Color.RoyalBlue;
            submitBtn.FlatStyle = FlatStyle.Flat;
            submitBtn.ForeColor = Color.White;
            submitBtn.Location = new Point(304, 816);
            submitBtn.Size = new Size(276, 30);
            submitBtn.Text = "Submit";
            submitBtn.UseVisualStyleBackColor = false;
            submitBtn.Click += submitBtn_Click;
            submitBtn.FlatStyle = FlatStyle.Flat;
            submitBtn.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            submitBtn.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;

            reload2.BackColor = Color.RoyalBlue;
            reload2.FlatStyle = FlatStyle.Flat;
            reload2.ForeColor = Color.White;
            reload2.Location = new Point(11, 816);
            reload2.Size = new Size(276, 30);
            reload2.Text = "Reload";
            reload2.UseVisualStyleBackColor = false;
            reload2.Click += reload2_Click;
            reload2.FlatStyle = FlatStyle.Flat;
            reload2.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            reload2.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;

            exit2.BackColor = Color.RoyalBlue;
            exit2.FlatStyle = FlatStyle.Flat;
            exit2.ForeColor = Color.White;
            exit2.Location = new Point(631, 816);
            exit2.Size = new Size(145, 30);
            exit2.Text = "Exit";
            exit2.UseVisualStyleBackColor = false;
            exit2.Click += exit2_Click; 
            exit2.FlatStyle = FlatStyle.Flat;
            exit2.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            exit2.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;


            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(847, 877);
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

