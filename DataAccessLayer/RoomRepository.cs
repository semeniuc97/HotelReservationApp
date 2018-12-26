using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DataAccessLayer
{
   public class RoomRepository
    {
        string connectionString;
        public RoomRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<Room> GetRoomsByHotelId(int hotelId)
        {
            var Rooms = new List<Room>();
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(@"Select RoomId,Number,Price,Capability,ComfortLevel from Rooms Where HotelId=@hotelId;", sqlConnection);
                command.Parameters.Add(new SqlParameter("hotelId", hotelId));
                sqlConnection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Room room = new Room()
                    {
                        RoomId = reader["RoomId"].ToString(),
                        Price = reader["Price"].ToString(),
                        Capability = reader["Capability"].ToString(),
                        ComfortLevel = reader["ComfortLevel"].ToString(),
                        Number = reader["Number"].ToString()
                    };
                    Rooms.Add(room);
                }
                reader.Close();
                sqlConnection.Close();
            }
            return Rooms;
        }
    }
}
