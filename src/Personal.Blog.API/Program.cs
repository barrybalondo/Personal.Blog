using Autofac;
using Autofac.Extensions.DependencyInjection;
using Personal.Blog.Application;
using Personal.Blog.Infrastructure.Configuration;

var builder = WebApplication.CreateBuilder(args);

IConfiguration configuration = builder.Configuration;

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(
    containerBuilder => ApplicationStartup.Initialize(
        containerBuilder, 
        configuration.GetConnectionString("DefaultConnection")));

ConfigureServices(builder.Services);
Configure(builder.Build());

void ConfigureServices(IServiceCollection services)
{
    services.AddControllers();
    services.AddEndpointsApiExplorer();
    services.AddSwaggerGen();
}

void Configure(WebApplication app)
{
    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }
    app.UseHttpsRedirection();
    app.UseAuthorization();
    app.MapControllers();
    app.Run();
}