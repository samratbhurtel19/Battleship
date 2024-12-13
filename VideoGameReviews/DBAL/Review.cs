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
        // List to store all reviews
        public static List<Review> Reviews = new List<Review>();

        public int ReviewID { get; set; }
        public int GameID { get; set; }
        public int ReviewerID { get; set; }
        public int Rating { get; set; }
        public string ReviewText { get; set; }
        public DateTime ReviewDate { get; set; }

        // Constructor for the Review class
        public Review() { }

        public Review(int reviewID, int gameID, int reviewerID, int rating, string reviewText, DateTime reviewDate)
        {
            ReviewID = reviewID;
            GameID = gameID;
            ReviewerID = reviewerID;
            Rating = rating;
            ReviewText = reviewText;
            ReviewDate = reviewDate;
        }

        // Static method to fetch reviews for a specific game
        public static void FillReviews(int gameID)
        {
            Reviews.Clear();
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.VideoGameReviewsConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Reviews WHERE GameID = @GameID", conn);
                cmd.Parameters.AddWithValue("@GameID", gameID);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
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
        }



        // Method to insert a new review into the database
        public void Insert()
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.VideoGameReviewsConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spInsertNewReview", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                // Generate a unique ReviewID (use a database sequence or logic here)
                ReviewID = new Random().Next(1000, 9999); // Replace with proper logic

                cmd.Parameters.AddWithValue("@ReviewID", ReviewID); // Explicitly set ReviewID
                cmd.Parameters.AddWithValue("@GameID", GameID);
                cmd.Parameters.AddWithValue("@UserID", ReviewerID);
                cmd.Parameters.AddWithValue("@Rating", Rating);
                cmd.Parameters.AddWithValue("@ReviewText", ReviewText);
                cmd.Parameters.AddWithValue("@ReviewDate", ReviewDate);

                cmd.ExecuteNonQuery();
            }
        }



        // Static method to delete a review
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

