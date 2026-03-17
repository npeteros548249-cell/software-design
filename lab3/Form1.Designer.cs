namespace lab3
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
            listBoxBooks = new ListBox();
            btnShowInfo = new Button();
            btnDisplayBooks = new Button();
            SuspendLayout();
            // 
            // listBoxBooks
            // 
            listBoxBooks.ForeColor = SystemColors.WindowText;
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.Location = new Point(12, 12);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(437, 304);
            listBoxBooks.TabIndex = 0;
            // 
            // btnShowInfo
            // 
            btnShowInfo.Location = new Point(465, 25);
            btnShowInfo.Name = "btnShowInfo";
            btnShowInfo.Size = new Size(142, 64);
            btnShowInfo.TabIndex = 1;
            btnShowInfo.Text = "Show Message Box";
            btnShowInfo.UseVisualStyleBackColor = true;
            btnShowInfo.Click += btnShowInfo_Click;
            // 
            // btnDisplayBooks
            // 
            btnDisplayBooks.Location = new Point(73, 333);
            btnDisplayBooks.Name = "btnDisplayBooks";
            btnDisplayBooks.Size = new Size(142, 64);
            btnDisplayBooks.TabIndex = 2;
            btnDisplayBooks.Text = "Show Array of Books";
            btnDisplayBooks.UseVisualStyleBackColor = true;
            btnDisplayBooks.Click += btnDisplayBooks_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 572);
            Controls.Add(btnDisplayBooks);
            Controls.Add(btnShowInfo);
            Controls.Add(listBoxBooks);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxBooks;
        private Button btnShowInfo;
        private Button btnDisplayBooks;
    }
}
