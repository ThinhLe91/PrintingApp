using DISCPrinting.Domain.ValueObjects;

namespace DISCPrinting.Domain.Interfaces.Services;

public interface IEmailService
{
    Task<bool> SendEmail(SendEmailDto input);
}
