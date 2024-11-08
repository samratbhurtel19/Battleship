// Title: Dungeons & Dragons Main Form
// Author Name: Samrat Jayanta Bhurtel
// Date: November 8, 2024
// Student ID: 100949545
// Description:This is the main form of the Dungeons & Dragons application, providing an interface to view, create, and edit characters.
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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Refreshes the character list to display any new or modified characters
        /// </summary>
        private void RefreshCharacterList()
        {
            lstCharacters.DataSource = null;  // Reset the data source
            lstCharacters.DataSource = Character.Characters;  // Bind to the updated list
            lstCharacters.DisplayMember = "Name";  // Display the character's name in the list
        }

        /// <summary>
        /// Opens the CharacterEditorForm to create a new character
        /// </summary>
        private void btnCreateCharacter_Click(object sender, EventArgs e)
        {
            // Open the CharacterEditorForm without a character to create a new one
            frmCharacterEditor editorForm = new frmCharacterEditor();
            editorForm.ShowDialog();  // Show as a modal dialog to wait for input

            // Refresh the list after potentially adding a new character
            RefreshCharacterList();
        }

        /// <summary>
        /// Exits the application when the Exit button is clicked
        /// </summary>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();  // Close the application
        }

        /// <summary>
        /// Opens the CharacterEditorForm with the selected character to edit
        /// </summary>
        private void btnEditCharacter_Click(object sender, EventArgs e)
        {
            if (lstCharacters.SelectedItem == null)
            {
                // Show warning if no character is selected for editing
                MessageBox.Show("Please select a character to edit.", "No Character Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the selected character from the list
            Character selectedCharacter = (Character)lstCharacters.SelectedItem;

            // Open the CharacterEditorForm with the selected character
            frmCharacterEditor editorForm = new frmCharacterEditor(selectedCharacter);
            editorForm.ShowDialog();  // Show as a modal dialog to wait for input

            // Refresh the list to reflect any changes
            RefreshCharacterList();
        }
    }
}