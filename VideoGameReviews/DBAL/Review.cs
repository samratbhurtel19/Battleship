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

        public static void FillReviews(int gameID)
        {
            Reviews.Clear();
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.VideoGameReviewsConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Reviews", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Reviews.Add(new Review(
                        (int)reader["ReviewID"],
                        (int)reader["GameID"],
                        (int)reader["ReviewerID"],
                        (int)reader["Rating"],
                        reader["ReviewText"].ToString(),
                        (DateTime)reader["ReviewDate"]
                    ));
                }
            }
        }
        public void Insert()
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.VideoGameReviewsConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spInsertNewReview", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                // Pass parameters to the stored procedure
                cmd.Parameters.AddWithValue("@ReviewID", ReviewID);
                cmd.Parameters.AddWithValue("@GameID", GameID);
                cmd.Parameters.AddWithValue("@UserID", ReviewerID);
                cmd.Parameters.AddWithValue("@Rating", Rating);
                cmd.Parameters.AddWithValue("@ReviewText", ReviewText);
                cmd.Parameters.AddWithValue("@ReviewDate", ReviewDate);

                // Execute the query
                cmd.ExecuteNonQuery();
            }
        }
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
