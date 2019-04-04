using System;

namespace Abstract.Classes
{
    public class DbCommand
    {
        private readonly DbConnection _dbConnection;
        private readonly string _instruction;

        public DbCommand(DbConnection dbConnection, string instructions)
        {
            _dbConnection = dbConnection 
                            ?? throw new InvalidOperationException("DbConnection cannot be null");
            if(string.IsNullOrEmpty(instructions))
                throw new InvalidOperationException("Instruction cannot be null or empty");
            _instruction = instructions;
        }

        public void Execute()
        {
            _dbConnection.Open();
            Console.WriteLine($"Executing instruction: {_instruction}");
            _dbConnection.Close();
        }
    }
}
