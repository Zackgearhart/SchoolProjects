using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment3Gearhart
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int ISBN { get; set; }
        public decimal Price { get; set; }
        public string BookType { get; set; }
        public DateTime Date { get; set; }

        public Book() { }
        public Book(string title, string author, int isbn, decimal price, string bookType)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            Price = price;
            BookType = bookType;
            Date = DateTime.Now;

        }
    }
}