// Name : Samrat Jayanta Bhurtel
// Student ID : 100949545
// Date : 2024-12-05
// Purpose : To create a class for the game
// Title : Game.cs
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace VideoGameReviews.DBAL
{
    public class Game
    {
        public static List<Game> Games = new List<Game>();

        public int GameID { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public DateTime ReleaseDate { get; set; }

        // Fetch all games from the database
        public static void FillGames()
        {
            Games.Clear();
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.VideoGameReviewsConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Games", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Games.Add(new Game
                    {
                        GameID = (int)reader["GameID"],
                        Title = reader["Title"].ToString(),
                        Genre = reader["Genre"].ToString(),
                        ReleaseDate = (DateTime)reader["ReleaseDate"]
                    });
                }
            }
        }
    }
}
