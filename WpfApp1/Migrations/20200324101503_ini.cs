using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab1.Migrations
{
    public partial class ini : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MotherboardTypes",
                table: "motherboardDtos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RAMType",
                table: "motherboardDtos",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MotherboardTypes",
                table: "motherboardDtos");

            migrationBuilder.DropColumn(
                name: "RAMType",
                table: "motherboardDtos");
        }
    }
}
