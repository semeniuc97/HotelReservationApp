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
                        BookingId= reader["BookingId"].ToString(),
                        UserName = reader["UserName"].ToString(),
                        Email = reader["Email"].ToString(),
                        Price = reader["Price"].ToString(),
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
                SqlCommand command = new SqlCommand($@"Insert Into Bookings Values('{booking.StartDate}','{booking.EndDate}','{booking.UserId}','{booking.RoomId}');", sqlConnection);
                sqlConnection.Open();
                command.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }

        public void CancelBooking(string bookingid)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            using (SqlDataAdapter cmd = new SqlDataAdapter())
            using (SqlCommand command = new SqlCommand("Delete From Bookings Where BookingId=@bookingId;", sqlConnection))
            {
                command.Parameters.Add(new SqlParameter("@bookingid", System.Data.SqlDbType.VarChar,50)).Value = bookingid;
                command.Connection = sqlConnection;
                cmd.InsertCommand = command;
                sqlConnection.Open();
                command.ExecuteNonQuery();
            }

        }

    }
}
