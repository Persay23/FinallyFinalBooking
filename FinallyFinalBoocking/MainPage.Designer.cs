namespace FinallyFinalBoocking
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            searchTextBox = new TextBox();
            accountInfo = new Button();
            comboBoxFilter = new ComboBox();
            groupBox1 = new GroupBox();
            Exitbtn2 = new Button();
            openbtn = new Button();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            pictureBox1 = new PictureBox();
            showRoomsBtn = new Button();
            hotelAmountOfRoomsTextBox = new TextBox();
            hotelLocationTextBox = new TextBox();
            hotelDateAvbTextBox = new TextBox();
            hotelTotalCostTextBox = new TextBox();
            hotelNameTextBox = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(171, 54);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.PlaceholderText = "Search";
            searchTextBox.Size = new Size(673, 29);
            searchTextBox.TabIndex = 0;
            searchTextBox.TextChanged += searchTextBox_TextChanged;
            // 
            // accountInfo
            // 
            accountInfo.Location = new Point(41, 19);
            accountInfo.Name = "accountInfo";
            accountInfo.Size = new Size(102, 29);
            accountInfo.TabIndex = 1;
            accountInfo.Text = "Account";
            accountInfo.UseVisualStyleBackColor = true;
            accountInfo.Click += button1_Click;
            // 
            // comboBoxFilter
            // 
            comboBoxFilter.FormattingEnabled = true;
            comboBoxFilter.Location = new Point(870, 54);
            comboBoxFilter.Name = "comboBoxFilter";
            comboBoxFilter.Size = new Size(164, 29);
            comboBoxFilter.TabIndex = 2;
            comboBoxFilter.Text = "Filter";
            comboBoxFilter.SelectedIndexChanged += comboBoxFilter_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Exitbtn2);
            groupBox1.Controls.Add(openbtn);
            groupBox1.Controls.Add(accountInfo);
            groupBox1.Controls.Add(comboBoxFilter);
            groupBox1.Controls.Add(searchTextBox);
            groupBox1.Location = new Point(327, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1062, 135);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Account details";
            // 
            // Exitbtn2
            // 
            Exitbtn2.Location = new Point(41, 91);
            Exitbtn2.Name = "Exitbtn2";
            Exitbtn2.Size = new Size(102, 31);
            Exitbtn2.TabIndex = 6;
            Exitbtn2.Text = "Exit";
            Exitbtn2.UseVisualStyleBackColor = true;
            Exitbtn2.Click += Exitbtn2_Click;
            // 
            // openbtn
            // 
            openbtn.Location = new Point(41, 54);
            openbtn.Name = "openbtn";
            openbtn.Size = new Size(102, 31);
            openbtn.TabIndex = 5;
            openbtn.Text = "Reload";
            openbtn.UseVisualStyleBackColor = true;
            openbtn.Click += openbtn_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Location = new Point(327, 234);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1062, 564);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(pictureBox1);
            groupBox3.Controls.Add(showRoomsBtn);
            groupBox3.Controls.Add(hotelAmountOfRoomsTextBox);
            groupBox3.Controls.Add(hotelLocationTextBox);
            groupBox3.Controls.Add(hotelDateAvbTextBox);
            groupBox3.Controls.Add(hotelTotalCostTextBox);
            groupBox3.Controls.Add(hotelNameTextBox);
            groupBox3.Location = new Point(82, 38);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(932, 309);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // pictureBox1
            // 
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(516, 101);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(368, 169);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // showRoomsBtn
            // 
            showRoomsBtn.Location = new Point(54, 241);
            showRoomsBtn.Name = "showRoomsBtn";
            showRoomsBtn.Size = new Size(368, 29);
            showRoomsBtn.TabIndex = 5;
            showRoomsBtn.Text = "Show";
            showRoomsBtn.UseVisualStyleBackColor = true;
            showRoomsBtn.Click += showRoomsBtn_Click;
            // 
            // hotelAmountOfRoomsTextBox
            // 
            hotelAmountOfRoomsTextBox.BackColor = SystemColors.HighlightText;
            hotelAmountOfRoomsTextBox.Enabled = false;
            hotelAmountOfRoomsTextBox.Location = new Point(54, 171);
            hotelAmountOfRoomsTextBox.Name = "hotelAmountOfRoomsTextBox";
            hotelAmountOfRoomsTextBox.PlaceholderText = "hotelAmountOfRooms";
            hotelAmountOfRoomsTextBox.Size = new Size(368, 29);
            hotelAmountOfRoomsTextBox.TabIndex = 4;
            // 
            // hotelLocationTextBox
            // 
            hotelLocationTextBox.BackColor = SystemColors.HighlightText;
            hotelLocationTextBox.Enabled = false;
            hotelLocationTextBox.Location = new Point(54, 101);
            hotelLocationTextBox.Name = "hotelLocationTextBox";
            hotelLocationTextBox.PlaceholderText = "hotelLocation";
            hotelLocationTextBox.Size = new Size(368, 29);
            hotelLocationTextBox.TabIndex = 3;
            // 
            // hotelDateAvbTextBox
            // 
            hotelDateAvbTextBox.BackColor = SystemColors.HighlightText;
            hotelDateAvbTextBox.Enabled = false;
            hotelDateAvbTextBox.Location = new Point(54, 136);
            hotelDateAvbTextBox.Name = "hotelDateAvbTextBox";
            hotelDateAvbTextBox.PlaceholderText = "hotelDateAvb";
            hotelDateAvbTextBox.Size = new Size(368, 29);
            hotelDateAvbTextBox.TabIndex = 2;
            // 
            // hotelTotalCostTextBox
            // 
            hotelTotalCostTextBox.BackColor = SystemColors.HighlightText;
            hotelTotalCostTextBox.Enabled = false;
            hotelTotalCostTextBox.Location = new Point(54, 206);
            hotelTotalCostTextBox.Name = "hotelTotalCostTextBox";
            hotelTotalCostTextBox.PlaceholderText = "hotelTotalCost";
            hotelTotalCostTextBox.Size = new Size(368, 29);
            hotelTotalCostTextBox.TabIndex = 1;
            // 
            // hotelNameTextBox
            // 
            hotelNameTextBox.BackColor = SystemColors.HighlightText;
            hotelNameTextBox.Enabled = false;
            hotelNameTextBox.Location = new Point(54, 28);
            hotelNameTextBox.Multiline = true;
            hotelNameTextBox.Name = "hotelNameTextBox";
            hotelNameTextBox.PlaceholderText = "hotelName";
            hotelNameTextBox.Size = new Size(830, 51);
            hotelNameTextBox.TabIndex = 0;
            hotelNameTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1672, 803);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "MainPage";
            Text = "MainPage";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox searchTextBox;
        private Button accountInfo;
        private ComboBox comboBoxFilter;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox hotelNameTextBox;
        private TextBox hotelLocationTextBox;
        private TextBox hotelDateAvbTextBox;
        private TextBox hotelTotalCostTextBox;
        private Button showRoomsBtn;
        private PictureBox pictureBox1;
        private TextBox hotelAmountOfRoomsTextBox;
        private OpenFileDialog openFileDialog1;
        private Button openbtn;
        private Button Exitbtn2;
    }
}