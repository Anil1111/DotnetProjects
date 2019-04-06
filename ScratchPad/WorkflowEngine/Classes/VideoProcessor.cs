using System;

namespace WorkflowEngine.Classes
{
    public class VideoProcessor : IActivityFlow
    {
        public void Run()
        {
            Console.WriteLine("Upload video to cloud...");
        }
    }

    public class WorkFlow
    {
        public void Execute(IActivityFlow activityFlow)
        {
            activityFlow.Run();
        }
    }
}