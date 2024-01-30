using System;
namespace OOPLab2
{
	public class BookManage : IManage
	{
		public BookManage()
		{
		}

        public void UpdateMembership(Customer cs, Librarain lb, int memberShipLevel)
        {
            Console.WriteLine($"\n\n{cs.UserName} Membership has been updated by {lb.UserName}!\n");
        }

        void IManage.AddABook(User user)
        {
            Console.WriteLine($"\n\n{user.UserName} has added a book!\n");
        }

        void IManage.BorrowABook(User user)
        {
            Console.WriteLine($"\n\n{user.UserName} has Borrow a book!\n");
        }

        //if a customer has a limit to borrow the books, should check it here.
        bool IManage.IsBorrowable(Book book)
        {
            return book.IsAvailable;
        }

        //if logined by a librarain, the user can manage
        bool IManage.IsManageable(bool isLoginAsLibrarain)
        {
            return isLoginAsLibrarain;
        }

        void IManage.ListAllBook(List<FictionBook> fb, List<NonFictionBook> nfb)
        {
            string strBooks = "";
            foreach (FictionBook book in fb)
            {
                strBooks += book.ToString() + "\n";
            }

            foreach (NonFictionBook book in nfb)
            {
                strBooks += book.ToString() + "\n";
            }
            Console.WriteLine(strBooks);
        }

        void IManage.RemoveAbook(User user)
        {
            Console.WriteLine($"\n\n{user.UserName} has removed a book!\n");
        }

        void IManage.ReturnABook(User user)
        {
            Console.WriteLine($"\n\n{user.UserName} has returned a book!\n");
        }
    }
}

