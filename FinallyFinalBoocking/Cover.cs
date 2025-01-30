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
            string path1 = @"C:\Users\Orest\Source\Repos\FinallyFinalBooking\FinallyFinalBoocking\DumbStaffDB\UserPasswdDumbDb.txt";
            string path2 = @"C:\Users\qwerd\Source\Repos\FinallyFinalBooking\FinallyFinalBoocking\DumbStaffDB\UserPasswdDumbDb.txt";
            string selectedPath = null;

            if (File.Exists(path1))
            {
                selectedPath = path1;
            }
            else if (File.Exists(path2))
            {
                selectedPath = path2;
            }
            else
            {
                MessageBox.Show("User data file not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            var lines = File.ReadAllLines(selectedPath);

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
