using System.Threading.Tasks;
using GrpcSample.Server.Services.Services;
using MediatR;

namespace GrpcSample.Server.Services.Query
{
    public class GetDataHandler : IAsyncRequestHandler<GetDataRequest, GetDataResponse>
    {
        private readonly IDataService _dataService;

        public GetDataHandler(IDataService dataService)
        {
            _dataService = dataService;
        }

        public async Task<GetDataResponse> Handle(GetDataRequest message)
        {
            var data = await _dataService.GetData(message.Id);
            
            return  new GetDataResponse
            {
                Data = data
            };
        }
    }
}