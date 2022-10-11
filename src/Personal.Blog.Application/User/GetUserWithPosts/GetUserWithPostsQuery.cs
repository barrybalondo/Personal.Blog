using Personal.Blog.Application.Configuration.Query;

namespace Personal.Blog.Application.User.GetUserWithPosts;

public class GetUserWithPostsQuery : IQuery<UserWithPostsDto>
{
    public int Id { get; }
    
    public GetUserWithPostsQuery(int id)
    {
        Id = id;
    }
}