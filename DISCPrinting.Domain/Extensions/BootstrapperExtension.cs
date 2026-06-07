using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DISCPrinting.Domain.Extensions;


public static class BootstrapperExtension
{
    public static IServiceCollection AddDomainExtensions(this IServiceCollection services, IConfiguration configuration)
    {
        return services;
    }
}
