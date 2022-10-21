using Autofac;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.Extensions.Logging;
using Personal.Blog.Application.Configuration.Data;
using Personal.Blog.Domain.Post;
using Personal.Blog.Domain.SeedWork;
using Personal.Blog.Domain.User;
using Personal.Blog.Infrastructure.Domain;
using Personal.Blog.Infrastructure.Domain.Post;
using Personal.Blog.Infrastructure.Domain.User;

namespace Personal.Blog.Infrastructure.Configuration.DataAccess;

public class DataAccessModule : Module
{
    private readonly string _databaseConnectionString;

    internal DataAccessModule(string databaseConnectionString)
    {
        _databaseConnectionString = databaseConnectionString;
    }

    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterType<SqlConnectionFactory>()
            .As<ISqlConnectionFactory>()
            .WithParameter("connectionString", _databaseConnectionString)
            .InstancePerLifetimeScope();
        builder.RegisterType<PostRepository>()
            .As<IPostRepository>()
            .InstancePerLifetimeScope();
        builder.RegisterType<UnitOfWork>()
            .As<IUnitOfWork>()
            .InstancePerLifetimeScope();
        builder
            .Register(c =>
            {
                var dbContextOptionsBuilder = new DbContextOptionsBuilder<BlogContext>();
                dbContextOptionsBuilder.UseSqlServer(_databaseConnectionString);
                return new BlogContext(dbContextOptionsBuilder.Options);
            })
            .AsSelf()
            .As<DbContext>()
            .InstancePerLifetimeScope();
    }
}