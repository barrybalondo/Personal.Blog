using Personal.Blog.Application.Configuration.Command;
using Personal.Blog.Application.Configuration.Processing;

namespace Personal.Blog.Infrastructure.Processing;

public class CommandScheduler : ICommandsScheduler
{
    public Task EnqueueAsync<T>(ICommand<T> command)
    {
        throw new NotImplementedException();
    }
}