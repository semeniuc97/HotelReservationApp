using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DataAccessLayer
{
    public class UserRepository
    {
        string connectionString;
        public UserRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public List<User> GetAllUsers()
        {
            List<User> allUsers = new List<User>();
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("Select * from Users; ", sqlConnection);
                sqlConnection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var user = new User()
                    {
                        Id = (int)reader["UserId"],
                        UserName = reader["UserName"].ToString()
                    };
                    allUsers.Add(user);
                }
                reader.Close();
                sqlConnection.Close();
            }
            return allUsers;
        }
    }
}
