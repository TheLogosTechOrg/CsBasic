// a more complex test of delegate: 
// separation of the managment of books (in BookDB class) and the operation of books (in Test class and PriceTotaller class)
using System;

namespace Bookstore 
{
    using System.Collections;
    
    public struct Book
    {
        public string Title;
        public string Author;
        public decimal Price;
        public bool Paperback;
        
        public Book(string title, string author, decimal price, bool paperBack)
        { 
            Title = title;
            Author = author;
            Price = price;
            Paperback = paperBack;
        }
    }
    
    // do something to a book
    public delegate void ProcessBookDelegate(Book book);
    
    public class BookDB
    {
        ArrayList list = new ArrayList();
        
        public void AddBook(string title, string author, decimal price, bool paperBack)
        {
            list.Add(new Book(title, author, price, paperBack));
        }
        
        // do something to all paperback books
        public void ProcessPaperbackBooks(ProcessBookDelegate processBook)
        {
            foreach (Book b in list) 
            {
                if (b.Paperback)
                    processBook(b);
            }
        }
    }
}

namespace BookTestClient
{
    using Bookstore;
    
    class PriceTotaller
    {
        int countBooks = 0;
        decimal priceBooks = 0.0m;
        
        internal void AddBookToTotal(Book book)
        {
            countBooks += 1;
            priceBooks += book.Price;
        }
        internal decimal AveragePrice()
        {
            return priceBooks / countBooks;
        }
    }

    class Test
    {
        static void Main()
        {
            BookDB bookDB = new BookDB();
            AddBooks(bookDB);      
            Console.WriteLine("Paperback Book Titles:");
            bookDB.ProcessPaperbackBooks(new ProcessBookDelegate(PrintTitle));
            PriceTotaller totaller = new PriceTotaller();
            bookDB.ProcessPaperbackBooks(new ProcessBookDelegate(totaller.AddBookToTotal));
            Console.WriteLine("Average Paperback Book Price: ${0:#.##}", totaller.AveragePrice());
            Console.ReadLine();
        }

        static void PrintTitle(Book b)
        {
            Console.WriteLine("   {0}", b.Title);
        }

        static void AddBooks(BookDB bookDB)
        {
            bookDB.AddBook("The C Programming Language", "Brian W. Kernighan and Dennis M. Ritchie", 19.95m, true);
            bookDB.AddBook("The Unicode Standard 2.0", "The Unicode Consortium", 39.95m, true);
            bookDB.AddBook("The MS-DOS Encyclopedia", "Ray Duncan", 129.95m, false);
            bookDB.AddBook("Dogbert's Clues for the Clueless", "Scott Adams", 12.00m, true);
        }
    }
}
