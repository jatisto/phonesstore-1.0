using Microsoft.EntityFrameworkCore.Migrations;

namespace MyFirstMVC.Migrations
{
    public partial class Addpropertyquantityrfomphonescs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Quantity",
                table: "Phones",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 1,
                column: "Quantity",
                value: 15);

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 2,
                column: "Quantity",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 3,
                column: "Quantity",
                value: 25);

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 4,
                column: "Quantity",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 5,
                column: "Quantity",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 6,
                column: "Quantity",
                value: 13);

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 7,
                column: "Quantity",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 8,
                column: "Quantity",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 9,
                column: "Quantity",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 10,
                column: "Quantity",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 11,
                column: "Quantity",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 12,
                column: "Quantity",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 13,
                column: "Quantity",
                value: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Quantity",
                table: "Phones",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 1,
                column: "Quantity",
                value: false);

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 2,
                column: "Quantity",
                value: false);

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 3,
                column: "Quantity",
                value: false);

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 4,
                column: "Quantity",
                value: false);

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 5,
                column: "Quantity",
                value: false);

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 6,
                column: "Quantity",
                value: false);

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 7,
                column: "Quantity",
                value: false);

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 8,
                column: "Quantity",
                value: false);

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 9,
                column: "Quantity",
                value: false);

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 10,
                column: "Quantity",
                value: false);

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 11,
                column: "Quantity",
                value: false);

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 12,
                column: "Quantity",
                value: false);

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 13,
                column: "Quantity",
                value: false);
        }
    }
}
