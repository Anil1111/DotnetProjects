using System;
using Delegates;
using Generics;

namespace MainApplication
{
    class Program
    {
        private static void Main(string[] args)
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

            var books = new GenericList<Book>();
            books.Add(new Book("Mary Poppins"));

            var dictionary = new GenericDictionary<string, Book>();
            dictionary.Add("4ED21", new Book("Stocks"));
        }
    }
}
