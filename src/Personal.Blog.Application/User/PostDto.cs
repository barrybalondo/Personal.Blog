namespace Personal.Blog.Application.User.GetUserWithPosts;

public class PostDto
{
    public int PostId { get; set; }

    public string? Title { get; set; }
    
    public string? Body { get; set; }
}