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

        private void cboTeams_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbTeams.SelectedValue != null)
            {
                int selectedTeamId = Convert.ToInt32(cmbTeams.SelectedValue);


                playersTableAdapter.FillByteamID(sportleaguesDataSet.players, selectedTeamId);
                dgvPlayers.DataSource = sportleaguesDataSet.players;
            }
            else
            {
                MessageBox.Show("Please select a valid team.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}


    
