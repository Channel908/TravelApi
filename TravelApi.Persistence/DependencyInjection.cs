using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace TravelApi.Persistence;

public static class DependencyInjection
{
    public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration config)
    {
        return services.AddDbContext<ApplicationDbContext>(
            options => options.UseSqlServer(config.GetConnectionString("Default"))
            );
    }
}
