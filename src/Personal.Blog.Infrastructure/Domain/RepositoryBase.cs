using Personal.Blog.Domain.SeedWork;
using Personal.Blog.Infrastructure.Configuration.DataAccess;

namespace Personal.Blog.Infrastructure.Domain;

public abstract class RepositoryBase<TEntity> : IRepository<TEntity> where TEntity : Entity
{
    private readonly BlogContext _context;

    protected RepositoryBase(BlogContext context)
    {
        _context = context;
    }

    public async Task AddAsync(TEntity entity)
    {
        await _context.Set<TEntity>().AddAsync(entity);
    }
}