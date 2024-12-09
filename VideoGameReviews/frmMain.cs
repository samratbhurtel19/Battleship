using System;
using System.Windows.Forms;
using VideoGameReviews.DBAL;

namespace VideoGameReviews
{
    public partial class frmMain : Form
    {
        private int LoggedInUserID;

        public frmMain(int loggedInUserID)
        {
            InitializeComponent();
            LoggedInUserID = loggedInUserID;
            LoadGames();
        }
        private void LoadGames()
        {
            try
            {
                Game.FillGames();

                // Clear existing columns
                dgvGame.Columns.Clear();
                dgvGame.AutoGenerateColumns = false;

                // Define columns
                dgvGame.Columns.Add("GameID", "Game ID");
                dgvGame.Columns["GameID"].DataPropertyName = "GameID";
                dgvGame.Columns["GameID"].Visible = false; // Hide GameID column

                dgvGame.Columns.Add("Title", "Title");
                dgvGame.Columns["Title"].DataPropertyName = "Title";

                dgvGame.Columns.Add("Genre", "Genre");
                dgvGame.Columns["Genre"].DataPropertyName = "Genre";

                dgvGame.Columns.Add("ReleaseDate", "Release Date");
                dgvGame.Columns["ReleaseDate"].DataPropertyName = "ReleaseDate";

                // Bind data
                dgvGame.DataSource = Game.Games;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading games: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LoadReviews(int gameID)
        {
            try
            {
                // Filter reviews based on the selected GameID
                Review.FillReviews(gameID);

                // Bind the filtered reviews to the second DataGridView
                dgvReviews.DataSource = null; // Clear the existing data source
                dgvReviews.DataSource = Review.Reviews;

                // Optionally, hide unnecessary columns (like ReviewID)
                dgvReviews.Columns["ReviewID"].Visible = false;
                dgvReviews.Columns["GameID"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error displaying reviews: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddReview_Click(object sender, EventArgs e)
        {
            if (dgvGame.SelectedRows.Count > 0)
            {
                int selectedGameID = (int)dgvGame.SelectedRows[0].Cells["GameID"].Value;

                try
                {
                    Review newReview = new Review
                    {
                        GameID = selectedGameID,
                        ReviewerID = LoggedInUserID,
                        Rating = int.Parse(nudRating.Text),
                        ReviewText = txtReview.Text,
                        ReviewDate = DateTime.Now
                    };

                    newReview.Insert();
                    MessageBox.Show("Review added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadReviews(selectedGameID);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error adding review: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDeleteReview_Click(object sender, EventArgs e)
        {
            if (dgvReviews.SelectedRows.Count > 0)
            {
                int selectedReviewID = (int)dgvReviews.SelectedRows[0].Cells["ReviewID"].Value;

                try
                {
                    Review.Delete(selectedReviewID);
                    MessageBox.Show("Review deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (dgvGame.SelectedRows.Count > 0)
                    {
                        int selectedGameID = (int)dgvGame.SelectedRows[0].Cells["GameID"].Value;
                        LoadReviews(selectedGameID);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting review: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin loginForm = new frmLogin();
            loginForm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'videoGameReviewsDataSet1.Reviews' table. You can move, or remove it, as needed.
            this.reviewsTableAdapter.Fill(this.videoGameReviewsDataSet1.Reviews);

        }

        private void dgvGame_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvGame.SelectedRows.Count > 0)
                {
                    // Get the selected GameID
                    int selectedGameID = (int)dgvGame.SelectedRows[0].Cells["GameID"].Value;

                    // Load reviews for the selected GameID
                    LoadReviews(selectedGameID);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading reviews: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
