﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Room
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public int Number { get; set; }
        public int Capability { get; set; }
        public int ComfortLevel { get; set; }
        public int HotelId { get; set; }
        public bool IsUpdated { get; set; }
        public bool IsAdded { get; set; }
    }
}
