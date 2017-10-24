using System.Threading.Tasks;

namespace GrpcSample.Server.Services.Services
{
    public class DataService : IDataService
    {
        public Task<string> GetData(string id)
        {
            return Task.FromResult($"Data with id: {id}");
        }
    }
}