using System.Linq.Expressions;
using DISCPrinting.Domain.Entities;
using DISCPrinting.Domain.ValueObjects;

namespace DISCPrinting.Domain.Interfaces.Repositories;

public interface IGenericRepository<T> : IDisposable where T : BaseEntity
{
    Task<IEnumerable<T>> GetAll();
    Task<T> GetById(Guid id);
    Task<T> GetById(string id);
    Task<IEnumerable<T>> GetByCondition(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "");
    IQueryable<T> GetByConditionQueryable(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "", bool tracking = false);
    Task<PagedResult<T>> GetWithPaging(int page, int pageSize, Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "");
    Task<DateTime?> GetMaxDateTime(Expression<Func<T, bool>> filter = null, Expression<Func<T, DateTime?>> selector = null);
    Task Insert(T entity);
    Task Insert(List<T> entities);
    void Update(T entity);
    void Update(List<T> entities);
    void Delete(Guid id);
    void Delete(string id);
}