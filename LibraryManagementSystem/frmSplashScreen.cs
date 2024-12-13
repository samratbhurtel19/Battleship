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

