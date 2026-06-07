using DISCPrinting.Infrastructure.Persistence.Contexts;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DISCPrinting.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitRoleAndSetting : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(SeedData.Seed_InitRoleAndSetting());
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
