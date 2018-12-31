using Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.IO;



namespace DataAccessLayer
{
    public class HotelRepository
    {
        string connectionString;

        public HotelRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<Hotel> GetHotels()
        {
            var Hotels = new List<Hotel>();
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("Select * from Hotels; ", sqlConnection);
                sqlConnection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Hotel hotel = new Hotel()
                    {
                        Id = (int)reader["HotelId"],
                        HotelName = reader["HotelName"].ToString(),
                        FoundationYear = (DateTime)(reader["FoundationYear"]),
                        Adress = reader["Adress"].ToString(),
                        IsActive = (bool)reader["IsActive"]
                    };
                    Hotels.Add(hotel);
                }
                reader.Close();
                sqlConnection.Close();
            }
            return Hotels;
        }

        public Hotel FindHotelById(string hotelId)
        {
            Hotel hotel = new Hotel();
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(@"Select HotelName,FoundationYear,IsActive,
                    Adress from Hotels Where HotelId=@hotelId;", sqlConnection);
                command.Parameters.Add(new SqlParameter("hotelId", hotelId));
                sqlConnection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    hotel.HotelName = reader["HotelName"].ToString();
                    hotel.Adress = reader["Adress"].ToString();
                    hotel.FoundationYear = (DateTime)reader["FoundationYear"];
                    hotel.IsActive = (bool)reader["IsActive"];

                }
                reader.Close();
                sqlConnection.Close();
            }
            return hotel;
        }

        public int AddHotel(Hotel hotel)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                var data = hotel.FoundationYear.ToString("u");
                SqlCommand command = new SqlCommand($@"Insert into Hotels(HotelName,foundationYear,Adress,IsActive,IsUpdated,IsAdded)
                                                     Values(@hotelName,@foundationYear,@adress,@isActive,@isUpdated,@isAdded);", sqlConnection);
                command.Parameters.Add(new SqlParameter("@hotelName", hotel.HotelName));
                command.Parameters.Add(new SqlParameter("@foundationYear", hotel.FoundationYear));
                command.Parameters.Add(new SqlParameter("@adress", hotel.Adress));
                command.Parameters.Add(new SqlParameter("@isActive", hotel.IsActive));
                command.Parameters.Add(new SqlParameter("@isAdded", hotel.IsAdded));
                command.Parameters.Add(new SqlParameter("@isUpdated", hotel.IsUpdated));

                sqlConnection.Open();
               return command.ExecuteNonQuery();
            }
        }

        public int UpdateHotel(Hotel hotel)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand($@"Update Hotels Set HotelName=@hotelName,FoundationYear=@foundationYear,
                                             Adress=@adress,IsActive=@isActive,IsUpdated=@isUpdated,IsAdded=@isAdded where HotelId=@id", sqlConnection);

                command.Parameters.Add(new SqlParameter("@hotelName", hotel.HotelName));
                command.Parameters.Add(new SqlParameter("@foundationYear", hotel.FoundationYear));
                command.Parameters.Add(new SqlParameter("@adress", hotel.Adress));
                command.Parameters.Add(new SqlParameter("@isActive", hotel.IsActive));
                command.Parameters.Add(new SqlParameter("@id", hotel.Id));
                command.Parameters.Add(new SqlParameter("@isAdded", hotel.IsAdded));
                command.Parameters.Add(new SqlParameter("@isUpdated", hotel.IsUpdated));

                sqlConnection.Open();
                return command.ExecuteNonQuery();

            }
        }
        public int DeleteHotel(int hotelId)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("Delete From Hotels Where HotelId=@hotelId;", sqlConnection))
                {
                    command.Parameters.Add(new SqlParameter("@hotelId", hotelId));

                    sqlConnection.Open();
                   return command.ExecuteNonQuery();
                    //sqlConnection.Close();
                }
            }
        }
    }
}
