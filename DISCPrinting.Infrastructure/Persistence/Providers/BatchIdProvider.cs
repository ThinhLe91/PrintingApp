using DISCPrinting.Domain.Interfaces.Providers;
using DISCPrinting.Domain.Interfaces.Services;
using DISCPrinting.Domain.Utils;
using System.Text;

namespace DISCPrinting.Infrastructure.Persistence.Providers;

public class BatchIdProvider(INexeedService _nexeedService) : IBatchIdProvider
{
    

    private char GetRunOrder(int runOrder)
    {
        return (char)('Z' - (runOrder - 1));
    }

    private string LocalGenerateBatchId(string machine, int runOrder)
    {
        StringBuilder sbBatch = new StringBuilder();
        sbBatch.Append(DateTime.Now.ToString("yy"));
        sbBatch.Append(Helper.ConvertMonthToChar(DateTime.Now.Month));
        sbBatch.Append(DateTime.Now.ToString("dd"));
        sbBatch.Append(GetRunOrder(runOrder));
        sbBatch.Append(machine);

        return sbBatch.ToString();
    }

    public async Task<string> GenerateBatchId(string machine, int runOrder)
    {
        string batchId = "";
        try
        {
            batchId = await _nexeedService.GetBatchId(machine);
        }
        catch (Exception)
        {
            batchId = LocalGenerateBatchId(machine, runOrder);
        }
        return batchId;
    }
}
