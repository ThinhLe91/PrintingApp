using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DISCPrinting.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Add_BatchEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "UserRole",
                newName: "UpdatedUtcDate");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "UserRole",
                newName: "CreatedUtcDate");

            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "User",
                newName: "UpdatedUtcDate");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "User",
                newName: "CreatedUtcDate");

            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "Setting",
                newName: "UpdatedUtcDate");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Setting",
                newName: "CreatedUtcDate");

            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "RoleToPermission",
                newName: "UpdatedUtcDate");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "RoleToPermission",
                newName: "CreatedUtcDate");

            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "Role",
                newName: "UpdatedUtcDate");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Role",
                newName: "CreatedUtcDate");

            migrationBuilder.CreateTable(
                name: "Batch",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BatchId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Machine = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ToolId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CoilCharge = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArticalNumberCoil = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArticalNumberFB = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DocumentVersion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RunOrder = table.Column<int>(type: "int", nullable: false),
                    RowIndex = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedUtcDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedUtcDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Batch", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DocumentInformation",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    No = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Owner = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Version = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RevisionDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ManagedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Reference = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    RowIndex = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedUtcDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedUtcDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentInformation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BatchQuantity",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BatchId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProcessName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BoxId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    NumberOfPrints = table.Column<int>(type: "int", nullable: false),
                    LastPrintedUtcDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RowIndex = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedUtcDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedUtcDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BatchQuantity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BatchQuantity_Batch_BatchId",
                        column: x => x.BatchId,
                        principalTable: "Batch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BatchQuantity_BatchId",
                table: "BatchQuantity",
                column: "BatchId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BatchQuantity");

            migrationBuilder.DropTable(
                name: "DocumentInformation");

            migrationBuilder.DropTable(
                name: "Batch");

            migrationBuilder.RenameColumn(
                name: "UpdatedUtcDate",
                table: "UserRole",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "CreatedUtcDate",
                table: "UserRole",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "UpdatedUtcDate",
                table: "User",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "CreatedUtcDate",
                table: "User",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "UpdatedUtcDate",
                table: "Setting",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "CreatedUtcDate",
                table: "Setting",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "UpdatedUtcDate",
                table: "RoleToPermission",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "CreatedUtcDate",
                table: "RoleToPermission",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "UpdatedUtcDate",
                table: "Role",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "CreatedUtcDate",
                table: "Role",
                newName: "CreatedDate");
        }
    }
}
