using DISCPrinting.Infrastructure.Persistence.Contexts;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DISCPrinting.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Add_DeburringTime_setting : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(SeedData.Seed_Add_DeburringTime_setting());
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
