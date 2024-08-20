using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ITInventoryManagement.Migrations
{
    /// <inheritdoc />
    public partial class AddAssigmentAndLoan : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Assignments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InventoryItemId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AssignedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReturnedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsReturned = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assignments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Assignments_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Assignments_InventoryItems_InventoryItemId",
                        column: x => x.InventoryItemId,
                        principalTable: "InventoryItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Loans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InventoryItemId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoanedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReturnedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsReturned = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Loans_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Loans_InventoryItems_InventoryItemId",
                        column: x => x.InventoryItemId,
                        principalTable: "InventoryItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Assignments_InventoryItemId",
                table: "Assignments",
                column: "InventoryItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Assignments_UserId",
                table: "Assignments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Loans_InventoryItemId",
                table: "Loans",
                column: "InventoryItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Loans_UserId",
                table: "Loans",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assignments");

            migrationBuilder.DropTable(
                name: "Loans");

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
                    { "5354ae83-3218-4669-9707-dd861991762e", null, "Admin", "it_staff " },
                    { "78a6375f-9f85-4c5e-95c0-25ece12b1d9b", null, "Standart Account", "standart_account" },
                    { "904ba18c-6c27-4ff7-9888-bceb8bd128f4", null, "IT Staff", null }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 20, 12, 33, 45, 632, DateTimeKind.Local).AddTicks(476), new DateTime(2024, 8, 20, 12, 33, 45, 632, DateTimeKind.Local).AddTicks(490) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 20, 12, 33, 45, 632, DateTimeKind.Local).AddTicks(492), new DateTime(2024, 8, 20, 12, 33, 45, 632, DateTimeKind.Local).AddTicks(492) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 20, 12, 33, 45, 632, DateTimeKind.Local).AddTicks(494), new DateTime(2024, 8, 20, 12, 33, 45, 632, DateTimeKind.Local).AddTicks(495) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 20, 12, 33, 45, 632, DateTimeKind.Local).AddTicks(496), new DateTime(2024, 8, 20, 12, 33, 45, 632, DateTimeKind.Local).AddTicks(496) });

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PurchaseDate", "UpdatedAt", "WarrantyExpiryDate" },
                values: new object[] { new DateTime(2024, 8, 20, 12, 33, 45, 632, DateTimeKind.Local).AddTicks(534), new DateTime(2023, 8, 20, 12, 33, 45, 632, DateTimeKind.Local).AddTicks(523), new DateTime(2024, 8, 20, 12, 33, 45, 632, DateTimeKind.Local).AddTicks(534), new DateTime(2025, 8, 20, 12, 33, 45, 632, DateTimeKind.Local).AddTicks(529) });

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PurchaseDate", "UpdatedAt", "WarrantyExpiryDate" },
                values: new object[] { new DateTime(2024, 8, 20, 12, 33, 45, 632, DateTimeKind.Local).AddTicks(539), new DateTime(2023, 10, 20, 12, 33, 45, 632, DateTimeKind.Local).AddTicks(536), new DateTime(2024, 8, 20, 12, 33, 45, 632, DateTimeKind.Local).AddTicks(540), new DateTime(2025, 10, 20, 12, 33, 45, 632, DateTimeKind.Local).AddTicks(537) });

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "PurchaseDate", "UpdatedAt", "WarrantyExpiryDate" },
                values: new object[] { new DateTime(2024, 8, 20, 12, 33, 45, 632, DateTimeKind.Local).AddTicks(543), new DateTime(2023, 12, 20, 12, 33, 45, 632, DateTimeKind.Local).AddTicks(541), new DateTime(2024, 8, 20, 12, 33, 45, 632, DateTimeKind.Local).AddTicks(544), new DateTime(2025, 12, 20, 12, 33, 45, 632, DateTimeKind.Local).AddTicks(542) });
        }
    }
}
