using Microsoft.EntityFrameworkCore.Migrations;

namespace MyFirstMVC.Migrations
{
    public partial class ChangeNameDataTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "_dataCreatCompany",
                table: "Companies",
                newName: "_dataCreateCompany");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "_dataCreateCompany",
                table: "Companies",
                newName: "_dataCreatCompany");
        }
    }
}
