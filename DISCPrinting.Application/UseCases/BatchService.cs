using DISCPrinting.Application.Dtos.BatchDtos;
using DISCPrinting.Application.Interfaces;
using DISCPrinting.Domain.Entities;
using DISCPrinting.Domain.Interfaces.Providers;
using DISCPrinting.Domain.Interfaces.Repositories;
using DISCPrinting.Domain.Interfaces.Services;
using DISCPrinting.Domain.Utils;
using DISCPrinting.Domain.ValueObjects;
using MapsterMapper;
using Microsoft.EntityFrameworkCore;

namespace DISCPrinting.Application.UseCases;

public class BatchService(IUnitOfWork _uow, IBatchIdProvider _batchIdProvider, IDocumentProvider _documentProvider,
    ICacheService _cacheService, IMapper _mapper, ISettingProvider _settingProvider) : IBatchService
{
    private readonly IGenericRepository<BatchEntity> _repository = _uow.GetRepository<BatchEntity>();

    private async Task<int> GetMaxRunOrder(string pattern)
    {
        var maxBatch = await _repository.GetByConditionQueryable(_ => EF.Functions.Like(_.BatchId, pattern),
            _ => _.OrderByDescending(__ => __.RunOrder)).FirstOrDefaultAsync();
        return maxBatch?.RunOrder ?? 0;
    }

    public async Task<string> CreateBatch(BatchInputDto input)
    {
        var batchEntity = _mapper.Map<BatchEntity>(input);
        batchEntity.RunOrder = (await GetMaxRunOrder($"{DateTime.Now.ToString("yy")}{Helper.ConvertMonthToChar(DateTime.Now.Month)}{DateTime.Now.ToString("dd")}%{input.Machine}")) + 1;
        batchEntity.DocumentVersion = await _documentProvider.GetActiveDocumentVersion();
        batchEntity.BatchId = await _batchIdProvider.GenerateBatchId(input.Machine, batchEntity.RunOrder);
        batchEntity.ProductionVersion = await _settingProvider.GetByKey(SettingKeys.Global.ProductVersion);
        await _repository.Insert(batchEntity);
        await _uow.SaveChangesAsync();
        _cacheService.Set(CacheKey.Setting_Cache_ + batchEntity.BatchId, batchEntity, TimeSpan.FromHours(24));
        return batchEntity.BatchId;

    }

    public async Task<BatchOutputDto> GetBatchInfo(string batchId)
    {
        var exBatchId = batchId.Substring(0, 8);
        if (!_cacheService.TryGetValue(CacheKey.Setting_Cache_ + exBatchId, out BatchEntity? batch) || batch == null)
        {
            batch = await _repository.GetByConditionQueryable(_ => _.BatchId == exBatchId).FirstOrDefaultAsync();
        }
        if (batch == null) throw new Exception($"Batch [{batchId}] is not exist");
        _cacheService.Set(CacheKey.Setting_Cache_ + batch.BatchId, batch, TimeSpan.FromHours(24));
        return _mapper.Map<BatchOutputDto>(batch);
    }
}
