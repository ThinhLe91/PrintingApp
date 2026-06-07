using DISCPrinting.Domain.Entities;

namespace DISCPrinting.Domain.Interfaces.Providers;

public interface IPrintTemplateProvider
{
    Task<List<string>> GetPaperTypeByProcess(string[] processes);
    Task<PrintTemplateEntity> GetPrintTemplateInformation(string process, string paperType);
}
