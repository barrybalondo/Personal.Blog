namespace Personal.Blog.API.Post;

public class AddPostRequest
{
    public int UserId { get; }
    
    public string Title { get; }
    
    public string Body { get; }

    public AddPostRequest(int userId, string title, string body)
    {
        UserId = userId;
        Title = title;
        Body = body;
    }
}