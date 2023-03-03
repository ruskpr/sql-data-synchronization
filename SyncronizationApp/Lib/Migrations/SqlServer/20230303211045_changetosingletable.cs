using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lib.Migrations.SqlServer
{
    /// <inheritdoc />
    public partial class changetosingletable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeviceTypes");

            migrationBuilder.DropTable(
                name: "UnitsOfMeasure1");

            migrationBuilder.DropTable(
                name: "UnitsOfMeasure2");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
