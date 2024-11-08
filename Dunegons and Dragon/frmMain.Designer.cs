namespace Dunegons_and_Dragon
{
    partial class frmMain
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
            this.lbxCharacter = new System.Windows.Forms.ListBox();
            this.btnCreateCharacter = new System.Windows.Forms.Button();
            this.btnEditCharacter = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxCharacter
            // 
            this.lbxCharacter.FormattingEnabled = true;
            this.lbxCharacter.ItemHeight = 16;
            this.lbxCharacter.Location = new System.Drawing.Point(291, 103);
            this.lbxCharacter.Name = "lbxCharacter";
            this.lbxCharacter.Size = new System.Drawing.Size(198, 148);
            this.lbxCharacter.TabIndex = 0;
            // 
            // btnCreateCharacter
            // 
            this.btnCreateCharacter.Location = new System.Drawing.Point(89, 306);
            this.btnCreateCharacter.Name = "btnCreateCharacter";
            this.btnCreateCharacter.Size = new System.Drawing.Size(136, 74);
            this.btnCreateCharacter.TabIndex = 1;
            this.btnCreateCharacter.Text = "Create Character";
            this.btnCreateCharacter.UseVisualStyleBackColor = true;
            // 
            // btnEditCharacter
            // 
            this.btnEditCharacter.Location = new System.Drawing.Point(324, 306);
            this.btnEditCharacter.Name = "btnEditCharacter";
            this.btnEditCharacter.Size = new System.Drawing.Size(102, 74);
            this.btnEditCharacter.TabIndex = 2;
            this.btnEditCharacter.Text = "Edit Character";
            this.btnEditCharacter.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(534, 306);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(101, 74);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 525);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEditCharacter);
            this.Controls.Add(this.btnCreateCharacter);
            this.Controls.Add(this.lbxCharacter);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxCharacter;
        private System.Windows.Forms.Button btnCreateCharacter;
        private System.Windows.Forms.Button btnEditCharacter;
        private System.Windows.Forms.Button btnExit;
    }
}