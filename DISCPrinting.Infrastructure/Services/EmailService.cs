using DISCPrinting.Domain.Interfaces.Services;
using DISCPrinting.Domain.ValueObjects;

namespace DISCPrinting.Infrastructure.Services;

public class EmailService : IEmailService
{
    public async Task<bool> SendEmail(SendEmailDto input)
    {
        await Task.Delay(1);
        return true;
    }
}
