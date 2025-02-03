namespace FinallyFinalBoocking
{
    partial class AdminPage
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
            panelAdmin = new Panel();
            panelRMUser = new Panel();
            textBoxRMusername = new TextBox();
            label9 = new Label();
            buttonRMUser = new Button();
            panelRMHotel = new Panel();
            textBoxRMId = new TextBox();
            label10 = new Label();
            buttonRMHotel = new Button();
            panelCRHotel = new Panel();
            label11 = new Label();
            textBoxCRName = new TextBox();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            textBoxCRPrice = new TextBox();
            textBoxCRRooms = new TextBox();
            textBoxCRAvb = new TextBox();
            buttonCRHotel = new Button();
            textBoxCRLoc = new TextBox();
            label15 = new Label();
            label16 = new Label();
            textBoxCRID = new TextBox();
            returnToAcc = new Button();
            panelAdmin.SuspendLayout();
            panelRMUser.SuspendLayout();
            panelRMHotel.SuspendLayout();
            panelCRHotel.SuspendLayout();
            SuspendLayout();
            // 
            // panelAdmin
            // 
            panelAdmin.AllowDrop = true;
            panelAdmin.AutoScroll = true;
            panelAdmin.Controls.Add(panelRMUser);
            panelAdmin.Controls.Add(panelRMHotel);
            panelAdmin.Controls.Add(panelCRHotel);
            panelAdmin.Location = new Point(28, 12);
            panelAdmin.Name = "panelAdmin";
            panelAdmin.Size = new Size(742, 584);
            panelAdmin.TabIndex = 6;
            // 
            // panelRMUser
            // 
            panelRMUser.BorderStyle = BorderStyle.FixedSingle;
            panelRMUser.Controls.Add(textBoxRMusername);
            panelRMUser.Controls.Add(label9);
            panelRMUser.Controls.Add(buttonRMUser);
            panelRMUser.Location = new Point(72, 444);
            panelRMUser.Name = "panelRMUser";
            panelRMUser.Size = new Size(586, 90);
            panelRMUser.TabIndex = 8;
            // 
            // textBoxRMusername
            // 
            textBoxRMusername.BackColor = Color.LightGray;
            textBoxRMusername.BorderStyle = BorderStyle.None;
            textBoxRMusername.Location = new Point(226, 33);
            textBoxRMusername.Name = "textBoxRMusername";
            textBoxRMusername.Size = new Size(172, 27);
            textBoxRMusername.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(19, 30);
            label9.Name = "label9";
            label9.Size = new Size(199, 28);
            label9.TabIndex = 11;
            label9.Text = "User name to remove";
            // 
            // buttonRMUser
            // 
            buttonRMUser.BackColor = Color.RoyalBlue;
            buttonRMUser.FlatAppearance.BorderSize = 0;
            buttonRMUser.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            buttonRMUser.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
            buttonRMUser.FlatStyle = FlatStyle.Flat;
            buttonRMUser.Font = new Font("Segoe UI", 10F);
            buttonRMUser.ForeColor = SystemColors.ButtonHighlight;
            buttonRMUser.Location = new Point(437, 31);
            buttonRMUser.Name = "buttonRMUser";
            buttonRMUser.Size = new Size(102, 30);
            buttonRMUser.TabIndex = 1;
            buttonRMUser.Text = "Remove";
            buttonRMUser.UseVisualStyleBackColor = false;
            buttonRMUser.Click += buttonRMUser_Click;
            // 
            // panelRMHotel
            // 
            panelRMHotel.BorderStyle = BorderStyle.FixedSingle;
            panelRMHotel.Controls.Add(textBoxRMId);
            panelRMHotel.Controls.Add(label10);
            panelRMHotel.Controls.Add(buttonRMHotel);
            panelRMHotel.Location = new Point(72, 322);
            panelRMHotel.Name = "panelRMHotel";
            panelRMHotel.Size = new Size(586, 90);
            panelRMHotel.TabIndex = 7;
            // 
            // textBoxRMId
            // 
            textBoxRMId.BackColor = Color.LightGray;
            textBoxRMId.BorderStyle = BorderStyle.None;
            textBoxRMId.Location = new Point(226, 33);
            textBoxRMId.Name = "textBoxRMId";
            textBoxRMId.Size = new Size(172, 27);
            textBoxRMId.TabIndex = 12;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(19, 30);
            label10.Name = "label10";
            label10.Size = new Size(179, 28);
            label10.TabIndex = 11;
            label10.Text = "Hotel ID to remove";
            // 
            // buttonRMHotel
            // 
            buttonRMHotel.BackColor = Color.RoyalBlue;
            buttonRMHotel.FlatAppearance.BorderSize = 0;
            buttonRMHotel.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            buttonRMHotel.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
            buttonRMHotel.FlatStyle = FlatStyle.Flat;
            buttonRMHotel.Font = new Font("Segoe UI", 10F);
            buttonRMHotel.ForeColor = SystemColors.ButtonHighlight;
            buttonRMHotel.Location = new Point(437, 31);
            buttonRMHotel.Name = "buttonRMHotel";
            buttonRMHotel.Size = new Size(102, 30);
            buttonRMHotel.TabIndex = 1;
            buttonRMHotel.Text = "Remove";
            buttonRMHotel.UseVisualStyleBackColor = false;
            buttonRMHotel.Click += buttonRMHotel_Click;
            // 
            // panelCRHotel
            // 
            panelCRHotel.BorderStyle = BorderStyle.FixedSingle;
            panelCRHotel.Controls.Add(label11);
            panelCRHotel.Controls.Add(textBoxCRName);
            panelCRHotel.Controls.Add(label12);
            panelCRHotel.Controls.Add(label13);
            panelCRHotel.Controls.Add(label14);
            panelCRHotel.Controls.Add(textBoxCRPrice);
            panelCRHotel.Controls.Add(textBoxCRRooms);
            panelCRHotel.Controls.Add(textBoxCRAvb);
            panelCRHotel.Controls.Add(buttonCRHotel);
            panelCRHotel.Controls.Add(textBoxCRLoc);
            panelCRHotel.Controls.Add(label15);
            panelCRHotel.Controls.Add(label16);
            panelCRHotel.Controls.Add(textBoxCRID);
            panelCRHotel.Location = new Point(72, 13);
            panelCRHotel.Name = "panelCRHotel";
            panelCRHotel.Size = new Size(586, 280);
            panelCRHotel.TabIndex = 6;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(42, 48);
            label11.Name = "label11";
            label11.Size = new Size(64, 28);
            label11.TabIndex = 22;
            label11.Text = "Name";
            // 
            // textBoxCRName
            // 
            textBoxCRName.BackColor = Color.LightGray;
            textBoxCRName.BorderStyle = BorderStyle.None;
            textBoxCRName.Location = new Point(304, 48);
            textBoxCRName.Name = "textBoxCRName";
            textBoxCRName.Size = new Size(235, 27);
            textBoxCRName.TabIndex = 21;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(42, 188);
            label12.Name = "label12";
            label12.Size = new Size(54, 28);
            label12.TabIndex = 20;
            label12.Text = "Price";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(42, 153);
            label13.Name = "label13";
            label13.Size = new Size(168, 28);
            label13.TabIndex = 19;
            label13.Text = "Number of rooms";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(42, 118);
            label14.Name = "label14";
            label14.Size = new Size(109, 28);
            label14.TabIndex = 18;
            label14.Text = "Availability";
            // 
            // textBoxCRPrice
            // 
            textBoxCRPrice.BackColor = Color.LightGray;
            textBoxCRPrice.BorderStyle = BorderStyle.None;
            textBoxCRPrice.Location = new Point(304, 188);
            textBoxCRPrice.Name = "textBoxCRPrice";
            textBoxCRPrice.Size = new Size(235, 27);
            textBoxCRPrice.TabIndex = 16;
            // 
            // textBoxCRRooms
            // 
            textBoxCRRooms.BackColor = Color.LightGray;
            textBoxCRRooms.BorderStyle = BorderStyle.None;
            textBoxCRRooms.Location = new Point(304, 153);
            textBoxCRRooms.Name = "textBoxCRRooms";
            textBoxCRRooms.Size = new Size(235, 27);
            textBoxCRRooms.TabIndex = 15;
            // 
            // textBoxCRAvb
            // 
            textBoxCRAvb.BackColor = Color.LightGray;
            textBoxCRAvb.BorderStyle = BorderStyle.None;
            textBoxCRAvb.Location = new Point(304, 118);
            textBoxCRAvb.Name = "textBoxCRAvb";
            textBoxCRAvb.Size = new Size(235, 27);
            textBoxCRAvb.TabIndex = 14;
            // 
            // buttonCRHotel
            // 
            buttonCRHotel.BackColor = Color.RoyalBlue;
            buttonCRHotel.FlatAppearance.BorderSize = 0;
            buttonCRHotel.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            buttonCRHotel.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
            buttonCRHotel.FlatStyle = FlatStyle.Flat;
            buttonCRHotel.Font = new Font("Segoe UI", 10F);
            buttonCRHotel.ForeColor = SystemColors.ButtonHighlight;
            buttonCRHotel.Location = new Point(43, 223);
            buttonCRHotel.Name = "buttonCRHotel";
            buttonCRHotel.Size = new Size(497, 30);
            buttonCRHotel.TabIndex = 12;
            buttonCRHotel.Text = "Create Hotel";
            buttonCRHotel.UseVisualStyleBackColor = false;
            buttonCRHotel.Click += buttonCRHotel_Click_1;
            // 
            // textBoxCRLoc
            // 
            textBoxCRLoc.BackColor = Color.LightGray;
            textBoxCRLoc.BorderStyle = BorderStyle.None;
            textBoxCRLoc.Location = new Point(304, 83);
            textBoxCRLoc.Name = "textBoxCRLoc";
            textBoxCRLoc.Size = new Size(235, 27);
            textBoxCRLoc.TabIndex = 11;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(42, 83);
            label15.Name = "label15";
            label15.Size = new Size(87, 28);
            label15.TabIndex = 10;
            label15.Text = "Location";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(42, 13);
            label16.Name = "label16";
            label16.Size = new Size(29, 28);
            label16.TabIndex = 5;
            label16.Text = "Id";
            // 
            // textBoxCRID
            // 
            textBoxCRID.BackColor = Color.LightGray;
            textBoxCRID.BorderStyle = BorderStyle.None;
            textBoxCRID.Location = new Point(304, 13);
            textBoxCRID.Name = "textBoxCRID";
            textBoxCRID.Size = new Size(235, 27);
            textBoxCRID.TabIndex = 0;
            // 
            // returnToAcc
            // 
            returnToAcc.Location = new Point(12, 12);
            returnToAcc.Name = "returnToAcc";
            returnToAcc.Size = new Size(44, 40);
            returnToAcc.TabIndex = 9;
            returnToAcc.Text = "<--";
            returnToAcc.UseVisualStyleBackColor = true;
            returnToAcc.Click += returnToAcc_Click;
            // 
            // AdminPage
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 609);
            Controls.Add(returnToAcc);
            Controls.Add(panelAdmin);
            Font = new Font("Segoe UI", 12F);
            Name = "AdminPage";
            Text = "AdminPage";
            Load += AdminPage_Load;
            panelAdmin.ResumeLayout(false);
            panelRMUser.ResumeLayout(false);
            panelRMUser.PerformLayout();
            panelRMHotel.ResumeLayout(false);
            panelRMHotel.PerformLayout();
            panelCRHotel.ResumeLayout(false);
            panelCRHotel.PerformLayout();
            ResumeLayout(false);
        }


        #endregion

        private Panel panelAdmin;
        private Panel panelRMUser;
        private TextBox textBoxRMusername;
        private Label label9;
        private Button buttonRMUser;
        private Panel panelRMHotel;
        private TextBox textBoxRMId;
        private Label label10;
        private Button buttonRMHotel;
        private Panel panelCRHotel;
        private Label label11;
        private TextBox textBoxCRName;
        private Label label12;
        private Label label13;
        private Label label14;
        private TextBox textBoxCRPrice;
        private TextBox textBoxCRRooms;
        private TextBox textBoxCRAvb;
        private Button buttonCRHotel;
        private TextBox textBoxCRLoc;
        private Label label15;
        private Label label16;
        private TextBox textBoxCRID;
        private Button returnToAcc;
        private ContextMenuStrip contextMenuStrip1;
    }
}

