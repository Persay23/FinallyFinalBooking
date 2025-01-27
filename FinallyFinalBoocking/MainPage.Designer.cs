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
            openFileDialog1 = new OpenFileDialog();
            pictureBox1 = new PictureBox();
            showRoomsBtn = new Button();
            hotelAmountOfRoomsTextBox = new TextBox();
            hotelLocationTextBox = new TextBox();
            hotelDateAvbTextBox = new TextBox();
            hotelTotalCostTextBox = new TextBox();
            hotelNameTextBox = new TextBox();
            groupBox2 = new GroupBox();
            scrollablePanel = new Panel();
            groupBox4 = new GroupBox();
            textBox6 = new TextBox();
            pictureBox3 = new PictureBox();
            textBox7 = new TextBox();
            button2 = new Button();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            groupBox3 = new GroupBox();
            textBox1 = new TextBox();
            pictureBox2 = new PictureBox();
            textBox2 = new TextBox();
            button1 = new Button();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            scrollablePanel.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            groupBox1.Location = new Point(13, 16);
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
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(503, 101);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(342, 169);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Click += PictureBox_Load;
            // 
            // showRoomsBtn
            // 
            showRoomsBtn.Location = new Point(41, 241);
            showRoomsBtn.Name = "showRoomsBtn";
            showRoomsBtn.Size = new Size(342, 29);
            showRoomsBtn.TabIndex = 12;
            showRoomsBtn.Text = "Show";
            showRoomsBtn.UseVisualStyleBackColor = true;
            showRoomsBtn.Click += showRoomsBtn_Click_1;
            // 
            // hotelAmountOfRoomsTextBox
            // 
            hotelAmountOfRoomsTextBox.BackColor = SystemColors.HighlightText;
            hotelAmountOfRoomsTextBox.Enabled = false;
            hotelAmountOfRoomsTextBox.Location = new Point(41, 171);
            hotelAmountOfRoomsTextBox.Name = "hotelAmountOfRoomsTextBox";
            hotelAmountOfRoomsTextBox.PlaceholderText = "hotelAmountOfRooms";
            hotelAmountOfRoomsTextBox.Size = new Size(342, 29);
            hotelAmountOfRoomsTextBox.TabIndex = 10;
            // 
            // hotelLocationTextBox
            // 
            hotelLocationTextBox.BackColor = SystemColors.HighlightText;
            hotelLocationTextBox.Enabled = false;
            hotelLocationTextBox.Location = new Point(41, 101);
            hotelLocationTextBox.Name = "hotelLocationTextBox";
            hotelLocationTextBox.PlaceholderText = "hotelLocation";
            hotelLocationTextBox.Size = new Size(342, 29);
            hotelLocationTextBox.TabIndex = 9;
            // 
            // hotelDateAvbTextBox
            // 
            hotelDateAvbTextBox.BackColor = SystemColors.HighlightText;
            hotelDateAvbTextBox.Enabled = false;
            hotelDateAvbTextBox.Location = new Point(41, 136);
            hotelDateAvbTextBox.Name = "hotelDateAvbTextBox";
            hotelDateAvbTextBox.PlaceholderText = "hotelDateAvb";
            hotelDateAvbTextBox.Size = new Size(342, 29);
            hotelDateAvbTextBox.TabIndex = 8;
            // 
            // hotelTotalCostTextBox
            // 
            hotelTotalCostTextBox.BackColor = SystemColors.HighlightText;
            hotelTotalCostTextBox.Enabled = false;
            hotelTotalCostTextBox.Location = new Point(41, 206);
            hotelTotalCostTextBox.Name = "hotelTotalCostTextBox";
            hotelTotalCostTextBox.PlaceholderText = "hotelTotalCost";
            hotelTotalCostTextBox.Size = new Size(342, 29);
            hotelTotalCostTextBox.TabIndex = 7;
            // 
            // hotelNameTextBox
            // 
            hotelNameTextBox.BackColor = SystemColors.HighlightText;
            hotelNameTextBox.Enabled = false;
            hotelNameTextBox.Location = new Point(41, 28);
            hotelNameTextBox.Multiline = true;
            hotelNameTextBox.Name = "hotelNameTextBox";
            hotelNameTextBox.PlaceholderText = "hotelName";
            hotelNameTextBox.Size = new Size(804, 51);
            hotelNameTextBox.TabIndex = 6;
            hotelNameTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(hotelNameTextBox);
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Controls.Add(hotelTotalCostTextBox);
            groupBox2.Controls.Add(showRoomsBtn);
            groupBox2.Controls.Add(hotelDateAvbTextBox);
            groupBox2.Controls.Add(hotelAmountOfRoomsTextBox);
            groupBox2.Controls.Add(hotelLocationTextBox);
            groupBox2.Location = new Point(25, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(882, 290);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // scrollablePanel
            // 
            scrollablePanel.AutoScroll = true;
            scrollablePanel.Controls.Add(groupBox4);
            scrollablePanel.Controls.Add(groupBox3);
            scrollablePanel.Controls.Add(groupBox2);
            scrollablePanel.Location = new Point(95, 159);
            scrollablePanel.Name = "scrollablePanel";
            scrollablePanel.Size = new Size(952, 506);
            scrollablePanel.TabIndex = 14;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(textBox6);
            groupBox4.Controls.Add(pictureBox3);
            groupBox4.Controls.Add(textBox7);
            groupBox4.Controls.Add(button2);
            groupBox4.Controls.Add(textBox8);
            groupBox4.Controls.Add(textBox9);
            groupBox4.Controls.Add(textBox10);
            groupBox4.Location = new Point(25, 606);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(882, 290);
            groupBox4.TabIndex = 14;
            groupBox4.TabStop = false;
            groupBox4.Text = "groupBox4";
            // 
            // textBox6
            // 
            textBox6.BackColor = SystemColors.HighlightText;
            textBox6.Enabled = false;
            textBox6.Location = new Point(41, 28);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "hotelName";
            textBox6.Size = new Size(804, 51);
            textBox6.TabIndex = 6;
            textBox6.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox3
            // 
            pictureBox3.InitialImage = (Image)resources.GetObject("pictureBox3.InitialImage");
            pictureBox3.Location = new Point(503, 101);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(342, 169);
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // textBox7
            // 
            textBox7.BackColor = SystemColors.HighlightText;
            textBox7.Enabled = false;
            textBox7.Location = new Point(41, 206);
            textBox7.Name = "textBox7";
            textBox7.PlaceholderText = "hotelTotalCost";
            textBox7.Size = new Size(342, 29);
            textBox7.TabIndex = 7;
            // 
            // button2
            // 
            button2.Location = new Point(41, 241);
            button2.Name = "button2";
            button2.Size = new Size(342, 29);
            button2.TabIndex = 12;
            button2.Text = "Show";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            textBox8.BackColor = SystemColors.HighlightText;
            textBox8.Enabled = false;
            textBox8.Location = new Point(41, 136);
            textBox8.Name = "textBox8";
            textBox8.PlaceholderText = "hotelDateAvb";
            textBox8.Size = new Size(342, 29);
            textBox8.TabIndex = 8;
            // 
            // textBox9
            // 
            textBox9.BackColor = SystemColors.HighlightText;
            textBox9.Enabled = false;
            textBox9.Location = new Point(41, 171);
            textBox9.Name = "textBox9";
            textBox9.PlaceholderText = "hotelAmountOfRooms";
            textBox9.Size = new Size(342, 29);
            textBox9.TabIndex = 10;
            // 
            // textBox10
            // 
            textBox10.BackColor = SystemColors.HighlightText;
            textBox10.Enabled = false;
            textBox10.Location = new Point(41, 101);
            textBox10.Name = "textBox10";
            textBox10.PlaceholderText = "hotelLocation";
            textBox10.Size = new Size(342, 29);
            textBox10.TabIndex = 9;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox1);
            groupBox3.Controls.Add(pictureBox2);
            groupBox3.Controls.Add(textBox2);
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(textBox3);
            groupBox3.Controls.Add(textBox4);
            groupBox3.Controls.Add(textBox5);
            groupBox3.Location = new Point(25, 299);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(882, 290);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.HighlightText;
            textBox1.Enabled = false;
            textBox1.Location = new Point(41, 28);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "hotelName";
            textBox1.Size = new Size(804, 51);
            textBox1.TabIndex = 6;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox2
            // 
            pictureBox2.InitialImage = (Image)resources.GetObject("pictureBox2.InitialImage");
            pictureBox2.Location = new Point(503, 101);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(342, 169);
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.HighlightText;
            textBox2.Enabled = false;
            textBox2.Location = new Point(41, 206);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "hotelTotalCost";
            textBox2.Size = new Size(342, 29);
            textBox2.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(41, 241);
            button1.Name = "button1";
            button1.Size = new Size(342, 29);
            button1.TabIndex = 12;
            button1.Text = "Show";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.HighlightText;
            textBox3.Enabled = false;
            textBox3.Location = new Point(41, 136);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "hotelDateAvb";
            textBox3.Size = new Size(342, 29);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.HighlightText;
            textBox4.Enabled = false;
            textBox4.Location = new Point(41, 171);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "hotelAmountOfRooms";
            textBox4.Size = new Size(342, 29);
            textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.HighlightText;
            textBox5.Enabled = false;
            textBox5.Location = new Point(41, 101);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "hotelLocation";
            textBox5.Size = new Size(342, 29);
            textBox5.TabIndex = 9;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1092, 677);
            Controls.Add(scrollablePanel);
            Controls.Add(groupBox1);
            Name = "MainPage";
            Text = "MainPage";
            Load += MainPage_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            scrollablePanel.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox searchTextBox;
        private Button accountInfo;
        private ComboBox comboBoxFilter;
        private GroupBox groupBox1;
        private OpenFileDialog openFileDialog1;
        private Button openbtn;
        private Button Exitbtn2;
        private PictureBox pictureBox1;
        private Button showRoomsBtn;
        private TextBox hotelAmountOfRoomsTextBox;
        private TextBox hotelLocationTextBox;
        private TextBox hotelDateAvbTextBox;
        private TextBox hotelTotalCostTextBox;
        private TextBox hotelNameTextBox;
        private GroupBox groupBox2;
        private Panel scrollablePanel;
        private GroupBox groupBox4;
        private TextBox textBox6;
        private PictureBox pictureBox3;
        private TextBox textBox7;
        private Button button2;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
        private GroupBox groupBox3;
        private TextBox textBox1;
        private PictureBox pictureBox2;
        private TextBox textBox2;
        private Button button1;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
    }
}