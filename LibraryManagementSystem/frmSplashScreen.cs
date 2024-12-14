// Name : Samrat Jayanta Bhurtel
// Student ID : 100949545
// Date : 2024/12/13
// title : frmSplashScreen.cs

// Purpose: This file contains the code for the splash screen form.
// The splash screen is displayed when the application is launched and
// is used to display the application Title and my name, studentID and Date. The splash screen is
// displayed for a few seconds before the main form is displayed. The splash
// screen also plays a sound when it is displayed.
// The sound is played from the resources of the application.
// The splash screen is hidden when the timer elapses and the main form is displayed.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
            timer1.Interval = 12000;
            timer1.Start();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
        
                timer1.Stop(); // Stop the timer
                frmMain mainForm= new frmMain(); // Create an instance of MainForm
                mainForm.Show(); // Show the main form
                this.Hide(); // Close the splash screen
            
        }

        private void frmSplashScreen_Load(object sender, EventArgs e)
        {
            PlaySound();
        }

        /// <summary>
        /// This method plays a sound when the splash screen is displayed. I added this feature to make 
        /// the splash screen more interactive. I learned how to play a sound in C# from the 
        /// following link: https://stackoverflow.com/questions/3502311/how-to-play-a-sound-in-c-net
        /// </summary>
        private void PlaySound()
        {
            try
            {
                // Play the sound from Resources
                SoundPlayer player = new SoundPlayer(Properties.Resources.call_to_arms);
                player.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error playing sound: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

