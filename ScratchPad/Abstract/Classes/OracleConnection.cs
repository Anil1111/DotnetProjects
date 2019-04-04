using System;

namespace Abstract.Classes
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {

        }

        public override void Close()
        {
            Console.WriteLine("Closing Oracle Connection");
        }

        public override void Open()
        {
            Console.WriteLine("Opening Oracle Connection");
        }
    }
}