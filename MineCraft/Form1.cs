// Title: Splash Screen
// Name: Samrat Jayanta Bhurtel
// Student ID: 100949545
// Date: 13th November 2024
// Description: A splash screen that displays the student's name, student ID, and the date. The splash screen will close after 5 seconds and open the main form.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineCraft
{
    public partial class splashScreen : Form
    {
        public splashScreen()
        {
            InitializeComponent();
            // Start the timer when the splash screen loads
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Stop the timer
            timer1.Stop();

            // Open the main form
            mainFrm MainForm = new mainFrm();
            MainForm.Show();

            // Close the splash screen
            this.Close();
        }
    }
}
