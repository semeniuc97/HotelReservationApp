using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
   public class BookingDetails
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public double Price { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
