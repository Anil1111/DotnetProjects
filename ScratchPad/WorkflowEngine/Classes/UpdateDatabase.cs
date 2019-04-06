using System;

namespace WorkflowEngine.Classes
{
    public class UpdateDatabase : IActivityFlow
    {
        public void Run()
        {
            Console.WriteLine("Updating database record...");
        }
    }
}