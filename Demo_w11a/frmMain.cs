using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_w11a
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeeSampleDataSetJoined.employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.employeeSampleDataSetJoined.employees);
            // TODO: This line of code loads data into the 'employeeSampleDataSetJoined.locations' table. You can move, or remove it, as needed.
            this.locationsTableAdapter.Fill(this.employeeSampleDataSetJoined.locations);
            // TODO: This line of code loads data into the 'employeeSampleDataSetJoined.departments' table. You can move, or remove it, as needed.
            this.departmentsTableAdapter.Fill(this.employeeSampleDataSetJoined.departments);

        }
    }
}
