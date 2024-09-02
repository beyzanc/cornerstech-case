using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cornerstech.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class deletedanentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Risks_RiskCategories_RiskCategoryId",
                table: "Risks");

            migrationBuilder.DropTable(
                name: "RiskCategories");

            migrationBuilder.DropIndex(
                name: "IX_Risks_RiskCategoryId",
                table: "Risks");

            migrationBuilder.DropColumn(
                name: "RiskCategoryId",
                table: "Risks");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Risks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Risks");

            migrationBuilder.AddColumn<int>(
                name: "RiskCategoryId",
                table: "Risks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "RiskCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RiskCategories", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Risks_RiskCategoryId",
                table: "Risks",
                column: "RiskCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Risks_RiskCategories_RiskCategoryId",
                table: "Risks",
                column: "RiskCategoryId",
                principalTable: "RiskCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
