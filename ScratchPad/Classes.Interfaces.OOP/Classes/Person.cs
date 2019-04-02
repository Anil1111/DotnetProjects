using System;

namespace Classes.Interfaces.OOP.Classes
{
    public class Person
    {
   
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }

        public void Introduce(string to)
        {
            Console.WriteLine($"(Hi {to}, I am {Name})");
        }

        public static Person Parse(string name)
        {
            var obj = new Person {Name = name};
            return obj;
        }
    }
}
