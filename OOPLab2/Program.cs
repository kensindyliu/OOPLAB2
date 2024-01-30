namespace OOPLab2;

class Program
{

    static bool isLoginAsLibrarian = false;
    static Librarain librarain = new();
    static Customer customer = new();
    static List<FictionBook> fictionBooks = new();
    static List<NonFictionBook> nonFictionBooks = new();
    static string strInvalidInputMsg = "Invalide input";
    static IManage bookManage = new BookManage();

    //All design info and Logic is refered to Readme.doc
    static void Main(string[] args)
    {
        Initialization();  //For test only
        string strMenu = "Welcome to library system\n" +
            "1.Login to the system as a librarian\n" +
            "2.Login to the system as a customer\n" +
            "3.Exit\nPlease input a menu index:";
        string strInput = "";
        while (true)
        {
            Console.Clear();
            strInput = GetInput(strMenu);
            switch (strInput)
            {
                case "1":
                    Librarian();
                    break;
                case "2":
                    Customer();
                    break;
                case "3":
                    Console.Write("Bye...");
                    Console.ReadKey();
                    return;
                default:
                    Console.WriteLine(strInvalidInputMsg);
                    Console.ReadKey();
                    break;
            }
        }

    }

    //For test only 
    static void Initialization()
    {
        librarain.ID = 1;
        librarain.UserName = "John";
        customer.ID = 100;
        customer.UserName = "Smith";
        fictionBooks.Add(new FictionBook(1, "Fictionbook1", "Author1", "2001", FictionBook.GenreType.Romance));
        fictionBooks.Add(new FictionBook(2, "Fictionbook2", "Author2", "2002", FictionBook.GenreType.Mystery));
        fictionBooks.Add(new FictionBook(3, "Fictionbook3", "Author3", "2003", FictionBook.GenreType.Science));

        nonFictionBooks.Add(new NonFictionBook(101, "NonFictionBook1", "Non - Author1", "2001", NonFictionBook.SubjectType.History));
        nonFictionBooks.Add(new NonFictionBook(102, "NonFictionBook2", "Non - Author2", "2002", NonFictionBook.SubjectType.History));
        nonFictionBooks.Add(new NonFictionBook(103, "NonFictionBook3", "Non - Author3", "2003", NonFictionBook.SubjectType.History));
    }

    //every menu option will call a special function 
    static void Librarian()
    {
        Console.Clear();
        isLoginAsLibrarian = true;
        string strMsg = $"Welcom Mr.{librarain.UserName}\n" +
            "1.List All books\n" +
            "2.Add a book\n" +
            "3.Remove a book\n" +
            "4.Update membership\n" +
            "5.Return to previous menu" +
            "Please Choose a menu:";
        while (true)
        {
            string strInput = GetInput(strMsg);
            switch (strInput)
            {
                case "1":
                    ListAllBooks();
                    break;
                case "2":
                    AddABook();
                    break;
                case "3":
                    RemoveABook();
                    break;
                case "4":
                    UpdateMembership();
                    break;
                case "5":
                    return;
                default:
                    Console.Clear();
                    Console.WriteLine(strInvalidInputMsg);
                    break;
            }
        }
    }

    //every menu option will call a special function 
    static void Customer()
    {
        Console.Clear();
        isLoginAsLibrarian = false;
        string strMsg = $"Welcom Mr.{customer.UserName}\n" +
            "1.List All books\n" +
            "2.Bowrrow A book\n" +
            "3.Returen A book\n" +
            "4.Return to previous menu" +
            "Please Choose a menu:";
        while (true)
        {
            string strInput = GetInput(strMsg);
            switch (strInput)
            {
                case "1":
                    ListAllBooks();
                    break;
                case "2":
                    BowrrowAbook();
                    break;
                case "3":
                    ReturenABook();
                    break;
                case "4":
                    return;
                default:
                    Console.Clear();
                    Console.WriteLine(strInvalidInputMsg);
                    break;
            }
        }
    }

    static string GetInput(string msg)
    {
        string strInput = "";
        Console.Write(msg);
        strInput = Console.ReadLine();
        if (strInput == null || strInput.Trim().Length == 0)
            return "";
        else
            return strInput;
    }

    static void ListAllBooks()
    {
        bookManage.ListAllBook(fictionBooks, nonFictionBooks);
    }

    static void AddABook()
    {
        if (bookManage.IsManageable(isLoginAsLibrarian))
            bookManage.AddABook(librarain);
        else
            Console.WriteLine("\n\nSorry, you don't have to right to add a book\n");
    }

    static void RemoveABook()
    {
        if (bookManage.IsManageable(isLoginAsLibrarian))
            bookManage.RemoveAbook(librarain);
        else
            Console.WriteLine("\n\nSorry, you don't have to right to remove a book\n");
    }

    static void UpdateMembership()
    {
        if (bookManage.IsManageable(isLoginAsLibrarian))
            bookManage.UpdateMembership(customer, librarain,2);  //should record who update the membership for the user.
        else
            Console.WriteLine("\n\nSorry, you don't have to right to remove a book\n");
    }

    static void BowrrowAbook()
    {
        if (bookManage.IsManageable(isLoginAsLibrarian))
            bookManage.BorrowABook(librarain);
        else
            bookManage.BorrowABook(customer);
    }

    static void ReturenABook()
    {
        if (bookManage.IsManageable(isLoginAsLibrarian))
            bookManage.ReturnABook(librarain);
        else
            bookManage.ReturnABook(customer);
    }



}


