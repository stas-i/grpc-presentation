using System;
using Grpc.Core;

namespace GrpcSample.Client.Services
{
    /// <summary>
    /// IChannelFactory is responsible for managing Grpc channels as it's recommended to reuse opened channels as much as possible.
    /// </summary>
    public interface IChannelFactory : IDisposable
    {
        Channel GetChannel(string target);
    }
}
