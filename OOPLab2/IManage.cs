using System;
namespace OOPLab2
{
	public interface IManage
	{
        void ListAllBook(List<FictionBook> fb, List<NonFictionBook> nfb);
        void AddABook(User user);
        void RemoveAbook(User user);
        bool IsBorrowable(Book book);
        bool IsManageable(bool isLoginAsLibrarain);
        void BorrowABook(User user);
        void ReturnABook(User user);
        void UpdateMembership(Customer cs, Librarain lb, int memberShipLevel);
    }
}

