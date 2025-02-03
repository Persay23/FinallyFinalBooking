using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace FinallyFinalBoocking
{
    public partial class AdminPage : Form
    {
        private string roomsFilePath = @"C:\Users\Orest\Source\Repos\FinallyFinalBooking\FinallyFinalBoocking\DumbStaffDB\Rooms.txt";
        private string usersFilePath = @"C:\Users\Orest\Source\Repos\FinallyFinalBooking\FinallyFinalBoocking\DumbStaffDB\UserPasswdDumbDb.txt";
        private Form parentForm;
        private AccountPage _accountPage;
        public AdminPage(object sender, EventArgs e, AccountPage accountPage, Form parent)
        {
            InitializeComponent();
            parentForm = parent;
            _accountPage = accountPage;
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {

        }

        private void buttonCRHotel_Click_1(object sender, EventArgs e)
        {
            string id = textBoxCRID.Text;
            string name = textBoxCRName.Text;
            string location = textBoxCRLoc.Text;
            string availability = textBoxCRAvb.Text;
            string rooms = textBoxCRRooms.Text;
            string price = textBoxCRPrice.Text;

            string hotelData = $"{id};{name};{location};{availability};{rooms};{price}";
            File.AppendAllText(roomsFilePath, hotelData + Environment.NewLine);

            MessageBox.Show("Hotel added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonRMHotel_Click(object sender, EventArgs e)
        {
            string hotelIdToRemove = textBoxRMId.Text;
            var lines = File.ReadAllLines(roomsFilePath).ToList();
            lines.RemoveAll(line => line.StartsWith(hotelIdToRemove + ";"));
            File.WriteAllLines(roomsFilePath, lines);

            MessageBox.Show("Hotel removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonRMUser_Click(object sender, EventArgs e)
        {
            string usernameToRemove = textBoxRMusername.Text;
            string adminUsername = "admin";

            if (usernameToRemove.Equals(adminUsername, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("You cannot remove the admin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var lines = File.ReadAllLines(usersFilePath).ToList();
            lines.RemoveAll(line => line.StartsWith(usernameToRemove + ";"));
            File.WriteAllLines(usersFilePath, lines);

            MessageBox.Show("User removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void returnToAcc_Click(object sender, EventArgs e)
        {
            _accountPage.Show();
            this.Close();
        }
        

        public Room SelectedRoom { get; private set; }

        public void SetSelectedRoom(Room room)
        {
            SelectedRoom = room;
        }
    }
}
