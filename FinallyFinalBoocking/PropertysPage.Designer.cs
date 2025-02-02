namespace FinallyFinalBoocking
{
    partial class PropertysPage
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
            personalpictureBox.Location = new Point(11, 83);
            personalpictureBox.Name = "personalpictureBox";
            personalpictureBox.Size = new Size(200, 200);
            personalpictureBox.TabIndex = 0;
            personalpictureBox.TabStop = false;
            personalpictureBox.Click += personalpictureBox_Click;
            // 
            // descriptionPoloniaTextBox
            // 
            descriptionPoloniaTextBox.BackColor = SystemColors.HighlightText;
            descriptionPoloniaTextBox.Enabled = false;
            descriptionPoloniaTextBox.Location = new Point(11, 345);
            descriptionPoloniaTextBox.Multiline = true;
            descriptionPoloniaTextBox.Name = "descriptionPoloniaTextBox";
            descriptionPoloniaTextBox.Size = new Size(824, 153);
            descriptionPoloniaTextBox.TabIndex = 1;
            descriptionPoloniaTextBox.TextChanged += descriptionTextBox_TextChanged;
            // 
            // reserveBtn
            // 
            reserveBtn.Location = new Point(631, 680);
            reserveBtn.Name = "reserveBtn";
            reserveBtn.Size = new Size(145, 41);
            reserveBtn.TabIndex = 2;
            reserveBtn.Text = "Reserve";
            reserveBtn.UseVisualStyleBackColor = true;
            // 
            // contactBtn
            // 
            contactBtn.Location = new Point(631, 755);
            contactBtn.Name = "contactBtn";
            contactBtn.Size = new Size(145, 41);
            contactBtn.TabIndex = 3;
            contactBtn.Text = "Contact US";
            contactBtn.UseVisualStyleBackColor = true;
            contactBtn.Click += contactBtn_Click;
            // 
            // commentBtn
            // 
            commentBtn.Location = new Point(631, 605);
            commentBtn.Name = "commentBtn";
            commentBtn.Size = new Size(145, 41);
            commentBtn.TabIndex = 4;
            commentBtn.Text = "Leave a comment";
            commentBtn.UseVisualStyleBackColor = true;
            // 
            // buyBtn
            // 
            buyBtn.Location = new Point(631, 530);
            buyBtn.Name = "buyBtn";
            buyBtn.Size = new Size(145, 41);
            buyBtn.TabIndex = 5;
            buyBtn.Text = "Go to checkout";
            buyBtn.UseVisualStyleBackColor = true;
            buyBtn.Click += buyBtn_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(11, 530);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(569, 266);
            textBox2.TabIndex = 6;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // hotelNameLabel
            // 
            hotelNameLabel.AutoSize = true;
            hotelNameLabel.Location = new Point(365, 15);
            hotelNameLabel.Name = "hotelNameLabel";
            hotelNameLabel.Size = new Size(130, 20);
            hotelNameLabel.TabIndex = 7;
            hotelNameLabel.Text = "Name of the hotel";
            // 
            // submitBtn
            // 
            submitBtn.Location = new Point(304, 816);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(276, 30);
            submitBtn.TabIndex = 8;
            submitBtn.Text = "Submit";
            submitBtn.UseVisualStyleBackColor = true;
            submitBtn.Click += submitBtn_Click;
            // 
            // reload2
            // 
            reload2.Location = new Point(11, 816);
            reload2.Name = "reload2";
            reload2.Size = new Size(276, 30);
            reload2.TabIndex = 9;
            reload2.Text = "Reload";
            reload2.UseVisualStyleBackColor = true;
            reload2.Click += reload2_Click;
            // 
            // exit2
            // 
            exit2.Location = new Point(631, 816);
            exit2.Name = "exit2";
            exit2.Size = new Size(145, 30);
            exit2.TabIndex = 10;
            exit2.Text = "Exit";
            exit2.UseVisualStyleBackColor = true;
            exit2.Click += exit2_Click;
            // 
            // PropertysPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
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