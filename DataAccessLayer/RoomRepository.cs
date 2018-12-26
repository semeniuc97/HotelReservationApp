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

        public Room FindRoomByRoomNumber(string roomNumber)
        {
            Room room = new Room();
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("Select * from Rooms Where Number=@RoomNumber;", sqlConnection);
                command.Parameters.Add(new SqlParameter("roomNumber", roomNumber));

                sqlConnection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    room.Price = reader["Price"].ToString();
                    room.Capability = reader["Capability"].ToString();
                    room.ComfortLevel = reader["ComfortLevel"].ToString();
                }
                reader.Close();
                sqlConnection.Close();
            }
            return room;
        }

        public void DeleteRoomById(string roomId)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("Delete From Rooms Where RoomId=@roomId;", sqlConnection);
                command.Parameters.Add(new SqlParameter("roomId", roomId));
                sqlConnection.Open();
                command.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }

        public void UpdateRoom(Room room)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand($@"Update Rooms Set Price='{room.Price}',Capability='{room.Capability}',
                                                    ComfortLevel='{room.ComfortLevel}' where Number='{room.Number}';", sqlConnection);
                
                sqlConnection.Open();
                command.ExecuteNonQuery();
                sqlConnection.Close();

            }
        }
        public void AddRoom(Room room)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                    SqlCommand command = new SqlCommand($@"Insert into Rooms(Number,Price,Capability,ComfortLevel,HotelId) Values('{room.Number}','{room.Price}',
                                                              '{room.Capability}','{room.ComfortLevel}','{room.HotelId}');", sqlConnection);
                    sqlConnection.Open();
                    command.ExecuteNonQuery();
                    sqlConnection.Close();
            }
        }
    }
}
