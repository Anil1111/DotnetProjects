using System;

namespace Classes.Interfaces.OOP.Classes
{
    public class Person
    {
        private string _name;

        public void Introduce(string to)
        {
            Console.WriteLine($"(Hi {to}, I am {_name})");
        }

        public static Person Parse(string name)
        {
            var obj = new Person {_name = name};
            return obj;
        }
    }
}
