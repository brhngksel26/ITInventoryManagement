using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ITInventoryManagement.Migrations
{
    /// <inheritdoc />
    public partial class LastMigrate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6c571f74-80d6-4248-a788-6819e51815a6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a83918c2-e190-4f11-858c-23d3b393e51d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c7046158-d605-4059-87b2-b9ce740e0439");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "41e77c96-bad0-4bf5-bb0f-4f68796d35be", null, "IT Staff", null },
                    { "6128b320-d292-4c2b-86b8-c183036d3603", null, "Standart Account", "standart_account" },
                    { "62daec9e-c700-41fd-b62c-1db301308727", null, "Admin", "it_staff " }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 20, 14, 28, 43, 644, DateTimeKind.Local).AddTicks(7929), new DateTime(2024, 8, 20, 14, 28, 43, 644, DateTimeKind.Local).AddTicks(7941) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 20, 14, 28, 43, 644, DateTimeKind.Local).AddTicks(7943), new DateTime(2024, 8, 20, 14, 28, 43, 644, DateTimeKind.Local).AddTicks(7944) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 20, 14, 28, 43, 644, DateTimeKind.Local).AddTicks(7946), new DateTime(2024, 8, 20, 14, 28, 43, 644, DateTimeKind.Local).AddTicks(7946) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 20, 14, 28, 43, 644, DateTimeKind.Local).AddTicks(7948), new DateTime(2024, 8, 20, 14, 28, 43, 644, DateTimeKind.Local).AddTicks(7948) });

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PurchaseDate", "UpdatedAt", "WarrantyExpiryDate" },
                values: new object[] { new DateTime(2024, 8, 20, 14, 28, 43, 644, DateTimeKind.Local).AddTicks(7997), new DateTime(2023, 8, 20, 14, 28, 43, 644, DateTimeKind.Local).AddTicks(7985), new DateTime(2024, 8, 20, 14, 28, 43, 644, DateTimeKind.Local).AddTicks(7998), new DateTime(2025, 8, 20, 14, 28, 43, 644, DateTimeKind.Local).AddTicks(7992) });

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PurchaseDate", "UpdatedAt", "WarrantyExpiryDate" },
                values: new object[] { new DateTime(2024, 8, 20, 14, 28, 43, 644, DateTimeKind.Local).AddTicks(8004), new DateTime(2023, 10, 20, 14, 28, 43, 644, DateTimeKind.Local).AddTicks(8001), new DateTime(2024, 8, 20, 14, 28, 43, 644, DateTimeKind.Local).AddTicks(8004), new DateTime(2025, 10, 20, 14, 28, 43, 644, DateTimeKind.Local).AddTicks(8002) });

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "PurchaseDate", "UpdatedAt", "WarrantyExpiryDate" },
                values: new object[] { new DateTime(2024, 8, 20, 14, 28, 43, 644, DateTimeKind.Local).AddTicks(8009), new DateTime(2023, 12, 20, 14, 28, 43, 644, DateTimeKind.Local).AddTicks(8007), new DateTime(2024, 8, 20, 14, 28, 43, 644, DateTimeKind.Local).AddTicks(8010), new DateTime(2025, 12, 20, 14, 28, 43, 644, DateTimeKind.Local).AddTicks(8008) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "41e77c96-bad0-4bf5-bb0f-4f68796d35be");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6128b320-d292-4c2b-86b8-c183036d3603");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "62daec9e-c700-41fd-b62c-1db301308727");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6c571f74-80d6-4248-a788-6819e51815a6", null, "Standart Account", "standart_account" },
                    { "a83918c2-e190-4f11-858c-23d3b393e51d", null, "Admin", "it_staff " },
                    { "c7046158-d605-4059-87b2-b9ce740e0439", null, "IT Staff", null }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 20, 13, 3, 39, 562, DateTimeKind.Local).AddTicks(7418), new DateTime(2024, 8, 20, 13, 3, 39, 562, DateTimeKind.Local).AddTicks(7432) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 20, 13, 3, 39, 562, DateTimeKind.Local).AddTicks(7434), new DateTime(2024, 8, 20, 13, 3, 39, 562, DateTimeKind.Local).AddTicks(7435) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 20, 13, 3, 39, 562, DateTimeKind.Local).AddTicks(7436), new DateTime(2024, 8, 20, 13, 3, 39, 562, DateTimeKind.Local).AddTicks(7437) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 20, 13, 3, 39, 562, DateTimeKind.Local).AddTicks(7439), new DateTime(2024, 8, 20, 13, 3, 39, 562, DateTimeKind.Local).AddTicks(7440) });

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PurchaseDate", "UpdatedAt", "WarrantyExpiryDate" },
                values: new object[] { new DateTime(2024, 8, 20, 13, 3, 39, 562, DateTimeKind.Local).AddTicks(7493), new DateTime(2023, 8, 20, 13, 3, 39, 562, DateTimeKind.Local).AddTicks(7477), new DateTime(2024, 8, 20, 13, 3, 39, 562, DateTimeKind.Local).AddTicks(7494), new DateTime(2025, 8, 20, 13, 3, 39, 562, DateTimeKind.Local).AddTicks(7484) });

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PurchaseDate", "UpdatedAt", "WarrantyExpiryDate" },
                values: new object[] { new DateTime(2024, 8, 20, 13, 3, 39, 562, DateTimeKind.Local).AddTicks(7499), new DateTime(2023, 10, 20, 13, 3, 39, 562, DateTimeKind.Local).AddTicks(7496), new DateTime(2024, 8, 20, 13, 3, 39, 562, DateTimeKind.Local).AddTicks(7500), new DateTime(2025, 10, 20, 13, 3, 39, 562, DateTimeKind.Local).AddTicks(7497) });

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "PurchaseDate", "UpdatedAt", "WarrantyExpiryDate" },
                values: new object[] { new DateTime(2024, 8, 20, 13, 3, 39, 562, DateTimeKind.Local).AddTicks(7505), new DateTime(2023, 12, 20, 13, 3, 39, 562, DateTimeKind.Local).AddTicks(7502), new DateTime(2024, 8, 20, 13, 3, 39, 562, DateTimeKind.Local).AddTicks(7506), new DateTime(2025, 12, 20, 13, 3, 39, 562, DateTimeKind.Local).AddTicks(7503) });
        }
    }
}
