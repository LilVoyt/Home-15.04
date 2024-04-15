using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public string Publisher { get; set; }
        public int PagesNumber { get; set; }
        public double Price { get; set; }

        public Book(string Title, string Author, int Year, string Publisher, int PagesNumber, double Price)
        {
            this.Title = Title;
            this.Author = Author;
            this.Year = Year;
            this.Publisher = Publisher;
            this.PagesNumber = PagesNumber;
            this.Price = Price;
        }
    }
}
