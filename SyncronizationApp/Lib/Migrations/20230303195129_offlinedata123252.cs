using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lib.Migrations
{
    /// <inheritdoc />
    public partial class offlinedata123252 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DataEntries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DeviceName = table.Column<string>(type: "TEXT", nullable: false),
                    DeviceType = table.Column<string>(type: "TEXT", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UOM1 = table.Column<string>(type: "TEXT", nullable: false),
                    UOM1Value = table.Column<double>(type: "REAL", nullable: false),
                    UOM2 = table.Column<string>(type: "TEXT", nullable: false),
                    UOM2Value = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataEntries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Synchronizations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RecordsAdded = table.Column<int>(type: "INTEGER", nullable: false),
                    TimeSynced = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Synchronizations", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DataEntries");

            migrationBuilder.DropTable(
                name: "Synchronizations");
        }
    }
}
