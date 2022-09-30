using MediatR;

namespace Personal.Blog.Application.Post.AddPost;

public class AddPostCommand : IRequest<int>
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