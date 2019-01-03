using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class User:ModifyTracker
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
