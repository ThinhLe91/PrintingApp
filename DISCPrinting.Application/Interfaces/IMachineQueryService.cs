using DISCPrinting.Application.Dtos.DataMasterDtos;

namespace DISCPrinting.Application.Interfaces;

public interface IMachineQueryService
{
    Task<List<MachineOutputDto>> GetMachines();
}
