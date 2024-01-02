using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebTests.Objects
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }

        // Add more properties as needed

        public Book(string title, string author, string isbn, decimal price)
        {
            Title = title;
            Author = author;
            Price = price;
        }
    }
}
