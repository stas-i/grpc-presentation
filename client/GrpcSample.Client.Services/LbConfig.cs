using Grpc.Core;

namespace GrpcSample.Client.Services
{
    /// <summary>
    /// Default LbConfig that uses round_robin load balancing policy
    /// It needs to be removed when deployed to DCOS and one of gRPC load balancers is used 
    /// or when we will be able to encode service configuration in DNS TXT record
    /// </summary>
    public class LbConfig : ILbConfig
    {
        public ChannelOption LbConfigOption => new ChannelOption("grpc.lb_policy_name", "round_robin");
    }
}