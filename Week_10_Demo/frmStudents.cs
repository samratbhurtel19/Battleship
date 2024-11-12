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
    public partial class frmStudents : Form
    {
        bool isLoading = true;
        public frmStudents()
        {
            InitializeComponent();
        }

        private void cboStudents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDB_Click(object sender, EventArgs e)
        {
            frmDB frm = new frmDB();
            frm.ShowDialog();
        }
    }
}
