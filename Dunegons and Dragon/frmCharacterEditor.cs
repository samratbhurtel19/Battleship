// Title: Dungeons & Dragons Character Editor
// Author Name: Samrat Jayanta Bhurtel
// Date: November 8, 2024
// Student ID: 100949545
// Description: This program is a Character Editor for a Dungeons & Dragons application, allowing users to create and edit character profiles with various attributes, abilities, and stats.

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
    public partial class frmCharacterEditor : Form
    {
        private Character currentCharacter; // Holds the character data for editing or creation
        private int remainingPoints = 27;   // Initial points available for allocation

        // Default constructor initializes the form and creates a new character
        public frmCharacterEditor()
        {
            InitializeComponent();
            currentCharacter = new Character();  // Initialize a new character object
        }

        /// <summary>
        /// Constructor that sets the character to edit and loads its data.
        /// </summary>
        /// <param name="character">Character object to be edited</param>
        public frmCharacterEditor(Character character)
        {
            InitializeComponent();
            currentCharacter = character;  // Set the character to edit
            LoadCharacterData();           // Load data into form fields
        }

        /// <summary>
        /// Form load event to initialize ComboBoxes and starting values for attributes.
        /// </summary>
        private void frmCharacterEditor_Load(object sender, EventArgs e)
        {
            // Populate Gender ComboBox with predefined values
            cmbGender.Items.AddRange(new string[] { "Male", "Female", "Gender-Diverse" });

            // Populate Race ComboBox with available races
            cmbRace.DataSource = Race.DefaultRaces;
            cmbRace.DisplayMember = "Name";

            // Populate Class ComboBox with available classes
            cmbClass.DataSource = Class.DefaultClasses;
            cmbClass.DisplayMember = "Name";

            // Populate Alignment ComboBox using Enum values
            cmbAlignment.DataSource = Enum.GetValues(typeof(Constants.Alignment));

            // Set starting values for NumericUpDown controls for each attribute
            numericUpDown1.Value = 8;  // Strength
            numericUpDown2.Value = 8;  // Constitution
            numericUpDown3.Value = 8;  // Dexterity
            numericUpDown4.Value = 8;  // Intelligence
            numericUpDown5.Value = 8;  // Wisdom
            numericUpDown6.Value = 8;  // Charisma

            // Initialize remaining points calculation
            UpdateRemainingPoints();
        }

        /// <summary>
        /// Calculates remaining points based on points spent on attributes.
        /// </summary>
        private void UpdateRemainingPoints()
        {
            // Calculate total points spent on attributes
            int totalPointsSpent = (int)(numericUpDown1.Value - 8) + (int)(numericUpDown2.Value - 8) +
                                   (int)(numericUpDown3.Value - 8) + (int)(numericUpDown4.Value - 8) +
                                   (int)(numericUpDown5.Value - 8) + (int)(numericUpDown6.Value - 8);

            remainingPoints = 27 - totalPointsSpent;
            lblRemainingPoints.Text = $"Remaining Points: {remainingPoints}";

            // Enable or disable increment based on remaining points and attribute limits
            numericUpDown1.Enabled = numericUpDown1.Value < 20 && remainingPoints > 0;
            numericUpDown2.Enabled = numericUpDown2.Value < 20 && remainingPoints > 0;
            numericUpDown3.Enabled = numericUpDown3.Value < 20 && remainingPoints > 0;
            numericUpDown4.Enabled = numericUpDown4.Value < 20 && remainingPoints > 0;
            numericUpDown5.Enabled = numericUpDown5.Value < 20 && remainingPoints > 0;
            numericUpDown6.Enabled = numericUpDown6.Value < 20 && remainingPoints > 0;
        }

        /// <summary>
        /// Event handler for the Save button to save or update character data.
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Assign values from form controls to character properties
            currentCharacter.Name = txtName.Text;
            currentCharacter.Gender = cmbGender.SelectedItem.ToString();
            currentCharacter.CharacterRace = (Race)cmbRace.SelectedItem;
            currentCharacter.CharacterClass = (Class)cmbClass.SelectedItem;
            currentCharacter.Alignment = (Constants.Alignment)cmbAlignment.SelectedItem;
            currentCharacter.Strength = (int)numericUpDown1.Value;
            currentCharacter.Constitution = (int)numericUpDown2.Value;
            currentCharacter.Dexterity = (int)numericUpDown3.Value;
            currentCharacter.Intelligence = (int)numericUpDown4.Value;
            currentCharacter.Wisdom = (int)numericUpDown5.Value;
            currentCharacter.Charisma = (int)numericUpDown6.Value;
            currentCharacter.Level = (int)numericUpDown10.Value;
            currentCharacter.ExperiencePoints = (int)numericUpDown11.Value;
            currentCharacter.Initiative = (int)numericUpDown7.Value;
            currentCharacter.Speed = (int)numericUpDown8.Value;
            currentCharacter.HitPoints = (int)numericUpDown9.Value;

            // Add character to list if it's new
            if (!Character.Characters.Contains(currentCharacter))
            {
                Character.Characters.Add(currentCharacter);
            }

            this.Close();  // Close the form after saving
        }

        /// <summary>
        /// Loads character data into the form controls for editing.
        /// </summary>
        private void LoadCharacterData()
        {
            // Populate form controls with current character data
            txtName.Text = currentCharacter.Name;
            cmbGender.SelectedItem = currentCharacter.Gender;
            cmbRace.SelectedItem = currentCharacter.CharacterRace;
            cmbClass.SelectedItem = currentCharacter.CharacterClass;
            cmbAlignment.SelectedItem = currentCharacter.Alignment;
            numericUpDown1.Value = currentCharacter.Strength;
            numericUpDown2.Value = currentCharacter.Constitution;
            numericUpDown3.Value = currentCharacter.Dexterity;
            numericUpDown4.Value = currentCharacter.Intelligence;
            numericUpDown5.Value = currentCharacter.Wisdom;
            numericUpDown6.Value = currentCharacter.Charisma;
            numericUpDown10.Value = currentCharacter.Level;
            numericUpDown11.Value = currentCharacter.ExperiencePoints;
            numericUpDown7.Value = currentCharacter.Initiative;
            numericUpDown8.Value = currentCharacter.Speed;
            numericUpDown9.Value = currentCharacter.HitPoints;
        }
    }
}
