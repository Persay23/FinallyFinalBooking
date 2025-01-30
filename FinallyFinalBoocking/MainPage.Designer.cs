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
            searchTextBox = new TextBox();
            accountInfo = new Button();
            comboBoxFilter = new ComboBox();
            groupBox1 = new GroupBox();
            Exitbtn2 = new Button();
            openbtn = new Button();
            openFileDialog1 = new OpenFileDialog();
            scrollablePanel = new Panel();
            groupBox1.SuspendLayout();
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
            // scrollablePanel
            // 
            scrollablePanel.AutoScroll = true;
            scrollablePanel.Location = new Point(95, 159);
            scrollablePanel.Name = "scrollablePanel";
            scrollablePanel.Size = new Size(952, 506);
            scrollablePanel.TabIndex = 14;
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
        private Panel scrollablePanel;
    }
}