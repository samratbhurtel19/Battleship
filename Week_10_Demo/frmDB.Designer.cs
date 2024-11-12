namespace Week_10_Demo
{
    partial class frmDB
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
            this.cboDB = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.employeeSampleDataSet1 = new Week_10_Demo.employeeSampleDataSet1();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new Week_10_Demo.employeeSampleDataSet1TableAdapters.employeesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.employeeSampleDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cboDB
            // 
            this.cboDB.DataSource = this.employeesBindingSource;
            this.cboDB.DisplayMember = "firstName";
            this.cboDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDB.FormattingEnabled = true;
            this.cboDB.Location = new System.Drawing.Point(150, 91);
            this.cboDB.Name = "cboDB";
            this.cboDB.Size = new System.Drawing.Size(237, 30);
            this.cboDB.TabIndex = 0;
            this.cboDB.ValueMember = "employeeID";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(618, 339);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 64);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // employeeSampleDataSet1
            // 
            this.employeeSampleDataSet1.DataSetName = "employeeSampleDataSet1";
            this.employeeSampleDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "employees";
            this.employeesBindingSource.DataSource = this.employeeSampleDataSet1;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // frmDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cboDB);
            this.Name = "frmDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDB";
            this.Load += new System.EventHandler(this.frmDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeSampleDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboDB;
        private System.Windows.Forms.Button btnClose;
        private employeeSampleDataSet1 employeeSampleDataSet1;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private employeeSampleDataSet1TableAdapters.employeesTableAdapter employeesTableAdapter;
    }
}