using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using FinallyFinalBoocking.DumbStaffDB.users;
using Microsoft.VisualBasic.ApplicationServices;

namespace FinallyFinalBoocking
{
    public partial class PropertysPage : Form
    {
        private Room _selectedRoom;

        public PropertysPage(Room selectedRoom)
        {
            InitializeComponent();
            _selectedRoom = selectedRoom;
            LoadReviews();
            LoadHotelImage();
            HotelLable();
            DisplayHotelInfo();
        }
        
        private void LoadHotelImage()
        {
            string imagePath = FilePathHelper.GetFilePath($"images\\{_selectedRoom.HotelId}.png");
            if (imagePath == null) return;

            //string imagePath = Path.Combine(imagesFolderPath, $"{_selectedRoom.HotelId}.png");

            if (File.Exists(imagePath))
            {
                personalpictureBox.Image = Image.FromFile(imagePath);
                personalpictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void LoadReviews()
        {
            string reviewsFilePath = FilePathHelper.GetFilePath("AllDescriptios.txt");

            if (string.IsNullOrEmpty(reviewsFilePath) || !File.Exists(reviewsFilePath))
            {
                descriptionTextBox.Text = "No reviews available.";
                return;
            }

            try
            {
                var lines = File.ReadAllLines(reviewsFilePath);
                var reviewBuilder = new System.Text.StringBuilder();

                foreach (string line in lines)
                {
                    var parts = line.Split(';');

                    if (parts.Length > 1 && int.TryParse(parts[0].Trim(), out int reviewHotelId) && reviewHotelId == _selectedRoom.HotelId)
                    {
                        reviewBuilder.AppendLine(parts[1].Trim());
                        reviewBuilder.AppendLine();
                    }
                }

                descriptionTextBox.Text = reviewBuilder.Length > 0 ? reviewBuilder.ToString() : "No reviews available.";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading reviews: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exit2_Click(object sender, EventArgs e)
        {
            new MainPage().Show();
            Close();
        }

        private void reload2_Click(object sender, EventArgs e)
        {
            LoadReviews();
        }

        private void buyBtn_Click(object sender, EventArgs e)
        {
            string roomsFilePath = FilePathHelper.GetFilePath("Rooms.txt");
            string userRoomsFilePath = FilePathHelper.GetFilePath($"users\\{CurrentUser.Username}.txt");

            if (string.IsNullOrEmpty(roomsFilePath) || string.IsNullOrEmpty(userRoomsFilePath))
                return;

            if (!File.Exists(roomsFilePath) || !File.Exists(userRoomsFilePath))
            {
                MessageBox.Show("Error: Required data files not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var allRooms = File.ReadAllLines(roomsFilePath).ToList();
            string selectedRoomText = $"{_selectedRoom.HotelId};{_selectedRoom.HotelName};{_selectedRoom.HotelLocation};{_selectedRoom.HotelDateAvb};{_selectedRoom.HotelAmountOfRooms};{_selectedRoom.HotelCostForNight};";

            File.WriteAllLines(roomsFilePath, allRooms);
            File.AppendAllText(userRoomsFilePath, selectedRoomText + Environment.NewLine);
            RemoveLine();

            MessageBox.Show("Hotel is booked!");

            MainPage mainPage = new MainPage();
            mainPage.DisplayAvailableRooms();
            new AccountPage(mainPage).Show();
            Hide();
        }
        private void RemoveLine()
        {
            string roomsFilePath = FilePathHelper.GetFilePath("Rooms.txt");
            if (string.IsNullOrEmpty(roomsFilePath) || !File.Exists(roomsFilePath))
                return;

            string selectedRoomText = $"{_selectedRoom.HotelId}; {_selectedRoom.HotelName}; {_selectedRoom.HotelLocation}; {_selectedRoom.HotelDateAvb}; {_selectedRoom.HotelAmountOfRooms}; {_selectedRoom.HotelCostForNight};";

            var tempFile = Path.GetTempFileName();

            var linesToKeep = File.ReadLines(roomsFilePath)
                .Where(line => !line.Trim().StartsWith($"{_selectedRoom.HotelId};"))
                .ToList();

            File.WriteAllLines(tempFile, linesToKeep);
            File.Delete(roomsFilePath);
            File.Move(tempFile, roomsFilePath);
        }


        private void contactBtn_Click(object sender, EventArgs e)
        {
            string contactFilePath = FilePathHelper.GetFilePath("ContactInfo_rooms.txt");
            if (contactFilePath == null || !File.Exists(contactFilePath))
            {
                MessageBox.Show("Contact information not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                foreach (var line in File.ReadLines(contactFilePath))
                {
                    var parts = line.Split(';');
                    if (int.TryParse(parts[0].Trim(), out int currentHotelId) && currentHotelId == _selectedRoom.HotelId)
                    {
                        MessageBox.Show($"Phone: {parts[1].Trim()}\nEmail: {parts[2].Trim()}\nInstagram: {parts[3].Trim()}",
                            "Hotel Contact Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving contact info: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string reviewText = textBox2.Text.Trim();
            if (string.IsNullOrEmpty(reviewText))
            {
                MessageBox.Show("Please enter a review before submitting.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string reviewsFilePath = FilePathHelper.GetFilePath("AllDescriptios.txt");
            if (reviewsFilePath == null)
                return;

            try
            {
                File.AppendAllText(reviewsFilePath, $"{_selectedRoom.HotelId}; {reviewText}{Environment.NewLine}");
                MessageBox.Show("Review submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox2.Clear();
                LoadReviews();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error submitting review: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayHotelInfo()
        {
            hotelInfoLabel.Text = $"Location: {_selectedRoom.HotelLocation}\n" +
                                  $"Available Date: {_selectedRoom.HotelDateAvb}\n" +
                                  $"Rooms Available: {_selectedRoom.HotelAmountOfRooms}\n" +
                                  $"Price per Night: {_selectedRoom.HotelCostForNight} USD";
            hotelNameLabel.Text = _selectedRoom.HotelName;


        }

        private void HotelLable()
        {
            hotelInfoLabel = new Label
            {
                AutoSize = true,
                Location = new Point(233, 140),
                Font = new Font("Arial", 12, FontStyle.Regular)
            };
            Controls.Add(hotelInfoLabel);
        }


        private void personalpictureBox_Click(object sender, EventArgs e)
        {

        }

        private void PropertysPage_Load(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            submitBtn.Visible = false;
        }

        private void descriptionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void hotelNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void commentBtn_Click(object sender, EventArgs e)
        {
            textBox2.Visible = !textBox2.Visible;
            submitBtn.Visible = !submitBtn.Visible;
        }

        private void reserveBtn_Click(object sender, EventArgs e)
        {

        }

        private void descriptionPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}