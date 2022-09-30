using Personal.Blog.Domain.Post;
using Personal.Blog.Infrastructure.Database;

namespace Personal.Blog.Infrastructure.Domain.Post;

public class PostRepository : GenericRepositoryBase<Blog.Domain.Post.Post>, IPostRepository
{
    public PostRepository(BlogContext context) : base(context)
    {
    }
}