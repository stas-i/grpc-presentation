using Grpc.Core;
using System.Threading;
using Grpc.Core.Logging;
using GrpcSample.Server.Services;

namespace GrpcSample.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            const int port = 50077;

            GrpcEnvironment.SetLogger(new LogLevelFilterLogger(new ConsoleLogger(), LogLevel.Debug));
            GrpcEnvironment.Logger.Debug("Starting services on port {0}", port);

            Grpc.Core.Server server = new Grpc.Core.Server
            {
                Services =
                {
                    GrpcSample.Contracts.Services.GrpcSampleService.BindService(new GrpcSampleServiceImpl()),
                    // Bind any other services to implementation
                },
                Ports =
                {
                    new ServerPort("localhost", port, ServerCredentials.Insecure),
                    //new ServerPort("anotherHost", 50100, new SslServerCredentials(new List<KeyCertificatePair>())),
                }
            };

            server.Start();

            GrpcEnvironment.Logger.Debug("Started Videa Billing services");

            Thread.Sleep(Timeout.Infinite);

            server.ShutdownAsync().Wait();

            GrpcEnvironment.Logger.Debug("Exit Videa Billing services");
        }
    }
}