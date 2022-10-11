using MediatR;
using Personal.Blog.Application.Configuration.Command;

namespace Personal.Blog.Application.Post.AddPost;

public class AddPostCommand : ICommand<int>
{
    public int UserId { get; }
    
    public string Title { get; }
    
    public string Body { get; }

    public AddPostCommand(int userId, string title, string body)
    {
        UserId = userId;
        Title = title;
        Body = body;
    }
}