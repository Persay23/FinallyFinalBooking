using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinallyFinalBoocking
{
    public partial class AccountPage : Form
    {
        public AccountPage()
        {
            InitializeComponent();
        }

        private void accountNameTextBOx_TextChanged(object sender, EventArgs e)
        {
            // This will display your username and you can cange it
        }

        private void exit3_Click(object sender, EventArgs e)
        {
            var newPropertysPage = new PropertysPage();
            newPropertysPage.Show();
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            //this should return the hotel to the main page
        }

        private void statusTextBox_TextChanged(object sender, EventArgs e)
        {
            // The status of the property, confimed or not
        }

        private void bookingCounterTextBox_TextChanged(object sender, EventArgs e)
        {
            // How many stays are in your back
        }

        private void accountPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            // This will display your password and you can cange it
        }

        private void theBookedOneTextBox_TextChanged(object sender, EventArgs e)
        {
            // Here will be short info about your books, the same as on the main page
        }
    }
}
