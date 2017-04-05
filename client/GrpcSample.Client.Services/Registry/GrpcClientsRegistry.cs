using System.Collections.Generic;
using GrpcSample.Contracts.Services;
using Microsoft.Extensions.DependencyInjection;

namespace GrpcSample.Client.Services.Registry
{
    public static class GrpcClientsRegistry
    {
        public static void ConfigureServices(IServiceCollection services, Dictionary<string, string> hosts)
        {
            services.AddSingleton<ILbConfig, LbConfig>();
            services.AddSingleton<IChannelFactory, ChannelFactory>();
            services.AddTransient<IDemoService>(provider => new SampleServiceClientDemoService(provider.GetService<IChannelFactory>(), hosts[nameof(GrpcSampleService)]));
        }
    }
}