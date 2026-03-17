using Microsoft.VisualBasic.Devices;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Book
        {
            public string Title { get; set; }

            public string Author { get; set; }
            public virtual string GetInfo()
            {
                return $"{Title} by {Author}";
            }

        }

        public class Magazine : Book
        {

            public int IssueNumber { get; set; }

            public override string GetInfo()
            {
                return $"{Title} - Issue {IssueNumber}";
            }
        }

        public class Ebooks : Book
        {
            public double Size { get; set; }

            public override string GetInfo()
            {
                return $"{Title} Size = {Size} mb";
            }
        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            Book mybook = new Magazine()
            {
                Title = "Tech Weekly",
                Author = "John Doe",
                IssueNumber = 45
            };
            MessageBox.Show(mybook.GetInfo());

        }

        private void btnDisplayBooks_Click(object sender, EventArgs e)
        {
            Book[] Inventory = new Book[] 
            { 
                new Book {Title = "The Great Gatsby", Author = "F Scott Fritzgeral"},
                new Magazine{Title = "National Geographic", IssueNumber = 2023},
                new Ebooks {Title = "Digital Forest", Author = "Dan Brown", Size = 1.5},
                new TextBook {Title = "Digital Forest", Subject = "Computer"},
                new AudioBook {Title = "The Song of Achilles", Narrator = "Kai Shido", Duration = 20}
            
            };

            foreach (Book book in Inventory)
            {
                listBoxBooks.Items.Add(book.GetInfo());
                
            }
        }

        public class TextBook : Book
        {
            public string Subject { get; set; }

            public override string GetInfo()
            {
                return $"{Title} for {Subject}";
            }    
        }

        public class AudioBook : Book 
        {
            public int Duration { get; set; }
            public string Narrator {  get; set; }

            public override string GetInfo()
            {
                return $"{Title} Narrated by: {Narrator} - {Duration} minutes";
            }
        }
    }
}
