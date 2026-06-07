using DISCPrinting.Domain.Entities.DataMasters;
using DISCPrinting.Domain.Interfaces.Repositories;
using DISCPrinting.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DISCPrinting.Infrastructure.Persistence.Repositories;

public class DataMasterGenericRepository<TContext, TEntity, TKey>(TContext _context) : IDataMasterGenericRepository<TEntity, TKey> where TEntity : DataMasterBaseEntity<TKey>
    where TContext : DbContext
{
    internal DbSet<TEntity> _dbSet = _context.Set<TEntity>();
    public void Dispose()
    {
        _context.Dispose();
    }

    public async Task<IEnumerable<TEntity>> GetAll()
    {
        return await _dbSet.AsNoTracking().ToListAsync();
    }

    public async Task<IEnumerable<TEntity>> GetByCondition(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "")
    {
        return await GetByConditionQueryable(filter, orderBy, includeProperties).ToListAsync();
    }

    public IQueryable<TEntity> GetByConditionQueryable(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "")
    {
        IQueryable<TEntity> query = _dbSet.AsNoTracking().Where(_ => _.IsDeleted == false);

        if (filter != null)
        {
            query = query.Where(filter);
        }

        foreach (var includeProperty in includeProperties.Split
            (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
        {
            query = query.Include(includeProperty);
        }

        if (orderBy != null)
        {
            return orderBy(query);
        }
        return query;
    }

    public async Task<TEntity> GetById(TKey id)
    {
        var entity = await _dbSet.FindAsync(id);
        if (entity != null)
            _dbSet.Entry(entity).State = EntityState.Detached;
        return entity;
    }

    public async Task<TEntity> GetById(string id)
    {
        var entity = await _dbSet.FindAsync(id);
        _dbSet.Entry(entity).State = EntityState.Detached;
        return entity;
    }

    public async Task<DateTime?> GetMaxDateTime(Expression<Func<TEntity, bool>> filter = null, Expression<Func<TEntity, DateTime?>> selector = null)
    {
        IQueryable<TEntity> query = _dbSet.AsNoTracking().Where(_ => _.IsDeleted == false);

        if (filter != null)
        {
            query = query.AsNoTracking().Where(filter);
        }
        var maxDateTime = await query.MaxAsync(selector);
        return maxDateTime;
    }

    public async Task<PagedResult<TEntity>> GetWithPaging(int page, int pageSize, Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "")
    {
        IQueryable<TEntity> query = GetByConditionQueryable(filter, orderBy, includeProperties);
        var result = new PagedResult<TEntity>();
        result.CurrentPage = page;
        result.PageSize = pageSize;
        result.RowCount = query.Count();

        var pageCount = (double)result.RowCount / pageSize;
        result.PageCount = (int)Math.Ceiling(pageCount);

        var skip = (page - 1) * pageSize;
        result.Results = await query.Skip(skip).Take(pageSize).ToListAsync();
        return result;
    }
}
