using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Data.SqlTypes;

namespace DataAccessLayer
{
    public class BookingRepository
    {
        string connectionString;
        public BookingRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public BookingRepository()
        {

        }

        public List<BookingDetails> GetBookingsDetailsByRoomId(int roomId)
        {
            List<BookingDetails> bookingDetails = new List<BookingDetails>();
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(@"Select BookingId,UserName,Email,Price,StartDate,EndDate from Bookings
                    Inner Join Users On Bookings.UserId=Users.UserId
                    Inner Join Rooms On Bookings.RoomId=Rooms.RoomId
                    Where Rooms.RoomId=@roomId;", sqlConnection);
                command.Parameters.Add(new SqlParameter("roomId", roomId));

                sqlConnection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    BookingDetails booking = new BookingDetails()
                    {
                        Id = Convert.ToInt32(reader["BookingId"]),
                        UserName = reader["UserName"].ToString(),
                        Email = reader["Email"].ToString(),
                        Price = Convert.ToDouble(reader["Price"]),
                        StartDate = (DateTime)reader["StartDate"],
                        EndDate = (DateTime)reader["EndDate"]
                    };
                    bookingDetails.Add(booking);
                }
                reader.Close();
                sqlConnection.Close();
            }
            return bookingDetails;
        }

        public void AddBooking(Booking booking)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand($@"Insert Into Bookings Values(@startDate,@endDate,@userId,@roomId);", sqlConnection);

                command.Parameters.Add(new SqlParameter("@startDate", booking.StartDate));
                command.Parameters.Add(new SqlParameter("@endDate", booking.EndDate));
                command.Parameters.Add(new SqlParameter("@userId", booking.UserId));
                command.Parameters.Add(new SqlParameter("@roomId", booking.RoomId));

                sqlConnection.Open();
                command.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }

        public void CancelBooking(string bookingid)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("Delete From Bookings Where BookingId=@bookingId;", sqlConnection);

                    command.Parameters.Add(new SqlParameter("@bookingid", bookingid));
                sqlConnection.Open();
                command.ExecuteNonQuery();
            }

        }

        public List<BookingPeriod> GetBookingsDatePeriods(int roomId)
        {
            var bookingsPeriods = new List<BookingPeriod>();
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("Select StartDate,EndDate from Bookings where RoomId=@roomId", sqlConnection);

                command.Parameters.Add(new SqlParameter("@roomId", roomId));
                sqlConnection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while(reader.Read())
                {
                    var bookingPeriod = new BookingPeriod()
                    {
                        StartDate = Convert.ToDateTime(reader["StartDate"]),
                        EndDate = Convert.ToDateTime(reader["EndDate"])
                    };
                    bookingsPeriods.Add(bookingPeriod);
                }
                reader.Close();
            }
            return bookingsPeriods;
        }

    }
}
