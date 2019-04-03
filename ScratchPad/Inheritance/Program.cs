using System;
using Inheritance.Classes;

namespace Inheritance
{
    class Program
    {
        private static void Main(string[] args)
        {
            Text text = new Text();
            Shape shape = text;         //no up-casting required

            text.Width = 200;
            shape.Width = 100;
            Console.WriteLine(text.Width); //both text and shape are ref'd to same objects (just different views)


        }
    }
}
