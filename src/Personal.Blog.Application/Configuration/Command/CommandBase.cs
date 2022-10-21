namespace Personal.Blog.Application.Configuration.Command;

public class CommandBase : ICommand
{
    public Guid CommandId { get; }

    protected CommandBase()
    {
        CommandId = Guid.NewGuid();
    }

    protected CommandBase(Guid id)
    {
        CommandId = id;
    }
}

public class CommandBase<TResult> : ICommand<TResult>
{
    public Guid CommandId { get; }

    protected CommandBase()
    {
        CommandId = Guid.NewGuid();
    }

    protected CommandBase(Guid id)
    {
        CommandId = id;
    }
}