using MediatR;

namespace Personal.Blog.Application.Configuration.Command;

public interface ICommand : IRequest
{
    Guid CommandId { get; }
}

public interface ICommand<out TResult> : IRequest<TResult>
{
    Guid CommandId { get; }
}