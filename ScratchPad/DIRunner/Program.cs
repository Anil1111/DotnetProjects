using System.Security.Principal;
using DIBasics.Classes;

namespace DIRunner
{
    class Program
    {
        private static void Main(string[] args)
        {
            var salutation = new Salutation(new SecureMessageWriter(new ConsoleMessageWrite(), WindowsIdentity.GetCurrent()));
            salutation.Exclaim();
        }

        private static void UseConsoleMessageWrite()
        {
            var salutation = new Salutation(new ConsoleMessageWrite());
            salutation.Exclaim();
        }
    }
}
