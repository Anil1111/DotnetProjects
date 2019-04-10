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
                new Book() {Title = "Database techniques", Price = 9.99f},
                new Book() {Title = "Object Oriented Programming", Price = 7},
                new Book() {Title = "Angular JS", Price = 9},
            };
        }
    }
}
