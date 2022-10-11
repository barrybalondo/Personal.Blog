using MediatR;

namespace Personal.Blog.Application.Configuration.Command;

public interface ICommand : IRequest
{
}

public interface ICommand<out TResult> : IRequest<TResult>
{
}