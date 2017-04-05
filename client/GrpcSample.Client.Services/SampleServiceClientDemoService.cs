using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using GrpcSample.Contracts.Messages;
using GrpcSample.Contracts.Services;

namespace GrpcSample.Client.Services
{
    public class SampleServiceClientDemoService : IDemoService
    {
        private readonly GrpcSampleService.GrpcSampleServiceClient _client;

        private DateTime DefaultDeadline => DateTime.UtcNow.AddSeconds(60);

        public SampleServiceClientDemoService(IChannelFactory channelFactory, string host)
        {
            var channel = channelFactory.GetChannel(host);
            _client = new GrpcSampleService.GrpcSampleServiceClient(channel);
        }

        public async Task DemoAllAsync()
        {
            //await DemoHelloWorld().ConfigureAwait(false);
            //await DemoGetLines().ConfigureAwait(false);
            //await DemoSum().ConfigureAwait(false);
            await DemoMultiply().ConfigureAwait(false);
        }

        private async Task DemoHelloWorld()
        {
            var request = new Google.Protobuf.WellKnownTypes.Empty();
            var response = await _client.GetHelloWorldAsync(request, deadline: DefaultDeadline);
            Console.WriteLine(response);
        }

        private async Task DemoGetLines()
        {
            var request = new GetLinesRequest
            {
                FilePath = @"D:\test-doc.txt",
                NumberOfLinesToRead = 10000
            };

            using (var call = _client.GetLines(request))
            {
                var responseStream = call.ResponseStream;

                while (await responseStream.MoveNext().ConfigureAwait(false))
                {
                    Console.WriteLine(responseStream.Current.TextLine);
                }
            }
        }

        private async Task DemoSum()
        {
            var list = Enumerable.Range(1, 500000);

            using (var call = _client.Sum())
            {
                foreach (var i in list)
                {
                    var request = new NumberMessage { Number = i };
                    await call.RequestStream.WriteAsync(request).ConfigureAwait(false);
                    Console.WriteLine(i);
                }

                await call.RequestStream.CompleteAsync().ConfigureAwait(false);

                var response = await call.ResponseAsync.ConfigureAwait(false);

                Console.WriteLine(response);
            }
        }

        private async Task DemoMultiply()
        {
            using (var call = _client.Multiply())
            {
                var readTask = ReadAsync(call);

                for (int i = 0, j = 0; i < 100000; i++, j++)
                {
                    var request = new MultiplyRequest
                    {
                        FirstNumber = i,
                        SecondNumber = j
                    };

                    await call.RequestStream.WriteAsync(request).ConfigureAwait(false);
                }

                await call.RequestStream.CompleteAsync().ConfigureAwait(false);

                await readTask.ConfigureAwait(false);
            }
        }

        private async Task ReadAsync(AsyncDuplexStreamingCall<MultiplyRequest, MultiplyResponse> call)
        {
            while (await call.ResponseStream.MoveNext().ConfigureAwait(false))
            {
                var response = call.ResponseStream.Current;
                Console.WriteLine("Response: " + response);
            }
        }
    }
}