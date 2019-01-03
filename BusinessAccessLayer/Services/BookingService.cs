using DataAccessLayer;
using DataAccessLayer.Context;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BusinessAccessLayer.Services
{
    public class BookingService
    {
        HotelContext hotelContext;
        public BookingService()
        {

        }

        public BookingService(HotelContext hotelContext)
        {
            this.hotelContext = hotelContext;
        }

        public Booking Delete(int id)
        {
            var booking = new Booking() { Id = id };
            hotelContext.Entry(booking).State = EntityState.Deleted;
            hotelContext.SaveChanges();
            return booking;
        }

        public Booking Add(Booking booking)
        {
            hotelContext.Bookings.Add(booking);
            hotelContext.SaveChanges();
            return booking;
        }

        public List<Booking> GetAllByRoomId(int roomId)
        {
            return hotelContext.Bookings.Include(x => x.User).Include(x => x.Room).Where(x => x.RoomId == roomId).ToList();
        }

        public List<Booking> GetRoomReservationsByDatesRange(DateTime StartDate, DateTime EndDate)
        {
            return hotelContext.Bookings
                .Include(x => x.Room.Hotel)
                .Where(x => x.StartDate >= StartDate && x.EndDate <= EndDate).ToList();
        }

        
    }
}
