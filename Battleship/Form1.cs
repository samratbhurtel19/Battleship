using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Battleship.BS;

namespace Battleship
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Methods to set initial (default) 
        private void SetInitials()
        {
            pnlBoatStatuses.Visible = false;
            pnlGame.Visible = false;
            lblXcoordinates.Visible = false;
            lblYcoordinates.Visible = false;
            cmbxX.Visible = false;
            cmbxY.Visible = false;
            cmbxX.SelectedValue = 0;
            cmbxX.Items.Clear();
            cmbxY.SelectedValue = 0;
            cmbxY.Items.Clear();
            lblBoatCarrier.BackColor = Color.Green;
            lblBoatBattleship.BackColor = Color.Green;
            lblBoatCruiser.BackColor = Color.Green;
            lblBoatSubmarine.BackColor = Color.Green;
            lblBoatDestroyer.BackColor = Color.Green;
            nudTurnsTaken.Value = 0;
            Settings.turnsTaken = 0;
            btnShoot.Visible = false;
            pnlBoatStatuses.BackColor = Color.FromArgb(90, 0, 0, 0);

        }
        /// <summary>
        /// Method to set the grid
        /// </summary>
        private void SetGrid()
        {
            for (int i = 1; i <= BS.MAX_BOARD_SIZE; i++)
            {
                for (int j = 1; j <= BS.MAX_BOARD_SIZE; j++)
                {
                    Label lbl = new Label();
                    lbl.BackColor = Color.FromArgb(65, 255, 255, 255);
                    lbl.Size = new Size(Settings.SIZE, Settings.SIZE);
                    Location = new Point(Settings.LOCATION * i, Settings.LOCATION * j);
                    lbl.BorderStyle = BorderStyle.FixedSingle;
                    lbl.TextAlign = ContentAlignment.MiddleCenter;
                    lbl.Text = $"{i}, {j}";
                    lbl.Click += new EventHandler(lbl_Click);
                    Settings.lbls[i, j] = lbl;

                }

            }
        }
        /// <summary>
        /// Methods to show the labels on the grid
        /// 
        private void ShowLabels()
        {
            pnlGame.Controls.Clear();

            SetGrid();
            for (int i = 1; i <= BS.MAX_BOARD_SIZE; i++)
            {
                for (int j = 1; j <= BS.MAX_BOARD_SIZE; j++)
                {
                    pnlGame.Controls.Add(Settings.lbls[i, j]);
                }
            }
            pnlGame.Visible = true;
        }
        /// <summary>
        /// Method to populate the X and Y coordinates
        /// 
        private void PopulateCoordinates()
        {

            for (int i = 1; i <= BS.MAX_BOARD_SIZE; i++)
            {
                cmbxX.Items.Add(i);
                cmbxY.Items.Add(i);
            }
            cmbxX.SelectedIndex = 0;
            cmbxY.SelectedIndex = 0;
        }
        /// <summary>
        /// Method to update sunk boats
        /// 
        private void UpdateSunkBoats()
        {
            var boatsAlive = BS.BoatsAlive();
            foreach (var boatAlive in boatsAlive)
            {
                if (boatAlive.Value)
                    // Update the label of the sunk boat
                    switch (boatAlive.Key)
                    {
                        case Boats.Carrier:
                            lblBoatCarrier.BackColor = Color.Red;
                            break;
                        case Boats.Battleship:
                            lblBoatBattleship.BackColor = Color.Red;
                            break;
                        case Boats.Cruiser:
                            lblBoatCruiser.BackColor = Color.Red;
                            break;
                        case Boats.Submarine:
                            lblBoatSubmarine.BackColor = Color.Red;
                            break;
                        case Boats.Destroyer:
                            lblBoatDestroyer.BackColor = Color.Red;
                            break;
                    }
            }

        }
        /// Method for Boat hit sound
        /// 

        public void PlayBoatHitSound()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.Stream = Properties.Resources.BoatHit;
            player.Play();
        }

        /// <summary>
        ///
        public static void PlayMissSound()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.Stream = Properties.Resources.Miss;
            player.Play();
        }


        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            SetInitials();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            SetInitials();
            BS.GridClear();
            BS.RandomizeBoats();
            ShowLabels();
            PopulateCoordinates();
            pnlBoatStatuses.Visible = true;
            pnlGame.Visible = true;
            lblXcoordinates.Visible = true;
            lblYcoordinates.Visible = true;
            cmbxX.Visible = true;
            cmbxY.Visible = true;
            btnShoot.Visible = true;

        }

        /// <summary>
        /// 
        private void lbl_Click(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            if (lbl != null)
            {

                string[] coordinates = lbl.Text.Split(',');
                int x = int.Parse(coordinates[0]);
                int y = int.Parse(coordinates[1]);
                if (BS.MissileHit(x, y))
                {
                    PlayBoatHitSound();
                    lbl.BackColor = Color.Red;
                }
                else
                {
                    PlayMissSound();
                    lbl.BackColor = Color.Blue;
                }
                Settings.turnsTaken++;
                nudTurnsTaken.Value = Settings.turnsTaken;
                lbl.Enabled = false;
                UpdateSunkBoats();
                if (BS.GameOver())
                {
                    MessageBox.Show("Congratulations! You have won the game!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SetInitials();
                }
            }

        }

        private void btnShoot_Click(object sender, EventArgs e)
        {
            if (cmbxX.SelectedIndex != null && cmbxY.SelectedIndex !=null)
            {
                int x = cmbxX.SelectedIndex + 1;
                int y = cmbxY.SelectedIndex + 1;
                if (BS.MissileHit(x, y))
                {
                    PlayBoatHitSound();
                    Settings.lbls[x, y].BackColor = Color.Red;
                }
                else
                {
                    PlayMissSound();
                    Settings.lbls[x, y].BackColor = Color.Blue;
                }
                Settings.turnsTaken++;
                nudTurnsTaken.Value = Settings.turnsTaken;
                Settings.lbls[x, y].Enabled = false;
                UpdateSunkBoats();
                if (BS.GameOver())
                {
                    MessageBox.Show("Congratulations! You have won the game!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SetInitials();
                }
            }
            else
            {
                MessageBox.Show("Please select the X and Y coordinates", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
    




