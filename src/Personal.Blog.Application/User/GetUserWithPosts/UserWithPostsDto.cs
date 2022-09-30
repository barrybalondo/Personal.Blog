namespace Personal.Blog.Application.User.GetUserWithPosts;

public class UserWithPostsDto
{
    public int Id { get; set; }
    
    public string? FirstName { get; set; }
    
    public string? LastName { get; set; }
    
    public IList<PostDto>? Posts { get; set; }
}