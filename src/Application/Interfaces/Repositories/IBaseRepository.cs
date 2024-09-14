using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace MiniHackaton.Application.Interfaces.Repositories
{
    public interface IBaseRepository<T> where T : class
    {
        int Count();
        int Count(Expression<Func<T, bool>> predicate);
        Task<int> CountAsync();
        Task<int> CountAsync(Expression<Func<T, bool>> predicate);

        Task<bool> AnyAsync(Expression<Func<T, bool>> predicate);
        bool Any(Expression<Func<T, bool>> predicate);

        Task<bool> AllAsync(Expression<Func<T, bool>> predicate);
        IQueryable<T> GetAll();

        Task<IQueryable<T>> GetAllAsync(bool withoutDefaultFilters = true,
            Expression<Func<T, bool>> predicate = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            int? take = null,
            Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null);

        Task<T> FirstAsync(Expression<Func<T, bool>> predicate);

        Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate,
           Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
           Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null);

        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);
        Task<List<T>> FindByAsync(Expression<Func<T, bool>> predicate);

        Task<Guid> AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);
        
        void Update(T entity);
        void Update(T entity, List<string> properties);
        
        void Delete(T entity);
        void DeleteWhere(Expression<Func<T, bool>> predicate);
        
        Task CommitAsync();
    }
}
