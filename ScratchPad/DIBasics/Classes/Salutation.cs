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
}
