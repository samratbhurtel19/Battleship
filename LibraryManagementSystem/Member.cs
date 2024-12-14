// Name : Samrat Jayanta Bhurtel
// Student ID : 100949545
// Date : 2024/12/13
// Title : Member.cs
// Purpose: Contains the Member class which represents a member of the library.
// It contains properties for the member's ID, name, email, phone number, and membership date.
// It also contains methods to add a member to the database, delete a member by name, and retrieve
// all members from the database.
// References for the constructor, properties, and methods:https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/instance-constructors
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using LibraryManagementSystem.Properties;

public class Member
{
    // Properties
    public int MemberID { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public DateTime MembershipDate { get; set; }

    // Method to Add a Member to the Database
    //I learned the Connection.close() methods from the
    // following link: https://learn.microsoft.com/en-us/dotnet/api/microsoft.data.sqlclient.sqlconnection.close?view=sqlclient-dotnet-standard-5.2
   
    public void AddMember()
    {
        string query = "INSERT INTO Members (Name, Email, PhoneNumber, MembershipDate) VALUES (@Name, @Email, @PhoneNumber, @MembershipDate)";
        SqlConnection connection = new SqlConnection(Settings.Default.ConnectionString);

        try
        {
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
            command.Parameters.AddWithValue("@MembershipDate", MembershipDate);
            command.ExecuteNonQuery();

            MessageBox.Show("Member added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error while adding member: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        connection.Close();
    }
    /// <summary>
    /// This method deletes a member from the database by name.
    /// </summary>
    /// <param name="name"></param>
    public static void DeleteMemberByName(string name)
    {
        string query = "DELETE FROM Members WHERE Name = @Name";
        SqlConnection connection = new SqlConnection(Settings.Default.ConnectionString);

        try
        {
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Name", name);

            int rowsAffected = command.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Member deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No member found with the given name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            connection.Close();
        }
        catch (Exception ex)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }

            MessageBox.Show($"Error while deleting member: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }


    /// <summary>
    /// This method retrieves all members from the database.
    /// </summary>
    /// <returns></returns>
    public static DataTable GetAllMembers()
    {
        string query = "SELECT * FROM Members";
        SqlConnection connection = new SqlConnection(Settings.Default.ConnectionString);
        DataTable membersTable = new DataTable();

        try
        {
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(membersTable);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error while retrieving members: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        connection.Close();

        return membersTable;
    }
}
