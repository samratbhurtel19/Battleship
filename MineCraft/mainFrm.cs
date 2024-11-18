// Title: Main Form
// Name: Samrat Jayanta Bhurtel
// Student ID: 100949545
// Date: 13th November 2024
// Purpose: The main form for the MineCraft application. This form allows the user to save, load, and set default player profiles.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineCraft
{
    public partial class mainFrm : Form
    {
        public mainFrm()
        {
            InitializeComponent();
        }

        private void btnSaveProfile_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a PlayerProfile object and populate it with data from the UI
                var profile = new playerProfile.PlayerProfile
                {
                    txtProfileName = txtProfileName.Text,
                    cbxInputDevice = (playerProfile.PlayerProfile.InputDevices)cbxInputDevice.SelectedItem,
                    cbxAutoJump = cbxAutoJump.Checked,
                    nudMouseSensitivity = (int)nudMouseSensitivity.Value,
                    nudControllerSensitivity = (int)nudControllerSensitivity.Value,
                    cbxYaxis = cbxYaxis.Checked,
                    nudBrightness = (int)nudBrightness.Value,
                    cbxFancyGraphics = cbxFancyGraphics.Checked,
                    cbxVsync = cbxVsync.Checked,
                    cbxFullScreen = cbxFullScreen.Checked,
                    nudRenderDistance = (int)nudRenderDistance.Value,
                    nudFieldofView = (int)nudFieldofView.Value,
                    cbxRayTracing = cbxRayTracing.Checked,
                    cbxUpscaling = cbxUpscaling.Checked,
                    trckbrMusicVolume = (int)trckbrMusicVolume.Value,
                    trckbrSoundVolume = (int)trckbrSoundVolume.Value,
                    nudTransparency = (int)nudTransparency.Value,
                    cbxShowCoordinates = cbxShowCoordinates.Checked,
                    cbxCameraPerspective = (playerProfile.PlayerProfile.CameraPerspectives)cbxCameraPerspective.SelectedItem
                };

                // Save the profile using FileIOTools
                fileIOTools.SaveProfile($"Profiles/{profile.txtProfileName}.txt", profile);
                MessageBox.Show("Profile saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving profile: {ex.Message}");
            }
        }

        private void btnLoadProfile_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the selected profile from the ComboBox
                string profileName = cbxProfile.SelectedItem.ToString();
                string filePath = $"Profiles/{profileName}.txt";

                // Load the profile using FileIOTools
                var profile = fileIOTools.LoadProfile(filePath);

                // Update UI controls with the profile data
                txtProfileName.Text = profile.txtProfileName;
                cbxInputDevice.SelectedItem = profile.cbxInputDevice;
                cbxAutoJump.Checked = profile.cbxAutoJump;
                nudMouseSensitivity.Value = profile.nudMouseSensitivity;
                nudControllerSensitivity.Value = profile.nudControllerSensitivity;
                cbxYaxis.Checked = profile.cbxYaxis;
                nudBrightness.Value = profile.nudBrightness;
                cbxFancyGraphics.Checked = profile.cbxFancyGraphics;
                cbxVsync.Checked = profile.cbxVsync;
                cbxFullScreen.Checked = profile.cbxFullScreen;
                nudRenderDistance.Value = profile.nudRenderDistance;
                nudFieldofView.Value = profile.nudFieldofView;
                cbxRayTracing.Checked = profile.cbxRayTracing;
                cbxUpscaling.Checked = profile.cbxUpscaling;
                trckbrMusicVolume.Value = profile.trckbrMusicVolume;
                trckbrSoundVolume.Value = profile.trckbrSoundVolume;
                nudTransparency.Value = profile.nudTransparency;
                cbxShowCoordinates.Checked = profile.cbxShowCoordinates;
                cbxCameraPerspective.SelectedItem = profile.cbxCameraPerspective;

                MessageBox.Show("Profile loaded successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading profile: {ex.Message}");
            }
        }

        private void btnSetDefault_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the selected profile from the ComboBox
                string defaultProfile = cbxProfile.SelectedItem.ToString();

                // Save the default profile name to a configuration file
                File.WriteAllText("Profiles/defaultProfile.txt", defaultProfile);

                MessageBox.Show("Default profile set successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error setting default profile: {ex.Message}");
            }
        }

        private void mainFrm_Load(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists("Profiles/defaultProfile.txt"))
                {
                    string defaultProfile = File.ReadAllText("Profiles/defaultProfile.txt");
                    cbxProfile.SelectedItem = defaultProfile;
                    btnLoadProfile_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading default profile: {ex.Message}");
            }
        }

    }
}
