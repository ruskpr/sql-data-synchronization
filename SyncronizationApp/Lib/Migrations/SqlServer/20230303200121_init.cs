using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lib.Migrations.SqlServer
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DataEntries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeviceName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeviceType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UOM1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UOM1Value = table.Column<double>(type: "float", nullable: false),
                    UOM2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UOM2Value = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataEntries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeviceTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Synchronizations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecordsAdded = table.Column<int>(type: "int", nullable: false),
                    TimeSynced = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Synchronizations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UnitsOfMeasure1",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnitOfMeasure = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitsOfMeasure1", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UnitsOfMeasure2",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnitOfMeasure = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitsOfMeasure2", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DataEntries");

            migrationBuilder.DropTable(
                name: "DeviceTypes");

            migrationBuilder.DropTable(
                name: "Synchronizations");

            migrationBuilder.DropTable(
                name: "UnitsOfMeasure1");

            migrationBuilder.DropTable(
                name: "UnitsOfMeasure2");
        }
    }
}
