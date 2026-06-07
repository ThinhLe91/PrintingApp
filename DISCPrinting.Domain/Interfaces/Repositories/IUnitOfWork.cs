using DISCPrinting.Domain.Entities;
using DISCPrinting.Domain.Entities.DataMasters;

namespace DISCPrinting.Domain.Interfaces.Repositories;

public interface IUnitOfWork : IDisposable
{
    IDataMasterGenericRepository<TEntity, TKey> GetDataMasterRepository<TEntity, TKey>() where TEntity : DataMasterBaseEntity<TKey>;
    IGenericRepository<T> GetRepository<T>() where T : BaseEntity;
    Task<int> SaveChangesAsync();
}
