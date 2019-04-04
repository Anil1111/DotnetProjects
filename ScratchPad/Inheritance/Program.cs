using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Inheritance.Classes;

namespace Inheritance
{
    class Program
    {
        private static void Main(string[] args)
        {
            var stack = new Inheritance.Classes.Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
        }

        private static void UpCastTwo()
        {
            //StreamReader reader = new StreamReader(new MemoryStream());
            ArrayList list = new ArrayList();
            list.Add(1);

            var anotherList = new List<int>();
            anotherList.Add(1);
        }

        private static void UpCastingExmpOne()
        {
            Text text = new Text();
            Shape shape = text;                 //no up-casting required

            text.Width = 200;
            shape.Width = 100;
            Console.WriteLine(text.Width);      //both text and shape are ref'd to same objects (just different views) Ans: 100
        }
    }
}
