using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FurniFusion_E_Commerce_.Migrations
{
    /// <inheritdoc />
    public partial class Roles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "647bb4eb-87db-49b6-93f6-46e937a7561e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b5e146aa-65d2-4d90-a925-38956fb7f2b8");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5c6ac9e6-1828-435a-b366-c2e9a145f31a", null, "user", "USER" },
                    { "792285f9-1c57-43be-8dcb-7b0b49053b52", null, "productManager", "PRODUCTMANAGER" },
                    { "799e5115-421d-4e03-a087-c8df9bbf83bc", null, "moderator", "MODERATOR" },
                    { "84b8b165-d386-4d24-8702-b5057c36db1f", null, "contentCreator", "CONTENTCREATOR" },
                    { "87ef5634-49de-423b-b002-b101a85a728a", null, "superAdmin", "SUPERADMIN" },
                    { "a95f8868-68c5-4da9-9fe8-148fde6d7a8e", null, "marketingManager", "MARKETINGMANAGER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5c6ac9e6-1828-435a-b366-c2e9a145f31a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "792285f9-1c57-43be-8dcb-7b0b49053b52");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "799e5115-421d-4e03-a087-c8df9bbf83bc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "84b8b165-d386-4d24-8702-b5057c36db1f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "87ef5634-49de-423b-b002-b101a85a728a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a95f8868-68c5-4da9-9fe8-148fde6d7a8e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "647bb4eb-87db-49b6-93f6-46e937a7561e", null, "admin", "ADMIN" },
                    { "b5e146aa-65d2-4d90-a925-38956fb7f2b8", null, "user", "USER" }
                });
        }
    }
}
