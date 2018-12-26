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
                        HotelId = reader["HotelId"].ToString(),
                        HotelName = reader["HotelName"].ToString(),
                        FoundationYear = Convert.ToDateTime(reader["FoundationYear"].ToString()),
                        Adress = reader["Adress"].ToString(),
                        IsActive = reader["IsActive"].ToString()
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
                    hotel.IsActive = reader["IsActive"].ToString();

                }
                reader.Close();
                sqlConnection.Close();
            }
            return hotel;
        }

        public void AddHotel(Hotel hotel)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                var data = hotel.FoundationYear.ToString("u");
                SqlCommand command = new SqlCommand($@"Insert into Hotels(HotelName,Adress,FoundationYear,IsActive)
                                                  Values('{hotel.HotelName}','{hotel.Adress}','{data}','{hotel.IsActive}');", sqlConnection);

                sqlConnection.Open();
                command.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }

        public void UpdateHotel(Hotel hotel)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand($@"Update Hotels Set HotelName='{hotel.HotelName}',FoundationYear='{hotel.FoundationYear.ToString("u")}',
                                             Adress='{hotel.Adress}',IsActive='{hotel.IsActive}' where HotelId={hotel.HotelId}", sqlConnection);
                //SqlCommand command = new SqlCommand($@"Update Hotels Set HotelName='@hotelName',FoundationYear='@foundationYear',
                //                             Adress='@adress',IsActive='@isActive' where HotelId=@hotelId", sqlConnection);
                //command.Parameters.Add(new SqlParameter("@hotelName", System.Data.SqlDbType.VarChar, 50)).Value = hotel.HotelName;
                //command.Parameters.Add(new SqlParameter("@foundationYear", System.Data.SqlDbType.VarChar, 50)).Value = hotel.FoundationYear.ToString("u");
                //command.Parameters.Add(new SqlParameter("@adress", System.Data.SqlDbType.VarChar, 50)).Value = hotel.Adress;
                //command.Parameters.Add(new SqlParameter("@isActive", System.Data.SqlDbType.Bit)).Value = hotel.IsActive;
                //command.Parameters.Add(new SqlParameter("@hotelId", System.Data.SqlDbType.Int)).Value = hotel.HotelId;

                sqlConnection.Open();
                command.ExecuteNonQuery();
                sqlConnection.Close();

            }
        }
        public void DeleteHotel(string hotelId)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("Delete From Hotels Where HotelId=@hotelId;", sqlConnection))
                {
                    command.Parameters.Add(new SqlParameter("@hotelId", hotelId));

                    sqlConnection.Open();
                    command.ExecuteNonQuery();
                    //sqlConnection.Close();
                }
            }
        }
    }
}
