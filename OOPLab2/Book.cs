using System;
namespace OOPLab2
{
	public class Book
	{
		public int BookID = -1;
		public string Title = "";
        public string Author = "";
		public string PublicationYear = "";
		public bool IsAvailable = true;

        public Book()
		{
		}

		public Book(int bookID, string title, string author, string publicationYear)
		{
			this.BookID = bookID;
			this.Title = title;
			this.Author = author;
			this.PublicationYear = publicationYear;
        }

        public override string ToString()
        {
			return string.Format($"BookID:{BookID} | Title:{Title} | Author:{Author} | " +
				$"PublicationYear:{PublicationYear} | IsAvailable: |{IsAvailable}");
        }
    }
}

