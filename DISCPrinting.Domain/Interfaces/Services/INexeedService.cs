using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISCPrinting.Domain.Interfaces.Services;

public interface INexeedService
{
    Task<string> GetBatchId(string machine);
}
