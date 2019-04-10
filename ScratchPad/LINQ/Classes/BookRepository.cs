using System.Collections;
using System.Collections.Generic;

namespace LINQ.Classes
{
    public class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>()
            {
                new Book() {Title = "Programming in C#", Price = 5},
                new Book() {Title = "SQL in 24hrs", Price = 9.99f},
                new Book() {Title = "Angular JS", Price = 7},
                new Book() {Title = "Pro ASP.NET MVC 5", Price = 9},
                new Book() {Title = "Pro ASP.NET MVC 5", Price = 11}
            };
        }
    }
}
