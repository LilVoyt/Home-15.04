using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ex1
            //Journal journal1 = new Journal(3);
            //Journal journal2 = journal1 + 5;
            //Console.WriteLine(journal2.NumberOfPeople);
            //Console.WriteLine(journal1 == journal2);
            //Console.WriteLine(journal2.Equals(journal1));
            //Console.WriteLine(journal1 < journal2);

            //Ex3
            Books books = new Books();
            books.AddBook(new Book("Name", "Author", 3434, "Publisher", 34, 12.3));
            books.AddBook(new Book("Another", "Author", 3434, "Publisher", 34, 12.3));
            books = books - 1;
            //books.PrintNames();
            books = books + (new Book("Hello", "Author", 3434, "Publisher", 34, 12.3));
            books.PrintNames();

            Book book1 = new Book("NoThere", "Author", 3434, "Publisher", 34, 12.3);
            books.AddBook(book1);

            Console.WriteLine(books != book1);
        }
    }
}
