namespace FinallyFinalBoocking
{
    public partial class Cover : Form
    {
        public Cover()
        {
            InitializeComponent();
        }

        private void logInbtn_Click(object sender, EventArgs e)
        {
            string usernameInput = UsernameInputTextBox.Text;
            string passwordInput = PasswordInputTextBox.Text;

            if (usernameInput == "user_1" && passwordInput == "password1")
            {
                var newMainPage = new MainPage();
                newMainPage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed");
            }
        }

        private bool validation(string username, string password)
        {
            if (!File.Exists("\"C:\\Users\\Orest\\source\\repos\\" +
                "FinallyFinalBoocking\\FinallyFinalBoocking\\DumbStaffDB\\UserPasswdDumbDb.txt\""))
            {
                MessageBox.Show("User data file not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            var lines = File.ReadAllLines("\"C:\\Users\\Orest\\source\\repos\\" +
                "FinallyFinalBoocking\\FinallyFinalBoocking\\DumbStaffDB\\UserPasswdDumbDb.txt\"");

            foreach (string line in lines)
            {
                var passwrdAndUsernames = line.Split(';');
                string storedUsername = passwrdAndUsernames[0];
                string storedPassword = passwrdAndUsernames[1];

                if (storedUsername == username && storedPassword == password)
                {
                    return true;
                }

            }

            return false;
        }

        private void singInbtn_Click(object sender, EventArgs e)
        {
            // this should also writedown new users
        }

        private void UsernameInputTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordInputTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
