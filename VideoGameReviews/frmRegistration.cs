using System;
using System.Linq;
using System.Windows.Forms;
using VideoGameReviews.DBAL;

namespace VideoGameReviews
{
    public partial class frmRegistration : Form
    {
        public frmRegistration()
        {
            InitializeComponent();
        }

        // Event triggered when the Register button is clicked
        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                // Input validations
                if (string.IsNullOrWhiteSpace(txtFullName.Text))
                {
                    MessageBox.Show("Full Name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    MessageBox.Show("Email cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtPasskey.Text) || string.IsNullOrWhiteSpace(txtConfirmPasskey.Text))
                {
                    MessageBox.Show("Passkey fields cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtPasskey.Text, out int passkey) || passkey < 1000 || passkey > 9999)
                {
                    MessageBox.Show("Passkey must be a 4-digit number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (txtPasskey.Text != txtConfirmPasskey.Text)
                {
                    MessageBox.Show("Passkey and Confirm Passkey must match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Create a new user object
                User newUser = new User
                {
                    UserID = GenerateNewUserID(), // Generate a unique UserID
                    FirstName = GetFirstName(txtFullName.Text),
                    LastName = GetLastName(txtFullName.Text),
                    Email = txtEmail.Text.Trim(),
                    PassKey = passkey
                };

                // Insert the new user into the database
                newUser.Insert();
                MessageBox.Show("Registration successful! You can now log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Navigate back to the Login Form
                frmLogin loginForm = new frmLogin();
                loginForm.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during registration: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Helper method to generate a unique UserID
        private int GenerateNewUserID()
        {
            return new Random().Next(1000, 9999); // Replace with actual unique UserID generation logic
        }

        // Helper method to extract first name from full name
        private string GetFirstName(string fullName)
        {
            var nameParts = fullName.Split(' ');
            return nameParts.Length > 0 ? nameParts[0] : fullName;
        }

        // Helper method to extract last name from full name
        private string GetLastName(string fullName)
        {
            var nameParts = fullName.Split(' ');
            return nameParts.Length > 1 ? string.Join(" ", nameParts.Skip(1)) : string.Empty;
        }

        // Event triggered when the Cancel button is clicked
        private void btnCancel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to cancel registration?", "Cancel Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Close the form
                this.Close();
            }
        }

        // Event triggered when Back to Login button is clicked
        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            frmLogin loginForm = new frmLogin();
            loginForm.Show();
            this.Close();
        }
    }
}
