using Abstract.Classes;

namespace Abstract
{
    class Program
    {
        private static void Main(string[] args)
        {
            var sqlConnection = new SqlConnection("This is a sql connect string.");
            var oracleConnection = new OracleConnection("This is a oracle connect string");

            sqlConnection.Open();
            oracleConnection.Open();
            sqlConnection.Close();
            oracleConnection.Close();
        }
    }
}
