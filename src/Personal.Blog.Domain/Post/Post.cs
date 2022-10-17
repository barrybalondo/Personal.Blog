using Personal.Blog.Domain.SeedWork;

namespace Personal.Blog.Domain.Post;

public class Post : Entity
{
    public int Id { get; }

    private int _userId;

    private string _title;

    private string _body;

    private Post()
    {
    }

    private Post(int userId, string title, string body)
    {
        _userId = userId;
        _title = title;
        _body = body;
    }

    public static Post AddPost(int userId, string title, string body)
    {
        return new Post(userId, title, body);
    }
    
}