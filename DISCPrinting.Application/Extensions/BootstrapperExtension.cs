using DISCPrinting.Application.Interfaces;
using DISCPrinting.Application.UseCases;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Mapster;

namespace DISCPrinting.Application.Extensions;

public static class BootstrapperExtension
{
    public static IServiceCollection AddApplicationExtensions(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<ISettingService, SettingService>();
        services.AddScoped<IRoleService, RoleService>();
        services.AddScoped<IRoleToPermissionService, RoleToPermissionService>();
        services.AddScoped<IUserRoleService, UserRoleService>();
        services.AddScoped<IBatchService, BatchService>();
        services.AddScoped<IMachineQueryService, MachineQueryService>();
        services.AddMapster();

        return services;
    }
}
