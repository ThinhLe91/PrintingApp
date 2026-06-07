using DISCPrinting.Domain.Entities.DataMasters;
using DISCPrinting.Domain.ValueObjects;
using System.Linq.Expressions;

namespace DISCPrinting.Domain.Interfaces.Repositories;

public interface IDataMasterGenericRepository<TEntity, TKey> : IDisposable where TEntity : DataMasterBaseEntity<TKey>
{
    Task<IEnumerable<TEntity>> GetAll();
    Task<TEntity> GetById(TKey id);
    Task<TEntity> GetById(string id);
    Task<IEnumerable<TEntity>> GetByCondition(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "");
    IQueryable<TEntity> GetByConditionQueryable(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "");
    Task<PagedResult<TEntity>> GetWithPaging(int page, int pageSize, Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "");
    Task<DateTime?> GetMaxDateTime(Expression<Func<TEntity, bool>> filter = null, Expression<Func<TEntity, DateTime?>> selector = null);
}
