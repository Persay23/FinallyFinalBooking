using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using FinallyFinalBoocking.DumbStaffDB.users;

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
        }

        private string GetDatabaseFilePath(string fileName)
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            DirectoryInfo dir = new DirectoryInfo(baseDir);

            return Path.Combine(dir.FullName, "DumbStaffDB", fileName);
        }

        private void LoadHotelImage()
        {
            string imagesFolderPath = GetDatabaseFilePath("images");
            if (imagesFolderPath == null) return;

            string imagePath = Path.Combine(imagesFolderPath, $"{_selectedRoom.HotelId}.png");

            if (File.Exists(imagePath))
            {
                personalpictureBox.Image = Image.FromFile(imagePath);
                personalpictureBox.SizeMode = PictureBoxSizeMode.StretchImage; 
            }           
        }

        private void LoadReviews()
        {
            string reviewsFilePath = GetDatabaseFilePath("AllDescriptios.txt");
            if (reviewsFilePath == null || !File.Exists(reviewsFilePath))
            {
                descriptionPoloniaTextBox.Text = "No reviews available.";
                return;
            }

            try
            {
                var lines = File.ReadAllLines(reviewsFilePath);
                descriptionPoloniaTextBox.Clear();

                foreach (string line in lines)
                {
                    var parts = line.Split(';');
                    if (int.TryParse(parts[0].Trim(), out int reviewHotelId) && reviewHotelId == _selectedRoom.HotelId)
                    {
                        descriptionPoloniaTextBox.AppendText(parts[1].Trim() + Environment.NewLine + Environment.NewLine);
                    }
                }
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
            string roomsFilePath = GetDatabaseFilePath("Rooms.txt");
            string userRoomsFilePath = GetDatabaseFilePath($"users\\{CurrentUser.Username}.txt");

            if (roomsFilePath == null || userRoomsFilePath == null)
                return;

            if (!File.Exists(roomsFilePath) || !File.Exists(userRoomsFilePath))
            {
                MessageBox.Show("Error: Required data files not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var allRooms = File.ReadAllLines(roomsFilePath).ToList();
            string selectedRoomText = $"{_selectedRoom.HotelId};{_selectedRoom.HotelName};{_selectedRoom.HotelLocation};{_selectedRoom.HotelDateAvb};{_selectedRoom.HotelAmountOfRooms};{_selectedRoom.HotelCostForNight}";

            File.WriteAllLines(roomsFilePath, allRooms);
            File.AppendAllText(userRoomsFilePath, selectedRoomText + Environment.NewLine);  

            MessageBox.Show("Hotel is booked!");

            MainPage mainPage = new MainPage();
            mainPage.DisplayAvailableRooms();
            new AccountPage(mainPage).Show();
            Hide();
        }

        private void contactBtn_Click(object sender, EventArgs e)
        {
            string contactFilePath = GetDatabaseFilePath("ContactInfo_rooms.txt");
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

            string reviewsFilePath = GetDatabaseFilePath("AllDescriptios.txt");
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


        private void personalpictureBox_Click(object sender, EventArgs e)
        {
        }

        private void PropertysPage_Load(object sender, EventArgs e)
        {
        }

        private void descriptionTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

    }
}