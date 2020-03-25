using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab1.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cPUDtos",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CpuTypes = table.Column<int>(nullable: false),
                    UsingPover = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cPUDtos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "motherboardDtos",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UsingPover = table.Column<int>(nullable: false),
                    CPUTypes = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_motherboardDtos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "powerSupplyDtos",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UsingPover = table.Column<int>(nullable: false),
                    Volume = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_powerSupplyDtos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "rAMDtos",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UsingPover = table.Column<int>(nullable: false),
                    RAMTypes = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rAMDtos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "systemUnitDtos",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MaxPoverSupplyVolume = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    MotherboardTypes = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_systemUnitDtos", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cPUDtos");

            migrationBuilder.DropTable(
                name: "motherboardDtos");

            migrationBuilder.DropTable(
                name: "powerSupplyDtos");

            migrationBuilder.DropTable(
                name: "rAMDtos");

            migrationBuilder.DropTable(
                name: "systemUnitDtos");
        }
    }
}
