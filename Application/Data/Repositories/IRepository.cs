using System.Linq.Expressions;

namespace Application.Data.Repositories;

public interface IRepository<T>
{
    Task<List<T>> GetAsync(
        Expression<Func<T, bool>>? filter = null,
        Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
        string[]? includeProperties = null
    );
    Task<T?> GetByIdAsync(object id);
    void Add(T entity);
    void Update(T entity);
    void Delete(T entity);
    void Delete(object id);
    Task SaveChangesAsync();
}