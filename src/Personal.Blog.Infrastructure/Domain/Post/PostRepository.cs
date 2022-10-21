using Personal.Blog.Domain.Post;
using Personal.Blog.Infrastructure.Configuration.DataAccess;

namespace Personal.Blog.Infrastructure.Domain.Post;

public class PostRepository : IPostRepository
{
    private readonly BlogContext _blogContext;

    public PostRepository(BlogContext blogContext)
    {
        _blogContext = blogContext;
    }

    public async Task AddAsync(Blog.Domain.Post.Post post)
    {
        await _blogContext.Posts.AddAsync(post);
    }
}