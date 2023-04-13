
using Microsoft.EntityFrameworkCore;
using TravelApi.Application.Interface;
using TravelApi.Domain.Entity;

namespace TravelApi.Persistence.Repository;

public class CustomerRepository : Repository<Customer>, ICustomerRepository
{
    private readonly DbSet<Customer> _set;
    public CustomerRepository(ApplicationDbContext context) : base(context)
    {
        _set = context.Set<Customer>();
    }

    public async Task<List<Customer>> GetByLastName(string name)
       => await _set
               .Where(x => x.LastName.ToLower() == name)
               .ToListAsync();
}
