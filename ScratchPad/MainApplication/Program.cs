﻿using System;
using System.Linq;
using Delegates;
using Events.Classes;
using Extension.Classes;
using Generics;
using Lambdas.Classes;


namespace MainApplication
{
    class Program
    {
        private static void Main(string[] args)
        {
            var books = new LINQ.Classes.BookRepository().GetBooks();

            //display list of books cheaper than $10
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

        private static void UseReverseStringWithExtension()
        {
            const string phrase = "This is a phrase that I want to reverse";
            Console.WriteLine(phrase.ReverseAString());
        }

        private static void ReverseString()
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

        private static void UseExtension()
        {
            string post = "This is supposed to be a very long blog post blah blah blah...";
            var shortenedPost = post.Shorten(5);
            Console.WriteLine(shortenedPost);
        }

        private static void UseEvent()
        {
            var video = new Video() { Title = "Video 1" };
            var videoEncoder = new VideoEncoder(); //publisher
            var mailService = new MailService(); //subscriber
            var messageService = new MessageService(); //subscriber

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded; //subscribing
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded; //subscribing

            videoEncoder.Encode(video);
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
