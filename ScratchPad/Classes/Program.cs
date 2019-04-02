using System;

namespace Classes
{
    public class Person
    {
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine($"Hi {to}, I am {Name}");
        }

        public static Person Parse(string str)
        {
            var obj = new Person {Name = str};
            return obj;
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            var person = Person.Parse("Anthony");
            person.Introduce("Rick");
        }
    }
}
