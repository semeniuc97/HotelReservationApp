using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Room:ModifyTracker
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public int Number { get; set; }
        public int Capability { get; set; }
        public int ComfortLevel { get; set; }

        public int HotelId { get; set; }
        public virtual Hotel Hotel { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
