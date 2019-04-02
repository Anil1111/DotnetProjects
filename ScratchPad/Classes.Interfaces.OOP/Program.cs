using System;
using Classes.Interfaces.OOP.Classes;

namespace Classes.Interfaces.OOP
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var cookie = new HttpCookie {["name"] = "Anthony"};
            Console.WriteLine(cookie["name"]);

        }

        private static void UseAccessMod()
        {
            var person = new Person { BirthDate = new DateTime(1970, 2, 10) };
            Console.WriteLine(person.Age);

        }

        private static void UseOutMod()
        {
            var result = int.TryParse("abc", out var number);
            if (result)
                Console.WriteLine(number);
            else
                Console.WriteLine("Conversion failed");
        }

        private static void UseParams()
        {
            var calc = new Calculator();
            Console.WriteLine(calc.Add(1, 2));
            Console.WriteLine(calc.Add(1, 2, 3, 4));
            Console.WriteLine(calc.Add(new int[] { 1, 2, 3, 4, 5 }));
        }

        private static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(null);
                Console.WriteLine($"Point is at {point.X}, {point.Y}");

                point.Move(100, 200);
                Console.WriteLine($"Point is at {point.X}, {point.Y}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error occured");
            }
        }
    }
}
