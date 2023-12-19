using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ETicaret.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Description", "Name", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 12, 19, 15, 30, 18, 667, DateTimeKind.Local).AddTicks(5910), "Amerikan Ürünü BOYKOTLUDUR.", "Iphone 15 Pro Max", 10 },
                    { 2, 3, new DateTime(2023, 12, 19, 15, 30, 18, 667, DateTimeKind.Local).AddTicks(5923), "Kışlık kazak", "Kazak", 10 },
                    { 3, 1, new DateTime(2023, 12, 19, 15, 30, 18, 667, DateTimeKind.Local).AddTicks(5925), "Çin ürünüdür.", "Xioami Mi 10T Pro", 10 },
                    { 4, 2, new DateTime(2023, 12, 19, 15, 30, 18, 667, DateTimeKind.Local).AddTicks(5926), "Çin ürünüdür.", "Yağ 5 LT", 10 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Elektronik" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Gıda" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Tekstil" });
        }
    }
}
