using System;
using System.Collections.Generic;
using GrpcSample.Client.Services;
using GrpcSample.Client.Services.Registry;
using Microsoft.Extensions.DependencyInjection;

namespace GrpcSample.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var configuration = LoadConfiguration();

            var services = new ServiceCollection();
            GrpcClientsRegistry.ConfigureServices(services, configuration);
            var provider = services.BuildServiceProvider();


            var demo = provider.GetService<IDemoService>();
            try
            {
                demo.DemoAllAsync().Wait();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine("Press enter to exit...");
            Console.ReadLine();
        }

        private static Dictionary<string, string> LoadConfiguration()
        {
            return new Dictionary<string, string>
            {
                { "GrpcSampleService", "127.0.0.1:50077" }
            };
        }
    }
}