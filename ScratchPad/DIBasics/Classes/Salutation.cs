using System;

namespace DIBasics.Classes
{
    public class Salutation
    {
        private readonly IMessageWriter _writer;

        public Salutation(IMessageWriter writer) //constructor injection of IMessageWriter dependency
        {
            _writer = writer ?? throw new ArgumentNullException(nameof(writer));
        }

        public void Exclaim()
        {
            this._writer.Write("Executing exclamation...");
        }
    }

    public interface IMessageWriter
    {
        void Write(string message);
    }

    public class ConsoleMessageWrite : IMessageWriter
    {
        public void Write(string message)
        {
            Console.WriteLine(message);
        }
    }
}
