namespace LibraryManagementSystem
{
    partial class frmMembers
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
            this.dgvMembers = new System.Windows.Forms.DataGridView();
            this.lblMembersList = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMembershipDate = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.dtpMembership = new System.Windows.Forms.DateTimePicker();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefreshMembers = new System.Windows.Forms.Button();
            this.btnAddMembers = new System.Windows.Forms.Button();
            this.btnExittoDashboard = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMembers
            // 
            this.dgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembers.Location = new System.Drawing.Point(46, 69);
            this.dgvMembers.Name = "dgvMembers";
            this.dgvMembers.RowHeadersWidth = 51;
            this.dgvMembers.RowTemplate.Height = 24;
            this.dgvMembers.Size = new System.Drawing.Size(601, 150);
            this.dgvMembers.TabIndex = 0;
            // 
            // lblMembersList
            // 
            this.lblMembersList.AutoSize = true;
            this.lblMembersList.Location = new System.Drawing.Point(46, 47);
            this.lblMembersList.Name = "lblMembersList";
            this.lblMembersList.Size = new System.Drawing.Size(83, 16);
            this.lblMembersList.TabIndex = 1;
            this.lblMembersList.Text = "Members list";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(710, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(713, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(710, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Phone Number";
            // 
            // lblMembershipDate
            // 
            this.lblMembershipDate.AutoSize = true;
            this.lblMembershipDate.Location = new System.Drawing.Point(693, 203);
            this.lblMembershipDate.Name = "lblMembershipDate";
            this.lblMembershipDate.Size = new System.Drawing.Size(114, 16);
            this.lblMembershipDate.TabIndex = 5;
            this.lblMembershipDate.Text = "Membership Date";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(827, 63);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(827, 101);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 22);
            this.txtEmail.TabIndex = 7;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(827, 145);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(100, 22);
            this.txtPhoneNumber.TabIndex = 8;
            // 
            // dtpMembership
            // 
            this.dtpMembership.Location = new System.Drawing.Point(827, 197);
            this.dtpMembership.Name = "dtpMembership";
            this.dtpMembership.Size = new System.Drawing.Size(200, 22);
            this.dtpMembership.TabIndex = 9;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(49, 275);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(127, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete Member";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRefreshMembers
            // 
            this.btnRefreshMembers.Location = new System.Drawing.Point(211, 275);
            this.btnRefreshMembers.Name = "btnRefreshMembers";
            this.btnRefreshMembers.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshMembers.TabIndex = 11;
            this.btnRefreshMembers.Text = "Refresh";
            this.btnRefreshMembers.UseVisualStyleBackColor = true;
            this.btnRefreshMembers.Click += new System.EventHandler(this.btnRefreshMembers_Click);
            // 
            // btnAddMembers
            // 
            this.btnAddMembers.Location = new System.Drawing.Point(732, 256);
            this.btnAddMembers.Name = "btnAddMembers";
            this.btnAddMembers.Size = new System.Drawing.Size(75, 23);
            this.btnAddMembers.TabIndex = 12;
            this.btnAddMembers.Text = "Add";
            this.btnAddMembers.UseVisualStyleBackColor = true;
            this.btnAddMembers.Click += new System.EventHandler(this.btnAddMembers_Click);
            // 
            // btnExittoDashboard
            // 
            this.btnExittoDashboard.Location = new System.Drawing.Point(485, 397);
            this.btnExittoDashboard.Name = "btnExittoDashboard";
            this.btnExittoDashboard.Size = new System.Drawing.Size(162, 23);
            this.btnExittoDashboard.TabIndex = 13;
            this.btnExittoDashboard.Text = "Back to Dashboard";
            this.btnExittoDashboard.UseVisualStyleBackColor = true;
            this.btnExittoDashboard.Click += new System.EventHandler(this.btnExittoDashboard_Click);
            // 
            // frmMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 531);
            this.Controls.Add(this.btnExittoDashboard);
            this.Controls.Add(this.btnAddMembers);
            this.Controls.Add(this.btnRefreshMembers);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dtpMembership);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblMembershipDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMembersList);
            this.Controls.Add(this.dgvMembers);
            this.Name = "frmMembers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Members";
            this.Load += new System.EventHandler(this.frmMembers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMembers;
        private System.Windows.Forms.Label lblMembersList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMembershipDate;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.DateTimePicker dtpMembership;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefreshMembers;
        private System.Windows.Forms.Button btnAddMembers;
        private System.Windows.Forms.Button btnExittoDashboard;
    }
}