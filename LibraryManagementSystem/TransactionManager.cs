﻿// Name : Samrat Jayanta Bhurtel
// Student ID : 100949545
// Date : 2024/12/13
// Title : TransactionManager.cs
// Purpose: This is the static class which contains methods to handle transactions such as borrowing and returning books.
// It also contains a method to retrieve all transactions from the database. This class is used to manage transactions in the library.
// The methods in this class interact with the database to perform the necessary operations.
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using LibraryManagementSystem.Properties;

public static class TransactionManager
{
    // Method to Borrow a Book
    public static void BorrowBook(int memberID, int bookID, DateTime issueDate, DateTime dueDate)
    {
        string query = @"
            INSERT INTO Transactions (MemberID, BookID, IssueDate, DueDate) 
            VALUES (@MemberID, @BookID, @IssueDate, @DueDate);
            UPDATE Books SET CopiesAvailable = CopiesAvailable - 1 WHERE BookID = @BookID";
        SqlConnection connection = new SqlConnection(Settings.Default.ConnectionString);

        try
        {
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MemberID", memberID);
            command.Parameters.AddWithValue("@BookID", bookID);
            command.Parameters.AddWithValue("@IssueDate", issueDate);
            command.Parameters.AddWithValue("@DueDate", dueDate);
            command.ExecuteNonQuery();

            MessageBox.Show("Book borrowed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error while borrowing book: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        connection.Close();
    }
    /// <summary>
    /// This method retrieves all transactions from the database.
    /// I learned the Connection.close() methods from the 
    /// following link: https://learn.microsoft.com/en-us/dotnet/api/microsoft.data.sqlclient.sqlconnection.close?view=sqlclient-dotnet-standard-5.2
    ///
    /// <returns></returns>
    public static DataTable GetAllTransactions()
    {
        string query = "SELECT * FROM Transactions"; // Query to fetch all transactions
        SqlConnection connection = new SqlConnection(Settings.Default.ConnectionString);
        DataTable transactionsTable = new DataTable();

        try
        {
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(transactionsTable); // Fill the DataTable with the query result

            // Explicitly close the connection after operation is successful
            connection.Close();
        }
        catch (Exception ex)
        {
            // Close the connection in the catch block if it's still open
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }

            MessageBox.Show($"Error while retrieving transactions: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        return transactionsTable;
    }


    /// <summary>
    /// This method returns a book by updating the transaction record with the return date.
    /// </summary>
    /// <param name="transactionID"></param>
    /// <param name="returnDate"></param>
    public static void ReturnBook(int transactionID, DateTime returnDate)
    {
        string query = @"
            UPDATE Transactions SET ReturnDate = @ReturnDate WHERE TransactionID = @TransactionID;
            UPDATE Books SET CopiesAvailable = CopiesAvailable + 1 WHERE BookID = 
                (SELECT BookID FROM Transactions WHERE TransactionID = @TransactionID)";
        SqlConnection connection = new SqlConnection(Settings.Default.ConnectionString);

        try
        {
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TransactionID", transactionID);
            command.Parameters.AddWithValue("@ReturnDate", returnDate);
            command.ExecuteNonQuery();

            MessageBox.Show("Book returned successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error while returning book: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        connection.Close();
    }
}
