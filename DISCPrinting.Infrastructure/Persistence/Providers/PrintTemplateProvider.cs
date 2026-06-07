using DISCPrinting.Domain.Entities;
using DISCPrinting.Domain.Interfaces.Providers;
using DISCPrinting.Domain.Interfaces.Repositories;
using DISCPrinting.Domain.Interfaces.Services;
using DISCPrinting.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;

namespace DISCPrinting.Infrastructure.Persistence.Providers;

public class PrintTemplateProvider(ICacheService _cacheService, IUnitOfWork _uow) : IPrintTemplateProvider
{
    private async Task<List<PrintTemplateEntity>> GetPrintTemplates()
    {
        if (!_cacheService.TryGetValue(CacheKey.PrintTemplates, out List<PrintTemplateEntity>? templates) || templates == null || templates.Count == 0)
            templates = await _uow.GetRepository<PrintTemplateEntity>().GetByConditionQueryable(orderBy: _ => _.OrderBy(__ => __.Order)).ToListAsync();
        if (templates == null || templates.Count == 0)
            throw new Exception("Print templates is not exist");
        _cacheService.Set(CacheKey.PrintTemplates, templates, TimeSpan.FromHours(24));
        return templates;
    }
    public async Task<PrintTemplateEntity> GetPrintTemplateInformation(string process, string paperType)
    {
        var templates = await GetPrintTemplates();
        var template = templates.FirstOrDefault(_ => _.Process == process && _.PaperType == paperType);
        if (template == null)
            throw new Exception($"Print template [{process}.{paperType}] is not exist");
        return template;
    }

    public async Task<List<string>> GetPaperTypeByProcess(string[] processes)
    {
        var templates = await GetPrintTemplates();
        return templates.Where(_ => processes.Contains(_.Process)).Select(_ => $"{_.Process}.{_.PaperType}").ToList();
    }
}
