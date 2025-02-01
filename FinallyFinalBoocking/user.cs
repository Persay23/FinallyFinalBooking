using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinallyFinalBoocking;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FinallyFinalBoocking
{
    internal class User
    {
        private int _userId;
        private string _userName;
        private string _email;
        private string _password;
        private List<Room> _bookedRooms;


        public User(int userId, string userName, string email, string password)
        {
            _userId = userId;
            _userName = userName;
            _email = email;
            _password = password;
            _bookedRooms = new List<Room>();
        }


        public int UserId => _userId;
        public string UserName => _userName;
        public string Email => _email;
        public string Password => _password;
        public List<Room> BookedRooms => _bookedRooms;
    }
}

//public void AddBooking(Room room)
//{
//    _bookedRooms.Add(room);
//}

//// Method to remove a room from the booked rooms list
//public bool RemoveBooking(Room room)
//{
//    return _bookedRooms.Remove(room);
//}

//// Override ToString to display user details easily
//public override string ToString()
//{
//    return $"{_userName} ({_email})";
//}