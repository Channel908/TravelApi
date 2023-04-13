using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TravelApi.Application.Interface;
using TravelApi.Persistence.Repository;

namespace TravelApi.Persistence;

public static class DependencyInjection
{
    public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration config)
        => services.AddDbContext<ApplicationDbContext>(
            options => options.UseSqlServer(config.GetConnectionString("Default"))
            )
            .AddScoped(typeof(IRepository<>), typeof(Repository<>))
            .AddScoped<ICustomerRepository, CustomerRepository>();
}
