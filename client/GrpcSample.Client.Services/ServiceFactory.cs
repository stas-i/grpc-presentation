using System;

namespace GrpcSample.Client.Services
{
    public static class ServiceFactory
    {
        public static IDemoService GetDemoService()
        {
            return new SampleServiceClientDemoService();
        }
    }
}
