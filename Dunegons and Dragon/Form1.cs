// Title: Dungeons & Dragons Splash Screen
// Author Name: Samrat Jayanta Bhurtel
// Date: November 8, 2024
// Student ID: 100949545
// Description:This splash screen is the initial form displayed to the user when the Dungeons & Dragons application starts.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dunegons_and_Dragon
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for the Next button to navigate to the main form
        /// </summary>
        private void btnNext_Click(object sender, EventArgs e)
        {
            // Create and display the main form
            frmMain mainForm = new frmMain();
            mainForm.Show();

            // Hide the splash screen
            this.Hide();
        }
    }
}