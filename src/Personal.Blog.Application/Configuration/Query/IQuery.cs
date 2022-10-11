using MediatR;

namespace Personal.Blog.Application.Configuration.Query;

public interface IQuery<out TResult> : IRequest<TResult>
{
}