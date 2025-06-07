using DAL.Db;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce_Application.WEB.Extensions
{
    internal static class ConfigureServicesForDevelopmentExtension
    {
        public static IServiceCollection ConfigureDevelopmentServices(this IServiceCollection services)
        {
            return services.AddServices()
                .AddBuiltInServices();
        }

        private static IServiceCollection AddServices(this IServiceCollection services)
        {
            return services;
        }

        private static IServiceCollection AddBuiltInServices(this IServiceCollection services)
        {
            services.AddControllersWithViews();
            return services;
        }

        public static IServiceCollection AddDb(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlite(configuration.GetConnectionString("DefaultConnection"));
            });
            return services;
        }
    }
}
