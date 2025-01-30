using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FinallyFinalBoocking
{
    public partial class Cover : Form
    {
        private readonly string userFilePath = @"C:\Users\Orest\Source\Repos\FinallyFinalBooking\FinallyFinalBoocking\DumbStaffDB\UserPasswdDumbDb.txt";

        public Cover()
        {
            InitializeComponent();
        }

        private void logInbtn_Click(object sender, EventArgs e)
        {
            string usernameInput = UsernameInputTextBox.Text;
            string passwordInput = PasswordInputTextBox.Text;

            if (string.IsNullOrEmpty(usernameInput) || string.IsNullOrEmpty(passwordInput))
            {
                MessageBox.Show("Username and password cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ValidationIsTrue(usernameInput, passwordInput))
            {
                var newMainPage = new MainPage();
                newMainPage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidationIsTrue(string username, string password)
        {
            if (!File.Exists(userFilePath))
            {
                MessageBox.Show("User data file not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            var lines = File.ReadAllLines(userFilePath);
            return lines.Any(line =>
            {
                var parts = line.Split(';');
                return parts.Length == 2 && parts[0] == username && parts[1] == password;
            });
        }

        private void singInbtn_Click(object sender, EventArgs e)
        {
            string usernameInput = UsernameInputTextBox.Text.Trim();
            string passwordInput = PasswordInputTextBox.Text.Trim();

            if (string.IsNullOrEmpty(usernameInput) || string.IsNullOrEmpty(passwordInput))
            {
                MessageBox.Show("Username and password cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!File.Exists(userFilePath))
            {
                File.Create(userFilePath).Close();
            }

            var lines = File.ReadAllLines(userFilePath);
            if (lines.Any(line => line.Split(';')[0] == usernameInput))
            {
                MessageBox.Show("Username already exists. Please choose a different one.", "Sign Up Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (StreamWriter sw = File.AppendText(userFilePath))
            {
                sw.WriteLine($"{usernameInput};{passwordInput}");
            }

            MessageBox.Show("Account successfully created! You can now log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    


        private void UsernameInputTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordInputTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
