using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using LibraryManagementSystem.Properties;

public class Book
{
    // Properties
    public int BookID { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public string Genre { get; set; }
    public int YearPublished { get; set; }
    public int CopiesAvailable { get; set; }

    // Method to Add a Book to the Database
    public void AddBook()
    {
        string query = "INSERT INTO Books (Title, Author, Genre, YearPublished, CopiesAvailable) VALUES (@Title, @Author, @Genre, @YearPublished, @CopiesAvailable)";
        SqlConnection connection = new SqlConnection(Settings.Default.ConnectionString);

        try
        {
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Title", Title);
            command.Parameters.AddWithValue("@Author", Author);
            command.Parameters.AddWithValue("@Genre", Genre);
            command.Parameters.AddWithValue("@YearPublished", YearPublished);
            command.Parameters.AddWithValue("@CopiesAvailable", CopiesAvailable);
            command.ExecuteNonQuery();

            MessageBox.Show("Book added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error while adding book: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        connection.Close();
    }

    // Method to Retrieve All Books
    public static DataTable GetAllBooks()
    {
        string query = "SELECT * FROM Books";
        SqlConnection connection = new SqlConnection(Settings.Default.ConnectionString);
        DataTable booksTable = new DataTable();

        try
        {
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(booksTable);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error while retrieving books: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        connection.Close();

        return booksTable;
    }
    // Method to Delete a Book by Title
    public static void DeleteBookByTitle(string title)
    {
        string query = "DELETE FROM Books WHERE Title = @Title";
        SqlConnection connection = new SqlConnection(Settings.Default.ConnectionString);

        try
        {
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Title", title);
            int rowsAffected = command.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Book deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No book found with the given title.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error while deleting book: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}

