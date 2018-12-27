using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessAccessLayer.Services
{
    public class BookingService
    {
        BookingRepository bookingRepository;
        List<DateTime> bookedDates = new List<DateTime>();
        public BookingService()
        {

        }
        public BookingService(string connectionString)
        {
            bookingRepository = new BookingRepository(connectionString);
        }

        public List<DateTime> GetAllBookedDays(int roomId)
        {
            var roomBookingsPeriods = bookingRepository.GetBookingsDatePeriods(roomId);
            //var roomAllBookedDays = new List<DateTime>();
            foreach (var booking in roomBookingsPeriods)
            {
                bookedDates.AddRange(GetBookingDatesRange(booking.StartDate, booking.EndDate));
            }
            return bookedDates;
        }

        public bool CheckIsBookedDates(DateTime StartDate, DateTime EndDate)
        {
            if (bookedDates.Contains(StartDate) || bookedDates.Contains(EndDate))
            {
                return false;
            }
            else
                return true;
        }

        private List<DateTime> GetBookingDatesRange(DateTime StartDate, DateTime EndDate)
        {
            var bookedDate = StartDate;
            var bookedDates = new List<DateTime>()
            {
                StartDate,
                EndDate
            };

            if ((EndDate.Date - bookedDate.Date).TotalDays == 1)
            {
                return bookedDates;
            }

            while ((EndDate.Date - bookedDate.Date).TotalDays != 1)
            {
                bookedDate = bookedDate.AddDays(1);
                bookedDates.Add(bookedDate);
            }
            return bookedDates;
        }
    }
}
