using System;

namespace WorkflowEngine.Classes
{
    public class InvokeWebService : IActivityFlow
    {
        public void Run()
        {
            Console.WriteLine("Informing Web Service video is ready...");
        }
    }
}