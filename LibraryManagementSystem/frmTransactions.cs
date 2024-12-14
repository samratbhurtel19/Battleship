using LibraryManagementSystem.Properties;
using System;
using System.Collections.Generic;
// Name : Samrat Jayanta Bhurtel
// Student ID : 100949545
// Date : 2024/12/13
// title : frmTransactions.cs
// Purpose: This form allows the user to borrow and return books
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class frmTransactions : Form
    {
        public frmTransactions()
        {
            InitializeComponent();
            utility.AddStatusStrip(this);
            utility.AddMenuStrip(this);
        }
        /// <summary>
        /// This method loads the transactions when the form is loaded.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmTransactions_Load(object sender, EventArgs e)
        {
            LoadTransactions();
        }
        private void LoadTransactions()
        {
            try
            {
                DataTable transactionsTable = TransactionManager.GetAllTransactions();
                dgvTransactions.DataSource = transactionsTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while loading transactions: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            {

            }
        }
        /// <summary>
        /// This method validates the Member ID.
        /// </summary>
        /// <param name="memberID"></param>
        /// <returns></returns>
        public static bool ValidateMemberID(int memberID)
        {
            string query = "SELECT COUNT(*) FROM Members WHERE MemberID = @MemberID";
            SqlConnection connection = new SqlConnection(Settings.Default.ConnectionString);

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MemberID", memberID);
                int count = (int)command.ExecuteScalar();
                connection.Close(); // Explicitly close the connection here
                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error validating Member ID: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close(); // Ensure the connection is closed in case of an error
                }
                return false;
            }
        }
        /// <summary>
        /// This method validates the Book ID.
        /// </summary>
        /// <param name="bookID"></param>
        /// <returns></returns>
        public static bool ValidateBookID(int bookID)
        {
            string query = "SELECT COUNT(*) FROM Books WHERE BookID = @BookID";
            SqlConnection connection = new SqlConnection(Settings.Default.ConnectionString);

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@BookID", bookID);
                int count = (int)command.ExecuteScalar();
                connection.Close(); // Explicitly close the connection here
                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error validating Book ID: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close(); // Ensure the connection is closed in case of an error
                }
                return false;
            }
        }
        /// <summary>
        /// This method validates the Transaction ID.
        /// </summary>
        /// <param name="transactionID"></param>
        /// <returns></returns>
        public static bool ValidateTransactionID(int transactionID)
        {
            string query = "SELECT COUNT(*) FROM Transactions WHERE TransactionID = @TransactionID";
            SqlConnection connection = new SqlConnection(Settings.Default.ConnectionString);

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TransactionID", transactionID);
                int count = (int)command.ExecuteScalar();
                connection.Close(); // Explicitly close the connection
                return count > 0; // Return true if the transaction exists
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error validating Transaction ID: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close(); // Close connection on error
                }
                return false;
            }
        }
        /// <summary>
        /// This method borrows a book.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBurrow_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate inputs
                if (string.IsNullOrWhiteSpace(txtMemberID.Text) || string.IsNullOrWhiteSpace(txtBookID.Text))
                {
                    MessageBox.Show("Please provide Member ID and Book ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Borrow a book
                int memberID = int.Parse(txtMemberID.Text);
                int bookID = int.Parse(txtBookID.Text);
                DateTime issueDate = DateTime.Now;
                DateTime dueDate = issueDate.AddDays(14); // Example: 14 days due

                TransactionManager.BorrowBook(memberID, bookID, issueDate, dueDate);
                MessageBox.Show("Book borrowed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh the DataGridView
                LoadTransactions();

                // Clear inputs
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while borrowing book: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// This method returns a book.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReturn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtTransactionID.Text) || !int.TryParse(txtTransactionID.Text, out int transactionID))
                {
                    MessageBox.Show("Please enter a valid Transaction ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (ValidateTransactionID(transactionID))
                {
                    MessageBox.Show("Transaction ID does not exist.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Perform the return operation
                TransactionManager.ReturnBook(transactionID, DateTime.Now);

                MessageBox.Show("Book returned successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh the transactions list
                LoadTransactions();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while returning the book: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// This method refreshes the transactions list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadTransactions();
        }

        /// <summary>
        /// This method clears the input fields.
        /// </summary>
        private void ClearInputs()
        {
            txtMemberID.Text = "";
            txtBookID.Text = "";
            txtTransactionID.Text = "";
        }
    }
}
