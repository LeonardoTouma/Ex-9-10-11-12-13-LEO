using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger MyfileLogger = new FileLogger();
            ILogger MyEventLogger = new EventLogger();

            Logs logs = new Logs();
            logs.AddLogger(MyfileLogger);
            logs.AddLogger(MyEventLogger);
            MyEventLogger.
        }
    }
    class Logs
    {
        List<ILogger> _List = new List<ILogger>();
        public void AddLogger (ILogger logger)
        {
            _List.Add(logger);
        }
    }
    class EventLogger : ILogger
    {
        public void LogDebug(string text)
        {
            throw new NotImplementedException();
        }

        public void LogError(string text)
        {
            throw new NotImplementedException();
        }

        public void LogInfo(string text)
        {
            throw new NotImplementedException();
        }
        public void LogWarning()
        {

        }
    }
    class FileLogger : ILogger
    {
        public void LogDebug(string text)
        {
           System.IO.File.WriteAlltext (@"C: \Temp\MyLog.Log")
        }

        public void LogError(string text)
        {
            
        }

        public void LogInfo(string text)
        {
            
        }
    }
    public interface ILogger
    {
       void LogDebug(string text);
        void LogError(string text);
        void LogInfo(string text);
    }
}
