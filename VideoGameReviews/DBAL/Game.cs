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

        public Game() { }

        public Game(int gameID, string title, string genre, DateTime releaseDate)
        {
            GameID = gameID;
            Title = title;
            Genre = genre;
            ReleaseDate = releaseDate;
        }

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
                    Games.Add(new Game(
                        (int)reader["GameID"],
                        reader["Title"].ToString(),
                        reader["Genre"].ToString(),
                        (DateTime)reader["ReleaseDate"]
                    ));
                }
            }
        }
    }
}
