using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace GrpcSample.Server.Services.Infrastructure
{
    public interface IMediatorExecutor
    {
        Task<T> ExecuteAsync<T>(IRequest<T> data);

        Task<T> ExecuteAsync<T>(IRequest<T> data, CancellationToken cancellationToken);
    }
}