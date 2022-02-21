using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AjimaExploreTravel.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Travel",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TravelTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BookDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TouristAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HotelPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    HotelAddress = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Travel", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Travel");
        }
    }
}
