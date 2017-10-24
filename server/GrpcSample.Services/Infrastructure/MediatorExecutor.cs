using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace GrpcSample.Server.Services.Infrastructure
{
    /// <summary>
    /// A simple wrapper around Mediatr to enable Dependency Injection into Handlers.
    /// </summary>
    public class MediatorExecutor : IMediatorExecutor
    {
        private readonly IServiceScopeFactory _serviceScopeFactory;

        public MediatorExecutor(IServiceScopeFactory serviceScopeFactory)
        {
            _serviceScopeFactory = serviceScopeFactory;
        }

        public async Task<T> ExecuteAsync<T>(IRequest<T> data)
        {
            using (var scope = _serviceScopeFactory.CreateScope())
            {
                var svc = scope.ServiceProvider.GetRequiredService<IMediator>();
                return await svc.Send(data).ConfigureAwait(false);
            }
        }

        public async Task<T> ExecuteAsync<T>(IRequest<T> data, CancellationToken cancellationToken)
        {
            using (var scope = _serviceScopeFactory.CreateScope())
            {
                var svc = scope.ServiceProvider.GetRequiredService<IMediator>();
                return await svc.Send(data, cancellationToken).ConfigureAwait(false);
            }
        }
    }
}