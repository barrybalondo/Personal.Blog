using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Personal.Blog.Application;

public static class ApplicationServicesRegistration
{
    public static IServiceCollection ConfigureApplication(this IServiceCollection services)
    {
        services.AddMediatR(AppDomain.CurrentDomain.GetAssemblies());
        return services;
    }
}