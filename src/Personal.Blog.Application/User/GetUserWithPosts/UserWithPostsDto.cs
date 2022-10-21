using Personal.Blog.Application.Post;

namespace Personal.Blog.Application.User.GetUserWithPosts;

public class UserWithPostsDto
{
    public int UserId { get; set; }
    
    public string FirstName { get; set; }
    
    public string LastName { get; set; }
    
    public IList<PostDto>? Posts { get; set; }

    public UserWithPostsDto(int userId, string firstName, string lastName)
    {
        UserId = userId;
        FirstName = firstName;
        LastName = lastName;
        Posts = new List<PostDto>();
    }
}