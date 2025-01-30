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
        //public AccountPage()
        //{
        //    InitializeComponent();
        //}

        private void accountNameTextBOx_TextChanged(object sender, EventArgs e)
        {
            // This will display your username and you can cange it
        }

        private PropertysPage _propertyPage;

        public AccountPage(PropertysPage propertyPage)
        {
            InitializeComponent();
            _propertyPage = propertyPage;
        }

        //public static Room SelectedRoom { get; set; }

        private void exit3_Click(object sender, EventArgs e)
        {
            _propertyPage.Show();
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            //this should return the hotel to the main page
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

        private void theBookedOneTextBox_TextChanged(object sender, EventArgs e)
        {
            // Here will be short info about your books, the same as on the main page
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //    panel1.Controls.Clear();

            //    int groupBoxHeight = 150;
            //    int spacing = 10;
            //    int currentY = 10;

            //    //var reservedRooms = new List<int>();

            //    foreach (var room in reservedRooms) // add to room one more bool reserved or not, which will change with button
            //    {

            //        GroupBox groupBox = new GroupBox
            //        {
            //            Text = room.HotelName,
            //            AutoSize = true,
            //            Location = new Point((panel1.Width - 500) / 2, currentY),
            //        };

            //        Label locationLabel = new Label
            //        {
            //            Text = $"Location: {room.HotelLocation}",
            //            Location = new Point(10, 20),
            //            AutoSize = true
            //        };

            //        Label datesLabel = new Label
            //        {
            //            Text = $"Available Dates: {room.HotelDateAvb}",
            //            Location = new Point(10, 40),
            //            AutoSize = true
            //        };

            //        Label roomsLabel = new Label
            //        {
            //            Text = $"Rooms: {room.HotelAmountOfRooms}",
            //            Location = new Point(10, 60),
            //            AutoSize = true
            //        };

            //        Label priceLabel = new Label
            //        {
            //            Text = $"Price: {room.HotelCostForNight} USD/night",
            //            Location = new Point(10, 80),
            //            AutoSize = true
            //        };
            //        // this button should open the property page
            //        //Button button = new Button
            //        //{
            //        //    Text = "Show",
            //        //    Location = new Point(10, groupBox.Height - 40),
            //        //    AutoSize = true,
            //        //};

            //        //PictureBox pictureBox = new PictureBox
            //        //{
            //        //    Size = new Size(200, 200),
            //        //    Location = new Point(10, 10),
            //        //    BorderStyle = BorderStyle.Fixed3D
            //        //};

            //        //pictureBox.ImageLocation = @"C:\Users\Orest\Source\Repos\FinallyFinalBooking\FinallyFinalBoocking\DumbStaffDB\Screenshot 2024-12-10 023140.png";

            //        groupBox.Controls.Add(locationLabel);
            //        groupBox.Controls.Add(datesLabel);
            //        groupBox.Controls.Add(roomsLabel);
            //        groupBox.Controls.Add(priceLabel);
            //        //groupBox.Controls.Add(button);
            //        //groupBox.Controls.Add(pictureBox);

            //        panel1.Controls.Add(groupBox);

            //        currentY += groupBoxHeight + spacing;

            //    }
        }
    }
}
