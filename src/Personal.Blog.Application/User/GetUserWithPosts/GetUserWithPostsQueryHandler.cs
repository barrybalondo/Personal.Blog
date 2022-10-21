using Dapper;
using Personal.Blog.Application.Configuration.Data;
using Personal.Blog.Application.Configuration.Query;
using Personal.Blog.Application.Post;

namespace Personal.Blog.Application.User.GetUserWithPosts;

internal sealed class GetUserWithPostsQueryHandler : IQueryHandler<GetUserWithPostsQuery, UserWithPostsDto>
{
    private readonly ISqlConnectionFactory _sqlConnectionFactory;
    
    public GetUserWithPostsQueryHandler(ISqlConnectionFactory sqlConnectionFactory)
    {
        _sqlConnectionFactory = sqlConnectionFactory;
    }
    
    public async Task<UserWithPostsDto> Handle(GetUserWithPostsQuery request, CancellationToken cancellationToken)
    {
        var connection = _sqlConnectionFactory.GetOpenConnection();
        const string sql = $@"SELECT UserId AS {nameof(UserWithPostsDto.UserId)},
                                     FirstName AS {nameof(UserWithPostsDto.FirstName)},
                                     LastName AS {nameof(UserWithPostsDto.LastName)}
                              FROM dbo.Users
                              WHERE UserId = @UserId";
        var user = await connection.QuerySingleOrDefaultAsync<UserWithPostsDto>(sql, new { request.UserId });    
        const string sqlPosts = $@"SELECT PostId AS {nameof(PostDto.PostId)},
                                          Title AS {nameof(PostDto.Title)},
                                          Body AS {nameof(PostDto.Body)}
                                   FROM dbo.Posts
                                   WHERE UserId = @UserId";
        var posts = await connection.QueryAsync<PostDto>(sqlPosts, new { request.UserId });
        user.Posts = posts.AsList();
        return user;
    }
}