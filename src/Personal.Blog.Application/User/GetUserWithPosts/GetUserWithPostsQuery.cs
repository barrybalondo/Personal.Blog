using MediatR;

namespace Personal.Blog.Application.User.GetUserWithPosts;

public class GetUserWithPostsQuery : IRequest<UserWithPostsDto>
{
    public int Id { get; }
    
    public GetUserWithPostsQuery(int id)
    {
        Id = id;
    }
}