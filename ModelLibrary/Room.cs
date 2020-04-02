using System;
using System.Collections.Generic;
using System.Text;

namespace ModelLibrary
{
    public class Room
    {
        private int _roomNr;

        public int RoomNr
        {
            get { return _roomNr; }
            set { _roomNr = value; }
        }

        private string _roomType;

        public string RoomType
        {
            get { return _roomType; }
            set { _roomType = value; }
        }

        private double _price;

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        private int _hotel_No;

        public int Hotel_No
        {
            get { return _hotel_No; }
            set { _hotel_No = value; }
        }

        public Room()
        {
            
        }

        public Room(int roomNr, string roomType, double price, int hotelNo)
        {
            _roomNr = roomNr;
            _roomType = roomType;
            _price = price;
            _hotel_No = hotelNo;
        }
    }
}
