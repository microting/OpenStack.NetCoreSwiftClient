using OpenStack.NetCoreSwiftClient.Infrastructure.Models;

namespace OpenStack.NetCoreSwiftClient.Abstractions
{
    public interface ISwiftLogging
    {
        void WriteLogEntry(LogEntry logEntry);
    }
}