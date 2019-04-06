using DIBasics.Classes;

namespace DIRunner
{
    class Program
    {
        private static void Main(string[] args)
        {
            var salutation = new Salutation(new ConsoleMessageWrite());
            salutation.Exclaim();
        }
    }
}
