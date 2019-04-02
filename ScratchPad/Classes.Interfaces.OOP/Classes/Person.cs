using System;

namespace Classes.Interfaces.OOP.Classes
{
    public class Person
    {
   
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }

        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - BirthDate;
                var years = timeSpan.Days / 365;

                return years;
            }
        }

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
