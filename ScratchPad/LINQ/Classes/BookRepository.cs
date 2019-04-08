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
                new Book() {Title = "Book 1", Price = 5},
                new Book() {Title = "Book 2", Price = 9.99f},
                new Book() {Title = "Book 3", Price = 7},
                new Book() {Title = "Book 4", Price = 9},
            };
        }
    }
}
