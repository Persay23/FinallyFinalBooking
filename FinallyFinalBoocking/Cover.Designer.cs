using System.Drawing;
using System.Drawing.Drawing2D;

namespace FinallyFinalBoocking
{
    partial class Cover
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
            singInbtn = new Button();
            logInbtn = new Button();
            UsernameInputTextBox = new TextBox();
            PasswordInputTextBox = new TextBox();
            label1 = new Label();
            exitbtn = new Button();
            SuspendLayout();
            // 
            // singInbtn
            // 
            singInbtn.BackColor = Color.RoyalBlue;
            singInbtn.FlatAppearance.BorderSize = 0;
            singInbtn.FlatAppearance.MouseDownBackColor = Color.DodgerBlue;
            singInbtn.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
            singInbtn.FlatStyle = FlatStyle.Flat;
            singInbtn.ForeColor = Color.White;
            singInbtn.Location = new Point(121, 289);
            singInbtn.Name = "singInbtn";
            singInbtn.Size = new Size(102, 38);
            singInbtn.TabIndex = 0;
            singInbtn.Text = "Sign In";
            singInbtn.UseVisualStyleBackColor = false;
            singInbtn.Click += singInbtn_Click;
            // 
            // logInbtn
            // 
            logInbtn.BackColor = Color.RoyalBlue;
            logInbtn.FlatAppearance.BorderSize = 0;
            logInbtn.FlatAppearance.MouseDownBackColor = Color.DodgerBlue;
            logInbtn.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
            logInbtn.FlatStyle = FlatStyle.Flat;
            logInbtn.ForeColor = Color.White;
            logInbtn.Location = new Point(121, 235);
            logInbtn.Name = "logInbtn";
            logInbtn.Size = new Size(102, 38);
            logInbtn.TabIndex = 1;
            logInbtn.Text = "Log In";
            logInbtn.UseVisualStyleBackColor = false;
            logInbtn.Click += logInbtn_Click;
            // 
            // UsernameInputTextBox
            // 
            UsernameInputTextBox.BackColor = Color.LightGray;
            UsernameInputTextBox.ForeColor = Color.Black;
            UsernameInputTextBox.Location = new Point(12, 84);
            UsernameInputTextBox.Name = "UsernameInputTextBox";
            UsernameInputTextBox.PlaceholderText = "Username";
            UsernameInputTextBox.Size = new Size(321, 30);
            UsernameInputTextBox.TabIndex = 2;
            UsernameInputTextBox.Text = "user_1";
            // 
            // PasswordInputTextBox
            // 
            PasswordInputTextBox.BackColor = Color.LightGray;
            PasswordInputTextBox.ForeColor = Color.Black;
            PasswordInputTextBox.Location = new Point(12, 160);
            PasswordInputTextBox.Name = "PasswordInputTextBox";
            PasswordInputTextBox.PasswordChar = '*';
            PasswordInputTextBox.PlaceholderText = "Password";
            PasswordInputTextBox.Size = new Size(321, 30);
            PasswordInputTextBox.TabIndex = 3;
            PasswordInputTextBox.Text = "password1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(96, 24);
            label1.Name = "label1";
            label1.Size = new Size(151, 32);
            label1.TabIndex = 4;
            label1.Text = "Booking 2.0";
            // 
            // exitbtn
            // 
            exitbtn.BackColor = Color.RoyalBlue;
            exitbtn.FlatAppearance.BorderSize = 0;
            exitbtn.FlatAppearance.MouseDownBackColor = Color.DodgerBlue;
            exitbtn.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
            exitbtn.FlatStyle = FlatStyle.Flat;
            exitbtn.ForeColor = Color.White;
            exitbtn.Location = new Point(121, 341);
            exitbtn.Name = "exitbtn";
            exitbtn.Size = new Size(102, 38);
            exitbtn.TabIndex = 5;
            exitbtn.Text = "Exit";
            exitbtn.UseVisualStyleBackColor = false;
            exitbtn.Click += exitbtn_Click;
            // 
            // Cover
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(349, 404);
            Controls.Add(exitbtn);
            Controls.Add(label1);
            Controls.Add(PasswordInputTextBox);
            Controls.Add(UsernameInputTextBox);
            Controls.Add(logInbtn);
            Controls.Add(singInbtn);
            Font = new Font("Segoe UI", 10F);
            Name = "Cover";
            Text = "CoverPage";
            ResumeLayout(false);
            PerformLayout();
        }

        private Region CreateRoundedRegion(Size size, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(size.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(size.Width - radius, size.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, size.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            return new Region(path);
        }

        #endregion

        private Button singInbtn;
        private Button logInbtn;
        private TextBox UsernameInputTextBox;
        private TextBox PasswordInputTextBox;
        private Label label1;
        private Button exitbtn;
    }
}
