using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home
{
    internal class Books
    {
        private List<Book> BookList { get; set; } //Тут використав list бо надто багато роботи буде якщо використовувати дефолтні масиви

        public Book this[int index] //індексатор
        {
            get
            {
                if(index >= 0 && index < BookList.Count - 1)
                {
                    return BookList[index];
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            set
            {
                if (index >= 0 && index < BookList.Count - 1)
                {
                    BookList[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }

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

        public static Books operator +(Books left, Book right)
        {
            if(left != right)
            {
                left.AddBook(right);
                return left;
            }
            else
            {
                throw new Exception("This Book already exist!");
            }
        }
        public static Books operator -(Books left, int right)
        {
            left.BookList.RemoveAt(right);
            return left;
        }
        public static bool operator ==(Books left, Book right)
        {
            return left.BookList.Contains(right);
        }
        public static bool operator !=(Books left, Book right)
        {
            return !(left.BookList.Contains(right));
        }
    }
}
