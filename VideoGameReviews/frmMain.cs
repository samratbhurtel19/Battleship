using System;
using System.Windows.Forms;
using VideoGameReviews.DBAL;

namespace VideoGameReviews
{
    public partial class frmMain : Form
    {
        private int LoggedInUserID; // To store the logged-in user ID

        public frmMain(int userID)
        {
            InitializeComponent();
            LoggedInUserID = userID;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                // Display logged-in user information
                User loggedInUser = User.GetByID(LoggedInUserID);
                if (loggedInUser != null)
                {
                    lblStatus.Text = $"Logged in as: {loggedInUser.FirstName} {loggedInUser.LastName}";
                }

                // Load games into DataGridView
                LoadGames();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing the form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadGames()
        {
            try
            {
                Game.FillGames();
                dgvGame.DataSource = null; // Reset data source
                dgvGame.DataSource = Game.Games; // Bind the Games list
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
                Review.FillReviews(gameID);
                dgvReviews.DataSource = null; // Reset data source
                dgvReviews.DataSource = Review.Reviews; // Bind the Reviews list
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading reviews: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvGames_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvGame.SelectedRows.Count > 0)
            {
                int selectedGameID = (int)dgvGame.SelectedRows[0].Cells["GameID"].Value;
                LoadReviews(selectedGameID); // Load reviews for the selected game
            }
        }

        private void btnAddReview_Click(object sender, EventArgs e)
        {
            if (dgvGame.SelectedRows.Count > 0)
            {
                int selectedGameID = (int)dgvGame.SelectedRows[0].Cells["GameID"].Value;

                try
                {
                    // Create a new review object
                    Review newReview = new Review
                    {
                        GameID = selectedGameID,
                        ReviewerID = LoggedInUserID,
                        ReviewText = txtReview.Text,
                        ReviewDate = DateTime.Now
                    };

                    // Insert the review into the database
                    newReview.Insert();
                    MessageBox.Show("Review added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh the reviews
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
                    // Delete the selected review
                    Review.Delete(selectedReviewID);
                    MessageBox.Show("Review deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh the reviews
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
            // Logout and return to login form
            frmLogin loginForm = new frmLogin();
            loginForm.Show();
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Exit the application
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show application information
            MessageBox.Show("Video Game Reviews System\nVersion 1.0\nBy COSC2100", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
