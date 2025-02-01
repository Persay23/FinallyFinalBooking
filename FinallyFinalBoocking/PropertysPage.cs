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
        public PropertysPage(Room selectedRoom)
        {
            InitializeComponent();
            _selectedRoom = selectedRoom;
        }

        private Room _selectedRoom;

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
            string filePath = null;


            if (File.Exists(@"C:\Users\Orest\Source\Repos\FinallyFinalBooking\FinallyFinalBoocking\DumbStaffDB\AllDescriptios.txt"))
            {
                filePath = @"C:\Users\Orest\Source\Repos\FinallyFinalBooking\FinallyFinalBoocking\DumbStaffDB\AllDescriptios.txt";
            }
            else if (File.Exists(@"C:\Users\qwerd\Source\Repos\FinallyFinalBooking\FinallyFinalBoocking\DumbStaffDB\AllDescriptios.txt"))
            {
                filePath = @"C:\Users\qwerd\Source\Repos\FinallyFinalBooking\FinallyFinalBoocking\DumbStaffDB\AllDescriptios.txt";
            }
            else
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
            string roomsFilePath = null;


            if (File.Exists(@"C:\Users\Orest\Source\Repos\FinallyFinalBooking\FinallyFinalBoocking\DumbStaffDB\Rooms.txt"))
            {
                roomsFilePath = @"C:\Users\Orest\Source\Repos\FinallyFinalBooking\FinallyFinalBoocking\DumbStaffDB\Rooms.txt";
            }
            else if (File.Exists(@"C:\Users\qwerd\Source\Repos\FinallyFinalBooking\FinallyFinalBoocking\DumbStaffDB\Rooms.txt"))
            {
                roomsFilePath = @"C:\Users\qwerd\Source\Repos\FinallyFinalBooking\FinallyFinalBoocking\DumbStaffDB\Rooms.txt";
            }
            else
            {
                MessageBox.Show("Hotel rooms list file not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string userRoomsFilePath = null;
            if (File.Exists(@"C:\Users\Orest\Source\Repos\FinallyFinalBooking\FinallyFinalBoocking\DumbStaffDB\users\user_1.txt"))
            {
                userRoomsFilePath = @"C:\Users\Orest\Source\Repos\FinallyFinalBooking\FinallyFinalBoocking\DumbStaffDB\users\user_1.txt";
            }
            else if (File.Exists(@"C:\Users\qwerd\Source\Repos\FinallyFinalBooking\FinallyFinalBoocking\DumbStaffDB\users\user_1.txt"))
            {
                userRoomsFilePath = @"C:\Users\qwerd\Source\Repos\FinallyFinalBooking\FinallyFinalBoocking\DumbStaffDB\users\user_1.txt";
            }
            else
            {
                MessageBox.Show("User reservation data file not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var allRooms = File.ReadAllLines(roomsFilePath).ToList();
            string selectedRoomText = $"{_selectedRoom.HotelId};{_selectedRoom.HotelName};{_selectedRoom.HotelLocation};{_selectedRoom.HotelDateAvb};{_selectedRoom.HotelAmountOfRooms};{_selectedRoom.HotelCostForNight}";

            foreach (var line in allRooms)
            {
                var roomData = line.Split(';');
                if (roomData[0] == _selectedRoom.HotelId.ToString())
                {
                    _selectedRoom.SetReserved(false);
                    break;
                }
            }

            File.WriteAllLines(roomsFilePath, allRooms);

            using (StreamWriter writer = new StreamWriter(userRoomsFilePath, true))
            {
                writer.WriteLine(selectedRoomText);
            }

            MessageBox.Show("Hotel is booked!");

            MainPage mainPage = new MainPage();
            mainPage.DisplayAvailableRooms();
            AccountPage accountPage = new AccountPage(mainPage);
            accountPage.Show();
            this.Hide();
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
