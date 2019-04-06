using Extensibility.Classes;
using Microsoft.VisualBasic;

namespace Extensibility
{
    class Program
    {
        private static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new ConsoleLogger());
            dbMigrator.Migrate();

            var dbMirgrator2 = new DbMigrator(new FileLogger("C:\\Users\\antho\\Desktop\\migration.log"));
            dbMirgrator2.Migrate();
        }
    }
}
