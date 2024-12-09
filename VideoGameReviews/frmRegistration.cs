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
            if (textBox3.Text != textBox4.Text)
            {
                MessageBox.Show("Passkey and Confirm Passkey must match.");
                return;
            }

            User newUser = new User
            {
                UserID = GenerateNewUserID(), // Implement logic to generate unique UserID
                FirstName = textBox1.Text,
                LastName = textBox2.Text,
                Email = textBox3.Text,
                PassKey = int.Parse(textBox4.Text)
            };

            newUser.Insert();
            MessageBox.Show("Registration successful!");
            this.Close();
        }

        private int GenerateNewUserID()
        {
            return new Random().Next(1000, 9999); // Simple UserID generator; replace with proper logic
        }
    }
}
