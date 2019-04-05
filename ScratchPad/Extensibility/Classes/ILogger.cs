using System.ComponentModel;

namespace Extensibility.Classes
{
    public interface ILogger
    {
        void LogError(string message);
        void LogInfo(string message);
    }
}