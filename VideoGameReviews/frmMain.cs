// Name : Samrat Jayanta Bhurtel
// Student ID : 100949545
// Date : 2024-12-09
// Description : Main form for the application
// Title : frmMain.cs
// Purpose: Main form for the application. Displays games and reviews, and allows users to add and delete reviews.
using System;
using System.Linq;
using System.Windows.Forms;
using VideoGameReviews.DBAL;

namespace VideoGameReviews
{
    public partial class frmMain : Form
    {
        public int LoggedInUserID { get; set; }
        public string LoggedInUserName { get; set; }

        public frmMain()
        {
            InitializeComponent();
        }

        // Form load event
        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                // Update status strip with logged-in user name
                lblStatus.Text = string.IsNullOrEmpty(LoggedInUserName)
                    ? "Logged in as: Unknown User"
                    : $"Logged in as: {LoggedInUserName}";

                // Load games into the DataGridView
                LoadGames();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading main form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Load all games into the DataGridView
        private void LoadGames()
        {
            try
            {
                Game.FillGames();
                dgvGame.DataSource = null; // Clear existing data
                dgvGame.DataSource = Game.Games;

                // Adjust columns
                dgvGame.AutoGenerateColumns = true;
                if (dgvGame.Columns.Contains("GameID")) dgvGame.Columns["GameID"].Visible = false;
                if (dgvGame.Columns.Contains("Genre")) dgvGame.Columns["Genre"].Visible = false;
                if (dgvGame.Columns.Contains("ReleaseDate")) dgvGame.Columns["ReleaseDate"].Visible = false;
                if (dgvGame.Columns.Contains("Title")) dgvGame.Columns["Title"].HeaderText = "Game Title";
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
                // Fetch reviews for the selected game
                Review.FillReviews(gameID);

                // Bind the reviews to the DataGridView
                dgvReviews.DataSource = null; // Clear any previous data
                dgvReviews.DataSource = Review.Reviews;

                // Debugging: Log review data
                foreach (var review in Review.Reviews)
                {
                    Console.WriteLine($"ReviewID: {review.ReviewID}, Rating: {review.Rating}, Text: {review.ReviewText}");
                }

                // Adjust column visibility and headers
                dgvReviews.AutoGenerateColumns = true;
                if (dgvReviews.Columns["ReviewID"] != null) dgvReviews.Columns["ReviewID"].Visible = false;
                if (dgvReviews.Columns["GameID"] != null) dgvReviews.Columns["GameID"].Visible = false;
                if (dgvReviews.Columns["ReviewerID"] != null) dgvReviews.Columns["ReviewerID"].Visible = false;

                if (dgvReviews.Columns["Rating"] != null) dgvReviews.Columns["Rating"].HeaderText = "Rating";
                if (dgvReviews.Columns["ReviewText"] != null) dgvReviews.Columns["ReviewText"].HeaderText = "Review";
                if (dgvReviews.Columns["ReviewDate"] != null) dgvReviews.Columns["ReviewDate"].HeaderText = "Date";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading reviews: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Triggered when a game is selected
        private void dgvGame_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvGame.SelectedRows.Count > 0)
                {
                    int selectedGameID = (int)dgvGame.SelectedRows[0].Cells["GameID"].Value;
                    Console.WriteLine($"Selected GameID: {selectedGameID}"); // Debugging
                    LoadReviews(selectedGameID);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error selecting game: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Add a new review
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dgvGame.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a game to review.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int selectedGameID = (int)dgvGame.SelectedRows[0].Cells["GameID"].Value;

                if (nudRating.Value < 1 || nudRating.Value > 5)
                {
                    MessageBox.Show("Rating must be between 1 and 5.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtReview.Text))
                {
                    MessageBox.Show("Review text cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Review newReview = new Review
                {
                    GameID = selectedGameID,
                    ReviewerID = LoggedInUserID,
                    Rating = (int)nudRating.Value,
                    ReviewText = txtReview.Text,
                    ReviewDate = DateTime.Now
                };

                newReview.Insert();
                MessageBox.Show("Review added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh reviews
                LoadReviews(selectedGameID);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding review: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Delete an existing review
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvReviews.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a review to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int selectedReviewID = (int)dgvReviews.SelectedRows[0].Cells["ReviewID"].Value;

                Review.Delete(selectedReviewID);
                MessageBox.Show("Review deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh reviews
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

        // Logout user
        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Logged out successfully.", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        // Exit application
        private void exitToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
