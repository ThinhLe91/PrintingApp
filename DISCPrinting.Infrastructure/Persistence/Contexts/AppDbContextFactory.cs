using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace DISCPrinting.Infrastructure.Persistence.Contexts;

public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
{
    public AppDbContext CreateDbContext(string[] args)
    {
        var builder = new DbContextOptionsBuilder<AppDbContext>();
        //connection string just for add migration. not work for production
        builder.UseSqlServer("Server=SGPVM00511;Database=Test.Thien.PrintingApp;user id=icotest;password=Ico@Test2023;TrustServerCertificate=True;");

        return new AppDbContext(builder.Options);
    }
}