using System;
using System.Drawing;
using System.Windows.Forms;

namespace Battleship
{
    partial class battleshipMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(battleshipMainForm));
            this.btnNewGame = new System.Windows.Forms.Button();
            this.lblBattleship = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlBoatStatuses = new System.Windows.Forms.Panel();
            this.nudTurnsTaken = new System.Windows.Forms.NumericUpDown();
            this.lblBoatDestroyer = new System.Windows.Forms.Label();
            this.lblBoatSubmarine = new System.Windows.Forms.Label();
            this.lblBoatCruiser = new System.Windows.Forms.Label();
            this.lblBoatBattleship = new System.Windows.Forms.Label();
            this.lblBoatCarrier = new System.Windows.Forms.Label();
            this.lblTurnsTaken = new System.Windows.Forms.Label();
            this.lblDestroyer = new System.Windows.Forms.Label();
            this.lblSubmarine = new System.Windows.Forms.Label();
            this.lblCruiser = new System.Windows.Forms.Label();
            this.lblBattleshipBoat = new System.Windows.Forms.Label();
            this.lblCarrier = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlGame = new System.Windows.Forms.Panel();
            this.lblXcoordinates = new System.Windows.Forms.Label();
            this.lblYcoordinates = new System.Windows.Forms.Label();
            this.cmbxX = new System.Windows.Forms.ComboBox();
            this.cmbxY = new System.Windows.Forms.ComboBox();
            this.btnShoot = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.pnlBoatStatuses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTurnsTaken)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNewGame.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNewGame.Location = new System.Drawing.Point(23, 70);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(91, 23);
            this.btnNewGame.TabIndex = 0;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // lblBattleship
            // 
            this.lblBattleship.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBattleship.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBattleship.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBattleship.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBattleship.Location = new System.Drawing.Point(-4, -3);
            this.lblBattleship.Name = "lblBattleship";
            this.lblBattleship.Size = new System.Drawing.Size(888, 55);
            this.lblBattleship.TabIndex = 2;
            this.lblBattleship.Text = "BATTLESHIP";
            this.lblBattleship.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(780, 598);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlBoatStatuses
            // 
            this.pnlBoatStatuses.AutoSize = true;
            this.pnlBoatStatuses.BackColor = System.Drawing.Color.Transparent;
            this.pnlBoatStatuses.Controls.Add(this.nudTurnsTaken);
            this.pnlBoatStatuses.Controls.Add(this.lblBoatDestroyer);
            this.pnlBoatStatuses.Controls.Add(this.lblBoatSubmarine);
            this.pnlBoatStatuses.Controls.Add(this.lblBoatCruiser);
            this.pnlBoatStatuses.Controls.Add(this.lblBoatBattleship);
            this.pnlBoatStatuses.Controls.Add(this.lblBoatCarrier);
            this.pnlBoatStatuses.Controls.Add(this.lblTurnsTaken);
            this.pnlBoatStatuses.Controls.Add(this.lblDestroyer);
            this.pnlBoatStatuses.Controls.Add(this.lblSubmarine);
            this.pnlBoatStatuses.Controls.Add(this.lblCruiser);
            this.pnlBoatStatuses.Controls.Add(this.lblBattleshipBoat);
            this.pnlBoatStatuses.Controls.Add(this.lblCarrier);
            this.pnlBoatStatuses.Controls.Add(this.label2);
            this.pnlBoatStatuses.Location = new System.Drawing.Point(579, 284);
            this.pnlBoatStatuses.Name = "pnlBoatStatuses";
            this.pnlBoatStatuses.Size = new System.Drawing.Size(279, 229);
            this.pnlBoatStatuses.TabIndex = 4;
            // 
            // nudTurnsTaken
            // 
            this.nudTurnsTaken.Location = new System.Drawing.Point(157, 204);
            this.nudTurnsTaken.Name = "nudTurnsTaken";
            this.nudTurnsTaken.Size = new System.Drawing.Size(59, 22);
            this.nudTurnsTaken.TabIndex = 13;
            // 
            // lblBoatDestroyer
            // 
            this.lblBoatDestroyer.BackColor = System.Drawing.Color.Green;
            this.lblBoatDestroyer.Location = new System.Drawing.Point(134, 180);
            this.lblBoatDestroyer.Name = "lblBoatDestroyer";
            this.lblBoatDestroyer.Size = new System.Drawing.Size(101, 16);
            this.lblBoatDestroyer.TabIndex = 12;
            // 
            // lblBoatSubmarine
            // 
            this.lblBoatSubmarine.BackColor = System.Drawing.Color.Green;
            this.lblBoatSubmarine.Location = new System.Drawing.Point(134, 148);
            this.lblBoatSubmarine.Name = "lblBoatSubmarine";
            this.lblBoatSubmarine.Size = new System.Drawing.Size(101, 16);
            this.lblBoatSubmarine.TabIndex = 11;
            // 
            // lblBoatCruiser
            // 
            this.lblBoatCruiser.BackColor = System.Drawing.Color.Green;
            this.lblBoatCruiser.Location = new System.Drawing.Point(134, 116);
            this.lblBoatCruiser.Name = "lblBoatCruiser";
            this.lblBoatCruiser.Size = new System.Drawing.Size(101, 16);
            this.lblBoatCruiser.TabIndex = 10;
            // 
            // lblBoatBattleship
            // 
            this.lblBoatBattleship.BackColor = System.Drawing.Color.Green;
            this.lblBoatBattleship.Location = new System.Drawing.Point(134, 85);
            this.lblBoatBattleship.Name = "lblBoatBattleship";
            this.lblBoatBattleship.Size = new System.Drawing.Size(101, 16);
            this.lblBoatBattleship.TabIndex = 9;
            // 
            // lblBoatCarrier
            // 
            this.lblBoatCarrier.BackColor = System.Drawing.Color.Green;
            this.lblBoatCarrier.Location = new System.Drawing.Point(134, 49);
            this.lblBoatCarrier.Name = "lblBoatCarrier";
            this.lblBoatCarrier.Size = new System.Drawing.Size(101, 16);
            this.lblBoatCarrier.TabIndex = 8;
            // 
            // lblTurnsTaken
            // 
            this.lblTurnsTaken.AutoSize = true;
            this.lblTurnsTaken.BackColor = System.Drawing.Color.Black;
            this.lblTurnsTaken.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurnsTaken.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTurnsTaken.Location = new System.Drawing.Point(43, 206);
            this.lblTurnsTaken.Name = "lblTurnsTaken";
            this.lblTurnsTaken.Size = new System.Drawing.Size(94, 16);
            this.lblTurnsTaken.TabIndex = 6;
            this.lblTurnsTaken.Text = "Turns Taken";
            // 
            // lblDestroyer
            // 
            this.lblDestroyer.AutoSize = true;
            this.lblDestroyer.BackColor = System.Drawing.Color.Black;
            this.lblDestroyer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestroyer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDestroyer.Location = new System.Drawing.Point(19, 180);
            this.lblDestroyer.Name = "lblDestroyer";
            this.lblDestroyer.Size = new System.Drawing.Size(93, 16);
            this.lblDestroyer.TabIndex = 5;
            this.lblDestroyer.Text = "Destroyer(2)";
            // 
            // lblSubmarine
            // 
            this.lblSubmarine.AutoSize = true;
            this.lblSubmarine.BackColor = System.Drawing.Color.Black;
            this.lblSubmarine.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubmarine.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSubmarine.Location = new System.Drawing.Point(19, 148);
            this.lblSubmarine.Name = "lblSubmarine";
            this.lblSubmarine.Size = new System.Drawing.Size(99, 16);
            this.lblSubmarine.TabIndex = 4;
            this.lblSubmarine.Text = "Submarine(3)";
            // 
            // lblCruiser
            // 
            this.lblCruiser.AutoSize = true;
            this.lblCruiser.BackColor = System.Drawing.Color.Black;
            this.lblCruiser.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCruiser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCruiser.Location = new System.Drawing.Point(19, 116);
            this.lblCruiser.Name = "lblCruiser";
            this.lblCruiser.Size = new System.Drawing.Size(74, 16);
            this.lblCruiser.TabIndex = 3;
            this.lblCruiser.Text = "Cruiser(3)";
            // 
            // lblBattleshipBoat
            // 
            this.lblBattleshipBoat.AutoSize = true;
            this.lblBattleshipBoat.BackColor = System.Drawing.Color.Black;
            this.lblBattleshipBoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBattleshipBoat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBattleshipBoat.Location = new System.Drawing.Point(19, 85);
            this.lblBattleshipBoat.Name = "lblBattleshipBoat";
            this.lblBattleshipBoat.Size = new System.Drawing.Size(94, 16);
            this.lblBattleshipBoat.TabIndex = 2;
            this.lblBattleshipBoat.Text = "Battleship(4)";
            // 
            // lblCarrier
            // 
            this.lblCarrier.AutoSize = true;
            this.lblCarrier.BackColor = System.Drawing.Color.Black;
            this.lblCarrier.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrier.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCarrier.Location = new System.Drawing.Point(19, 49);
            this.lblCarrier.Name = "lblCarrier";
            this.lblCarrier.Size = new System.Drawing.Size(72, 16);
            this.lblCarrier.TabIndex = 1;
            this.lblCarrier.Text = "Carrier(5)";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "Boat Stasuses";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(154, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "label6";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(154, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "label5";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(154, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(154, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "label3";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(154, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label_Click);
            // 
            // pnlGame
            // 
            this.pnlGame.BackColor = System.Drawing.Color.Transparent;
            this.pnlGame.Location = new System.Drawing.Point(48, 112);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new System.Drawing.Size(470, 433);
            this.pnlGame.TabIndex = 5;
            // 
            // lblXcoordinates
            // 
            this.lblXcoordinates.AutoSize = true;
            this.lblXcoordinates.BackColor = System.Drawing.SystemColors.InfoText;
            this.lblXcoordinates.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXcoordinates.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblXcoordinates.Location = new System.Drawing.Point(598, 98);
            this.lblXcoordinates.Name = "lblXcoordinates";
            this.lblXcoordinates.Size = new System.Drawing.Size(107, 16);
            this.lblXcoordinates.TabIndex = 6;
            this.lblXcoordinates.Text = "X co-ordinates";
            // 
            // lblYcoordinates
            // 
            this.lblYcoordinates.AutoSize = true;
            this.lblYcoordinates.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblYcoordinates.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYcoordinates.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblYcoordinates.Location = new System.Drawing.Point(598, 129);
            this.lblYcoordinates.Name = "lblYcoordinates";
            this.lblYcoordinates.Size = new System.Drawing.Size(108, 16);
            this.lblYcoordinates.TabIndex = 7;
            this.lblYcoordinates.Text = "Y co-ordinates";
            // 
            // cmbxX
            // 
            this.cmbxX.FormattingEnabled = true;
            this.cmbxX.Location = new System.Drawing.Point(716, 95);
            this.cmbxX.Name = "cmbxX";
            this.cmbxX.Size = new System.Drawing.Size(121, 24);
            this.cmbxX.TabIndex = 8;
            // 
            // cmbxY
            // 
            this.cmbxY.FormattingEnabled = true;
            this.cmbxY.Location = new System.Drawing.Point(716, 129);
            this.cmbxY.Name = "cmbxY";
            this.cmbxY.Size = new System.Drawing.Size(121, 24);
            this.cmbxY.TabIndex = 9;
            // 
            // btnShoot
            // 
            this.btnShoot.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnShoot.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnShoot.Location = new System.Drawing.Point(762, 172);
            this.btnShoot.Name = "btnShoot";
            this.btnShoot.Size = new System.Drawing.Size(75, 23);
            this.btnShoot.TabIndex = 10;
            this.btnShoot.Text = "Shoot";
            this.btnShoot.UseVisualStyleBackColor = false;
            this.btnShoot.Click += new System.EventHandler(this.btnShoot_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReset.Location = new System.Drawing.Point(678, 598);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // battleshipMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(882, 653);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnShoot);
            this.Controls.Add(this.cmbxY);
            this.Controls.Add(this.cmbxX);
            this.Controls.Add(this.lblYcoordinates);
            this.Controls.Add(this.lblXcoordinates);
            this.Controls.Add(this.pnlGame);
            this.Controls.Add(this.pnlBoatStatuses);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblBattleship);
            this.Controls.Add(this.btnNewGame);
            this.Name = "battleshipMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Battleship - Samrat Jayanta Bhurtel";
            this.pnlBoatStatuses.ResumeLayout(false);
            this.pnlBoatStatuses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTurnsTaken)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void pnlBoatStatuses_Paint(object sender, PaintEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        

        #endregion

        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Label lblBattleship;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlBoatStatuses;
        private System.Windows.Forms.Label lblBoatDestroyer;
        private System.Windows.Forms.Label lblBoatSubmarine;
        private System.Windows.Forms.Label lblBoatCruiser;
        private System.Windows.Forms.Label lblBoatBattleship;
        private System.Windows.Forms.Label lblBoatCarrier;
        private System.Windows.Forms.Label lblTurnsTaken;
        private System.Windows.Forms.Label lblDestroyer;
        private System.Windows.Forms.Label lblSubmarine;
        private System.Windows.Forms.Label lblCruiser;
        private System.Windows.Forms.Label lblBattleshipBoat;
        private System.Windows.Forms.Label lblCarrier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlGame;
        private System.Windows.Forms.Label lblXcoordinates;
        private System.Windows.Forms.Label lblYcoordinates;
        private System.Windows.Forms.ComboBox cmbxX;
        private System.Windows.Forms.ComboBox cmbxY;
        private System.Windows.Forms.NumericUpDown nudTurnsTaken;
        private System.Windows.Forms.Button btnShoot;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}

