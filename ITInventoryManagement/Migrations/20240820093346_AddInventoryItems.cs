using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ITInventoryManagement.Migrations
{
    /// <inheritdoc />
    public partial class AddInventoryItems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "493d7f4e-d1c3-4eba-90b6-7f2a4b2f2da1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7a5e6246-9302-49e2-a71f-e20bd2d31bcd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dc8c95e4-ea92-495b-aba0-feb4299f08fe");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5354ae83-3218-4669-9707-dd861991762e", null, "Admin", "it_staff " },
                    { "78a6375f-9f85-4c5e-95c0-25ece12b1d9b", null, "Standart Account", "standart_account" },
                    { "904ba18c-6c27-4ff7-9888-bceb8bd128f4", null, "IT Staff", null }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 20, 12, 33, 45, 632, DateTimeKind.Local).AddTicks(476), null, "Laptops", new DateTime(2024, 8, 20, 12, 33, 45, 632, DateTimeKind.Local).AddTicks(490) },
                    { 2, new DateTime(2024, 8, 20, 12, 33, 45, 632, DateTimeKind.Local).AddTicks(492), null, "Monitors", new DateTime(2024, 8, 20, 12, 33, 45, 632, DateTimeKind.Local).AddTicks(492) },
                    { 3, new DateTime(2024, 8, 20, 12, 33, 45, 632, DateTimeKind.Local).AddTicks(494), null, "Keyboards", new DateTime(2024, 8, 20, 12, 33, 45, 632, DateTimeKind.Local).AddTicks(495) },
                    { 4, new DateTime(2024, 8, 20, 12, 33, 45, 632, DateTimeKind.Local).AddTicks(496), null, "Mice", new DateTime(2024, 8, 20, 12, 33, 45, 632, DateTimeKind.Local).AddTicks(496) }
                });

            migrationBuilder.InsertData(
                table: "InventoryItems",
                columns: new[] { "Id", "Brand", "CategoryId", "CreatedAt", "DeletedAt", "IsAssigned", "IsLoaned", "Model", "Name", "PurchaseDate", "SerialNumber", "StockQuantity", "UpdatedAt", "WarrantyExpiryDate" },
                values: new object[,]
                {
                    { 1, "Dell", 1, new DateTime(2024, 8, 20, 12, 33, 45, 632, DateTimeKind.Local).AddTicks(534), null, false, false, "XPS 13", "Dell XPS 13", new DateTime(2023, 8, 20, 12, 33, 45, 632, DateTimeKind.Local).AddTicks(523), "DXPS13-001", 5, new DateTime(2024, 8, 20, 12, 33, 45, 632, DateTimeKind.Local).AddTicks(534), new DateTime(2025, 8, 20, 12, 33, 45, 632, DateTimeKind.Local).AddTicks(529) },
                    { 2, "Samsung", 2, new DateTime(2024, 8, 20, 12, 33, 45, 632, DateTimeKind.Local).AddTicks(539), null, false, false, "UltraWide 49", "Samsung UltraWide Monitor", new DateTime(2023, 10, 20, 12, 33, 45, 632, DateTimeKind.Local).AddTicks(536), "SUM-002", 3, new DateTime(2024, 8, 20, 12, 33, 45, 632, DateTimeKind.Local).AddTicks(540), new DateTime(2025, 10, 20, 12, 33, 45, 632, DateTimeKind.Local).AddTicks(537) },
                    { 3, "Logitech", 4, new DateTime(2024, 8, 20, 12, 33, 45, 632, DateTimeKind.Local).AddTicks(543), null, false, false, "MX Master 3", "Logitech MX Master 3", new DateTime(2023, 12, 20, 12, 33, 45, 632, DateTimeKind.Local).AddTicks(541), "LMXM3-003", 10, new DateTime(2024, 8, 20, 12, 33, 45, 632, DateTimeKind.Local).AddTicks(544), new DateTime(2025, 12, 20, 12, 33, 45, 632, DateTimeKind.Local).AddTicks(542) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5354ae83-3218-4669-9707-dd861991762e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "78a6375f-9f85-4c5e-95c0-25ece12b1d9b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "904ba18c-6c27-4ff7-9888-bceb8bd128f4");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "493d7f4e-d1c3-4eba-90b6-7f2a4b2f2da1", null, "Admin", "it_staff " },
                    { "7a5e6246-9302-49e2-a71f-e20bd2d31bcd", null, "IT Staff", null },
                    { "dc8c95e4-ea92-495b-aba0-feb4299f08fe", null, "Standart Account", "standart_account" }
                });
        }
    }
}
