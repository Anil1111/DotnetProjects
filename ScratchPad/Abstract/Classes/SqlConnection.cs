using System;

namespace Abstract.Classes
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {
        }

        public override void Open()
        {
            Console.WriteLine("Opening SQL Connection");
        }

        public override void Close()
        {
            Console.WriteLine("Closing SQL Connection");
        }
    }
}