using Personal.Blog.Application.Configuration.Query;

namespace Personal.Blog.Application.User.GetUserWithPosts;

public class GetUserWithPostsQuery : IQuery<UserWithPostsDto>
{
    public int UserId { get; }
    
    public GetUserWithPostsQuery(int userId)
    {
        UserId = userId;
    }
}