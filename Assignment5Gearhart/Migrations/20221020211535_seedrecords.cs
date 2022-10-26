using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment5Gearhart.Migrations
{
    public partial class seedrecords : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FuelRecordModels",
                columns: table => new
                {
                    FuelRecordModelId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    mileage = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    datePurchased = table.Column<DateTime>(nullable: false),
                    numberGallons = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    pricePaid = table.Column<decimal>(type: "decimal(18,4)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FuelRecordModels", x => x.FuelRecordModelId);
                });

            migrationBuilder.InsertData(
                table: "FuelRecordModels",
                columns: new[] { "FuelRecordModelId", "datePurchased", "mileage", "numberGallons", "pricePaid" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, 0m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FuelRecordModels");
        }
    }
}
