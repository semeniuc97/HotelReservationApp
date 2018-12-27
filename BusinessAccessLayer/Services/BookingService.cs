using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessAccessLayer.Services
{
    public class BookingService
    {
        string connectionString;
            
        public BookingService(string connectionString)
        {
            this.connectionString = connectionString;
        }
        BookingRepository bookingRepository = new BookingRepository(connectionString);

        //public List<DateTime>GetAllBookedDays()
        //{
        //    var roomAllBookedDays = new List<DateTime>();
        //    //var roomBookingsPeriods;
        //    return;
        //}

        private List<DateTime> GetBookingDatesRange(DateTime StartDate,DateTime EndDate)
        {
            var bookedDate = StartDate;
            var bookedDates = new List<DateTime>()
            {
                StartDate,
                EndDate
            };
            
            if((EndDate.Date - bookedDate.Date).TotalDays == 1)
            {
                return bookedDates;
            }
            
            while((EndDate.Date-bookedDate.Date).TotalDays!=1)
            {
                bookedDate=bookedDate.AddDays(1);
                bookedDates.Add(bookedDate);
            }
            return bookedDates;  
        }
    }
}
