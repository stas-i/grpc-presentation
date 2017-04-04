using System;
using static GrpcSample.Client.Services.ServiceFactory;

namespace GrpcSample.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var demo = GetDemoService();
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
    }
}