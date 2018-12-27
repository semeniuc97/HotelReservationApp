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
                command.Parameters.Add(new SqlParameter("@hotelId", hotelId));
                sqlConnection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Room room = new Room()
                    {
                        Id = Convert.ToInt32(reader["RoomId"]),
                        Price =Convert.ToDouble(reader["Price"]),
                        Capability = Convert.ToInt16(reader["Capability"]),
                        ComfortLevel = Convert.ToInt16(reader["ComfortLevel"]),
                        Number = Convert.ToInt32(reader["Number"])
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
                SqlCommand command = new SqlCommand("Select * from Rooms Where Number=@roomNumber;", sqlConnection);
                command.Parameters.Add(new SqlParameter("@roomNumber", roomNumber));

                sqlConnection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    room.Price = Convert.ToDouble(reader["Price"]);
                    room.Capability = Convert.ToInt16(reader["Capability"]);
                    room.ComfortLevel =Convert.ToInt16(reader["ComfortLevel"]);
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
                SqlCommand command = new SqlCommand($@"Update Rooms Set Price=@price,Capability=@capability,
                                                    ComfortLevel=@comfortLevel,IsAdded=@isAdded,IsUpdated=@isUpdated where Number=@number;", sqlConnection);

                command.Parameters.Add(new SqlParameter("@number", room.Number));
                command.Parameters.Add(new SqlParameter("@price", room.Price));
                command.Parameters.Add(new SqlParameter("@capability", room.Capability));
                command.Parameters.Add(new SqlParameter("@comfortLevel", room.ComfortLevel));
                command.Parameters.Add(new SqlParameter("@isAdded", room.IsAdded));
                command.Parameters.Add(new SqlParameter("@isUpdated", room.IsUpdated));


                sqlConnection.Open();
                command.ExecuteNonQuery();
                sqlConnection.Close();

            }
        }
        public void AddRoom(Room room)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                    SqlCommand command = new SqlCommand($@"Insert into Rooms(Number,Price,Capability,ComfortLevel,HotelId,IsUpdated,IsAdded) 
                                                       Values(@number,@price,@capability,@comfortLevel,@hotelId,@isUpdated,@isAdded);", sqlConnection);

                command.Parameters.Add(new SqlParameter("@number", room.Number));
                command.Parameters.Add(new SqlParameter("@price", room.Price));
                command.Parameters.Add(new SqlParameter("@capability", room.Capability));
                command.Parameters.Add(new SqlParameter("@comfortLevel", room.ComfortLevel));
                command.Parameters.Add(new SqlParameter("@hotelId", room.HotelId));
                command.Parameters.Add(new SqlParameter("@isAdded", room.IsAdded));
                command.Parameters.Add(new SqlParameter("@isUpdated", room.IsUpdated));

                sqlConnection.Open();
                    command.ExecuteNonQuery();
                    sqlConnection.Close();
            }
        }
    }
}
