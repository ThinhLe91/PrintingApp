using DISCPrinting.Application.Dtos.DataMasterDtos;
using DISCPrinting.Application.Interfaces;
using DISCPrinting.Domain.Entities.DataMasters;
using DISCPrinting.Domain.Interfaces.Repositories;
using DISCPrinting.Domain.Interfaces.Services;
using DISCPrinting.Domain.ValueObjects;
using MapsterMapper;

namespace DISCPrinting.Application.UseCases;

public class MachineQueryService(IUnitOfWork _uow, ICacheService _cacheService, IMapper _mapper) : IMachineQueryService
{
    private readonly IDataMasterGenericRepository<MachineEntity, short> _repository = _uow.GetDataMasterRepository<MachineEntity, short>();
    public async Task<List<MachineOutputDto>> GetMachines()
    {
        if (!_cacheService.TryGetValue<List<MachineOutputDto>>(CacheKey.Machine_Cache, out List<MachineOutputDto>? list) || list == null || list.Count == 0)
        {
            list = _mapper.Map<List<MachineOutputDto>>(await _repository.GetByCondition());
            _cacheService.Set(CacheKey.Machine_Cache, list, TimeSpan.FromHours(24));
        }
        return list;
    }
}
