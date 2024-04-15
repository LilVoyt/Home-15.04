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

        public void DeleteByIndex(int index)
        {
            this.BookList.RemoveAt(index);
        }
        public void Append(Book item) 
        {
            this.BookList.Add(item);
        }
        public static Books operator +(Books left, Book right)
        {
            Books books = new Books();
            books.Append(right);
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
