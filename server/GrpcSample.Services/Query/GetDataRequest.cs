using MediatR;

namespace GrpcSample.Server.Services.Query
{
    public class GetDataRequest : IRequest<GetDataResponse>
    {
        public string Id { get; set; }
    }
}