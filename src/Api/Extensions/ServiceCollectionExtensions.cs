using Microsoft.EntityFrameworkCore;
using MiniHackaton.Persistence.Contexts;
using MiniHackaton.Persistence.Repositories;

namespace Evner.Api.Extensions
{
    internal static class ServiceCollectionExtensions
    {
        internal static IServiceCollection AddDatabase(this IServiceCollection services, ConfigurationManager configuration)
            => services.AddDbContext<AppDbContext>(options => options
                       .UseNpgsql(configuration.GetConnectionString("DefaultConnection")));

        internal static IServiceCollection AddApplicationRepositories(this IServiceCollection services)
        {
            services.AddScoped(typeof(BaseRepository<>), typeof(BaseRepository<>));
            return services;
        }

        internal static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            return services;
        }
    }
}
