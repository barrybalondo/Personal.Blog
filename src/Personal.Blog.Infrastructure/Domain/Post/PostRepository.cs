using Personal.Blog.Domain.Post;
using Personal.Blog.Infrastructure.Configuration.DataAccess;

namespace Personal.Blog.Infrastructure.Domain.Post;

public class PostRepository : RepositoryBase<Blog.Domain.Post.Post>, IPostRepository
{
    public PostRepository(BlogContext context) : base(context)
    {
    }
}