// Name : Samrat Jayanta Bhurtel
// Student ID : 100949545
// Date : 2024-12-05
// Description : User class for the application
// Title : User.cs
// Purpose: This file contains the User class which is used to represent a user in the database.
// It also contains the GetUser method which is used to fetch a user by email and passkey.
// It also contains the Insert method which is used to insert a new user into the database.
using System;
using System.Data.SqlClient;

namespace VideoGameReviews.DBAL
{
    public class User
    {
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int PassKey { get; set; }

        // Fetch user by email and passkey
        public static User GetUser(string email, int passKey)
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.VideoGameReviewsConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE Email = @Email AND PassKey = @PassKey", conn);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@PassKey", passKey);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new User
                    {
                        UserID = (int)reader["UserID"],
                        FirstName = reader["FirstName"].ToString(),
                        LastName = reader["LastName"].ToString(),
                        Email = reader["Email"].ToString(),
                        PassKey = (int)reader["PassKey"]
                    };
                }
                return null;
            }
        }
        public void Insert()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.VideoGameReviewsConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("spInsertNewUser", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        // Pass parameters to the stored procedure
                        cmd.Parameters.AddWithValue("@userID", UserID);
                        cmd.Parameters.AddWithValue("@firstName", FirstName);
                        cmd.Parameters.AddWithValue("@lastName", LastName);
                        cmd.Parameters.AddWithValue("@Email", Email);
                        cmd.Parameters.AddWithValue("@PassKey", PassKey);

                        // Execute the query
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error inserting user: {ex.Message}");
            }
        }

    }
}
