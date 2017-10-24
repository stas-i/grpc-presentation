using System.Threading.Tasks;

namespace GrpcSample.Server.Services.Services
{
    public interface IDataService
    {
        Task<string> GetData(string id);
    }
}