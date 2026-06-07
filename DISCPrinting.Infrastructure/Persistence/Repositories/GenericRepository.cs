using DISCPrinting.Domain.Entities;
using DISCPrinting.Domain.Interfaces.Repositories;
using DISCPrinting.Domain.Interfaces.Services;
using DISCPrinting.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DISCPrinting.Infrastructure.Persistence.Repositories;

public class GenericRepository<TContext, T>(TContext _context, ICacheService _cacheService) : IGenericRepository<T> where T : BaseEntity
    where TContext : DbContext
{
    internal DbSet<T> _dbSet = _context.Set<T>();
    public void Delete(Guid id)
    {
        _dbSet.Remove(_dbSet.Find(id));
    }

    public void Delete(string id)
    {
        _dbSet.Remove(_dbSet.Find(id));
    }

    public void Dispose()
    {
        _context.Dispose();
    }

    public async Task<IEnumerable<T>> GetAll()
    {
        return await _dbSet.AsNoTracking().ToListAsync();
    }

    public async Task<IEnumerable<T>> GetByCondition(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "")
    {
        return await GetByConditionQueryable(filter, orderBy, includeProperties).ToListAsync();
    }

    public IQueryable<T> GetByConditionQueryable(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "", bool tracking = false)
    {
        IQueryable<T> query = _dbSet.Where(_ => _.IsDeleted == false);

        if (!tracking)
        {
            query = query.AsNoTracking();
        }

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

    public async Task<T> GetById(Guid id)
    {
        var entity = await _dbSet.FindAsync(id);
        if (entity != null)
            _dbSet.Entry(entity).State = EntityState.Detached;
        return entity;
    }

    public async Task<T> GetById(string id)
    {
        var entity = await _dbSet.FindAsync(id);
        _dbSet.Entry(entity).State = EntityState.Detached;
        return entity;
    }

    public async Task<DateTime?> GetMaxDateTime(Expression<Func<T, bool>> filter = null, Expression<Func<T, DateTime?>> selector = null)
    {
        IQueryable<T> query = _dbSet.Where(_ => _.IsDeleted == false);

        if (filter != null)
        {
            query = query.AsNoTracking().Where(filter);
        }
        var maxDateTime = await query.MaxAsync(selector);
        return maxDateTime;
    }

    public async Task<PagedResult<T>> GetWithPaging(int page, int pageSize, Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "")
    {
        IQueryable<T> query = GetByConditionQueryable(filter, orderBy, includeProperties);
        var result = new PagedResult<T>();
        result.CurrentPage = page;
        result.PageSize = pageSize;
        result.RowCount = query.Count();

        var pageCount = (double)result.RowCount / pageSize;
        result.PageCount = (int)Math.Ceiling(pageCount);

        var skip = (page - 1) * pageSize;
        result.Results = await query.Skip(skip).Take(pageSize).ToListAsync();
        return result;
    }

    public async Task Insert(T entity)
    {
        AuditData(entity, true);
        await _dbSet.AddAsync(entity);
    }

    public async Task Insert(List<T> entities)
    {
        AuditData(entities, true);
        await _dbSet.AddRangeAsync(entities);
    }

    public void Update(T entity)
    {
        AuditData(entity, false);
        _dbSet.Attach(entity);
        _dbSet.Entry(entity).State = EntityState.Modified;
    }

    public void Update(List<T> entities)
    {
        AuditData(entities, false);
        foreach (T entity in entities)
        {
            _dbSet.Attach(entity);
            _dbSet.Entry(entity).State = EntityState.Modified;
        }
    }

    //========================= Private Function ===========================================
    private void AuditData(T entity, bool isCreated)
    {
        if (isCreated)
        {
            entity.CreatedUtcDate = DateTime.UtcNow;
        }
        entity.UpdatedBy = _cacheService.Get<UserInformation>(CacheKey.LoginUser)?.Username ?? "";
        entity.UpdatedUtcDate = DateTime.UtcNow;
    }

    private void AuditData(List<T> entities, bool isCreated)
    {
        foreach (T entity in entities)
        {
            AuditData(entity, isCreated);
        }
    }
}
