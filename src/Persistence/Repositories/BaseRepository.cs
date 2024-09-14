using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using MiniHackaton.Application.Interfaces.Repositories;
using MiniHackaton.Domain.Common;
using System.Linq.Expressions;

namespace MiniHackaton.Persistence.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        public DbContext Context { get; set; }

        public BaseRepository(DbContext context)
        {
            Context = context;
        }

        protected IQueryable<T> PrepareQuery(
            IQueryable<T> query,
            Expression<Func<T, bool>> predicate = null,
            Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            int? take = null)
        {
            if (include != null)
            {
                query = include(query);
            }

            if (predicate != null)
            {
                query = query.Where(predicate);
            }

            if (orderBy != null)
            {
                query = orderBy(query);
            }

            if (take.HasValue)
            {
                query = query.Take(Convert.ToInt32(take));
            }

            return query;
        }

        #region Count
        public virtual int Count()
        {
            return GetAll().Count();
        }

        public virtual int Count(Expression<Func<T, bool>> predicate)
        {
            return GetAll().Count(predicate);
        }

        public async virtual Task<int> CountAsync()
        {
            return await GetAll().CountAsync();
        }

        public async virtual Task<int> CountAsync(Expression<Func<T, bool>> predicate)
        {
            return await GetAll().CountAsync(predicate);
        }
        #endregion

        #region Any
        public virtual bool Any(Expression<Func<T, bool>> predicate)
        {
            return GetAll().Any(predicate);
        }

        public async virtual Task<bool> AnyAsync(Expression<Func<T, bool>> predicate)
        {
            return await GetAll().AnyAsync(predicate);
        }
        #endregion

        #region Get
        public async virtual Task<bool> AllAsync(Expression<Func<T, bool>> predicate)
        {
            return await GetAll().AllAsync(predicate);
        }

        public virtual IQueryable<T> GetAll()
        {
            var entitySet = Context.Set<T>();
            return entitySet.AsQueryable();
        }

        public virtual async Task<IQueryable<T>> GetAllAsync(
            bool withoutDefaultFilters = true,
            Expression<Func<T, bool>> predicate = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            int? take = null,
            Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null)
        {
            IQueryable<T> query = Context.Set<T>().AsQueryable();
            query = await Task.FromResult(PrepareQuery(query, predicate, include, orderBy, take));
            return query;
        }

        public async virtual Task<T> FirstAsync(Expression<Func<T, bool>> predicate)
        {
            return await GetAll().FirstOrDefaultAsync(predicate);
        }

        public virtual async Task<T> FirstOrDefaultAsync(
           Expression<Func<T, bool>> predicate,
           Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
           Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null)
        {
            IQueryable<T> query = Context.Set<T>().AsQueryable();
            query = PrepareQuery(query, predicate, include, orderBy);
            return await query.FirstOrDefaultAsync();
        }


        public virtual IQueryable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            return GetAll().Where(predicate);
        }

        public virtual async Task<List<T>> FindByAsync(Expression<Func<T, bool>> predicate)
        {
            return await GetAll().Where(predicate).ToListAsync();
        }
        #endregion

        #region Add
        public async virtual Task<Guid> AddAsync(T entity)
        {
            await Context.Set<T>().AddAsync(entity);
            return entity.Id;
        }

        public async virtual Task AddRangeAsync(IEnumerable<T> entities)
            => await Context.Set<T>().AddRangeAsync(entities);
        #endregion

        #region Update
        public virtual void Update(T entity)
        {
            var dbEntry = Context.Entry(entity);
            dbEntry.State = EntityState.Modified;
        }

        /// <summary>
        /// Update where don't modify fields array
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="properties"></param>
        public virtual void Update(T entity, List<string> properties)
        {
            var dbEntry = Context.Entry(entity);
            properties.ForEach(x =>
            {
                dbEntry.Property(x).IsModified = false;
            });
        }
        #endregion

        #region Delete
        public virtual void Delete(T entity)
        {
            var entitySet = Context.Set<T>();
            entitySet.Remove(entity);
        }

        public virtual void DeleteWhere(Expression<Func<T, bool>> predicate)
        {
            IQueryable<T> entities = FindBy(predicate);
            var entitySet = Context.Set<T>();
            entitySet.RemoveRange(entities);
        }
        #endregion

        public async virtual Task CommitAsync()
        {
            await Context.SaveChangesAsync();
        }
    }
}
