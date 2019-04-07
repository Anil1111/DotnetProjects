using System;
using Delegates;
using Generics;
using Lambdas.Classes;
using Book = Lambdas.Classes.Book;


namespace MainApplication
{
    class Program
    {
        private static void Main(string[] args)
        {
            UseLambdaTwo();
        }

        private static void UseLambdaTwo()
        {
            var books = new BookRepository().GetBooks();
            var cheapBooks = books.FindAll(x => x.Price < 10);
            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }
        }

        private static void UseWithoutLambda()
        {
            var books = new BookRepository().GetBooks();
            var cheapBooks = books.FindAll(IsCheaperThan10Dollars);
            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }
        }

        static bool IsCheaperThan10Dollars(Lambdas.Classes.Book book)
        {
            return book.Price < 10;
        }

        private static void UseLambdaOne()
        {
            // args => expression

            // ()=> ...         - No args
            // x => ...         - One arg
            // (x,y,z) => ...   - Multiple args

            Func<int, int> square = number => number * number;
            Console.WriteLine(square(5));

            const int factor = 5;
            Func<int, int> multiplier = n => n * factor;
            Console.WriteLine(multiplier(10));
        }

        private static void UseDelegate()
        {
            var photoProc = new PhotoProcessor();
            var filters = new PhotoFilters();
            Action<Photo> filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += RemoveRedEye;

            photoProc.Process("photo.jpg", filterHandler);
        }

        private static void RemoveRedEye(Photo photo)
        {
            Console.WriteLine("Remove Red Eye...");
        }

        private static void UseNullableT()
        {
            var number = new Generics.Nullable<int>(5);
            Console.WriteLine($"Has Value ? {number.HasValue}");
            Console.WriteLine($"Value: {number.GetValueOrDefault()}");

            //nullable int
            var anotherNumber = new Generics.Nullable<int>();
            Console.WriteLine($"Has Value ? {anotherNumber.HasValue}");
            Console.WriteLine($"Value: {anotherNumber.GetValueOrDefault()}");
        }

        private static void UseGenericList()
        {
            var numbers = new GenericList<int>();
            numbers.Add(10);

            var books = new GenericList<Generics.Book>();
            books.Add(new Generics.Book("Mary Poppins"));

            var dictionary = new GenericDictionary<string, Generics.Book>();
            dictionary.Add("4ED21", new Generics.Book("Stocks"));
        }
    }
}
