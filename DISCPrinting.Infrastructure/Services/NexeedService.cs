using DISCPrinting.Domain.Interfaces.Services;

namespace DISCPrinting.Infrastructure.Services;

public class NexeedService : INexeedService
{
    public Task<string> GetBatchId(string machine)
    {
        throw new NotImplementedException();
    }
}
