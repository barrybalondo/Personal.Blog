using MediatR;

namespace Personal.Blog.Application.Configuration.Query;

public interface IQueryHandler<in TQuery, TResult> : IRequestHandler<TQuery, TResult> 
    where TQuery : IQuery<TResult>
{
}