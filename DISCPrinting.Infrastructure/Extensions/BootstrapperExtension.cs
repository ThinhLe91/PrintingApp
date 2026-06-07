using DISCPrinting.Domain.Interfaces.Providers;
using DISCPrinting.Domain.Interfaces.Repositories;
using DISCPrinting.Domain.Interfaces.Services;
using DISCPrinting.Domain.Utils;
using DISCPrinting.Infrastructure.Persistence.Contexts;
using DISCPrinting.Infrastructure.Persistence.Providers;
using DISCPrinting.Infrastructure.Persistence.Repositories;
using DISCPrinting.Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DISCPrinting.Infrastructure.Extensions;

public static class BootstrapperExtension
{
    public static IServiceCollection AddInfrastructureExtensions(this IServiceCollection services, IConfiguration configuration)
    {
        var secretKey = configuration["Encryption:SecretKey"];
        services.AddMemoryCache();
        services.AddSingleton<ICacheService, MemoryCacheService>();
        services.AddDbContextFactory<AppDbContext>(opt => opt.UseSqlServer(
            Helper.Decrypt(configuration.GetConnectionString("DefaultConnection") ?? throw new Exception("Please config connection string"))));
        services.AddScoped<IUnitOfWork, UnitOfWork<AppDbContext>>();
        services.AddScoped<IEmailService, EmailService>();
        services.AddScoped<ISettingProvider, SettingProvider>();
        services.AddScoped<INexeedService, NexeedService>();
        services.AddScoped<IBatchIdProvider, BatchIdProvider>();
        services.AddScoped<IPrintTemplateProvider, PrintTemplateProvider>();
        services.AddScoped<IBatchProvider, BatchProvider>();
        services.AddScoped<IDocumentProvider, DocumentProvider>();
        return services;
    }
}
