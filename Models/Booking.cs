using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
   public class Booking
    {

        public string BookingId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string UserId { get; set; }
        public string RoomId { get; set; }
    }
}
