using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LibraryManagementSystem;
using System.Linq;

namespace LibraryManagementSystemTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_AddMember_ValidInput()
        {
            var member = new Member
            {
                Name = "John Doe",
                Email = "johndoe@example.com",
                PhoneNumber = "123-456-7890",
                MembershipDate = DateTime.Now
            };

            // Act
            member.AddMember();

            // Assert
            var allMembers = Member.GetAllMembers(); // Method to retrieve all members
            var addedMember = allMembers.Select($"Name = '{member.Name}' AND Email = '{member.Email}'").FirstOrDefault();
            Assert.IsNotNull(addedMember, "Member was not added successfully.");
        }


        [TestMethod]
        public void Test_AddBook_ValidInput()
        {
            // Arrange
            var book = new Book
            {
                Title = "New Book",
                Author = "Test Author",
                Genre = "Test Genre",
                YearPublished = 2023,
                CopiesAvailable = 10
            };

            // Act
            book.AddBook();

            // Assert
            var allBooks = Book.GetAllBooks(); // Method to retrieve all books
            var addedBook = allBooks.Select($"Title = '{book.Title}' AND Author = '{book.Author}'").FirstOrDefault();
            Assert.IsNotNull(addedBook, "Book was not added successfully.");
        }
        [TestMethod]
        public void Test_DeleteBook_ValidTitle()
        {
            // Arrange
            string title = "New Book";
            Book.DeleteBookByTitle(title);

            // Assert
            var allBooks = Book.GetAllBooks(); // Method to retrieve all books
            var deletedBook = allBooks.Select($"Title = '{title}'").FirstOrDefault();
            Assert.IsNull(deletedBook, "Book was not deleted successfully.");
        }

    }
}
