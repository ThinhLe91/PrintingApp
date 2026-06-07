using DISCPrinting.Domain.Entities;
using DISCPrinting.Domain.Entities.DataMasters;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DISCPrinting.Infrastructure.Persistence.Contexts;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }
    public DbSet<SettingEntity> Settings { get; set; }
    public DbSet<RoleEntity> Roles { get; set; }
    public DbSet<RoleToPermissionEntity> RoleToPermissions { get; set; }
    public DbSet<UserEntity> Users { get; set; }
    public DbSet<UserRoleEntity> UserRoles { get; set; }
    public DbSet<BatchEntity> Batches { get; set; }
    public DbSet<BatchQuantityEntity> BatchQuantities { get; set; }
    public DbSet<DocumentInformationEntity> DocumentInformations { get; set; }
    public DbSet<MachineEntity> Machines { get; set; }
    public DbSet<PrintTemplateEntity> PrintTemplates { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var entityTypes = modelBuilder.Model.GetEntityTypes();
        foreach (var entityType in modelBuilder.Model.GetEntityTypes())
        {
            if (typeof(BaseEntity).IsAssignableFrom(entityType.ClrType))
            {
                modelBuilder.Entity(entityType.ClrType)
                    .Property("RowIndex")
                    .ValueGeneratedOnAdd()
                    .Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore)
                    ;
            }
            var testType = typeof(DataMasterBaseEntity<>);

            if (typeof(DataMasterBaseEntity<short>).IsAssignableFrom(entityType.ClrType))
            {
                modelBuilder.Entity(entityType.ClrType).ToTable(entityType.GetTableName()!, entityType.GetSchema(), t => t.ExcludeFromMigrations());
                modelBuilder.Entity(entityType.ClrType).HasKey("Id");
            }
        }
    }
}
