using DISCPrinting.Domain.Entities;

namespace DISCPrinting.Domain.Interfaces.Providers;

public interface IDocumentProvider
{
    Task<DocumentInformationEntity> GetActiveDocument();
    Task<DocumentInformationEntity> GetDocumentByVersion(string documentVersion);
    Task<string> GetActiveDocumentVersion();
}
