namespace lab6
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnFetchBooks = new Button();
            listBoxBooks = new ListBox();
            btnAddBook = new Button();
            txtAuthorName = new TextBox();
            txtBookTitle = new TextBox();
            btnUpdateBook = new Button();
            txtBookID = new TextBox();
            btnDelete = new Button();
            btnSearchBook = new Button();
            progressBar1 = new ProgressBar();
            SuspendLayout();
            // 
            // btnFetchBooks
            // 
            btnFetchBooks.Location = new Point(28, 268);
            btnFetchBooks.Name = "btnFetchBooks";
            btnFetchBooks.Size = new Size(129, 61);
            btnFetchBooks.TabIndex = 0;
            btnFetchBooks.Text = "SHOW";
            btnFetchBooks.UseVisualStyleBackColor = true;
            btnFetchBooks.Click += btnFetchBooks_Click;
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.Location = new Point(28, 348);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(787, 224);
            listBoxBooks.TabIndex = 1;
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(173, 268);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(129, 61);
            btnAddBook.TabIndex = 2;
            btnAddBook.Text = "ADD";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(28, 195);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.PlaceholderText = "Author Name";
            txtAuthorName.Size = new Size(285, 27);
            txtAuthorName.TabIndex = 3;
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new Point(28, 228);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.PlaceholderText = "Book Title";
            txtBookTitle.Size = new Size(285, 27);
            txtBookTitle.TabIndex = 4;
            // 
            // btnUpdateBook
            // 
            btnUpdateBook.Location = new Point(322, 268);
            btnUpdateBook.Name = "btnUpdateBook";
            btnUpdateBook.Size = new Size(129, 61);
            btnUpdateBook.TabIndex = 5;
            btnUpdateBook.Text = "UPDATE";
            btnUpdateBook.UseVisualStyleBackColor = true;
            btnUpdateBook.Click += btnUpdateBook_Click;
            // 
            // txtBookID
            // 
            txtBookID.Location = new Point(28, 162);
            txtBookID.Name = "txtBookID";
            txtBookID.PlaceholderText = "Book ID";
            txtBookID.Size = new Size(285, 27);
            txtBookID.TabIndex = 6;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(470, 268);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(129, 61);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearchBook
            // 
            btnSearchBook.Location = new Point(615, 268);
            btnSearchBook.Name = "btnSearchBook";
            btnSearchBook.Size = new Size(129, 61);
            btnSearchBook.TabIndex = 8;
            btnSearchBook.Text = "SEARCH BOOK TITLE";
            btnSearchBook.UseVisualStyleBackColor = true;
            btnSearchBook.Click += btnSearchBook_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(365, 195);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(427, 29);
            progressBar1.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(845, 707);
            Controls.Add(progressBar1);
            Controls.Add(btnSearchBook);
            Controls.Add(btnDelete);
            Controls.Add(txtBookID);
            Controls.Add(btnUpdateBook);
            Controls.Add(txtBookTitle);
            Controls.Add(txtAuthorName);
            Controls.Add(btnAddBook);
            Controls.Add(listBoxBooks);
            Controls.Add(btnFetchBooks);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFetchBooks;
        private ListBox listBoxBooks;
        private Button btnAddBook;
        private TextBox txtAuthorName;
        private TextBox txtBookTitle;
        private Button btnUpdateBook;
        private TextBox txtBookID;
        private Button btnDelete;
        private Button btnSearchBook;
        private ProgressBar progressBar1;
    }
}
