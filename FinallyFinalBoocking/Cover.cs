using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using FinallyFinalBoocking.DumbStaffDB.users;

namespace FinallyFinalBoocking
{
    public partial class Cover : Form
    {
        private readonly string userPasswdPath =
            @"C:\\Users\\qwerd\\Source\\Repos\\FinallyFinalBooking\\FinallyFinalBoocking\\DumbStaffDB\\UserPasswdDumbDb.txt";

        private readonly string termsAcceptedPath =
            @"C:\\Users\\qwerd\\Source\\Repos\\FinallyFinalBooking\\FinallyFinalBoocking\\DumbStaffDB\\termsAccepted.txt";

        public Cover()
        {
            InitializeComponent();
            ShowTermsOfUseIfNeeded();
        }

        private void ShowTermsOfUseIfNeeded()
        {
            if (!File.Exists(termsAcceptedPath) || File.ReadAllText(termsAcceptedPath).Trim() != "Accepted")
            {
                using (var termsForm = new TermsOfUseForm(termsAcceptedPath))
                {
                    termsForm.ShowDialog();
                }
            }
        }

        private void logInbtn_Click(object sender, EventArgs e)
        {
            string usernameInput = UsernameInputTextBox.Text.Trim();
            string passwordInput = PasswordInputTextBox.Text;

            if (string.IsNullOrEmpty(usernameInput) || string.IsNullOrEmpty(passwordInput))
            {
                MessageBox.Show("Username and password cannot be empty.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            bool validUser = false;

            if (File.Exists(userPasswdPath))
            {
                foreach (var line in File.ReadAllLines(userPasswdPath))
                {
                    var parts = line.Split(';');
                    if (parts.Length >= 2)
                    {
                        string fileUsername = parts[0].Trim();
                        string filePassword = parts[1].Trim();
                        string hashedInputPassword = HashPassword(passwordInput);

                        if (fileUsername.Equals(usernameInput, StringComparison.OrdinalIgnoreCase) &&
                            filePassword == hashedInputPassword)
                        {
                            validUser = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("User data file not found!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (validUser)
            {
                CurrentUser.Username = usernameInput;

                var newMainPage = new MainPage();
                newMainPage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.",
                    "Login Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void singInbtn_Click(object sender, EventArgs e)
        {
            string usernameInput = UsernameInputTextBox.Text.Trim();
            string passwordInput = PasswordInputTextBox.Text.Trim();

            if (string.IsNullOrEmpty(usernameInput) || string.IsNullOrEmpty(passwordInput))
            {
                MessageBox.Show("Username and password cannot be empty.", "Validation Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!File.Exists(userPasswdPath))
            {
                File.Create(userPasswdPath).Close();
            }

            var lines = File.ReadAllLines(userPasswdPath);
            if (lines.Any(line => line.Split(';')[0].Equals(usernameInput, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Username already exists. Please choose a different one.", "Sign Up Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string usersBookingFile =
                $@"C:\Users\Orest\Source\Repos\FinallyFinalBooking\FinallyFinalBoocking\DumbStaffDB\users\{usernameInput}.txt";
            using (FileStream fs = File.Create(usersBookingFile))
            {

            }

            string hashedPassword = HashPassword(passwordInput);

            using (StreamWriter sw = File.AppendText(userPasswdPath))
            {
                sw.WriteLine($"{usernameInput};{hashedPassword}");
            }

            MessageBox.Show("Account successfully created! You can now log in.", "Success", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        public class TermsOfUseForm : Form
        {
            private readonly string termsFilePath;
            private CheckBox acceptCheckBox;
            private Button okButton;

            public TermsOfUseForm(string termsFilePath)
            {
                this.termsFilePath = termsFilePath;
                InitializeComponents();
            }

            private void InitializeComponents()
            {
                this.Text = "Terms of Use";
                this.Size = new System.Drawing.Size(400, 200);
                this.StartPosition = FormStartPosition.CenterScreen;
                this.FormBorderStyle = FormBorderStyle.FixedDialog;
                this.MaximizeBox = false;

                Label messageLabel = new Label()
                {
                    Text = "I accept the terms of use of the application.",
                    AutoSize = true,
                    Location = new System.Drawing.Point(20, 20)
                };

                acceptCheckBox = new CheckBox()
                {
                    Location = new System.Drawing.Point(20, 50)
                };
                acceptCheckBox.CheckedChanged += AcceptCheckBox_CheckedChanged;

                okButton = new Button()
                {
                    Text = "OK",
                    Location = new System.Drawing.Point(20, 80),
                    Size = new System.Drawing.Size(50, 30),
                    Enabled = false
                };
                okButton.Click += OkButton_Click;

                this.Controls.Add(messageLabel);
                this.Controls.Add(acceptCheckBox);
                this.Controls.Add(okButton);
            }

            private void AcceptCheckBox_CheckedChanged(object sender, EventArgs e)
            {
                okButton.Enabled = acceptCheckBox.Checked;
            }

            private void OkButton_Click(object sender, EventArgs e)
            {
                File.WriteAllText(termsFilePath, "Accepted");
                this.Close();
            }
        }

    }
}

