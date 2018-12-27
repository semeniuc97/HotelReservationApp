﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
   public class Booking
    {

        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int UserId { get; set; }
        public int RoomId { get; set; }
    }
}
