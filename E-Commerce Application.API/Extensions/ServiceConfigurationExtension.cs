using Application.Handlers;
using System.Reflection;

namespace E_Commerce_Application.API.Extensions;

public static class ServiceConfigurationExtension
{
    public static IServiceCollection ConfigureServices(this IServiceCollection services)
    {
        return services.ConfigureBuiltIn()
            .AddHandlers()
            .AddServices();
    }

    private static IServiceCollection ConfigureBuiltIn(this IServiceCollection services)
    {
        services.AddControllers();
        return services.AddEndpointsApiExplorer()
        .AddSwaggerGen();
    }

    private static IServiceCollection AddHandlers(this IServiceCollection services)
    {
        var assembly = Assembly.GetAssembly(typeof(GetProductQueryHandler));
        if (assembly is null)
        {
            throw new InvalidOperationException("Assembly not found for GetProductQueryHandler.");
        }

        var types = assembly.GetTypes();
        foreach (var item in types)
        {
            services.AddScoped(item.GetInterfaces()[0].GetType(), item);
        }

        return services;
    }

    private static IServiceCollection AddServices(this IServiceCollection services)
    {

        return services;
    }
}
