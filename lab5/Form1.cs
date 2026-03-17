using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            using (var context = new BookstoreContext())
            {
                context.Database.EnsureCreated();
            }
        }

        public class Author
        {
            public int AuthorID { get; set; }
            public string Name { get; set; }
            public virtual ICollection<Book> Books { get; set; }
        }

        public class Book
        {
            public int BookID { get; set; }
            public string Title { get; set; }
            public int AuthorID { get; set; }
            public virtual Author Author { get; set; }
        }

        public void AddAuthorWithBook(string authorName, string bookTitle)
        {
            try
            {
                using (var context = new BookstoreContext())
                {
                    var author = new Author { Name = authorName };
                    var book = new Book { Title = bookTitle, Author = author };
                    context.Authors.Add(author);
                    context.Books.Add(book);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding book: " + ex.Message);
            }
        }

        public List<string> GetBooksWithAuthors()
        {
            try
            {
                using (var context = new BookstoreContext())
                {
                    var books = context.Books
                        .Include(b => b.Author)
                        .Select(b => "[ID:" + b.BookID + "] " + b.Title + " by " + b.Author.Name)
                        .ToList();
                    return books;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting books: " + ex.Message);
                return new List<string>();
            }
        }


        public void DeleteBook(int bookId)
        {
            try
            {
                using (var context = new BookstoreContext())
                {
                    var book = context.Books.FirstOrDefault(b => b.BookID == bookId);
                    if (book != null)
                    {
                        context.Books.Remove(book);
                        context.SaveChanges();
                        MessageBox.Show("Book deleted successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Book ID not found!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting book: " + ex.Message);
            }
        }

        public List<string> SearchBooksByAuthor(string authorName)
        {
            try
            {
                using (var context = new BookstoreContext())
                {
                    var books = context.Books
                        .Include(b => b.Author)
                        .Where(b => b.Author.Name.Contains(authorName))
                        .Select(b => "[ID:" + b.BookID + "] " + b.Title + " by " + b.Author.Name)
                        .ToList();
                    return books;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching books: " + ex.Message);
                return new List<string>();
            }
        }

        private void RefreshListBox()
        {
            var books = GetBooksWithAuthors();
            ListBoxBooks.DataSource = null;
            ListBoxBooks.DataSource = books;
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAuthorName.Text) || string.IsNullOrWhiteSpace(txtBookTitle.Text))
            {
                MessageBox.Show("Please enter both Author Name and Book Title.");
                return;
            }
            AddAuthorWithBook(txtAuthorName.Text, txtBookTitle.Text);
            MessageBox.Show("Book added successfully!");
            RefreshListBox();
        }

        private void btnShowBooks_Click(object sender, EventArgs e)
        {
            RefreshListBox();
            if (ListBoxBooks.Items.Count == 0)
            {
                MessageBox.Show("No books found in the database!");
            }
        }

        public void UpdateBookAndAuthor(int bookId, string newTitle, string newAuthorName)
        {
            try
            {
                using (var context = new BookstoreContext())
                {
                    var book = context.Books
                        .Include(b => b.Author)
                        .FirstOrDefault(b => b.BookID == bookId);
                    if (book != null)
                    {
                        book.Title = newTitle;
                        book.Author.Name = newAuthorName;
                        context.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("Book ID not found!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating book: " + ex.Message);
            }
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBookID.Text))
            {
                MessageBox.Show("Please enter a Book ID.");
                return;
            }
            int bookId;
            if (!int.TryParse(txtBookID.Text, out bookId))
            {
                MessageBox.Show("Book ID must be a number!");
                return;
            }
            UpdateBookAndAuthor(bookId, txtBookTitle.Text, txtAuthorName.Text);
            MessageBox.Show("Book updated successfully!");
            RefreshListBox();
        }



        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBookID.Text))
            {
                MessageBox.Show("Please enter a Book ID to delete.");
                return;
            }
            int bookId;
            if (!int.TryParse(txtBookID.Text, out bookId))
            {
                MessageBox.Show("Book ID must be a number!");
                return;
            }
            var confirm = MessageBox.Show(
                "Are you sure you want to delete Book ID " + txtBookID.Text + "?",
                "Confirm Delete",
                MessageBoxButtons.YesNo
            );
            if (confirm == DialogResult.Yes)
            {
                DeleteBook(bookId);
                RefreshListBox();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show(
                "This will DELETE ALL books and authors and reset IDs back to 1. Are you sure?",
                "Reset Database",
                MessageBoxButtons.YesNo
            );

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    using (var context = new BookstoreContext())
                    {
                        context.Books.RemoveRange(context.Books);
                        context.Authors.RemoveRange(context.Authors);
                        context.SaveChanges();
                        context.Database.ExecuteSqlRaw("DBCC CHECKIDENT ('Books', RESEED, 0)");
                        context.Database.ExecuteSqlRaw("DBCC CHECKIDENT ('Authors', RESEED, 0)");
                    }
                    RefreshListBox();
                    MessageBox.Show("Database reset! IDs will start from 1 again.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error resetting database: " + ex.Message);
                }
            }
        }

        private void btnSearchAuthor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAuthorName.Text))
            {
                MessageBox.Show("Please enter an Author Name to search.");
                return;
            }
            var results = SearchBooksByAuthor(txtAuthorName.Text);
            ListBoxBooks.DataSource = null;
            ListBoxBooks.DataSource = results;
            if (results.Count == 0)
            {
                MessageBox.Show("No books found for author: " + txtAuthorName.Text);
            }
        }
    }
}