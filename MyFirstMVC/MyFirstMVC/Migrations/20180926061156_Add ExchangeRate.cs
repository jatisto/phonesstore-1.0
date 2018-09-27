using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyFirstMVC.Migrations
{
    public partial class AddExchangeRate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExchangeRates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    _currencyCode = table.Column<string>(nullable: true),
                    _currencyName = table.Column<string>(nullable: true),
                    _currencyRate = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExchangeRates", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "_currencyCode", "_currencyName", "_currencyRate" },
                values: new object[] { 1, "RUB", "Рубль", 57.0 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "_currencyCode", "_currencyName", "_currencyRate" },
                values: new object[] { 2, "KGS", "Сом", 68.0 });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "_currencyCode", "_currencyName", "_currencyRate" },
                values: new object[] { 3, "EUR", "Евро", 80.99 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExchangeRates");
        }
    }
}
