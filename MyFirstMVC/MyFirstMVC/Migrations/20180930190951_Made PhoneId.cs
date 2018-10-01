using Microsoft.EntityFrameworkCore.Migrations;

namespace MyFirstMVC.Migrations
{
    public partial class MadePhoneId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PhoneId",
                table: "RatingModels",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RatingModels_PhoneId",
                table: "RatingModels",
                column: "PhoneId");

            migrationBuilder.AddForeignKey(
                name: "FK_RatingModels_Phones_PhoneId",
                table: "RatingModels",
                column: "PhoneId",
                principalTable: "Phones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RatingModels_Phones_PhoneId",
                table: "RatingModels");

            migrationBuilder.DropIndex(
                name: "IX_RatingModels_PhoneId",
                table: "RatingModels");

            migrationBuilder.DropColumn(
                name: "PhoneId",
                table: "RatingModels");
        }
    }
}
