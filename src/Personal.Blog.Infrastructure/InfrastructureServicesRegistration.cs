using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Personal.Blog.Application.Configuration.Data;
using Personal.Blog.Domain.Post;
using Personal.Blog.Domain.SeedWork;
using Personal.Blog.Domain.User;
using Personal.Blog.Infrastructure.Database;
using Personal.Blog.Infrastructure.Domain;
using Personal.Blog.Infrastructure.Domain.Post;
using Personal.Blog.Infrastructure.Domain.User;

namespace Personal.Blog.Infrastructure;

public static class InfrastructureServicesRegistration
{
    private const string ConnectionString = "DefaultConnection";
    
    public static IServiceCollection ConfigureInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<BlogContext>(
            options => options.UseSqlServer(configuration.GetConnectionString(ConnectionString)));
        services.AddScoped<ISqlConnectionFactory>(
            s => ActivatorUtilities.CreateInstance<SqlConnectionFactory>(s, configuration.GetConnectionString(ConnectionString)));
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IPostRepository, PostRepository>();
        return services;
    }
}