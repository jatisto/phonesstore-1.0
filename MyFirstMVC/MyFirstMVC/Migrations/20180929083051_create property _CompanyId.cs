using Microsoft.EntityFrameworkCore.Migrations;

namespace MyFirstMVC.Migrations
{
    public partial class createproperty_CompanyId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "_CompanyId",
                table: "Companies",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Companies__CompanyId",
                table: "Companies",
                column: "_CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_Companies__CompanyId",
                table: "Companies",
                column: "_CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companies_Companies__CompanyId",
                table: "Companies");

            migrationBuilder.DropIndex(
                name: "IX_Companies__CompanyId",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "_CompanyId",
                table: "Companies");
        }
    }
}
