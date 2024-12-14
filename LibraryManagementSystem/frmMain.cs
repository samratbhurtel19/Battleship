// Name : Samrat Jayanta Bhurtel
// Student ID : 100949545
// Date : 2024/12/13
// title : frmMain.cs
// Purpose: This file contains the main form of the application. It is the first form that is displayed
// when the application is run. It contains buttons that allow the user to navigate to the Books, Members,
// and Transactions forms.It also contains a button that allows the user to exit the application.
// The form also contains a status strip that displays the current date and time.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            utility.AddStatusStrip(this);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBooks booksForm = new frmBooks();
            booksForm.Show();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMembers_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMembers membersForm = new frmMembers();
            membersForm.Show();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTransactions_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTransactions transactionsForm = new frmTransactions();
            transactionsForm.Show();
        }
        /// <summary>
        /// This method exits the application when the Exit button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

    }
}
