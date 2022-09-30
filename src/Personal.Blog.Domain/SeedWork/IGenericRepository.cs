namespace Personal.Blog.Domain.SeedWork;

public interface IGenericRepository<in TEntity> where  TEntity : Entity
{
    Task AddAsync(TEntity entity);
}