using DISCPrinting.Domain.Entities;
using DISCPrinting.Domain.Interfaces.Providers;
using DISCPrinting.Domain.Interfaces.Repositories;
using DISCPrinting.Domain.Interfaces.Services;
using DISCPrinting.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;

namespace DISCPrinting.Infrastructure.Persistence.Providers;

public class BatchProvider(IUnitOfWork _uow, ICacheService _cacheService) : IBatchProvider
{
    public async Task<BatchEntity> GetBatchInformation(string batchId)
    {
        if (!_cacheService.TryGetValue(CacheKey.Batch_Cache_ + batchId, out BatchEntity? batchInfo) || batchInfo == null)
        {
            batchInfo = await _uow.GetRepository<BatchEntity>().GetByConditionQueryable(_ => _.IsDeleted == false && _.BatchId == batchId).FirstOrDefaultAsync();
            if (batchInfo == null) throw new Exception($"Batch [{batchId}] is not exist");
            _cacheService.Set(CacheKey.Batch_Cache_ + batchId, batchInfo);
        }
        return batchInfo;
    }
}
