using System;

namespace WorkflowEngine.Classes
{
    public class NotifyCustomer : IActivityFlow
    {
        public void Run()
        {
            Console.WriteLine("Sending email...");
        }
    }
}