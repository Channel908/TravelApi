
namespace TravelApi.Application.Interface;

public interface IRepository<T> where T : class
{
    Task<List<T>> GetAsync();
    Task<T?> GetAsync(Guid id);
    Task<T?> GetAsync(int id);
    Task<T> AddAsync(T entity);
    void Update(T entity);
    void Delete(T entity);
    Task<int> SaveChangesAsync();
}
