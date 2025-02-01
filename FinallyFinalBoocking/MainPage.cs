using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace FinallyFinalBoocking
{
    public partial class MainPage : Form
    {
        private List<Room> _rooms = new List<Room>();
        private bool roomsLoaded = false;
        public Room SelectedRoom { get; private set; }
        public MainPage()
        {
            InitializeComponent();
            DisplayAvailableRooms();
        }
        private void MainPage_Load(object sender, EventArgs e)
        {
            RefreshHotelList();
            comboBoxFilter.Items.Add("By Name ↓");
            comboBoxFilter.Items.Add("By Name ↑");
            comboBoxFilter.Items.Add("By Price ↓");
            comboBoxFilter.Items.Add("By Price ↑");
            comboBoxFilter.Items.Add("By Rooms ↓");
            comboBoxFilter.Items.Add("By Rooms ↑");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var accountPage = new AccountPage(this);
            accountPage.Show();
            this.Hide();
        }


        private void openbtn_Click(object sender, EventArgs e)
        {
            if (roomsLoaded) return;

            string selectedPath = null;
            if (File.Exists(@"C:\Users\Orest\Source\Repos\FinallyFinalBooking\FinallyFinalBoocking\DumbStaffDB\Rooms.txt"))
            {
                selectedPath = @"C:\Users\Orest\Source\Repos\FinallyFinalBooking\FinallyFinalBoocking\DumbStaffDB\Rooms.txt";
            }
            else if (File.Exists(@"C:\Users\qwerd\Source\Repos\FinallyFinalBooking\FinallyFinalBoocking\DumbStaffDB\Rooms.txt"))
            {
                selectedPath = @"C:\Users\qwerd\Source\Repos\FinallyFinalBooking\FinallyFinalBoocking\DumbStaffDB\Rooms.txt";
            }
            else
            {
                MessageBox.Show("Hotel rooms list not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var lines = File.ReadLines(selectedPath);

            foreach (var line in lines)
            {
                var split = line.Split(";");

                var hotelId = int.Parse(split[0]);
                var hotelName = split[1];
                var hotelLocation = split[2];
                var hotelDateAvb = split[3];
                var hotelAmount = int.Parse(split[4]);
                var hotelTotalCost = int.Parse(split[5]);
                var reservedOrNot = bool.Parse(split[6]);
                var room = new Room(hotelId, hotelName, hotelLocation, hotelDateAvb, hotelAmount, hotelTotalCost, reservedOrNot);
                _rooms.Add(room);
            }

            roomsLoaded = true;
            hotelsScrollMenu(_rooms);
        }



        private void Exitbtn2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = searchTextBox.Text.ToLower();

            var filteredRooms = _rooms.Where(room => room.HotelName.ToLower().Contains(searchTerm)).ToList();

            hotelsScrollMenu(filteredRooms);
        }

        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFilter = comboBoxFilter.SelectedItem.ToString();

            List<Room> sortedRooms = new List<Room>();

            switch (selectedFilter)
            {
                case "By Name ↓":
                    sortedRooms = _rooms.OrderBy(room => room.HotelName).ToList();
                    break;

                case "By Name ↑":
                    sortedRooms = _rooms.OrderByDescending(room => room.HotelName).ToList();
                    break;

                case "By Price ↓":
                    sortedRooms = _rooms.OrderBy(room => room.HotelCostForNight).ToList();
                    break;

                case "By Price ↑":
                    sortedRooms = _rooms.OrderByDescending(room => room.HotelCostForNight).ToList();
                    break;

                case "By Rooms ↓":
                    sortedRooms = _rooms.OrderBy(room => room.HotelAmountOfRooms).ToList();
                    break;

                case "By Rooms ↑":
                    sortedRooms = _rooms.OrderByDescending(room => room.HotelAmountOfRooms).ToList();
                    break;

                default:
                    sortedRooms = _rooms;
                    break;
            }
            hotelsScrollMenu(sortedRooms);
        }

        public void DisplayAvailableRooms()
        {
            string roomsFilePath = GetFilePath() /*@"C:\Users\Orest\Source\Repos\FinallyFinalBooking\FinallyFinalBoocking\DumbStaffDB\Rooms.txt"*/;

            var allRooms = File.ReadAllLines(roomsFilePath).ToList();
            var availableRooms = allRooms
                .Select(line => line.Split(';'))
                .Select(parts => new Room(
                    int.Parse(parts[0]),
                    parts[1],
                    parts[2],
                    parts[3],
                    int.Parse(parts[4]),
                    int.Parse(parts[5]),
                    bool.Parse(parts[6])
                ))
                .Where(room => !room.ReservedOrNot)
                .ToList();

            hotelsScrollMenu(availableRooms);
        }
        private string GetFilePath()
        {
            string[] possiblePaths = {
                @"C:\Users\Orest\Source\Repos\FinallyFinalBooking\FinallyFinalBoocking\DumbStaffDB\Rooms.txt",
                @"C:\Users\qwerd\Source\Repos\FinallyFinalBooking\FinallyFinalBoocking\DumbStaffDB\Rooms.txt"
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


        private void hotelsScrollMenu(List<Room> rooms)
        {
            scrollablePanel.Controls.Clear();

            int groupBoxHeight = 150;
            int spacing = 10;
            int currentY = 10;

            foreach (var room in rooms)
            {
                GroupBox groupBox = new GroupBox
                {
                    Text = room.HotelName,
                    AutoSize = true,
                    Location = new Point((scrollablePanel.Width - 500) / 2, currentY),
                };

                Label locationLabel = new Label
                {
                    Text = $"Location: {room.HotelLocation}",
                    Location = new Point(10, 20),
                    AutoSize = true
                };

                Label datesLabel = new Label
                {
                    Text = $"Available Dates: {room.HotelDateAvb}",
                    Location = new Point(10, 40),
                    AutoSize = true
                };

                Label roomsLabel = new Label
                {
                    Text = $"Rooms: {room.HotelAmountOfRooms}",
                    Location = new Point(10, 60),
                    AutoSize = true
                };

                Label priceLabel = new Label
                {
                    Text = $"Price: {room.HotelCostForNight} USD/night",
                    Location = new Point(10, 80),
                    AutoSize = true
                };

                Button button = new Button
                {
                    Text = "Show",
                    Location = new Point(10, 100),
                    AutoSize = true,
                    Tag = room
                };
                button.Click += ShowPropertyPage;

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
                    MessageBox.Show("Hotel photo not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                pictureBox.ImageLocation = imagePath;

                groupBox.Controls.Add(locationLabel);
                groupBox.Controls.Add(datesLabel);
                groupBox.Controls.Add(roomsLabel);
                groupBox.Controls.Add(priceLabel);
                groupBox.Controls.Add(button);
                groupBox.Controls.Add(pictureBox);

                scrollablePanel.Controls.Add(groupBox);

                currentY += groupBoxHeight + spacing;
            }
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

        public void SetSelectedRoom(Room room)
        {
            SelectedRoom = room;
        }

        public void RefreshHotelList()
        {
            _rooms.Clear();
            scrollablePanel.Controls.Clear();
            openbtn_Click(null, null);
        }
    }
}
