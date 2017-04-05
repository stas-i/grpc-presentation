using Grpc.Core;

namespace GrpcSample.Client.Services
{
    public interface ILbConfig
    {
        ChannelOption LbConfigOption { get; }
    }
}
