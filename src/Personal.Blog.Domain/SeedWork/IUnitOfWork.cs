using Personal.Blog.Domain.Post;
using Personal.Blog.Domain.User;

namespace Personal.Blog.Domain.SeedWork;

public interface IUnitOfWork
{
    IPostRepository PostRepository { get; }
    
    Task SaveAsync();
}