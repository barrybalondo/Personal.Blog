using System.Data;
using Autofac;
using Autofac.Builder;
using Personal.Blog.Infrastructure.Configuration.DataAccess;
using Personal.Blog.Infrastructure.Configuration.Mediation;

namespace Personal.Blog.Infrastructure.Configuration;

public static class ApplicationStartup
{
    public static void Initialize(ContainerBuilder containerBuilder, string connectionString)
    {
        containerBuilder.RegisterModule(new MediatorModule());
        containerBuilder.RegisterModule(new DataAccessModule(connectionString));
        containerBuilder.RegisterBuildCallback(c =>
        {
            var container = c as IContainer ?? throw new NoNullAllowedException(nameof(c));
            CompositionRoot.SetContainer(container);
        }); 
    }
}