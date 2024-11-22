namespace SportLeaugeApp
{
    partial class mainFrm
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
            this.components = new System.ComponentModel.Container();
            this.cmbTeamList = new System.Windows.Forms.ComboBox();
            this.sportleaguesDataSet = new SportLeaugeApp.sportleaguesDataSet();
            this.teamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teamsTableAdapter = new SportLeaugeApp.sportleaguesDataSetTableAdapters.teamsTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.teamidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isactiveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jerseycolourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.sportleaguesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTeamList
            // 
            this.cmbTeamList.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.teamsBindingSource, "teamname", true));
            this.cmbTeamList.DataSource = this.teamsBindingSource;
            this.cmbTeamList.DisplayMember = "teamname";
            this.cmbTeamList.FormattingEnabled = true;
            this.cmbTeamList.Location = new System.Drawing.Point(31, 36);
            this.cmbTeamList.Name = "cmbTeamList";
            this.cmbTeamList.Size = new System.Drawing.Size(121, 24);
            this.cmbTeamList.TabIndex = 0;
            this.cmbTeamList.ValueMember = "teamname";
            // 
            // sportleaguesDataSet
            // 
            this.sportleaguesDataSet.DataSetName = "sportleaguesDataSet";
            this.sportleaguesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teamsBindingSource
            // 
            this.teamsBindingSource.DataMember = "teams";
            this.teamsBindingSource.DataSource = this.sportleaguesDataSet;
            // 
            // teamsTableAdapter
            // 
            this.teamsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teamidDataGridViewTextBoxColumn,
            this.teamnameDataGridViewTextBoxColumn,
            this.isactiveDataGridViewTextBoxColumn,
            this.jerseycolourDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.teamsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(805, 351);
            this.dataGridView1.TabIndex = 1;
            // 
            // teamidDataGridViewTextBoxColumn
            // 
            this.teamidDataGridViewTextBoxColumn.DataPropertyName = "teamid";
            this.teamidDataGridViewTextBoxColumn.HeaderText = "teamid";
            this.teamidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.teamidDataGridViewTextBoxColumn.Name = "teamidDataGridViewTextBoxColumn";
            this.teamidDataGridViewTextBoxColumn.Width = 125;
            // 
            // teamnameDataGridViewTextBoxColumn
            // 
            this.teamnameDataGridViewTextBoxColumn.DataPropertyName = "teamname";
            this.teamnameDataGridViewTextBoxColumn.HeaderText = "teamname";
            this.teamnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.teamnameDataGridViewTextBoxColumn.Name = "teamnameDataGridViewTextBoxColumn";
            this.teamnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // isactiveDataGridViewTextBoxColumn
            // 
            this.isactiveDataGridViewTextBoxColumn.DataPropertyName = "isactive";
            this.isactiveDataGridViewTextBoxColumn.HeaderText = "isactive";
            this.isactiveDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.isactiveDataGridViewTextBoxColumn.Name = "isactiveDataGridViewTextBoxColumn";
            this.isactiveDataGridViewTextBoxColumn.Width = 125;
            // 
            // jerseycolourDataGridViewTextBoxColumn
            // 
            this.jerseycolourDataGridViewTextBoxColumn.DataPropertyName = "jerseycolour";
            this.jerseycolourDataGridViewTextBoxColumn.HeaderText = "jerseycolour";
            this.jerseycolourDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jerseycolourDataGridViewTextBoxColumn.Name = "jerseycolourDataGridViewTextBoxColumn";
            this.jerseycolourDataGridViewTextBoxColumn.Width = 125;
            // 
            // mainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbTeamList);
            this.Name = "mainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sport Leauge - Samrat";
            this.Load += new System.EventHandler(this.mainFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sportleaguesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTeamList;
        private sportleaguesDataSet sportleaguesDataSet;
        private System.Windows.Forms.BindingSource teamsBindingSource;
        private sportleaguesDataSetTableAdapters.teamsTableAdapter teamsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isactiveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jerseycolourDataGridViewTextBoxColumn;
    }
}

