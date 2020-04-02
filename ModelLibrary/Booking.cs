using System;
using System.Collections.Generic;
using System.Text;

namespace ModelLibrary
{
    public class Booking
    {
        private int _booking_id;

        public int Booking_id
        {
            get { return _booking_id; }
            set { _booking_id = value; }
        }

        private int _hotel_No;

        public int Hotel_No
        {
            get { return _hotel_No; }
            set { _hotel_No = value; }
        }

        private Room _room;

        public Room room
        {
            get { return _room; }
            set { _room = value; }
        }


   
        private DateTime _date_From;

        public DateTime Date_From
        {
            get { return _date_From; }
            set { _date_From = value; }
        }

        private DateTime _date_To;

        public DateTime Date_To
        {
            get { return _date_To; }
            set { _date_To = value; }
        }

        private Guest _guest;

        public Guest Guest
        {
            get { return _guest; }
            set { _guest = value; }
        }


        private int _room_No;

        public Booking()
        {
            
        }

        public Booking(int bookingId, int hotelNo, Room room, Guest guest, DateTime dateFrom, DateTime dateTo)
        {
            _booking_id = bookingId;
            _hotel_No = hotelNo;
            _room = room;
            _guest = guest;
            _date_From = dateFrom;
            _date_To = dateTo;
        }
    }
}
