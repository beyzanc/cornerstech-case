using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cornerstech.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class insertednewentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RiskManagements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RiskCategory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RiskDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RiskValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RiskManagements", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RiskManagements");
        }
    }
}
