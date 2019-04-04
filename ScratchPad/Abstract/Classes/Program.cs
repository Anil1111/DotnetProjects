namespace Abstract.Classes
{
    class Program
    {
        private static void Main(string[] args)
        {
            var dbCommand = new DbCommand(new SqlConnection("SQL Connect String"), "Select * from person");
            dbCommand.Execute();

            var dbCommand2 = new DbCommand(new OracleConnection("Oracle Connect String"), "Select * from customer");
            dbCommand2.Execute();
        }
    }
}
