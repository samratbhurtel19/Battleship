using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class frmBooks : Form
    {
        public frmBooks()
        {
            InitializeComponent();
        }

        private void frmBooks_Load(object sender, EventArgs e)
        {
            LoadBooks();
        }
        private void LoadBooks()
        {
            DataTable booksTable = Book.GetAllBooks();
            dgvBooks.DataSource = booksTable;
        }

        private void btnAddBooks_Click(object sender, EventArgs e)
        {
            try
            {
                Book book = new Book
                {
                    Title = txtTitle.Text,
                    Genre = txtGenre.Text,
                    YearPublished = int.Parse(txtYearPublished.Text),
                    Author = txtAuthor.Text,
                    CopiesAvailable = int.Parse(txtAvailableCopies.Text)
                };

                book.AddBook();
                MessageBox.Show("Book added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh the DataGridView
                LoadBooks();

                // Clear input fields
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while adding book: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
            
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure a book is selected in the DataGridView
                if (dgvBooks.CurrentRow == null || dgvBooks.CurrentRow.Cells["Title"] == null)
                {
                    MessageBox.Show("Please select a book to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string selectedBookTitle = dgvBooks.CurrentRow.Cells["Title"].Value.ToString();

                // Confirm deletion
                var confirmResult = MessageBox.Show($"Are you sure you want to delete the book '{selectedBookTitle}'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult != DialogResult.Yes)
                {
                    return;
                }

                // Delete the selected book from the database
                Book.DeleteBookByTitle(selectedBookTitle);

                // Notify the user
                MessageBox.Show("Book deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh the DataGridView
                LoadBooks();
            }
            catch (Exception ex)
            {
                // Handle exceptions and display error messages
                MessageBox.Show($"Error deleting book: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadBooks();
        }

        private void btnBacktoDashBoard_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain mainForm = new frmMain();
            mainForm.Show();
        }
        private void ClearInputs()
        {
            txtTitle.Text = "";
            txtGenre.Text = "";
            txtYearPublished.Text = "";
            txtAuthor.Text = "";
            txtAvailableCopies.Text = "";
        }
    }
}
