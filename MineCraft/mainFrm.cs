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
        /// <summary>
        /// This method is called when the "Save Profile" button is clicked. It saves the profile data to a file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveProfile_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate profile name
                if (string.IsNullOrWhiteSpace(txtProfileName.Text))
                {
                    MessageBox.Show("Profile name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Create a PlayerProfile object and populate it with data from the UI
                var profile = new PlayerProfile
                {
                    ProfileName = txtProfileName.Text,
                    InputDevice = cbxInputDevice.SelectedItem?.ToString() ?? "Keyboard",
                    AutoJump = cbxAutoJump.Checked,
                    MouseSensitivity = (int)nudMouseSensitivity.Value,
                    ControllerSensitivity = (int)nudControllerSensitivity.Value,
                    InvertYAxis = cbxYaxis.Checked,
                    Brightness = (int)nudBrightness.Value,
                    FancyGraphics = cbxFancyGraphics.Checked,
                    VSync = cbxVsync.Checked,
                    Fullscreen = cbxFullScreen.Checked,
                    RenderDistance = (int)nudRenderDistance.Value,
                    FieldOfView = (int)nudFieldofView.Value,
                    RayTracing = cbxRayTracing.Checked,
                    Upscaling = cbxUpscaling.Checked,
                    MusicVolume = (int)trckbrMusicVolume.Value,
                    SoundVolume = (int)trckbrSoundVolume.Value,
                    HUDTransparency = (int)nudTransparency.Value,
                    ShowCoordinates = cbxShowCoordinates.Checked,
                    CameraPerspective = cbxCameraPerspective.SelectedItem?.ToString() ?? "First-person"
                };

                // Save the profile
                Directory.CreateDirectory("Profiles");
                string filePath = $"Profiles/{profile.ProfileName}.txt";
                fileIOTools.SaveProfile(filePath, profile);

                MessageBox.Show("Profile saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving profile: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// This method is called when the "Load Profile" button is clicked. It loads the profile data from a file and populates the UI controls.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoadProfile_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxProfile.SelectedItem == null)
                {
                    MessageBox.Show("Please select a profile to load.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string profileName = cbxProfile.SelectedItem.ToString();
                string filePath = $"Profiles/{profileName}.txt";

                var profile = fileIOTools.LoadProfile(filePath);

                // Update UI controls
                txtProfileName.Text = profile.ProfileName;
                cbxInputDevice.SelectedItem = profile.InputDevice;
                cbxAutoJump.Checked = profile.AutoJump;
                nudMouseSensitivity.Value = profile.MouseSensitivity;
                nudControllerSensitivity.Value = profile.ControllerSensitivity;
                cbxYaxis.Checked = profile.InvertYAxis;
                nudBrightness.Value = profile.Brightness;
                cbxFancyGraphics.Checked = profile.FancyGraphics;
                cbxVsync.Checked = profile.VSync;
                cbxFullScreen.Checked = profile.Fullscreen;
                nudRenderDistance.Value = profile.RenderDistance;
                nudFieldofView.Value = profile.FieldOfView;
                cbxRayTracing.Checked = profile.RayTracing;
                cbxUpscaling.Checked = profile.Upscaling;
                trckbrMusicVolume.Value = profile.MusicVolume;
                trckbrSoundVolume.Value = profile.SoundVolume;
                nudTransparency.Value = profile.HUDTransparency;
                cbxShowCoordinates.Checked = profile.ShowCoordinates;
                cbxCameraPerspective.SelectedItem = profile.CameraPerspective;

                MessageBox.Show("Profile loaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FileNotFoundException fnfEx)
            {
                MessageBox.Show($"File not found: {fnfEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading profile: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// This method is called when the "Set Default" button is clicked. It sets the selected profile as the default profile.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSetDefault_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxProfile.SelectedItem == null)
                {
                    MessageBox.Show("Please select a profile to set as default.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string defaultProfile = cbxProfile.SelectedItem.ToString();
                File.WriteAllText("Profiles/defaultProfile.txt", defaultProfile);

                MessageBox.Show("Default profile set successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (UnauthorizedAccessException uaEx)
            {
                MessageBox.Show($"Access denied: {uaEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error setting default profile: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainFrm_Load(object sender, EventArgs e)
        {
            try
            {
                        // Ensure the Profiles directory exists
                        Directory.CreateDirectory("Profiles");

                        // Populate the ComboBox with available profiles
                        RefreshProfileList();

                        // Load the default profile if available
                        string defaultFilePath = "Profiles/defaultProfile.txt";
                        if (File.Exists(defaultFilePath))
                        {
                            string defaultProfile = File.ReadAllText(defaultFilePath);
                            cbxProfile.SelectedItem = defaultProfile;
                            btnLoadProfile_Click(sender, e);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading default profile: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
        /// <summary>
        /// This method refreshes the profile list in the ComboBox.
        /// </summary>
        private void RefreshProfileList()
        {
            try
            {
                cbxProfile.Items.Clear(); // Clear existing items

                // Get all profile files in the Profiles directory
                string[] profileFiles = Directory.GetFiles("Profiles", "*.txt");

                foreach (string file in profileFiles)
                {
                    string profileName = Path.GetFileNameWithoutExtension(file);
                    cbxProfile.Items.Add(profileName); // Add profile name to ComboBox
                }

                if (cbxProfile.Items.Count > 0)
                {
                    cbxProfile.SelectedIndex = 0; // Set the first item as selected
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error refreshing profile list: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}

