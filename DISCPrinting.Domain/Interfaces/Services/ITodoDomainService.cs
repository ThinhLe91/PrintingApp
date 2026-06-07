namespace DISCPrinting.Domain.Interfaces.Services;

public interface ITodoDomainService
{
    Task CheckTitleExist(string title, Guid? id = null);
}
