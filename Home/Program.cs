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
            books.BookList = new List<Book>();
            books.AddBook(new Book("Name", "Author", 3434, "Publisher", 34, 12.3));
            books.Append(new Book("China", "Author", 3434, "Publisher", 34, 12.3));
            //books = books - 0;
            books.PrintNames();
        }
    }
}
