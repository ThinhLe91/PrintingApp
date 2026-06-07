using DISCPrinting.Domain.Entities;
using DISCPrinting.Domain.Entities.DataMasters;
using DISCPrinting.Domain.Interfaces.Repositories;
using DISCPrinting.Domain.Interfaces.Services;
using Microsoft.EntityFrameworkCore;

namespace DISCPrinting.Infrastructure.Persistence.Repositories;

public class UnitOfWork<TContext>(IDbContextFactory<TContext> _contextFactory, ICacheService _cacheService)
    : IUnitOfWork where TContext : DbContext
{
    readonly TContext _context = _contextFactory.CreateDbContext();
    readonly Dictionary<Type, object> _repositories = new(); 
    readonly Dictionary<Type, object> _dataMasterRepositories = new();

    public void Dispose()
    {
        _context.Dispose();
    }

    public IGenericRepository<T> GetRepository<T>() where T : BaseEntity
    {
        if (_repositories.ContainsKey(typeof(T)))
        {
            return (IGenericRepository<T>)_repositories[typeof(T)];
        }

        var repository = new GenericRepository<TContext, T>(_context, _cacheService);
        _repositories.Add(typeof(T), repository);
        return repository;
    }

    public IDataMasterGenericRepository<TEntity, TKey> GetDataMasterRepository<TEntity, TKey>() where TEntity : DataMasterBaseEntity<TKey>
    {
        if (_dataMasterRepositories.TryGetValue(typeof(TEntity), out var repo)) return (IDataMasterGenericRepository<TEntity, TKey>)repo;

        var repository = new DataMasterGenericRepository<TContext, TEntity, TKey>(_context);
        _dataMasterRepositories[typeof(TEntity)] = repository;
        return repository;
    }

    public async Task<int> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync();
    }
}
