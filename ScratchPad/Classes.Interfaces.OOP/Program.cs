using System;
using Classes.Interfaces.OOP.Classes;

namespace Classes.Interfaces.OOP
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var text = new Text {Width = 100};
            text.Copy();

        }

        private static void UsePost()
        {
            var post = new Post("How to program C#?", "Where do I start learning how to program?"
                , DateTime.Now);
            post.UpVote();
            Console.WriteLine(post.CurrentVoteCount);
            post.DownVote();
            post.DownVote();
            Console.WriteLine(post.CurrentVoteCount);
        }

        private static void UseStopWatch()
        {
            var stopWatch = new StopWatch();
            stopWatch.Start();
            System.Threading.Thread.Sleep(4000);
            stopWatch.Stop();
            Console.WriteLine(stopWatch.Duration.Seconds);
            System.Threading.Thread.Sleep(1000);
            stopWatch.Start();
            System.Threading.Thread.Sleep(6000);
            stopWatch.Stop();
            Console.WriteLine(stopWatch.Duration.Seconds);
        }

        private static void UseIndexer()
        {
            var cookie = new HttpCookie { ["name"] = "Anthony" };
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
            catch (Exception)
            {
                Console.WriteLine("Unexpected error occured");
            }
        }
    }
}
