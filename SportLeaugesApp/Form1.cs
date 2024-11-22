// Title: MainForm.cs
// Name : Samrat Jayanta Bhurtel
// Student ID: 100949545
// Date: 2024 - 11 - 22
// Description: This is the main form of the application. It is used to display the data from the database and to filter the data based on the selected team.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportLeaugesApp
{
    public partial class MainForm : Form
    {
      
        public MainForm()
        {
            InitializeComponent();
            this.cmbTeams.ValueMember = "teamid"; 


        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sportleaguesDataSet.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.sportleaguesDataSet.DataTable1);
            // TODO: This line of code loads data into the 'sportleaguesDataSet.players' table. You can move, or remove it, as needed.
            this.playersTableAdapter.Fill(this.sportleaguesDataSet.players);
            // TODO: This line of code loads data into the 'sportleaguesDataSet.teams' table. You can move, or remove it, as needed.
            this.teamsTableAdapter.Fill(this.sportleaguesDataSet.teams);

        }

        private void cmbTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Check if a team is selected and the value is valid
                if (cmbTeams.SelectedValue != null && int.TryParse(cmbTeams.SelectedValue.ToString(), out int selectedTeamId))
                {
                    // Load filtered data using FillByTeamID
                    this.playersTableAdapter.FillByteamID(this.sportleaguesDataSet.players, selectedTeamId);
                    dgvPlayers.DataSource = null; // Clear existing data
                    dgvPlayers.DataSource = this.sportleaguesDataSet.players; // Bind new filtered data
                }
                else
                {
                    MessageBox.Show("Please select a valid team.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Handle any runtime exceptions
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}


