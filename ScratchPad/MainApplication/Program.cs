using Generics;

namespace MainApplication
{
    class Program
    {
        private static void Main(string[] args)
        {
            
        }

        private static void UseGenericList()
        {
            var numbers = new GenericList<int>();
            numbers.Add(10);

            var books = new GenericList<Book>();
            books.Add(new Book("Mary Poppins"));

            var dictionary = new GenericDictionary<string, Book>();
            dictionary.Add("4ED21", new Book("Stocks"));
        }
    }
}
