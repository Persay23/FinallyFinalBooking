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


        public MainPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // this shold open new window with personal data
        }


        private void openbtn_Click(object sender, EventArgs e)
        {


            string path1 = @"C:\Users\Orest\Source\Repos\FinallyFinalBooking\FinallyFinalBoocking\DumbStaffDB\Rooms.txt";
            string path2 = @"C:\Users\qwerd\Source\Repos\FinallyFinalBooking\FinallyFinalBoocking\DumbStaffDB\Rooms.txt";
            string selectedPath = null;


            if (File.Exists(path1))
            {
                selectedPath = path1;
            }
            else if (File.Exists(path2))
            {
                selectedPath = path2;
            }
            else
            {
                MessageBox.Show("User data file not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                var room = new Room(hotelId, hotelName, hotelName, hotelDateAvb, hotelAmount, hotelTotalCost);
                _rooms.Add(room);

                hotelNameTextBox.Text = String.Join(Environment.NewLine, hotelName);
                hotelLocationTextBox.Text = String.Join(Environment.NewLine, hotelLocation);
                hotelDateAvbTextBox.Text = String.Join(Environment.NewLine, hotelDateAvb);
                hotelAmountOfRoomsTextBox.Text = String.Join(Environment.NewLine, hotelAmount);
                hotelTotalCostTextBox.Text = String.Join(Environment.NewLine, hotelTotalCost);

            }

            hotelsScrollMenu(_rooms);
        }



        private void Exitbtn2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            // this should work as a search
        }

        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this should work as a filter
        }



        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
        }

        private void PictureBox_Load(object sender, EventArgs e)
        {
            string logoPath = @"C:\Users\Orest\Source\Repos\FinallyFinalBooking\FinallyFinalBoocking\DumbStaffDB\Screenshot 2024-12-10 023140.png";

            if (File.Exists(logoPath))
            {
                pictureBox1.Image = Image.FromFile(logoPath);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                MessageBox.Show("Image file not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void showRoomsBtn_Click_1(object sender, EventArgs e)
        {
            var newPropertyPage = new PropertysPage();
            newPropertyPage.Show();
            this.Hide();
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
                // this button should open the property page
                //Button button = new Button
                //{
                //    Text = "Show",
                //    Location = new Point(10, groupBox.Height - 40),
                //    AutoSize = true,
                //};

                //PictureBox pictureBox = new PictureBox
                //{
                //    Size = new Size(200, 200),
                //    Location = new Point(10, 10),
                //    BorderStyle = BorderStyle.Fixed3D
                //};

                //pictureBox.ImageLocation = @"C:\Users\Orest\Source\Repos\FinallyFinalBooking\FinallyFinalBoocking\DumbStaffDB\Screenshot 2024-12-10 023140.png";

                groupBox.Controls.Add(locationLabel);
                groupBox.Controls.Add(datesLabel);
                groupBox.Controls.Add(roomsLabel);
                groupBox.Controls.Add(priceLabel);
                //groupBox.Controls.Add(button);
                //groupBox.Controls.Add(pictureBox);

                scrollablePanel.Controls.Add(groupBox);

                currentY += groupBoxHeight + spacing;

            }
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            
            
        }
    }
}
