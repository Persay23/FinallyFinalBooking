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
using FinallyFinalBoocking.DumbStaffDB.users;
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
            string reviewsFilePath = null;

            if (File.Exists(@"C:\Users\Orest\Source\Repos\FinallyFinalBooking\FinallyFinalBoocking\DumbStaffDB\AllDescriptios.txt"))
            {
                reviewsFilePath = @"C:\Users\Orest\Source\Repos\FinallyFinalBooking\FinallyFinalBoocking\DumbStaffDB\AllDescriptios.txt";
            }
            else if (File.Exists(@"C:\Users\qwerd\Source\Repos\FinallyFinalBooking\FinallyFinalBoocking\DumbStaffDB\AllDescriptios.txt"))
            {
                reviewsFilePath = @"C:\Users\qwerd\Source\Repos\FinallyFinalBooking\FinallyFinalBoocking\DumbStaffDB\AllDescriptios.txt";
            }
            else
            {
                MessageBox.Show("Reviews file not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var lines = File.ReadAllLines(reviewsFilePath);
                descriptionPoloniaTextBox.Clear();

                foreach (string line in lines)
                {
                    var parts = line.Split(';');

                    int reviewHotelId = int.Parse(parts[0].Trim());

                    if (reviewHotelId == _selectedRoom.HotelId)
                    {
                        string reviewText = parts[1].Trim();
                        descriptionPoloniaTextBox.AppendText(reviewText + Environment.NewLine + Environment.NewLine);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while reading the reviews file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (File.Exists($@"C:\Users\Orest\Source\Repos\FinallyFinalBooking\FinallyFinalBoocking\DumbStaffDB\users\{CurrentUser.Username}.txt"))
            {
                userRoomsFilePath = $@"C:\Users\Orest\Source\Repos\FinallyFinalBooking\FinallyFinalBoocking\DumbStaffDB\users\{CurrentUser.Username}.txt";
            }
            else if (File.Exists($@"C:\Users\qwerd\Source\Repos\FinallyFinalBooking\FinallyFinalBoocking\DumbStaffDB\users\{CurrentUser.Username}.txt"))
            {
                userRoomsFilePath = $@"C:\Users\qwerd\Source\Repos\FinallyFinalBooking\FinallyFinalBoocking\DumbStaffDB\users\{CurrentUser.Username}.txt";
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
            string contactFilePath = null;

            if (File.Exists(@"C:\Users\Orest\Source\Repos\FinallyFinalBooking\FinallyFinalBoocking\DumbStaffDB\ContactInfo_rooms.txt"))
            {
                contactFilePath = @"C:\Users\Orest\Source\Repos\FinallyFinalBooking\FinallyFinalBoocking\DumbStaffDB\ContactInfo_rooms.txt";
            }
            else if (File.Exists(@"C:\Users\qwerd\Source\Repos\FinallyFinalBooking\FinallyFinalBoocking\DumbStaffDB\ContactInfo_rooms.txt"))
            {
                contactFilePath = @"C:\Users\qwerd\Source\Repos\FinallyFinalBooking\FinallyFinalBoocking\DumbStaffDB\ContactInfo_rooms.txt";
            }
            else
            {
                MessageBox.Show("Contact information file not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string hotelPhone = string.Empty;
            string hotelEmail = string.Empty;
            string hotelInst = string.Empty;

            foreach (var line in File.ReadLines(contactFilePath))
            {
                var parts = line.Split(';');

                int currentHotelId = int.Parse(parts[0].Trim());

                if (currentHotelId == _selectedRoom.HotelId)
                {
                    hotelPhone = parts[1].Trim();
                    hotelEmail = parts[2].Trim();
                    hotelInst = parts[3].Trim();
                    break;
                }
            }

            MessageBox.Show(
                $"Phone: {hotelPhone}\nEmail: {hotelEmail}\nInstagram: {hotelInst}",
                "Hotel Contact Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //here i should be able to add comment to the comment section
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string reviewText = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(reviewText))
            {
                MessageBox.Show("Please enter a review before submitting.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string reviewsFilePath = null;
            if (File.Exists(@"C:\Users\Orest\Source\Repos\FinallyFinalBooking\FinallyFinalBoocking\DumbStaffDB\AllDescriptios.txt"))
            {
                reviewsFilePath = @"C:\Users\Orest\Source\Repos\FinallyFinalBooking\FinallyFinalBoocking\DumbStaffDB\AllDescriptios.txt";
            }
            else if (File.Exists(@"C:\Users\qwerd\Source\Repos\FinallyFinalBooking\FinallyFinalBoocking\DumbStaffDB\AllDescriptios.txt"))
            {
                reviewsFilePath = @"C:\Users\qwerd\Source\Repos\FinallyFinalBooking\FinallyFinalBoocking\DumbStaffDB\AllDescriptios.txt";
            }
            else
            {
                MessageBox.Show("Review file not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string reviewEntry = $"{_selectedRoom.HotelId}; {reviewText}";

            try
            {
                using (StreamWriter writer = new StreamWriter(reviewsFilePath, true))
                {
                    writer.WriteLine(reviewEntry);
                }
                MessageBox.Show("Review submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textBox2.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while submitting review: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void personalpictureBox_Click(object sender, EventArgs e)
        {
            // a picture of the hotel
        }

        private void PropertysPage_Load(object sender, EventArgs e)
        {

        }
    }
}
