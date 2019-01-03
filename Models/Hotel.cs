using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Hotel:ModifyTracker
    {
        public int Id { get; set; }
        public string HotelName { get; set; }
        public DateTime FoundationYear { get; set; }
        public string Adress { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<Room> Rooms { get; set; }


    }
}
