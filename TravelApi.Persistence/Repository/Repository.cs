using Microsoft.EntityFrameworkCore;
using TravelApi.Application.Interface;

namespace TravelApi.Persistence.Repository;

public class Repository<T> : IRepository<T> where T : class
{
    private readonly ApplicationDbContext _context;
    private readonly DbSet<T> _set;

    public Repository(ApplicationDbContext context)
    {
        _context = context;
        _set = _context.Set<T>();
    }

    public async Task<List<T>> GetAsync() => await _set.ToListAsync();

    public async Task<T?> GetAsync(Guid id) => await _set.FindAsync(id);

    public async Task<T?> GetAsync(int id) => await _set.FindAsync(id);

    public async Task<T> AddAsync(T entity)
    {
        await _set.AddAsync(entity);
        return entity;
    }

    public void Update(T entity) => _set.Update(entity);

    public void Delete(T entity) => _set.Remove(entity);

    public async Task<int> SaveChangesAsync() => await _context.SaveChangesAsync();

}
