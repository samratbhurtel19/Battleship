namespace Battleship
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnNewGame = new System.Windows.Forms.Button();
            this.lblBattleship = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlBoatStatuses = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCarrier = new System.Windows.Forms.Label();
            this.lblBattleshipBoat = new System.Windows.Forms.Label();
            this.lblCruiser = new System.Windows.Forms.Label();
            this.lblSubmarine = new System.Windows.Forms.Label();
            this.lblDestroyer = new System.Windows.Forms.Label();
            this.lblTurnsTaken = new System.Windows.Forms.Label();
            this.lblBoatCarrier = new System.Windows.Forms.Label();
            this.lblBoatBattleship = new System.Windows.Forms.Label();
            this.lblBoatCruiser = new System.Windows.Forms.Label();
            this.lblBoatSubmarine = new System.Windows.Forms.Label();
            this.lblBoatDestroyer = new System.Windows.Forms.Label();
            this.pnlGame = new System.Windows.Forms.Panel();
            this.lblXcoordinates = new System.Windows.Forms.Label();
            this.lblYcoordinates = new System.Windows.Forms.Label();
            this.cmbxX = new System.Windows.Forms.ComboBox();
            this.cmbxY = new System.Windows.Forms.ComboBox();
            this.nudTurnsTaken = new System.Windows.Forms.NumericUpDown();
            this.btnShoot = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.pnlBoatStatuses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTurnsTaken)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(23, 70);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(91, 23);
            this.btnNewGame.TabIndex = 0;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // lblBattleship
            // 
            this.lblBattleship.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBattleship.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBattleship.Location = new System.Drawing.Point(-4, -3);
            this.lblBattleship.Name = "lblBattleship";
            this.lblBattleship.Size = new System.Drawing.Size(888, 55);
            this.lblBattleship.TabIndex = 2;
            this.lblBattleship.Text = "BATTLESHIP";
            this.lblBattleship.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(780, 598);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlBoatStatuses
            // 
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
            this.pnlBoatStatuses.Location = new System.Drawing.Point(605, 283);
            this.pnlBoatStatuses.Name = "pnlBoatStatuses";
            this.pnlBoatStatuses.Size = new System.Drawing.Size(265, 229);
            this.pnlBoatStatuses.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "Boat Stasuses";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCarrier
            // 
            this.lblCarrier.AutoSize = true;
            this.lblCarrier.Location = new System.Drawing.Point(19, 33);
            this.lblCarrier.Name = "lblCarrier";
            this.lblCarrier.Size = new System.Drawing.Size(44, 16);
            this.lblCarrier.TabIndex = 1;
            this.lblCarrier.Text = "label3";
            // 
            // lblBattleshipBoat
            // 
            this.lblBattleshipBoat.AutoSize = true;
            this.lblBattleshipBoat.Location = new System.Drawing.Point(19, 70);
            this.lblBattleshipBoat.Name = "lblBattleshipBoat";
            this.lblBattleshipBoat.Size = new System.Drawing.Size(44, 16);
            this.lblBattleshipBoat.TabIndex = 2;
            this.lblBattleshipBoat.Text = "label4";
            // 
            // lblCruiser
            // 
            this.lblCruiser.AutoSize = true;
            this.lblCruiser.Location = new System.Drawing.Point(19, 101);
            this.lblCruiser.Name = "lblCruiser";
            this.lblCruiser.Size = new System.Drawing.Size(44, 16);
            this.lblCruiser.TabIndex = 3;
            this.lblCruiser.Text = "label5";
            // 
            // lblSubmarine
            // 
            this.lblSubmarine.AutoSize = true;
            this.lblSubmarine.Location = new System.Drawing.Point(19, 132);
            this.lblSubmarine.Name = "lblSubmarine";
            this.lblSubmarine.Size = new System.Drawing.Size(44, 16);
            this.lblSubmarine.TabIndex = 4;
            this.lblSubmarine.Text = "label6";
            // 
            // lblDestroyer
            // 
            this.lblDestroyer.AutoSize = true;
            this.lblDestroyer.Location = new System.Drawing.Point(19, 164);
            this.lblDestroyer.Name = "lblDestroyer";
            this.lblDestroyer.Size = new System.Drawing.Size(44, 16);
            this.lblDestroyer.TabIndex = 5;
            this.lblDestroyer.Text = "label7";
            // 
            // lblTurnsTaken
            // 
            this.lblTurnsTaken.AutoSize = true;
            this.lblTurnsTaken.Location = new System.Drawing.Point(70, 207);
            this.lblTurnsTaken.Name = "lblTurnsTaken";
            this.lblTurnsTaken.Size = new System.Drawing.Size(44, 16);
            this.lblTurnsTaken.TabIndex = 6;
            this.lblTurnsTaken.Text = "label8";
            // 
            // lblBoatCarrier
            // 
            this.lblBoatCarrier.AutoSize = true;
            this.lblBoatCarrier.Location = new System.Drawing.Point(90, 33);
            this.lblBoatCarrier.Name = "lblBoatCarrier";
            this.lblBoatCarrier.Size = new System.Drawing.Size(44, 16);
            this.lblBoatCarrier.TabIndex = 8;
            this.lblBoatCarrier.Text = "label9";
            // 
            // lblBoatBattleship
            // 
            this.lblBoatBattleship.AutoSize = true;
            this.lblBoatBattleship.Location = new System.Drawing.Point(90, 70);
            this.lblBoatBattleship.Name = "lblBoatBattleship";
            this.lblBoatBattleship.Size = new System.Drawing.Size(51, 16);
            this.lblBoatBattleship.TabIndex = 9;
            this.lblBoatBattleship.Text = "label10";
            // 
            // lblBoatCruiser
            // 
            this.lblBoatCruiser.AutoSize = true;
            this.lblBoatCruiser.Location = new System.Drawing.Point(90, 101);
            this.lblBoatCruiser.Name = "lblBoatCruiser";
            this.lblBoatCruiser.Size = new System.Drawing.Size(51, 16);
            this.lblBoatCruiser.TabIndex = 10;
            this.lblBoatCruiser.Text = "label11";
            // 
            // lblBoatSubmarine
            // 
            this.lblBoatSubmarine.AutoSize = true;
            this.lblBoatSubmarine.Location = new System.Drawing.Point(90, 132);
            this.lblBoatSubmarine.Name = "lblBoatSubmarine";
            this.lblBoatSubmarine.Size = new System.Drawing.Size(51, 16);
            this.lblBoatSubmarine.TabIndex = 11;
            this.lblBoatSubmarine.Text = "label12";
            // 
            // lblBoatDestroyer
            // 
            this.lblBoatDestroyer.AutoSize = true;
            this.lblBoatDestroyer.Location = new System.Drawing.Point(90, 164);
            this.lblBoatDestroyer.Name = "lblBoatDestroyer";
            this.lblBoatDestroyer.Size = new System.Drawing.Size(51, 16);
            this.lblBoatDestroyer.TabIndex = 12;
            this.lblBoatDestroyer.Text = "label13";
            // 
            // pnlGame
            // 
            this.pnlGame.BackColor = System.Drawing.Color.Transparent;
            this.pnlGame.Location = new System.Drawing.Point(48, 112);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new System.Drawing.Size(400, 400);
            this.pnlGame.TabIndex = 5;
            // 
            // lblXcoordinates
            // 
            this.lblXcoordinates.AutoSize = true;
            this.lblXcoordinates.Location = new System.Drawing.Point(609, 98);
            this.lblXcoordinates.Name = "lblXcoordinates";
            this.lblXcoordinates.Size = new System.Drawing.Size(93, 16);
            this.lblXcoordinates.TabIndex = 6;
            this.lblXcoordinates.Text = "X co-ordinates";
            // 
            // lblYcoordinates
            // 
            this.lblYcoordinates.AutoSize = true;
            this.lblYcoordinates.Location = new System.Drawing.Point(608, 129);
            this.lblYcoordinates.Name = "lblYcoordinates";
            this.lblYcoordinates.Size = new System.Drawing.Size(94, 16);
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
            // nudTurnsTaken
            // 
            this.nudTurnsTaken.Location = new System.Drawing.Point(132, 203);
            this.nudTurnsTaken.Name = "nudTurnsTaken";
            this.nudTurnsTaken.Size = new System.Drawing.Size(120, 22);
            this.nudTurnsTaken.TabIndex = 13;
            // 
            // btnShoot
            // 
            this.btnShoot.Location = new System.Drawing.Point(762, 172);
            this.btnShoot.Name = "btnShoot";
            this.btnShoot.Size = new System.Drawing.Size(75, 23);
            this.btnShoot.TabIndex = 10;
            this.btnShoot.Text = "Shoot";
            this.btnShoot.UseVisualStyleBackColor = true;
            this.btnShoot.Click += new System.EventHandler(this.btnShoot_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(678, 598);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
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
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Battleship - Samrat Jayanta Bhurtel";
            this.pnlBoatStatuses.ResumeLayout(false);
            this.pnlBoatStatuses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTurnsTaken)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

