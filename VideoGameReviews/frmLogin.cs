using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using VideoGameReviews.DBAL;

namespace VideoGameReviews
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            this.ControlBox = false; // Disable top control box
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Validate input
            string email = txtEmail.Text.Trim();
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter your email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtPasskey.Text.Trim(), out int passKey) || txtPasskey.Text.Length != 4)
            {
                MessageBox.Show("Passkey must be a 4-digit number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Connect to database and validate credentials
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.VideoGameReviewsConnectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT UserID FROM Users WHERE Email = @Email AND PassKey = @PassKey", conn);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@PassKey", passKey);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        int userID = (int)result;

                        // Store UserID for session tracking
                        MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Navigate to the main form
                        frmMain mainForm = new frmMain(userID);
                        mainForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid email or passkey. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Exit the application
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegistration registrationForm = new frmRegistration();
            registrationForm.ShowDialog();
        }
    }
}
