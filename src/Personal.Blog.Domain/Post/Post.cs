using Personal.Blog.Domain.SeedWork;

namespace Personal.Blog.Domain.Post;

public class Post : Entity
{
    public int Id { get; }
    
    public int UserId { get; }
    
    public string Title { get; }
    
    public string Body { get; }

    public Post()
    {
        // EF Core requirement
    }

    public Post(int userId, string title, string body)
    {
        UserId = userId;
        Title = title;
        Body = body;
    }
}