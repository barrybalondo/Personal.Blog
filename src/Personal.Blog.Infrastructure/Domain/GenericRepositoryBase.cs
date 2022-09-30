using Personal.Blog.Domain.SeedWork;
using Personal.Blog.Infrastructure.Database;

namespace Personal.Blog.Infrastructure.Domain;

public abstract class GenericRepositoryBase<TEntity> : IGenericRepository<TEntity> where TEntity : Entity
{
    private readonly BlogContext _context;

    protected GenericRepositoryBase(BlogContext context)
    {
        _context = context;
    }

    public async Task AddAsync(TEntity entity)
    {
        await _context.Set<TEntity>().AddAsync(entity);
    }
}