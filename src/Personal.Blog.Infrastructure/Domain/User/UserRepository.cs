using Personal.Blog.Domain.User;
using Personal.Blog.Infrastructure.Database;

namespace Personal.Blog.Infrastructure.Domain.User;

public class UserRepository : GenericRepositoryBase<Blog.Domain.User.User>, IUserRepository
{
    public UserRepository(BlogContext context) : base(context)
    {
    }
}