using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ITInventoryManagement.Migrations
{
    /// <inheritdoc />
    public partial class AddRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "71264b6a-2d8c-4287-ac36-213bbad3e50d", null, "Admin", "it_staff " },
                    { "ba45be05-dcf5-4e8d-b411-4c40100ac3fa", null, "Standart Account", "standart_account" },
                    { "d58dd9e4-4c8e-4bf0-82bf-194c268eb8e8", null, "IT Staff", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71264b6a-2d8c-4287-ac36-213bbad3e50d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba45be05-dcf5-4e8d-b411-4c40100ac3fa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d58dd9e4-4c8e-4bf0-82bf-194c268eb8e8");
        }
    }
}
