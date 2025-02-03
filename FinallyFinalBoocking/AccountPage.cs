using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinallyFinalBoocking.DumbStaffDB.users;
using Microsoft.VisualBasic.ApplicationServices;

namespace FinallyFinalBoocking
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    public partial class AccountPage : Form
    {
        private List<Room> _rooms = new List<Room>();
        private PropertysPage _propertyPage;
        private MainPage _mainPage;
        private string userRoomsFilePath;

        public AccountPage(MainPage mainPage, PropertysPage propertyPage = null, string filePath = null)
        {
            _mainPage = mainPage;
            _propertyPage = propertyPage;
            InitializeComponent();
            userRoomsFilePath = filePath ?? GetCurrentUserFilePath();
            LoadUserData();
            DisplayBookings();
        }

        private void exit3_Click(object sender, EventArgs e)
        {
            if (_propertyPage != null)
            {
                _propertyPage.Show();
            }
            else
            {
                _mainPage.Show();
            }
            this.Close();
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            int groupBoxHeight = 150;
            int spacing = 150;
            int currentY = 10;

            string currentUserFilePath = GetCurrentUserFilePath();
            if (currentUserFilePath == null)
            {
                MessageBox.Show("User reservation data file not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _rooms.Clear();
            var reservedHotelLines = File.ReadAllLines(currentUserFilePath);

            foreach (var line in reservedHotelLines)
            {
                var split = line.Split(';');
                if (split.Length < 6)
                    continue;

                var hotelId = int.Parse(split[0]);
                var hotelName = split[1];
                var hotelLocation = split[2];
                var hotelDateAvb = split[3];
                var hotelAmount = int.Parse(split[4]);
                var hotelTotalCost = int.Parse(split[5]);
                bool reservedOrNot = true;
                var reservedRoom = new Room(hotelId, hotelName, hotelLocation, hotelDateAvb, hotelAmount, hotelTotalCost, reservedOrNot);
                _rooms.Add(reservedRoom);
            }


            foreach (var reservedRoom in _rooms)
            {
                var existingGroupBox = panel1.Controls.OfType<GroupBox>().FirstOrDefault(g => g.Text == reservedRoom.HotelName);
                if (existingGroupBox != null)
                    continue;

                GroupBox groupBox = new GroupBox
                {
                    Text = reservedRoom.HotelName,
                    AutoSize = true,
                    Location = new Point((panel1.Width - 570) / 2, currentY),
                };

                Label locationLabel = new Label
                {
                    Text = $"Location: {reservedRoom.HotelLocation}",
                    Location = new Point(10, 40),
                    AutoSize = true
                };

                Label datesLabel = new Label
                {
                    Text = $"Available Dates: {reservedRoom.HotelDateAvb}",
                    Location = new Point(10, 80),
                    AutoSize = true
                };

                Label roomsLabel = new Label
                {
                    Text = $"Rooms: {reservedRoom.HotelAmountOfRooms}",
                    Location = new Point(10, 120),
                    AutoSize = true
                };

                Label priceLabel = new Label
                {
                    Text = $"Price: {reservedRoom.HotelCostForNight} USD/night",
                    Location = new Point(10, 160),
                    AutoSize = true
                };

                Button cancelButton = new Button
                {
                    Text = "Cancel",
                    Location = new Point(10, 200),
                    AutoSize = true,
                    Tag = reservedRoom,
                    BackColor = Color.RoyalBlue,
                    FlatAppearance = { BorderSize = 0, MouseDownBackColor = Color.DodgerBlue, MouseOverBackColor = Color.DodgerBlue },
                    FlatStyle = FlatStyle.Flat,
                    ForeColor = Color.White,
                    UseVisualStyleBackColor = false
                };
                cancelButton.Click += CancelRoom;

                Button showPropButton = new Button
                {
                    Text = "Open Hotel",
                    Location = new Point(100, 200),
                    AutoSize = true,
                    Tag = reservedRoom,
                    BackColor = Color.RoyalBlue,
                    FlatAppearance = { BorderSize = 0, MouseDownBackColor = Color.DodgerBlue, MouseOverBackColor = Color.DodgerBlue },
                    FlatStyle = FlatStyle.Flat,
                    ForeColor = Color.White,
                    UseVisualStyleBackColor = false
                };
                showPropButton.Click += ShowPropertyPage;

                PictureBox pictureBox = new PictureBox
                {
                    Size = new Size(200, 200),
                    Location = new Point(360, 35),
                    BorderStyle = BorderStyle.Fixed3D,
                    SizeMode = PictureBoxSizeMode.StretchImage
                };

                string imagePath = null;
                if (File.Exists(@"C:\Users\Orest\Source\Repos\FinallyFinalBooking\FinallyFinalBoocking\DumbStaffDB\Screenshot 2024-12-10 023140.png"))
                {
                    imagePath = @"C:\Users\Orest\Source\Repos\FinallyFinalBooking\FinallyFinalBoocking\DumbStaffDB\Screenshot 2024-12-10 023140.png";
                }
                else if (File.Exists(@"C:\Users\qwerd\Source\Repos\FinallyFinalBooking\FinallyFinalBoocking\DumbStaffDB\Screenshot 2024-12-10 023140.png"))
                {
                    imagePath = @"C:\Users\qwerd\Source\Repos\FinallyFinalBooking\FinallyFinalBoocking\DumbStaffDB\Screenshot 2024-12-10 023140.png";
                }
                else
                {
                    MessageBox.Show("Hotel photo not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                pictureBox.ImageLocation = imagePath;
                groupBox.Controls.Add(locationLabel);
                groupBox.Controls.Add(datesLabel);
                groupBox.Controls.Add(roomsLabel);
                groupBox.Controls.Add(priceLabel);
                groupBox.Controls.Add(cancelButton);
                groupBox.Controls.Add(showPropButton);
                groupBox.Controls.Add(pictureBox);
                panel1.Controls.Add(groupBox);

                currentY += groupBoxHeight + spacing;
            }
        }

        private void CancelRoom(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton == null || !(clickedButton.Tag is Room selectedRoom))
                return;
            string userFilePath = GetCurrentUserFilePath();
            string roomsFilePath = @"C:\Users\qwerd\Source\Repos\FinallyFinalBooking\FinallyFinalBoocking\DumbStaffDB\Rooms.txt";

            if (userFilePath == null || roomsFilePath == null || !File.Exists(userFilePath))
            {
                MessageBox.Show("File paths not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string selectedRoomText = $"{selectedRoom.HotelId};{selectedRoom.HotelName};{selectedRoom.HotelLocation};{selectedRoom.HotelDateAvb};{selectedRoom.HotelAmountOfRooms};{selectedRoom.HotelCostForNight};";

            var tempUserFile = Path.GetTempFileName();
            var userLines = File.ReadLines(userFilePath)
                                .Where(line => !line.Trim().StartsWith($"{selectedRoom.HotelId};"))
                                .ToList();

            File.WriteAllLines(tempUserFile, userLines);
            File.Delete(userFilePath);
            File.Move(tempUserFile, userFilePath);

            File.AppendAllText(roomsFilePath, selectedRoomText + Environment.NewLine);

            MessageBox.Show($"Room {selectedRoom.HotelName} has been canceled.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            panel1.Controls.Clear();
            DisplayBookings();
        }

        private void LoadUserData()
        {
            string currentUserFilePath = GetCurrentUserInfoFilePath();

            if (File.Exists(currentUserFilePath))
            {
                var allUserData = File.ReadAllLines(currentUserFilePath);
                string currentUserData = null;

                string userBookingsFilePath = GetUserBookingsFilePath(CurrentUser.Username);
                NumberOfBookingsCounter(userBookingsFilePath);

                foreach (var line in allUserData)
                {
                    var userData = line.Split(';');
                    if (userData.Length >= 3 && userData[0].Trim() == CurrentUser.Username)
                    {
                        currentUserData = line;
                        break;
                    }
                }

                if (currentUserData != null)
                {
                    var userData = currentUserData.Split(';');
                    textBox1.Text = userData[0].Trim();
                    textBox2.Text = userData[1].Trim();
                    textBox3.Text = userData[2].Trim();
                }
                else
                {
                    MessageBox.Show("User data not found for the logged-in user!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("User data file not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NumberOfBookingsCounter(string userBookingsFilePath)
        {
            if (File.Exists(userBookingsFilePath))
            {

                var lines = File.ReadLines(userBookingsFilePath);
                var numberOfBookings = lines.Count();

                textBox4.Text = numberOfBookings.ToString();
            }
            else
            {
                MessageBox.Show("User bookings file not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetUserBookingsFilePath(string username)
        {
            // Assuming the bookings are stored in a separate file per user
            return $@"C:\Users\qwerd\Source\Repos\FinallyFinalBooking\FinallyFinalBoocking\DumbStaffDB\users\{username}.txt";
        }

        private string GetCurrentUserFilePath()
        {
            string path1 = $@"C:\Users\Orest\Source\Repos\FinallyFinalBooking\FinallyFinalBoocking\DumbStaffDB\users\{CurrentUser.Username}.txt";
            string path2 = $@"C:\Users\qwerd\Source\Repos\FinallyFinalBooking\FinallyFinalBoocking\DumbStaffDB\users\{CurrentUser.Username}.txt";

            if (File.Exists(path1))
                return path1;
            if (File.Exists(path2))
                return path2;

            return null;
        }

        private string GetCurrentUserInfoFilePath()
        {
            string path1 = $@"C:\Users\Orest\Source\Repos\FinallyFinalBooking\FinallyFinalBoocking\DumbStaffDB\users\usersInfo.txt";
            string path2 = $@"C:\Users\qwerd\Source\Repos\FinallyFinalBooking\FinallyFinalBoocking\DumbStaffDB\users\usersInfo.txt";

            if (File.Exists(path1))
                return path1;
            if (File.Exists(path2))
                return path2;

            return null;
        }

        private void DisplayBookings()
        {
            panel1_Paint(null, null);
        }

        private void ShowPropertyPage(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton.Tag is Room selectedRoom)
            {
                SetSelectedRoom(selectedRoom);

                var newPropertyPage = new PropertysPage(selectedRoom);
                newPropertyPage.Show();
                this.Hide();
            }
        }

        public Room SelectedRoom { get; private set; }

        public void SetSelectedRoom(Room room)
        {
            SelectedRoom = room;
        }

        private void AccountPage_Load(object sender, EventArgs e)
        {
            LoadUserData();
            string loggedInUsername = GetLoggedInUsername();
            ShowAdminBttn(loggedInUsername);
        }

        private void ShowAdminBttn(string loggedInUsername)
        {
            if (loggedInUsername.Equals("admin", StringComparison.OrdinalIgnoreCase))
            {
                button1.Visible = true;
            }
            else
            {
                button1.Visible = false;
            }
        }
        private string GetLoggedInUsername()
        {
            return CurrentUser.Username;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var adminPage = new AdminPage(sender, e, this, this);
            adminPage.Show();
            this.Hide();
        }

        private void logOutbttn_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms.Cast<Form>().ToList())
            {
                if (!(form is Cover))
                {
                    form.Close();
                }
            }
            Cover coverPage = new Cover();
            coverPage.Show();

        }
    }
}
