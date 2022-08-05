using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SummitTichTask.Migrations
{
    public partial class secondsetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Trip",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Destination = table.Column<string>(nullable: true),
                    ReservationCount = table.Column<int>(nullable: false),
                    SeatCost = table.Column<decimal>(nullable: false),
                    GoingDate = table.Column<DateTime>(nullable: false),
                    ComingBackDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trip", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Trip");
        }
    }
}
