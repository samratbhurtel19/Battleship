// Name : Samrat Jayanta Bhurtel
// Student ID : 100949545
// Date : 2024/12/13
// Title : Book.cs
// Purpose: Contains the Book class and its methods to add, retrieve, and delete books from the database.
// This class is used to manage books in the library. The methods in this class interact with the database
// to perform the necessary operations.
// References for the constructor, properties, and methods:https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/instance-constructors
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

    /// <summary>
    /// This method adds a book to the database.I learned the Connection.close() methods from the 
    /// following link: https://learn.microsoft.com/en-us/dotnet/api/microsoft.data.sqlclient.sqlconnection.close?view=sqlclient-dotnet-standard-5.2
    /// </summary>
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

