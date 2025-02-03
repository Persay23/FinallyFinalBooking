using System.Drawing;
using System.Drawing.Drawing2D;

namespace FinallyFinalBoocking
{
    partial class MainPage
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
            searchTextBox.BackColor = Color.LightGray;
            searchTextBox.BorderStyle = BorderStyle.FixedSingle;
            searchTextBox.ForeColor = Color.Black;
            searchTextBox.Location = new Point(164, 60);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.PlaceholderText = "Search";
            searchTextBox.Size = new Size(566, 32);
            searchTextBox.TabIndex = 0;
            searchTextBox.TextChanged += searchTextBox_TextChanged;
            // 
            // accountInfo
            // 
            accountInfo.BackColor = Color.RoyalBlue;
            accountInfo.FlatAppearance.BorderSize = 0;
            accountInfo.FlatAppearance.MouseDownBackColor = Color.DodgerBlue;
            accountInfo.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
            accountInfo.FlatStyle = FlatStyle.Flat;
            accountInfo.ForeColor = Color.White;
            accountInfo.Location = new Point(34, 25);
            accountInfo.Name = "accountInfo";
            accountInfo.Size = new Size(102, 32);
            accountInfo.TabIndex = 1;
            accountInfo.Text = "Account";
            accountInfo.UseVisualStyleBackColor = false;
            accountInfo.Click += button1_Click;
            // 
            // comboBoxFilter
            // 
            comboBoxFilter.FormattingEnabled = true;
            comboBoxFilter.Location = new Point(754, 60);
            comboBoxFilter.Name = "comboBoxFilter";
            comboBoxFilter.Size = new Size(164, 33);
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
            groupBox1.Location = new Point(95, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(952, 140);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Account details";
            // 
            // Exitbtn2
            // 
            Exitbtn2.BackColor = Color.RoyalBlue;
            Exitbtn2.FlatAppearance.BorderSize = 0;
            Exitbtn2.FlatAppearance.MouseDownBackColor = Color.DodgerBlue;
            Exitbtn2.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
            Exitbtn2.FlatStyle = FlatStyle.Flat;
            Exitbtn2.ForeColor = Color.White;
            Exitbtn2.Location = new Point(34, 97);
            Exitbtn2.Name = "Exitbtn2";
            Exitbtn2.Size = new Size(102, 32);
            Exitbtn2.TabIndex = 6;
            Exitbtn2.Text = "Exit";
            Exitbtn2.UseVisualStyleBackColor = false;
            Exitbtn2.Click += Exitbtn2_Click;
            // 
            // openbtn
            // 
            openbtn.BackColor = Color.RoyalBlue;
            openbtn.FlatAppearance.BorderSize = 0;
            openbtn.FlatAppearance.MouseDownBackColor = Color.DodgerBlue;
            openbtn.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
            openbtn.FlatStyle = FlatStyle.Flat;
            openbtn.ForeColor = Color.White;
            openbtn.Location = new Point(34, 60);
            openbtn.Name = "openbtn";
            openbtn.Size = new Size(102, 32);
            openbtn.TabIndex = 5;
            openbtn.Text = "Reload";
            openbtn.UseVisualStyleBackColor = false;
            openbtn.Click += openbtn_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // scrollablePanel
            // 
            scrollablePanel.AutoScroll = true;
            scrollablePanel.Location = new Point(95, 188);
            scrollablePanel.Name = "scrollablePanel";
            scrollablePanel.Size = new Size(952, 477);
            scrollablePanel.TabIndex = 14;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1092, 677);
            Controls.Add(scrollablePanel);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 10F);
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
