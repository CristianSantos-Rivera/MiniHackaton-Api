using Microsoft.EntityFrameworkCore;
using MiniHackaton.Api.Contexts;

namespace Evner.Api.Extensions
{
    internal static class ServiceCollectionExtensions
    {
        internal static IServiceCollection AddDatabase(this IServiceCollection services, ConfigurationManager configuration)
            => services.AddDbContext<AppDbContext>(options => options
                       .UseNpgsql(configuration.GetConnectionString("DefaultConnection")));

    }
}
