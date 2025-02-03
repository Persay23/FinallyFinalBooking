using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using FinallyFinalBoocking.DumbStaffDB.users;

namespace FinallyFinalBoocking
{
    public partial class Cover : Form
    {

        private readonly string userPasswdPath = FilePathHelper.GetFilePath("UserPasswdDumbDb.txt");
        private readonly string usersInfoPath = FilePathHelper.GetFilePath($"users\\usersInfo.txt");

        public Cover()
        {
            InitializeComponent();
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

            string usersBookingFile = $@"C:\Users\Orest\Source\Repos\FinallyFinalBooking\FinallyFinalBoocking\DumbStaffDB\users\{usernameInput}.txt";

            if (string.IsNullOrEmpty(usersBookingFile))
            {
                MessageBox.Show("Error: Could not find the file path for the user's booking file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                using (FileStream fs = File.Create(usersBookingFile))
                {

                }
                MessageBox.Show("Booking file created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while creating the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string hashedPassword = HashPassword(passwordInput);

            using (StreamWriter sw = File.AppendText(userPasswdPath))
            {
                sw.WriteLine($"{usernameInput};{hashedPassword}");
            }
            using (StreamWriter sw = File.AppendText(usersInfoPath))
            {
                sw.WriteLine($"{usernameInput};{passwordInput};{usernameInput}@domain.com;" + Environment.NewLine);
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


    }
}

