using Personal.Blog.Domain.Post;
using Personal.Blog.Domain.SeedWork;
using Personal.Blog.Domain.User;
using Personal.Blog.Infrastructure.Configuration.DataAccess;
using Personal.Blog.Infrastructure.Domain.Post;
using Personal.Blog.Infrastructure.Domain.User;

namespace Personal.Blog.Infrastructure.Domain;

public class UnitOfWork : IUnitOfWork
{
    private readonly BlogContext _context;
    
    public IPostRepository PostRepository { get; }
    
    public UnitOfWork(BlogContext context)
    {
        _context = context;
        PostRepository = new PostRepository(_context);
    }
    
    public async Task SaveAsync()
    {
        await _context.SaveChangesAsync();
    }
}