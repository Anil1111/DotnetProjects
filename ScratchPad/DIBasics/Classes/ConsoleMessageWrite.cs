using System;

namespace DIBasics.Classes
{
    public class ConsoleMessageWrite : IMessageWriter
    {
        public void Write(string message)
        {
            Console.WriteLine(message);
        }
    }
}