using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DISCPrinting.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Fix_IsDeleted : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsDelete",
                table: "UserRole",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "IsDelete",
                table: "User",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "IsDelete",
                table: "Setting",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "IsDelete",
                table: "RoleToPermission",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "IsDelete",
                table: "Role",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "IsDelete",
                table: "DocumentInformation",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "IsDelete",
                table: "BatchQuantity",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "IsDelete",
                table: "Batch",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "ArticalNumberFB",
                table: "Batch",
                newName: "ProductionVersion");

            migrationBuilder.RenameColumn(
                name: "ArticalNumberCoil",
                table: "Batch",
                newName: "ArticleNumberFB");

            migrationBuilder.AddColumn<string>(
                name: "ArticleNumberCoil",
                table: "Batch",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ArticleNumberDB",
                table: "Batch",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArticleNumberCoil",
                table: "Batch");

            migrationBuilder.DropColumn(
                name: "ArticleNumberDB",
                table: "Batch");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "UserRole",
                newName: "IsDelete");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "User",
                newName: "IsDelete");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "Setting",
                newName: "IsDelete");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "RoleToPermission",
                newName: "IsDelete");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "Role",
                newName: "IsDelete");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "DocumentInformation",
                newName: "IsDelete");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "BatchQuantity",
                newName: "IsDelete");

            migrationBuilder.RenameColumn(
                name: "ProductionVersion",
                table: "Batch",
                newName: "ArticalNumberFB");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "Batch",
                newName: "IsDelete");

            migrationBuilder.RenameColumn(
                name: "ArticleNumberFB",
                table: "Batch",
                newName: "ArticalNumberCoil");
        }
    }
}
