using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace VideoGameReviews.DBAL
{
    public class User
    {
        public static List<User> Users = new List<User>();

        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int PassKey { get; set; }

        public User() { }

        public User(int userID, string firstName, string lastName, string email, int passKey)
        {
            UserID = userID;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PassKey = passKey;
        }

        public static void FillUsers()
        {
            Users.Clear();
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.VideoGameReviewsConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Users", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Users.Add(new User(
                        (int)reader["UserID"],
                        reader["FirstName"].ToString(),
                        reader["LastName"].ToString(),
                        reader["Email"].ToString(),
                        (int)reader["PassKey"]
                    ));
                }
            }
        }

        public static User GetByID(int userID)
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.VideoGameReviewsConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE UserID = @UserID", conn);
                cmd.Parameters.AddWithValue("@UserID", userID);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new User(
                        (int)reader["UserID"],
                        reader["FirstName"].ToString(),
                        reader["LastName"].ToString(),
                        reader["Email"].ToString(),
                        (int)reader["PassKey"]
                    );
                }
                return null;
            }
        }

        public static void DeleteByID(int userID)
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.VideoGameReviewsConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spDeleteUser", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@userID", userID);
                cmd.ExecuteNonQuery();
            }
        }

        public void Insert()
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.VideoGameReviewsConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spInsertNewUser", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@userID", UserID);
                cmd.Parameters.AddWithValue("@firstName", FirstName);
                cmd.Parameters.AddWithValue("@lastName", LastName);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@PassKey", PassKey);
                cmd.ExecuteNonQuery();
            }
        }

        public void Update()
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.VideoGameReviewsConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spUpdateUser", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@userID", UserID);
                cmd.Parameters.AddWithValue("@firstName", FirstName);
                cmd.Parameters.AddWithValue("@lastName", LastName);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@PassKey", PassKey);
                cmd.ExecuteNonQuery();
            }
        }

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
                    return new User(
                        (int)reader["UserID"],
                        reader["FirstName"].ToString(),
                        reader["LastName"].ToString(),
                        reader["Email"].ToString(),
                        (int)reader["PassKey"]
                    );
                }
                return null;
            }
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} ({Email})";
        }
    }
}
