using DISCPrinting.Application.Dtos.BatchDtos;

namespace DISCPrinting.Application.Interfaces;

public interface IBatchService
{
    Task<string> CreateBatch(BatchInputDto input);
    Task<BatchOutputDto> GetBatchInfo(string batchId);
}
