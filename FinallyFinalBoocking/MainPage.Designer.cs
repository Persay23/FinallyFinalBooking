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
            vScrollBar1 = new VScrollBar();
            pictureBox1 = new PictureBox();
            showRoomsBtn = new Button();
            hotelAmountOfRoomsTextBox = new TextBox();
            hotelLocationTextBox = new TextBox();
            hotelDateAvbTextBox = new TextBox();
            hotelTotalCostTextBox = new TextBox();
            hotelNameTextBox = new TextBox();
            groupBox1.SuspendLayout();
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
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(327, 255);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(1062, 425);
            vScrollBar1.TabIndex = 5;
            vScrollBar1.Scroll += vScrollBar1_Scroll;
            // 
            // pictureBox1
            // 
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(907, 421);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(368, 169);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // showRoomsBtn
            // 
            showRoomsBtn.Location = new Point(445, 561);
            showRoomsBtn.Name = "showRoomsBtn";
            showRoomsBtn.Size = new Size(368, 29);
            showRoomsBtn.TabIndex = 12;
            showRoomsBtn.Text = "Show";
            showRoomsBtn.UseVisualStyleBackColor = true;
            // 
            // hotelAmountOfRoomsTextBox
            // 
            hotelAmountOfRoomsTextBox.BackColor = SystemColors.HighlightText;
            hotelAmountOfRoomsTextBox.Enabled = false;
            hotelAmountOfRoomsTextBox.Location = new Point(445, 491);
            hotelAmountOfRoomsTextBox.Name = "hotelAmountOfRoomsTextBox";
            hotelAmountOfRoomsTextBox.PlaceholderText = "hotelAmountOfRooms";
            hotelAmountOfRoomsTextBox.Size = new Size(368, 29);
            hotelAmountOfRoomsTextBox.TabIndex = 10;
            // 
            // hotelLocationTextBox
            // 
            hotelLocationTextBox.BackColor = SystemColors.HighlightText;
            hotelLocationTextBox.Enabled = false;
            hotelLocationTextBox.Location = new Point(445, 421);
            hotelLocationTextBox.Name = "hotelLocationTextBox";
            hotelLocationTextBox.PlaceholderText = "hotelLocation";
            hotelLocationTextBox.Size = new Size(368, 29);
            hotelLocationTextBox.TabIndex = 9;
            // 
            // hotelDateAvbTextBox
            // 
            hotelDateAvbTextBox.BackColor = SystemColors.HighlightText;
            hotelDateAvbTextBox.Enabled = false;
            hotelDateAvbTextBox.Location = new Point(445, 456);
            hotelDateAvbTextBox.Name = "hotelDateAvbTextBox";
            hotelDateAvbTextBox.PlaceholderText = "hotelDateAvb";
            hotelDateAvbTextBox.Size = new Size(368, 29);
            hotelDateAvbTextBox.TabIndex = 8;
            // 
            // hotelTotalCostTextBox
            // 
            hotelTotalCostTextBox.BackColor = SystemColors.HighlightText;
            hotelTotalCostTextBox.Enabled = false;
            hotelTotalCostTextBox.Location = new Point(445, 526);
            hotelTotalCostTextBox.Name = "hotelTotalCostTextBox";
            hotelTotalCostTextBox.PlaceholderText = "hotelTotalCost";
            hotelTotalCostTextBox.Size = new Size(368, 29);
            hotelTotalCostTextBox.TabIndex = 7;
            // 
            // hotelNameTextBox
            // 
            hotelNameTextBox.BackColor = SystemColors.HighlightText;
            hotelNameTextBox.Enabled = false;
            hotelNameTextBox.Location = new Point(445, 348);
            hotelNameTextBox.Multiline = true;
            hotelNameTextBox.Name = "hotelNameTextBox";
            hotelNameTextBox.PlaceholderText = "hotelName";
            hotelNameTextBox.Size = new Size(830, 51);
            hotelNameTextBox.TabIndex = 6;
            hotelNameTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1672, 803);
            Controls.Add(pictureBox1);
            Controls.Add(showRoomsBtn);
            Controls.Add(hotelAmountOfRoomsTextBox);
            Controls.Add(hotelLocationTextBox);
            Controls.Add(hotelDateAvbTextBox);
            Controls.Add(hotelTotalCostTextBox);
            Controls.Add(hotelNameTextBox);
            Controls.Add(vScrollBar1);
            Controls.Add(groupBox1);
            Name = "MainPage";
            Text = "MainPage";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox searchTextBox;
        private Button accountInfo;
        private ComboBox comboBoxFilter;
        private GroupBox groupBox1;
        private OpenFileDialog openFileDialog1;
        private Button openbtn;
        private Button Exitbtn2;
        private VScrollBar vScrollBar1;
        private PictureBox pictureBox1;
        private Button showRoomsBtn;
        private TextBox hotelAmountOfRoomsTextBox;
        private TextBox hotelLocationTextBox;
        private TextBox hotelDateAvbTextBox;
        private TextBox hotelTotalCostTextBox;
        private TextBox hotelNameTextBox;
    }
}