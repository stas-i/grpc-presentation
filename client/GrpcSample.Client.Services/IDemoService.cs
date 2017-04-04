using System.Threading.Tasks;

namespace GrpcSample.Client.Services
{
    public interface IDemoService
    {
        Task DemoAllAsync();
    }
}