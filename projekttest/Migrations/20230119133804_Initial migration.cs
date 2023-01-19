using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projekttest.Migrations
{
    public partial class Initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "calculators",
                columns: table => new
                {
                    calculatorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Number1 = table.Column<double>(type: "float", nullable: false),
                    Number2 = table.Column<double>(type: "float", nullable: false),
                    result = table.Column<double>(type: "float", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_calculators", x => x.calculatorID);
                });

            migrationBuilder.CreateTable(
                name: "RPSGAMEs",
                columns: table => new
                {
                    rpsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Scoure = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RPSGAMEs", x => x.rpsID);
                });

            migrationBuilder.CreateTable(
                name: "shapes",
                columns: table => new
                {
                    shapeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Area = table.Column<double>(type: "float", nullable: false),
                    Perimeter = table.Column<double>(type: "float", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shapes", x => x.shapeID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "calculators");

            migrationBuilder.DropTable(
                name: "RPSGAMEs");

            migrationBuilder.DropTable(
                name: "shapes");
        }
    }
}
