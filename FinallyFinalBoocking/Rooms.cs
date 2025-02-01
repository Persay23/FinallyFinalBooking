using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinallyFinalBoocking
{
    public class Room
    {
        private int _hotelId;
        private string _hotelName;
        private string _location;
        private string _dateAvb;
        private int _amountOfRooms;
        private int _costForNight;
        private bool _reservedOrNot;

        public Room(int hotelId, string hotelName, string hotelLocation, string hotelDateAvb, 
            int hotelAmountOfRooms, int hotelCostForNight, bool reservedOrNot)
        {
            _hotelName = hotelName;
            _location = hotelLocation;
            _dateAvb = hotelDateAvb;
            _amountOfRooms = hotelAmountOfRooms;
            _costForNight = hotelCostForNight;
            _hotelId = hotelId;
            _reservedOrNot = reservedOrNot;
        }
        public int HotelId => _hotelId;
        public string HotelName => _hotelName;
        public string HotelLocation => _location;
        public string HotelDateAvb => _dateAvb;
        public int HotelAmountOfRooms => _amountOfRooms;
        public int HotelCostForNight => _costForNight;
        public bool ReservedOrNot => _reservedOrNot;

        public void SetReserved(bool reserved)
        {
            _reservedOrNot = reserved;
        }
    }
}
