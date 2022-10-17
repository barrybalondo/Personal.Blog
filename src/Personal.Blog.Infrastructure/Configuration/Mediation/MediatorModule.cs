using System.Reflection;
using Autofac;
using Autofac.Core;
using Autofac.Features.Variance;
using MediatR;
using Personal.Blog.Infrastructure.Configuration.Processing;

namespace Personal.Blog.Infrastructure.Configuration.Mediation;

public class MediatorModule : Autofac.Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterAssemblyTypes(typeof(IMediator).GetTypeInfo().Assembly)
            .AsImplementedInterfaces();
        var mediatrOpenTypes = new[]
        {
            typeof(IRequestHandler<,>),
            typeof(INotificationHandler<>)
        };
        foreach (var mediatrOpenType in mediatrOpenTypes)
        {
            builder
                .RegisterAssemblyTypes(Assemblies.Application, ThisAssembly)
                .AsClosedTypesOf(mediatrOpenType)
                .AsImplementedInterfaces();
        }
        builder.Register<ServiceFactory>(ctx =>
        {   
            var c = ctx.Resolve<IComponentContext>();
            return t => c.Resolve(t);
        });
    }
}