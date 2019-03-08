using System;

namespace OpenStack.NetCoreSwiftClient.Infrastructure.Models
{
    public class LogEntry
    {
        public LogEntry(int level, string type, string message)
        {
            Time = DateTime.Now;
            Level = level;
            Type = type;
            Message = message;
        }

        public DateTime Time { get; }
        public int Level { get; }
        public string Type { get; }
        public string Message { get; }
    }
}