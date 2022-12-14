namespace Personal.Blog.Application.Post;

public class PostDto
{
    public int PostId { get; set; }

    public string? Title { get; set; }
    
    public string? Body { get; set; }

    public PostDto(int postId, string? title, string? body)
    {
        PostId = postId;
        Title = title;
        Body = body;
    }
}