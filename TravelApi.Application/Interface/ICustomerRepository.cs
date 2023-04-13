using TravelApi.Domain.Entity;

namespace TravelApi.Application.Interface;

public interface ICustomerRepository : IRepository<Customer>
{
    Task<List<Customer>> GetByLastName(string lastName);
}
