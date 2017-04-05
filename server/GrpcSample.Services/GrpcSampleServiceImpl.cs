using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using GrpcSample.Contracts.Messages;
using GrpcSample.Contracts.Services;

namespace GrpcSample.Server.Services
{
    public class GrpcSampleServiceImpl : GrpcSampleService.GrpcSampleServiceBase
    {
        public override Task<HelleWorldResponse> GetHelloWorld(Empty request, ServerCallContext context)
        {
            //return base.GetHelloWorld(request, context);
            var response = new HelleWorldResponse
            {
                DateTimeProperty = Timestamp.FromDateTime(DateTime.Now), // Exception
                Message = "Hello Oxagile",
                NullableInt = null
            };

            return Task.FromResult(response);
        }

        public override async Task GetLines(GetLinesRequest request, IServerStreamWriter<Line> responseStream, ServerCallContext context)
        {
            using (var reader = new StreamReader(File.OpenRead(request.FilePath)))
            {
                string line;
                int linesRemain = request.NumberOfLinesToRead;

                while (linesRemain > 0 && (line = await reader.ReadLineAsync().ConfigureAwait(false)) != null)
                {
                    linesRemain--;
                    await responseStream.WriteAsync(new Line {TextLine = line}).ConfigureAwait(false);
                }
            }
        }

        public override async Task<SumResponse> Sum(IAsyncStreamReader<NumberMessage> requestStream, ServerCallContext context)
        {
            var sum = 0L;
            var count = 0;
            while (await requestStream.MoveNext(CancellationToken.None).ConfigureAwait(false))
            {
                sum += requestStream.Current.Number;
                count++;
            }

            return new SumResponse { NumbersCount = count, Sum = sum };
        }

        public override async Task Multiply(IAsyncStreamReader<MultiplyRequest> requestStream, IServerStreamWriter<MultiplyResponse> responseStream, ServerCallContext context)
        {
            while (await requestStream.MoveNext(CancellationToken.None).ConfigureAwait(false))
            {
                await MultiplyAsync(requestStream, responseStream).ConfigureAwait(false);
            }
        }

        private Task MultiplyAsync(IAsyncStreamReader<MultiplyRequest> requestStream, IServerStreamWriter<MultiplyResponse> responseStream)
        {
            var request = requestStream.Current;
            var response = new MultiplyResponse
            {
                MultiplyResult = 1d * request.FirstNumber * request.SecondNumber,
                Request = request
            };

            return responseStream.WriteAsync(response);
        }
    }
}
