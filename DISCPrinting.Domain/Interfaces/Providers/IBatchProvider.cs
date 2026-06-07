using DISCPrinting.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISCPrinting.Domain.Interfaces.Providers;

public interface IBatchProvider
{
    Task<BatchEntity> GetBatchInformation(string batchId);
}
