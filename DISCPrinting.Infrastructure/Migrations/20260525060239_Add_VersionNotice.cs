using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DISCPrinting.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Add_VersionNotice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "VersionNotice",
                table: "DocumentInformation",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VersionNotice",
                table: "DocumentInformation");
        }
    }
}
