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
        /// This method is called when the form loads. It initializes the default profile if available and populates the profiles combo box.
        /// </summary>
        private void mainFrm_Load(object sender, EventArgs e)
        {
            try
            {
                // Ensure the Profiles directory exists
                Directory.CreateDirectory("Profiles");

                // Populate profiles in the dropdown
                PopulateProfiles();

                // Initialize default values for CameraPerspective and other settings
                cbxCameraPerspective.Items.Clear();
                cbxCameraPerspective.Items.AddRange(new[] { "First-person", "Third-person Front", "Third-person Back" });

                // Load default profile if available
                string defaultFilePath = "Profiles/defaultProfile.txt";
                if (File.Exists(defaultFilePath))
                {
                    string defaultProfile = File.ReadAllText(defaultFilePath);
                    cbxProfile.SelectedItem = defaultProfile;
                    btnLoadProfile_Click(sender, e);
                }
                else
                {
                    // Set default input device and other default values if no default profile exists
                    cbxInputDevice.SelectedItem = "Keyboard";
                    cbxAutoJump.Checked = true;
                    nudMouseSensitivity.Value = 50;
                    nudControllerSensitivity.Value = 50;
                    cbxYaxis.Checked = false;
                    nudBrightness.Value = 50;
                    cbxFancyGraphics.Checked = true;
                    cbxVsync.Checked = true;
                    cbxFullScreen.Checked = false;
                    nudRenderDistance.Value = 16;
                    nudFieldofView.Value = 64;
                    cbxRayTracing.Checked = false;
                    cbxUpscaling.Checked = false;
                    trckbrMusicVolume.Value = 100;
                    trckbrSoundVolume.Value = 100;
                    nudTransparency.Value = 100;
                    cbxShowCoordinates.Checked = false;
                    cbxCameraPerspective.SelectedItem = "First-Person"; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading the application: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// This method saves the player profile data into a file.
        /// </summary>
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
        /// This method loads a player profile from a file and populates the form controls.
        /// </summary>
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
        /// This method sets the selected profile as the default profile.
        /// </summary>
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
        /// This method populates the combo box with all available profiles from the Profiles directory.
        /// </summary>
        private void PopulateProfiles()
        {
            try
            {
                Directory.CreateDirectory("Profiles");
                cbxProfile.Items.Clear();

                var files = Directory.GetFiles("Profiles", "*.txt");
                foreach (var file in files)
                {
                    cbxProfile.Items.Add(Path.GetFileNameWithoutExtension(file));
                }

                if (cbxProfile.Items.Count > 0)
                {
                    cbxProfile.SelectedIndex = 0; // Select the first profile by default
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error populating profiles: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
