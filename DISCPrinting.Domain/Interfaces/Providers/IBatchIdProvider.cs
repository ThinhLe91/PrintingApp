namespace DISCPrinting.Domain.Interfaces.Providers;

public interface IBatchIdProvider
{
    Task<string> GenerateBatchId(string machine, int runOrder);
}
