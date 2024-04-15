using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home
{
    internal class Books
    {
        public List<Book> BookList { get; set; } //Тут використав list бо надто багато роботи буде якщо використовувати дефолтні масиви

        public Books()
        {
            BookList = new List<Book>();
        }
        public void PrintNames()
        {
            foreach(Book book in BookList)
            {
                Console.WriteLine($"Name of book {book.Title}");
            }
        }

        public void DeleteByIndex(int index)
        {
            this.BookList.RemoveAt(index);
        }
        public void AddBook(Book item) 
        {
            this.BookList.Add(item);
        }
        public void Append(Book item)
        {
            this.BookList.Append(item);
        }
        public static Books operator +(Books left, Book right)
        {
            Books books = new Books();
            books.AddBook(right);
            return books;
        }
        public static Books operator -(Books left, int right)
        {
            Books books = new Books();
            books.DeleteByIndex(right);
            return books;
        }
    }
}
