using System;
using System.IO;


namespace OpenStack.NetCoreSwiftClient.Abstractions
{
    internal interface ISwiftResponseWithStream : IDisposable
    {
        Stream ObjectStreamContent { get; set; }
    }
}
