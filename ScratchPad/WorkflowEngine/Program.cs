using System.Collections.Generic;
using WorkflowEngine.Classes;

namespace WorkflowEngine
{
    class Program
    {
        private static void Main(string[] args)
        {
            var workflow = new WorkFlow();
            var processes = new List<IActivityFlow>
            {
                new VideoProcessor(),
                new InvokeWebService(),
                new NotifyCustomer(),
                new UpdateDatabase()
            };
         
            foreach (var process in processes)
            {
                process.Run();
            }
        }
    }
}
