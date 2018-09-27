using Microsoft.EntityFrameworkCore.Migrations;

namespace MyFirstMVC.Migrations
{
    public partial class Addphonestockjson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PhonesOnStocks",
                columns: new[] { "PhoneId", "StockId", "Quantity" },
                values: new object[,]
                {
                    { 1, 2, 15 },
                    { 3, 1, 25 },
                    { 4, 3, 0 },
                    { 7, 2, 40 },
                    { 6, 1, 33 },
                    { 5, 3, 55 },
                    { 2, 2, 75 },
                    { 9, 1, 25 },
                    { 8, 3, 30 },
                    { 10, 3, 7 },
                    { 12, 2, 24 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PhonesOnStocks",
                keyColumns: new[] { "PhoneId", "StockId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "PhonesOnStocks",
                keyColumns: new[] { "PhoneId", "StockId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "PhonesOnStocks",
                keyColumns: new[] { "PhoneId", "StockId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "PhonesOnStocks",
                keyColumns: new[] { "PhoneId", "StockId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "PhonesOnStocks",
                keyColumns: new[] { "PhoneId", "StockId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "PhonesOnStocks",
                keyColumns: new[] { "PhoneId", "StockId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "PhonesOnStocks",
                keyColumns: new[] { "PhoneId", "StockId" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "PhonesOnStocks",
                keyColumns: new[] { "PhoneId", "StockId" },
                keyValues: new object[] { 8, 3 });

            migrationBuilder.DeleteData(
                table: "PhonesOnStocks",
                keyColumns: new[] { "PhoneId", "StockId" },
                keyValues: new object[] { 9, 1 });

            migrationBuilder.DeleteData(
                table: "PhonesOnStocks",
                keyColumns: new[] { "PhoneId", "StockId" },
                keyValues: new object[] { 10, 3 });

            migrationBuilder.DeleteData(
                table: "PhonesOnStocks",
                keyColumns: new[] { "PhoneId", "StockId" },
                keyValues: new object[] { 12, 2 });
        }
    }
}
