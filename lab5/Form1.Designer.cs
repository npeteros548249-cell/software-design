namespace lab5
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtAuthorName = new TextBox();
            txtBookTitle = new TextBox();
            txtBookID = new TextBox();
            ListBoxBooks = new ListBox();
            btnAddBook = new Button();
            btnShowBooks = new Button();
            btnUpdateBook = new Button();
            btnDeleteBook = new Button();
            btnSearchAuthor = new Button();
            btnReset = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            
            txtAuthorName.Location = new Point(30, 45);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(290, 23);
            txtAuthorName.TabIndex = 1;
            
            txtBookTitle.Location = new Point(30, 105);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(290, 23);
            txtBookTitle.TabIndex = 3;
            
            txtBookID.Location = new Point(30, 165);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(290, 23);
            txtBookID.TabIndex = 5;
           
            ListBoxBooks.ItemHeight = 15;
            ListBoxBooks.Location = new Point(350, 20);
            ListBoxBooks.Name = "ListBoxBooks";
            ListBoxBooks.Size = new Size(400, 349);
            ListBoxBooks.TabIndex = 11;
            
            btnAddBook.BackColor = SystemColors.ButtonFace;
            btnAddBook.Location = new Point(30, 210);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(90, 30);
            btnAddBook.TabIndex = 6;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = false;
            btnAddBook.Click += btnAddBook_Click;
           
            btnShowBooks.BackColor = SystemColors.ButtonFace;
            btnShowBooks.Location = new Point(130, 210);
            btnShowBooks.Name = "btnShowBooks";
            btnShowBooks.Size = new Size(90, 30);
            btnShowBooks.TabIndex = 7;
            btnShowBooks.Text = "Show Books";
            btnShowBooks.UseVisualStyleBackColor = false;
            btnShowBooks.Click += btnShowBooks_Click;
            
            btnUpdateBook.BackColor = SystemColors.ButtonFace;
            btnUpdateBook.Location = new Point(230, 210);
            btnUpdateBook.Name = "btnUpdateBook";
            btnUpdateBook.Size = new Size(90, 30);
            btnUpdateBook.TabIndex = 8;
            btnUpdateBook.Text = "Update Book";
            btnUpdateBook.UseVisualStyleBackColor = false;
            btnUpdateBook.Click += btnUpdateBook_Click;
           
            btnDeleteBook.BackColor = SystemColors.ButtonFace;
            btnDeleteBook.Location = new Point(30, 250);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(90, 30);
            btnDeleteBook.TabIndex = 9;
            btnDeleteBook.Text = "Delete Book";
            btnDeleteBook.UseVisualStyleBackColor = false;
            btnDeleteBook.Click += btnDeleteBook_Click;
            
            btnSearchAuthor.BackColor = SystemColors.ButtonFace;
            btnSearchAuthor.Location = new Point(230, 250);
            btnSearchAuthor.Name = "btnSearchAuthor";
            btnSearchAuthor.Size = new Size(90, 30);
            btnSearchAuthor.TabIndex = 10;
            btnSearchAuthor.Text = "Search Author";
            btnSearchAuthor.UseVisualStyleBackColor = false;
            btnSearchAuthor.Click += btnSearchAuthor_Click;
          
            btnReset.BackColor = SystemColors.ButtonFace;
            btnReset.ForeColor = Color.Black;
            btnReset.Location = new Point(130, 250);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(90, 30);
            btnReset.TabIndex = 12;
            btnReset.Text = "Reset All";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            
            label1.Location = new Point(30, 20);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 0;
            label1.Text = "Authors Name";
          
            label2.Location = new Point(30, 80);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 2;
            label2.Text = "Book Title";
         
            label3.Location = new Point(30, 140);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 4;
            label3.Text = "Book ID";
           

            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(txtAuthorName);
            Controls.Add(label2);
            Controls.Add(txtBookTitle);
            Controls.Add(label3);
            Controls.Add(txtBookID);
            Controls.Add(btnAddBook);
            Controls.Add(btnShowBooks);
            Controls.Add(btnUpdateBook);
            Controls.Add(btnDeleteBook);
            Controls.Add(btnSearchAuthor);
            Controls.Add(btnReset);
            Controls.Add(ListBoxBooks);
            Name = "Form1";
            Text = "Bookstore Manager";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtAuthorName;
        private System.Windows.Forms.TextBox txtBookTitle;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.ListBox ListBoxBooks;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnShowBooks;
        private System.Windows.Forms.Button btnUpdateBook;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Button btnSearchAuthor;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}