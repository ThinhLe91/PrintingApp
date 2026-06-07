using DISCPrinting.Domain.Entities;
using DISCPrinting.Domain.Interfaces.Providers;
using DISCPrinting.Domain.Interfaces.Repositories;
using DISCPrinting.Domain.Interfaces.Services;
using DISCPrinting.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;

namespace DISCPrinting.Infrastructure.Persistence.Providers;

public class DocumentProvider(IUnitOfWork _uow, ICacheService _cacheService) : IDocumentProvider
{
    public async Task<DocumentInformationEntity> GetActiveDocument()
    {
        if (_cacheService.TryGetValue<DocumentInformationEntity>(CacheKey.ActiveDocumentInformation, out DocumentInformationEntity? docInfo) && docInfo != null)
            return docInfo;
        docInfo = await _uow.GetRepository<DocumentInformationEntity>().GetByConditionQueryable(_ => _.IsActive == true).FirstOrDefaultAsync();
        if (docInfo != null)
        {
            _cacheService.Set(CacheKey.ActiveDocumentInformation, docInfo, TimeSpan.FromHours(24), true);
            return docInfo;
        }
        return new DocumentInformationEntity()
        {
            ManagedBy = "HcP/MFE1.11",
            No = "HcP-001385-002",
            Owner = "HcP/MFE1.11 Production Engineer",
            IsActive = true,
            Reference = "Nguyen Van A",
            RevisionDate = "11-09-2025",
            Version = "005"
        };
    }

    public async Task<string> GetActiveDocumentVersion()
    {
        if (_cacheService.TryGetValue<DocumentInformationEntity>(CacheKey.ActiveDocumentInformation, out DocumentInformationEntity? docInfo) && docInfo != null)
            return docInfo.Version;
        docInfo = await _uow.GetRepository<DocumentInformationEntity>().GetByConditionQueryable(_ => _.IsActive == true).FirstOrDefaultAsync();
        if (docInfo != null)
        {
            _cacheService.Set(CacheKey.ActiveDocumentInformation, docInfo, TimeSpan.FromHours(24), true);
            return docInfo.Version;
        }
        return "005";
    }

    public async Task<DocumentInformationEntity> GetDocumentByVersion(string documentVersion)
    {
        if (_cacheService.TryGetValue(CacheKey.Document_Cache_ + documentVersion, out DocumentInformationEntity? docInfo) && docInfo != null)
            return docInfo;
        docInfo = await _uow.GetRepository<DocumentInformationEntity>().GetByConditionQueryable(_ => _.Version == documentVersion).FirstOrDefaultAsync();
        if (docInfo != null)
        {
            _cacheService.Set(CacheKey.Document_Cache_ + documentVersion, docInfo, TimeSpan.FromHours(24), true);
            return docInfo;
        }
        return new DocumentInformationEntity()
        {
            ManagedBy = "HcP/MFE1.11",
            No = "HcP-001385-002",
            Owner = "HcP/MFE1.11 Production Engineer",
            IsActive = true,
            Reference = "Nguyen Van A",
            RevisionDate = "11-09-2025",
            Version = "005"
        };
    }
}
