using System;
namespace OOPLab2
{
	public class NonFictionBook:Book
	{
		public enum SubjectType
		{
            History,
			Science
        }

		public SubjectType Subject = SubjectType.History;

		public NonFictionBook()
		{
		}

        public NonFictionBook(int bookId,string title, string author, string publicationYear, SubjectType subjectType)
            : base (bookId, title, author, publicationYear)
        {
			this.Subject = subjectType;
        }

        public override string ToString()
        {
            return base.ToString() + string.Format($" | Class:Non-Fiction | Subject:{Subject}");
        }
    }
}

