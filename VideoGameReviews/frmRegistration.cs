using System;
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

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtPasskey.Text != txtConfirmPasskey.Text)
            {
                MessageBox.Show("Passkey and Confirm Passkey must match.");
                return;
            }

            User newUser = new User
            {
                UserID = GenerateNewUserID(), // Implement logic to generate unique UserID
                FirstName = txtFullName.Text,
                LastName = txtEmail.Text,
                Email = txtPasskey.Text,
                PassKey = int.Parse(txtConfirmPasskey.Text)
            };

            newUser.Insert();
            MessageBox.Show("Registration successful!");
            this.Close();
        }

        private int GenerateNewUserID()
        {
            return new Random().Next(1000, 9999); // Simple UserID generator; replace with proper logic
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Step 1: Validate Input
            string fullName = txtFullName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string passkeyText = txtPasskey.Text.Trim();
            string confirmPasskeyText = txtConfirmPasskey.Text.Trim();

            if (string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(passkeyText) || string.IsNullOrWhiteSpace(confirmPasskeyText))
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(passkeyText, out int passkey) || passkey < 1000 || passkey > 9999)
            {
                MessageBox.Show("Passkey must be a 4-digit number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (passkeyText != confirmPasskeyText)
            {
                MessageBox.Show("Passkey and Confirm Passkey must match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Step 2: Create and Insert the User
            try
            {
                User newUser = new User
                {
                    UserID = GenerateNewUserID(), // You can implement this logic to generate a unique UserID
                    FirstName = fullName.Split(' ')[0], // Assuming the first name is the first word
                    LastName = fullName.Split(' ').Length > 1 ? fullName.Split(' ')[1] : "", // Optional last name
                    Email = email,
                    PassKey = passkey
                };

                newUser.Insert();

                // Step 3: Provide Feedback and Close the Form
                MessageBox.Show("Registration successful! You can now log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Navigate back to Login Form
                frmLogin loginForm = new frmLogin();
                loginForm.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during registration: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
           
          // Confirm with the user before closing the form
          var result = MessageBox.Show("Are you sure you want to cancel registration?",
          "Cancel Confirmation",
          MessageBoxButtons.YesNo,
          MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Close the form
                    this.Close();
                }
            

        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            
                // Open the Login Form
                frmLogin loginForm = new frmLogin();
                loginForm.Show();

                // Close the current form
                this.Close();
            

        }
    }
    
}
