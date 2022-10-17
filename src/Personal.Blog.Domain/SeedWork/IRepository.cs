namespace Personal.Blog.Domain.SeedWork;

public interface IRepository<in TEntity> where  TEntity : Entity
{
    Task AddAsync(TEntity entity);
}