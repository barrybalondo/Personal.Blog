using Microsoft.EntityFrameworkCore;
using Personal.Blog.Domain.Post;
using Personal.Blog.Domain.User;

namespace Personal.Blog.Infrastructure.Database;

public class BlogContext : DbContext
{
    public const string DefaultSchema = "dbo";
    
    public DbSet<User> Users => Set<User>();

    public DbSet<Post> Posts => Set<Post>();

    public BlogContext(DbContextOptions<BlogContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(BlogContext).Assembly);
    }
}