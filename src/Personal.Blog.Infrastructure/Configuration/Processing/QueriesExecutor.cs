using Autofac;
using MediatR;
using Personal.Blog.Application.Configuration.Query;

namespace Personal.Blog.Infrastructure.Configuration.Processing;

public static class QueriesExecutor
{
    public static async Task<TResult> Execute<TResult>(IQuery<TResult> command)
    {
        using (var scope = CompositionRoot.BeginLifetimeScope())
        {
            var mediator = scope.Resolve<IMediator>();
            return await mediator.Send(command);
        }
    }
}