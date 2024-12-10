// Name : Samrat Jayanta Bhurtel
// Student ID : 100949545
// Date : 2024-12-05
// Description : Registration form for the application
// Title : frmRegistration.cs
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace VideoGameReviews.DBAL
{
    public class Review
    {
        public static List<Review> Reviews = new List<Review>();

        public int ReviewID { get; set; }
        public int GameID { get; set; }
        public int ReviewerID { get; set; }
        public int Rating { get; set; }
        public string ReviewText { get; set; }
        public DateTime ReviewDate { get; set; }

        // Fetch all reviews for a specific game
        public static void FillReviews(int gameID)
        {
            Reviews.Clear();
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.VideoGameReviewsConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Reviews WHERE GameID = @GameID", conn);
                cmd.Parameters.AddWithValue("@GameID", gameID);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Reviews.Add(new Review
                    {
                        ReviewID = (int)reader["ReviewID"],
                        GameID = (int)reader["GameID"],
                        ReviewerID = (int)reader["ReviewerID"],
                        Rating = (int)reader["Rating"],
                        ReviewText = reader["ReviewText"].ToString(),
                        ReviewDate = (DateTime)reader["ReviewDate"]
                    });
                }
            }
        }

        // Insert a new review
        public void Insert()
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.VideoGameReviewsConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spInsertNewReview", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ReviewID", ReviewID);
                cmd.Parameters.AddWithValue("@GameID", GameID);
                cmd.Parameters.AddWithValue("@UserID", ReviewerID);
                cmd.Parameters.AddWithValue("@Rating", Rating);
                cmd.Parameters.AddWithValue("@ReviewText", ReviewText);
                cmd.Parameters.AddWithValue("@ReviewDate", ReviewDate);

                cmd.ExecuteNonQuery();
            }
        }

        // Delete a review
        public static void Delete(int reviewID)
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.VideoGameReviewsConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spDeleteReview", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ReviewID", reviewID);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
