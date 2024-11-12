using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_10_Demo
{
    public partial class frmDB : Form
    {
        public frmDB()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDB_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeeSampleDataSet1.employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.employeeSampleDataSet1.employees);

        }
    }
}
