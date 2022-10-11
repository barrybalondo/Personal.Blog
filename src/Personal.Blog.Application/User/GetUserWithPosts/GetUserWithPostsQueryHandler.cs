using Dapper;
using Personal.Blog.Application.Configuration.Data;
using Personal.Blog.Application.Configuration.Query;

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
        var sql = $@"SELECT Id AS {nameof(UserWithPostsDto.Id)},
                            FirstName AS {nameof(UserWithPostsDto.FirstName)},
                            LastName AS {nameof(UserWithPostsDto.LastName)}
                     FROM dbo.Users
                     WHERE Id = @Id";
        var user = await connection.QuerySingleOrDefaultAsync<UserWithPostsDto>(sql, new { request.Id });    
        var sqlPosts = $@"SELECT Id AS {nameof(PostDto.PostId)},
                                 Title AS {nameof(PostDto.Title)},
                                 Body AS {nameof(PostDto.Body)}
                          FROM dbo.Posts
                          WHERE UserId = @UserId";
        var posts = await connection.QueryAsync<PostDto>(sqlPosts, new { UserId = request.Id });
        user.Posts = posts.AsList();
        return user;
    }
}