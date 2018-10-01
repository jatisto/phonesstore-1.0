using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyFirstMVC.Migrations
{
    public partial class MadeRatingModelAndmadeStarforjson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RatingModelsDB");

            migrationBuilder.CreateTable(
                name: "RatingModels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Star = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RatingModels", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "RatingModels",
                columns: new[] { "Id", "Star" },
                values: new object[,]
                {
                    { 1, "★" },
                    { 2, "★★" },
                    { 3, "★★★" },
                    { 4, "★★★★" },
                    { 5, "★★★★★" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RatingModels");

            migrationBuilder.CreateTable(
                name: "RatingModelsDB",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RatingModelsDB", x => x.Id);
                });
        }
    }
}
