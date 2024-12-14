namespace LibraryManagementSystem
{
    partial class frmTransactions
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
            this.dgvTransactions = new System.Windows.Forms.DataGridView();
            this.lblTransactionsHistory = new System.Windows.Forms.Label();
            this.btnBurrow = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblMemberID = new System.Windows.Forms.Label();
            this.lblBookID = new System.Windows.Forms.Label();
            this.lblTransactionID = new System.Windows.Forms.Label();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.txtTransactionID = new System.Windows.Forms.TextBox();
            this.btnReturntoDashboard = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTransactions
            // 
            this.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransactions.Location = new System.Drawing.Point(66, 91);
            this.dgvTransactions.Name = "dgvTransactions";
            this.dgvTransactions.RowHeadersWidth = 51;
            this.dgvTransactions.RowTemplate.Height = 24;
            this.dgvTransactions.Size = new System.Drawing.Size(550, 150);
            this.dgvTransactions.TabIndex = 0;
            // 
            // lblTransactionsHistory
            // 
            this.lblTransactionsHistory.AutoSize = true;
            this.lblTransactionsHistory.Location = new System.Drawing.Point(63, 55);
            this.lblTransactionsHistory.Name = "lblTransactionsHistory";
            this.lblTransactionsHistory.Size = new System.Drawing.Size(130, 16);
            this.lblTransactionsHistory.TabIndex = 1;
            this.lblTransactionsHistory.Text = "Transactions History";
            // 
            // btnBurrow
            // 
            this.btnBurrow.Location = new System.Drawing.Point(66, 390);
            this.btnBurrow.Name = "btnBurrow";
            this.btnBurrow.Size = new System.Drawing.Size(75, 23);
            this.btnBurrow.TabIndex = 2;
            this.btnBurrow.Text = "Burrow";
            this.btnBurrow.UseVisualStyleBackColor = true;
            this.btnBurrow.Click += new System.EventHandler(this.btnBurrow_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(516, 350);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(100, 23);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(284, 269);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblMemberID
            // 
            this.lblMemberID.AutoSize = true;
            this.lblMemberID.Location = new System.Drawing.Point(68, 313);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(73, 16);
            this.lblMemberID.TabIndex = 5;
            this.lblMemberID.Text = "Member ID";
            // 
            // lblBookID
            // 
            this.lblBookID.AutoSize = true;
            this.lblBookID.Location = new System.Drawing.Point(68, 353);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(55, 16);
            this.lblBookID.TabIndex = 6;
            this.lblBookID.Text = "Book ID";
            // 
            // lblTransactionID
            // 
            this.lblTransactionID.AutoSize = true;
            this.lblTransactionID.Location = new System.Drawing.Point(365, 307);
            this.lblTransactionID.Name = "lblTransactionID";
            this.lblTransactionID.Size = new System.Drawing.Size(94, 16);
            this.lblTransactionID.TabIndex = 7;
            this.lblTransactionID.Text = "Transaction ID";
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(176, 307);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(100, 22);
            this.txtMemberID.TabIndex = 8;
            // 
            // txtBookID
            // 
            this.txtBookID.Location = new System.Drawing.Point(176, 347);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(100, 22);
            this.txtBookID.TabIndex = 9;
            // 
            // txtTransactionID
            // 
            this.txtTransactionID.Location = new System.Drawing.Point(516, 304);
            this.txtTransactionID.Name = "txtTransactionID";
            this.txtTransactionID.Size = new System.Drawing.Size(100, 22);
            this.txtTransactionID.TabIndex = 10;
            // 
            // btnReturntoDashboard
            // 
            this.btnReturntoDashboard.Location = new System.Drawing.Point(368, 474);
            this.btnReturntoDashboard.Name = "btnReturntoDashboard";
            this.btnReturntoDashboard.Size = new System.Drawing.Size(208, 23);
            this.btnReturntoDashboard.TabIndex = 11;
            this.btnReturntoDashboard.Text = "Return to Dashboard";
            this.btnReturntoDashboard.UseVisualStyleBackColor = true;
            // 
            // frmTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 552);
            this.Controls.Add(this.btnReturntoDashboard);
            this.Controls.Add(this.txtTransactionID);
            this.Controls.Add(this.txtBookID);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.lblTransactionID);
            this.Controls.Add(this.lblBookID);
            this.Controls.Add(this.lblMemberID);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnBurrow);
            this.Controls.Add(this.lblTransactionsHistory);
            this.Controls.Add(this.dgvTransactions);
            this.Name = "frmTransactions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transactions";
            this.Load += new System.EventHandler(this.frmTransactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTransactions;
        private System.Windows.Forms.Label lblTransactionsHistory;
        private System.Windows.Forms.Button btnBurrow;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblMemberID;
        private System.Windows.Forms.Label lblBookID;
        private System.Windows.Forms.Label lblTransactionID;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.TextBox txtTransactionID;
        private System.Windows.Forms.Button btnReturntoDashboard;
    }
}