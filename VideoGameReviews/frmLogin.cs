using System;
using System.Windows.Forms;
using VideoGameReviews.DBAL;

namespace VideoGameReviews
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegistration registrationForm = new frmRegistration();
            registrationForm.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input
                if (string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPasskey.Text))
                {
                    MessageBox.Show("Email and Passkey cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtPasskey.Text, out int passkey) || txtPasskey.Text.Length != 4)
                {
                    MessageBox.Show("Passkey must be a 4-digit number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Fetch the user from the database
                var user = User.GetUser(txtEmail.Text.Trim(), passkey);
                if (user == null)
                {
                    MessageBox.Show("Invalid email or passkey.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Navigate to the main form
                frmMain mainForm = new frmMain
                {
                    LoggedInUserID = user.UserID,
                    LoggedInUserName = user.FirstName + " " + user.LastName
                };

                mainForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Close the application
            Application.Exit();
        }
    }
}
