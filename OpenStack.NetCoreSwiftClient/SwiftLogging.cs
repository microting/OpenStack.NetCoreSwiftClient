using System;
using OpenStack.NetCoreSwiftClient.Abstractions;
using OpenStack.NetCoreSwiftClient.Infrastructure.Models;

namespace OpenStack.NetCoreSwiftClient
{
    public class SwiftLogging : ISwiftLogging
    {
        public SwiftLogging()
        {
            
        }
        
        public void LogDebug(string type, string message)
        {
            WriteLogEntry(new LogEntry(4, type, message));
        }
        
        public void LogInfo(string type, string message)
        {
            WriteLogEntry(new LogEntry(3, type, message));
        }
        
        public void LogWarning(string type, string message)
        {
            WriteLogEntry(new LogEntry(2, type, message));
        }
        
        public void LogError(string type, string message)
        {
            WriteLogEntry(new LogEntry(1, type, message));
        }
        
        public void LogCritical(string type, string message)
        {
            WriteLogEntry(new LogEntry(0, type, message));
        }
        
        
        public void WriteLogEntry(LogEntry logEntry)
        {
            var foregroundColor = Console.ForegroundColor;

            switch (logEntry.Level)
            {
                case 0:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("[CRI] " + logEntry.Type + ": " + logEntry.Message);
                    break;
                case 1:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("[ERR] " + logEntry.Type + ": " + logEntry.Message);
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("[WRN] " + logEntry.Type + ": " + logEntry.Message);
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("[INF] " + logEntry.Type + ": " + logEntry.Message);
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("[DBG] " + logEntry.Type + ": " + logEntry.Message);
                    break;
                    
            }
            
            Console.ForegroundColor = foregroundColor;
        }
    }
}