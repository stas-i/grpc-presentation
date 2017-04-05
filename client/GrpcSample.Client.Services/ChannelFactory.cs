using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using Grpc.Core;

namespace GrpcSample.Client.Services
{
    public class ChannelFactory : IChannelFactory
    {
        private readonly ILbConfig _lbConfig;
        private readonly ConcurrentDictionary<string, Channel> _channels;

        public ChannelFactory(ILbConfig lbConfig)
        {
            _lbConfig = lbConfig;
            _channels = new ConcurrentDictionary<string, Channel>();
        }

        public Channel GetChannel(string target)
        {
            if (string.IsNullOrWhiteSpace(target))
            {
                throw new ArgumentException("Please specify target", nameof(target));
            }

            return _channels.GetOrAdd(target, CreateChannel(target));
        }

        public Channel CreateChannel(string target)
        {
            var parts = target.Split(':');
            if (parts.Length != 2)
            {
                throw new ArgumentOutOfRangeException(nameof(target), "Target does not contain host and port");
            }

            var host = parts[0];
            var port = int.Parse(parts[1]);

            IEnumerable<ChannelOption> opts = null;
            var opt = _lbConfig.LbConfigOption;
            if (opt != null)
            {
                opts = new[] { opt };
            }

            return new Channel(host, port, ChannelCredentials.Insecure, opts);
        }

        public void Dispose()
        {
            foreach (var channel in _channels)
            {
                channel.Value.ShutdownAsync().GetAwaiter().GetResult();
            }
        }
    }
}
