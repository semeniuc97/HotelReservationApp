using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Booking:ModifyTracker
    {

        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public virtual Room Room { get; set; }
        public int RoomId { get; set; }
    }
}
