using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinallyFinalBoocking
{
    internal class RoomsInfo : Room
    {
        private string _hotelPhone;
        private string _hotelEmail;
        private string _hotelInst;

        public RoomsInfo(int hotelId, string hotelName, string hotelLocation, string hotelDateAvb,
                         int hotelAmountOfRooms, int hotelCostForNight,
                         string hotelPhone, string hotelEmail, string hotelInst)
            : base(hotelId, hotelName, hotelLocation, hotelDateAvb, hotelAmountOfRooms, hotelCostForNight)
        {
            _hotelPhone = hotelPhone;
            _hotelEmail = hotelEmail;
            _hotelInst = hotelInst;
        }

        public string HotelPhone => _hotelPhone;
        public string HotelEmail => _hotelEmail;
        public string HotelInst => _hotelInst;
    }
}