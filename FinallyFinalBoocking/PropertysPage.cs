using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.LinkLabel;

namespace FinallyFinalBoocking
{
    public partial class PropertysPage : Form
    {
        public PropertysPage()
        {
            InitializeComponent();
        }

        private void descriptionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void exit2_Click(object sender, EventArgs e)
        {
            var newMainPage = new MainPage();
            newMainPage.Show();
            this.Close();
        }
        private void reload2_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\Orest\source\repos\FinallyFinalBoocking - Copy\FinallyFinalBoocking\DumbStaffDB\AllDescriptios.txt";

            if (!File.Exists(filePath))
            {
                MessageBox.Show("The file does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var lines = File.ReadAllLines(filePath);

                descriptionPoloniaTextBox.Clear();

                foreach (string line in lines)
                {
                    var splitTheDescription = line.Split('/');

                    var description = splitTheDescription[0];

                    descriptionPoloniaTextBox.AppendText(description + Environment.NewLine);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while reading the file: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buyBtn_Click(object sender, EventArgs e)
        {
            var newAccountPage = new AccountPage();
            newAccountPage.Show();
            this.Hide();

            // it also has to hide this advertisment from main page
        }

        private void contactBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phone: +1 (123) 456-7890\nEmail: contact@hotel.com\nInstagram: @hotel_official",
                            "Hotel Contact Information",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //here i should be able to add comment to the comment section
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            //submiting the reviwe
        }

        private void personalpictureBox_Click(object sender, EventArgs e)
        {
            // a picture of the hotel
        }
    }
}
