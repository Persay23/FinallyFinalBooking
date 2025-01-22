using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void showRoomsBtn_Click(object sender, EventArgs e)
        {
            var newPropertyPage = new PropertysPage();
            newPropertyPage.Show();
            this.Hide();

        }

        private void openbtn_Click(object sender, EventArgs e)
        {
            var lines = File.ReadLines(@"D:\Orest_D\projects\Proga\FinallyFinalBooking\FinallyFinalBoocking\DumbStaffDB\Rooms.txt");

            foreach (var line in lines)
            {
                var split = line.Split(";");

                var hotelId = int.Parse(split[0]);
                var hotelName = split[1];
                var hotelLocation = split[2];
                var hotelDateAvb = DateTime.Parse(split[3]);
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


            //}

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //string logoPath = "\"C:\\Users\\Orest\\source\\repos\\FinallyFinalBoocking - Copy\\" +
            //    "FinallyFinalBoocking\\DumbStaffDB\\Screenshot 2024-12-10 023140.png\"";
            //pictureBox1.Image = Image.FromFile(logoPath);
            //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            // here must be at least 5 hotels/rooms
            // and also somehow make scroll menu like on a page
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}
