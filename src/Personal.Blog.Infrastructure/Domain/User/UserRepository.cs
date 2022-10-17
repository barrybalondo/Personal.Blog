using Personal.Blog.Domain.User;
using Personal.Blog.Infrastructure.Configuration.DataAccess;

namespace Personal.Blog.Infrastructure.Domain.User;

public class UserRepository : RepositoryBase<Blog.Domain.User.User>, IUserRepository
{
    public UserRepository(BlogContext context) : base(context)
    {
    }
}