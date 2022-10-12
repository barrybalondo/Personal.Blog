using Personal.Blog.Application.Configuration.Command;

namespace Personal.Blog.Application.Configuration.Processing;

public interface ICommandsScheduler
{
    Task EnqueueAsync<T>(ICommand<T> command);
}