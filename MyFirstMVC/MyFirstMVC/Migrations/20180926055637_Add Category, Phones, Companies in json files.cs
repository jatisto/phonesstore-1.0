using Microsoft.EntityFrameworkCore.Migrations;

namespace MyFirstMVC.Migrations
{
    public partial class AddCategoryPhonesCompaniesinjsonfiles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "iOS");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Android OS");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "ParentCategoryId" },
                values: new object[] { 3, "BlackBerry OS", null });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 4, "Xiaomi" },
                    { 5, "LG" },
                    { 6, "Huawei" },
                    { 7, "Sony" },
                    { 8, "BlackBerry" },
                    { 9, "Philips" }
                });

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Apple iPhone 7 256Gb Red", 74.4 });

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "CompanyId", "Name", "Price" },
                values: new object[] { 1, 1, "Apple iPhone 6S (Space Grey, 32GB)", 30.5 });

            migrationBuilder.InsertData(
                table: "Phones",
                columns: new[] { "Id", "CategoryId", "CompanyId", "Name", "Price" },
                values: new object[,]
                {
                    { 3, 1, 1, "Apple iPhone X (Space Grey, 256GB)", 99.999 },
                    { 4, 2, 2, "Samsung On7 Pro (Gold)", 7.99 },
                    { 5, 2, 2, "Samsung Galaxy On7 Prime (Gold, 4GB RAM + 64GB Memory)", 13.99 },
                    { 12, 2, 3, "Nokia 6.1 (2018) (4GB + 64GB, Blue-Gold)", 15.95 }
                });

            migrationBuilder.InsertData(
                table: "Phones",
                columns: new[] { "Id", "CategoryId", "CompanyId", "Name", "Price" },
                values: new object[,]
                {
                    { 6, 2, 4, "Redmi 6 Pro (Black, 32GB)", 11.499 },
                    { 7, 2, 4, "Redmi Y2 (Rose Gold, 32GB)", 9.999 },
                    { 8, 2, 5, "LG Q6 (Black, 18:9 FullVision Display)", 11.82 },
                    { 9, 2, 5, "LG V30+ (18:9 OLED FullVisionTM, 128GB, Black)", 34.963 },
                    { 11, 2, 6, "Huawei P20 Pro Blue (40MP Leica Triple Camera, 6GB+128GB)", 64.999 },
                    { 13, 2, 7, "Sony Xperia R1 Plus Dual SIM (Black)", 11.899 },
                    { 10, 3, 8, "BlackBerry Passport 32GB (White)", 26.999 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "IOS");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Android");

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Iphone 4", 200.0 });

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "CompanyId", "Name", "Price" },
                values: new object[] { 2, 2, "Xperia", 100.0 });
        }
    }
}
