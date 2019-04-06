using System;
using System.Security.Cryptography.X509Certificates;

namespace Abstract.Classes
{
    public abstract class DbConnection
    {
        private readonly string _connectionString;

        public DbConnection(string connectionString)
        {
            if(string.IsNullOrEmpty(connectionString))
                throw new InvalidOperationException("Connection string cannot be null or empty");
            _connectionString = connectionString;
        }

        public abstract void Open();
        public abstract void Close();
    }
}
