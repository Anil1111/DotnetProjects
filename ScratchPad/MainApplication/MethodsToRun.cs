using System;
using System.Linq;
using Delegates;
using Events.Classes;
using Extension.Classes;
using Generics;
using Lambdas.Classes;

namespace MainApplication
{
    class MethodsToRun
    {
        public static void UseLinqExamplesTwo()
        {
            var books = new LINQ.Classes.BookRepository().GetBooks();

            //Use Single when one and only one object satisfies the condition, if no match an exception will be thrown
            var book = books.Single(x => x.Title == "Angular JS");
            Console.WriteLine(book.Title);

            //Use SingleOrDefault when you are not sure if only one objects matches. Null will be returned if it doesn't and it won't throw an execption
            var book2 = books.SingleOrDefault(x => x.Title == "Angular Forever");
            Console.WriteLine(book2 != null ? book2.Title : "Book2 was null");

            //Use First to get the first object in a collection that matches the predicate
            //Use FirstOrDefault if you want to return null and not an exception on a non match
            //Use Last or LastOrDefault which is self explanatory at this point
            var firstBook = books.First(x => x.Title == "Pro ASP.NET MVC 5");
            Console.WriteLine(firstBook.Title + " " + firstBook.Price);

            //Use Skip and Take ... does what they say
            var pagedBooks = books.Skip(2).Take(3); //skip first two records and the next three
            foreach (var pagedBook in pagedBooks)
            {
                Console.WriteLine(pagedBook.Title);
            }

            //Use count to items in the collection
            Console.WriteLine($"Num of books in collection: {books.Count()}");

            //Use Min and Max to get the lowest and highest values
            Console.WriteLine($"Highest priced book: {books.Max(x => x.Price)}"); //highest priced book
            Console.WriteLine($"Lowest priced book: {books.Min(x => x.Price)}"); //lowest priced book
            Console.WriteLine($"Total amount of all books: {books.Sum(x => x.Price)}"); //total price of all books
            Console.WriteLine($"Average price of all books: {books.Average(x => x.Price)}");
        }

        public static void UseLinqExampleOne()
        {
            var books = new LINQ.Classes.BookRepository().GetBooks();

            //LINQ Extension Methods
            var cheapBooks = books
                .Where(x => x.Price < 10)
                .OrderBy(x => x.Title)
                .Select(x => x.Title);
            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book);
                //Console.WriteLine(book.Title + " " + book.Price);
            }
        }

        public static void UseReverseStringWithExtension()
        {
            const string phrase = "This is a phrase that I want to reverse";
            Console.WriteLine(phrase.ReverseAString());
        }

        public static void ReverseString()
        {
            const string words = "These are the words";
            var len = words.Length - 1;
            var rev = "";

            while (len >= 0)
            {
                rev += words[len];
                len--;
            }

            Console.WriteLine($"Original string was : {words}");
            Console.WriteLine($"Reversed is : {rev}");
        }

        public static void UseExtension()
        {
            string post = "This is supposed to be a very long blog post blah blah blah...";
            var shortenedPost = post.Shorten(5);
            Console.WriteLine(shortenedPost);
        }

        public static void UseEvent()
        {
            var video = new Video() { Title = "Video 1" };
            var videoEncoder = new VideoEncoder(); //publisher
            var mailService = new MailService(); //subscriber
            var messageService = new MessageService(); //subscriber

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded; //subscribing
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded; //subscribing

            videoEncoder.Encode(video);
        }

        public static void UseLambdaTwo()
        {
            var books = new BookRepository().GetBooks();
            var cheapBooks = books.FindAll(x => x.Price < 10);
            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }
        }

        public static void UseWithoutLambda()
        {
            var books = new BookRepository().GetBooks();
            var cheapBooks = books.FindAll(IsCheaperThan10Dollars);
            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }
        }

        public static bool IsCheaperThan10Dollars(Lambdas.Classes.Book book)
        {
            return book.Price < 10;
        }

        public static void UseLambdaOne()
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

        public static void UseDelegate()
        {
            var photoProc = new PhotoProcessor();
            var filters = new PhotoFilters();
            Action<Photo> filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += RemoveRedEye;

            photoProc.Process("photo.jpg", filterHandler);
        }

        public static void RemoveRedEye(Photo photo)
        {
            Console.WriteLine("Remove Red Eye...");
        }

        public static void UseNullableT()
        {
            var number = new Generics.Nullable<int>(5);
            Console.WriteLine($"Has Value ? {number.HasValue}");
            Console.WriteLine($"Value: {number.GetValueOrDefault()}");

            //nullable int
            var anotherNumber = new Generics.Nullable<int>();
            Console.WriteLine($"Has Value ? {anotherNumber.HasValue}");
            Console.WriteLine($"Value: {anotherNumber.GetValueOrDefault()}");
        }

        public static void UseGenericList()
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