namespace FinallyFinalBoocking
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
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
            singInbtn.Location = new Point(457, 373);
            singInbtn.Name = "singInbtn";
            singInbtn.Size = new Size(102, 29);
            singInbtn.TabIndex = 0;
            singInbtn.Text = "SingIn";
            singInbtn.UseVisualStyleBackColor = true;
            singInbtn.Click += singInbtn_Click;
            // 
            // logInbtn
            // 
            logInbtn.Location = new Point(457, 324);
            logInbtn.Name = "logInbtn";
            logInbtn.Size = new Size(102, 29);
            logInbtn.TabIndex = 1;
            logInbtn.Text = "LogIn";
            logInbtn.UseVisualStyleBackColor = true;
            logInbtn.Click += logInbtn_Click;
            // 
            // UsernameInputTextBox
            // 
            UsernameInputTextBox.Location = new Point(348, 186);
            UsernameInputTextBox.Name = "UsernameInputTextBox";
            UsernameInputTextBox.PlaceholderText = "User name";
            UsernameInputTextBox.Size = new Size(321, 29);
            UsernameInputTextBox.TabIndex = 2;
            UsernameInputTextBox.TextChanged += UsernameInputTextBox_TextChanged;
            // 
            // PasswordInputTextBox
            // 
            PasswordInputTextBox.Location = new Point(348, 255);
            PasswordInputTextBox.Name = "PasswordInputTextBox";
            PasswordInputTextBox.PasswordChar = '*';
            PasswordInputTextBox.PlaceholderText = "Password";
            PasswordInputTextBox.Size = new Size(321, 29);
            PasswordInputTextBox.TabIndex = 3;
            PasswordInputTextBox.TextChanged += PasswordInputTextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(460, 120);
            label1.Name = "label1";
            label1.Size = new Size(96, 21);
            label1.TabIndex = 4;
            label1.Text = "Booking  2.0";
            // 
            // exitbtn
            // 
            exitbtn.Location = new Point(457, 420);
            exitbtn.Name = "exitbtn";
            exitbtn.Size = new Size(102, 31);
            exitbtn.TabIndex = 5;
            exitbtn.Text = "Exit";
            exitbtn.UseVisualStyleBackColor = true;
            exitbtn.Click += exitbtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 566);
            Controls.Add(exitbtn);
            Controls.Add(label1);
            Controls.Add(PasswordInputTextBox);
            Controls.Add(UsernameInputTextBox);
            Controls.Add(logInbtn);
            Controls.Add(singInbtn);
            Name = "Form1";
            Text = "CoverPage";
            ResumeLayout(false);
            PerformLayout();
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
