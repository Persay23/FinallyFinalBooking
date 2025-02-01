using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinallyFinalBoocking
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    public partial class AccountPage : Form
    {

        private List<Room> _rooms = new List<Room>();
        private void accountNameTextBOx_TextChanged(object sender, EventArgs e)
        {
            // This will display your username and you can cange it
        }

        private PropertysPage _propertyPage;
        private MainPage _mainPage;
        private string userRoomsFilePath;
        public AccountPage(MainPage mainPage, PropertysPage propertyPage = null, string filePath = null)
        {
            
            _mainPage = mainPage;
            _propertyPage = propertyPage;
            InitializeComponent();
            userRoomsFilePath = filePath;
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

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            _mainPage.Show();
            this.Close();
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

        private string GetDebuggerDisplay()
        {
            return ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            int groupBoxHeight = 150;
            int spacing = 10;
            int currentY = 10;

            string userRoomsFilePath = null;
            if (File.Exists(@"C:\Users\Orest\Source\Repos\FinallyFinalBooking\FinallyFinalBoocking\DumbStaffDB\users\user_2.txt"))
            {
                userRoomsFilePath = @"C:\Users\Orest\Source\Repos\FinallyFinalBooking\FinallyFinalBoocking\DumbStaffDB\users\user_2.txt";
            }
            else if (File.Exists(@"C:\Users\qwerd\Source\Repos\FinallyFinalBooking\FinallyFinalBoocking\DumbStaffDB\users\user_2.txt"))
            {
                userRoomsFilePath = @"C:\Users\qwerd\Source\Repos\FinallyFinalBooking\FinallyFinalBoocking\DumbStaffDB\users\user_2.txt";
            }
            else
            {
                MessageBox.Show("User reservation data file not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _rooms.Clear();

            var ReservedHotelLines = File.ReadLines(userRoomsFilePath);

            foreach (var line in ReservedHotelLines)
            {
                var split = line.Split(";");

                var hotelId = int.Parse(split[0]);
                var hotelName = split[1];
                var hotelLocation = split[2];
                var hotelDateAvb = split[3];
                var hotelAmount = int.Parse(split[4]);
                var hotelTotalCost = int.Parse(split[5]);
                var reservedOrNot = true;

                var reservedroom = new Room(hotelId, hotelName, hotelLocation, hotelDateAvb, hotelAmount, hotelTotalCost, reservedOrNot);
                _rooms.Add(reservedroom);
            }


            foreach (var reservedroom in _rooms)
            {

                var existingGroupBox = panel1.Controls.OfType<GroupBox>().FirstOrDefault(g => g.Text == reservedroom.HotelName);
                if (existingGroupBox != null)
                {
                    continue;
                }

                GroupBox groupBox = new GroupBox
                {
                    Text = reservedroom.HotelName,
                    AutoSize = true,
                    Location = new Point((panel1.Width - 500) / 2, currentY),
                };

                Label locationLabel = new Label
                {
                    Text = $"Location: {reservedroom.HotelLocation}",
                    Location = new Point(10, 20),
                    AutoSize = true
                };

                Label datesLabel = new Label
                {
                    Text = $"Available Dates: {reservedroom.HotelDateAvb}",
                    Location = new Point(10, 40),
                    AutoSize = true
                };

                Label roomsLabel = new Label
                {
                    Text = $"Rooms: {reservedroom.HotelAmountOfRooms}",
                    Location = new Point(10, 60),
                    AutoSize = true
                };

                Label priceLabel = new Label
                {
                    Text = $"Price: {reservedroom.HotelCostForNight} USD/night",
                    Location = new Point(10, 80),
                    AutoSize = true
                };

                Button canclebutton = new Button
                {
                    Text = "Cancle",
                    Location = new Point(10, 100),
                    AutoSize = true,
                    Tag = reservedroom
                };

                Button showpropbutton = new Button
                {
                    Text = "Open Hotel",
                    Location = new Point(100, 100),
                    AutoSize = true,
                    Tag = reservedroom
                };
                showpropbutton.Click += ShowPropertyPage;

                PictureBox pictureBox = new PictureBox
                {
                    Size = new Size(200, 110),
                    Location = new Point(320, 20),
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
                    MessageBox.Show("Image file not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                pictureBox.ImageLocation = imagePath;

                groupBox.Controls.Add(locationLabel);
                groupBox.Controls.Add(datesLabel);
                groupBox.Controls.Add(roomsLabel);
                groupBox.Controls.Add(priceLabel);
                groupBox.Controls.Add(canclebutton);
                groupBox.Controls.Add(showpropbutton);
                groupBox.Controls.Add(pictureBox);

                panel1.Controls.Add(groupBox);

                currentY += groupBoxHeight + spacing;
            }
        }

        private void LoadUserData()
        {
            string userRoomsFilePath = GetFilePath() /*@"C:\Users\Orest\Source\Repos\FinallyFinalBooking\FinallyFinalBoocking\DumbStaffDB\users\user_1.txt"*/;

            if (File.Exists(userRoomsFilePath))
            {
                var userData = File.ReadAllText(userRoomsFilePath).Split(';');

                if (userData.Length >= 4)
                {
                    accountNameTextBOx.Text = userData[0].Trim();
                    accountPasswordTextBox.Text = userData[1].Trim();
                    statusTextBox.Text = userData[2].Trim();
                    bookingCounterTextBox.Text = userData[3].Trim();
                }
                else
                {
                    MessageBox.Show("User data file is incomplete. Please check the file contents.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("User data file not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetFilePath()
        {
            string[] possiblePaths = {
                @"C:\Users\Orest\Source\Repos\FinallyFinalBooking\FinallyFinalBoocking\DumbStaffDB\users\user_2.txt",
                @"C:\Users\qwerd\Source\Repos\FinallyFinalBooking\FinallyFinalBoocking\DumbStaffDB\users\user_2.txt"
            };

            foreach (var path in possiblePaths)
            {
                if (File.Exists(path))
                {
                    return path;
                }
            }

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
    }
}
