using System.Net.Http;

namespace OpenStack.NetCoreSwiftClient.Extensions
{
    public static class HttpMessageExts
    {
        public static void FillTokenHeader(this HttpRequestMessage req, string token)
        {
            req.Headers.Add(SwiftHeaders.AuthToken, token);
        }
    }
}
