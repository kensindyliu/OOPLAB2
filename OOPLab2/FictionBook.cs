using System;
using static OOPLab2.NonFictionBook;

namespace OOPLab2
{
	public class FictionBook : Book
	{
		public enum GenreType
		{
            Mystery,
            Romance,
            Science
        }

		public GenreType Genre = GenreType.Mystery;

        public FictionBook()
		{
		}

        public FictionBook(int bookId, string title, string author, string publicationYear, GenreType genre) : base(bookId, title, author, publicationYear)
        {
            this.Genre = genre;
        }

        public override string ToString()
        {
            return base.ToString() + string.Format($" | Class:Fiction | Genre:{Genre}");
        }
    }
}

