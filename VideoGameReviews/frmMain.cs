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

                // Ensurejo reviews are fetched
                if (Review.Reviews == null || !Review.Reviews.Any())
                {
                    dgvReviews.DataSource = null; // Clear existing data
                    return; // Exit if no reviews are available
                }

                // Bind the fetched reviews to the DataGridView
                dgvReviews.DataSource = null; // Clear any previous data binding
                dgvReviews.DataSource = Review.Reviews;

                // Configure DataGridView columns dynamically
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
                // Handle exceptions and display error messages
                MessageBox.Show($"Error loading reviews: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Add a new review
        private void btnAdd_Click_1(object sender, EventArgs e)
{
    try
    {
        // Ensure a game is selected in the DataGridView
        if (dgvGame.CurrentRow == null || dgvGame.CurrentRow.Cells["GameID"] == null)
        {
            MessageBox.Show("Please select a game to review.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        int selectedGameID = Convert.ToInt32(dgvGame.CurrentRow.Cells["GameID"].Value);

        // Validate the rating input
        if (nudRating.Value < 1 || nudRating.Value > 5)
        {
            MessageBox.Show("Rating must be between 1 and 5.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        // Validate the review text input
        if (string.IsNullOrWhiteSpace(txtReview.Text))
        {
            MessageBox.Show("Review text cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        // Create a new review object
        Review newReview = new Review
        {
            GameID = selectedGameID,
            ReviewerID = LoggedInUserID,
            Rating = (int)nudRating.Value,
            ReviewText = txtReview.Text.Trim(),
            ReviewDate = DateTime.Now
        };

        // Insert the new review into the database
        newReview.Insert();

        // Notify the user
        MessageBox.Show("Review added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        // Refresh reviews
        LoadReviews(selectedGameID);
    }
    catch (Exception ex)
    {
        // Handle exceptions and display error messages
        MessageBox.Show($"Error adding review: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}


        // Delete an existing review
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure a review is selected in the DataGridView
                if (dgvReviews.CurrentRow == null || dgvReviews.CurrentRow.Cells["ReviewID"] == null)
                {
                    MessageBox.Show("Please select a review to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int selectedReviewID = Convert.ToInt32(dgvReviews.CurrentRow.Cells["ReviewID"].Value);

                // Confirm deletion
                var confirmResult = MessageBox.Show("Are you sure you want to delete this review?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult != DialogResult.Yes)
                {
                    return;
                }

                // Delete the selected review from the database
                Review.Delete(selectedReviewID);

                // Notify the user
                MessageBox.Show("Review deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh reviews for the currently selected game
                if (dgvGame.CurrentRow != null && dgvGame.CurrentRow.Cells["GameID"] != null)
                {
                    int selectedGameID = Convert.ToInt32(dgvGame.CurrentRow.Cells["GameID"].Value);
                    LoadReviews(selectedGameID);
                }
                else
                {
                    dgvReviews.DataSource = null; // Clear reviews if no valid game is selected
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions and display error messages
                MessageBox.Show($"Error deleting review: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Logout user
        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Logged out successfully.", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmLogin loginForm = new frmLogin();
            loginForm.Show();
            this.Close();
        }

        // Exit application
        private void exitToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgvGame_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                // Ensure a game is selected in the DataGridView
                if (dgvGame.CurrentRow != null && dgvGame.CurrentRow.Cells["GameID"] != null)
                {
                    int selectedGameID = Convert.ToInt32(dgvGame.CurrentRow.Cells["GameID"].Value);

                    // Load the reviews for the selected game
                    LoadReviews(selectedGameID);
                }
                else
                {
                    dgvReviews.DataSource = null; // Clear reviews if no valid game is selected
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions and display error messages
                MessageBox.Show($"Error loading reviews for selected game: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
