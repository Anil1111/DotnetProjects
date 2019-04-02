using Classes.Interfaces.OOP.Classes;

namespace Classes.Interfaces.OOP
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var person = Person.Parse("Anthony");
            person.Introduce("Rick");
        }
    }
}
