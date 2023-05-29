using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebShop.Migrations
{
    /// <inheritdoc />
    public partial class addedTestData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "IsAdmin", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, "d8b80286-c2c3-4b98-b397-0ec1cbb6956a", "jens@havenoemail.com", true, "Jens", false, "Jensson", false, null, "JENS@HAVENOEMAIL.COM", "USER", "AQAAAAIAAYagAAAAEMM4bKL7v8u7twDfCCjsWJZ9/d72XRYw7nerM/9iiarKDqteW0h1A48QXwjNRmj53g==", null, false, "e98e0e03-723e-421f-b8ea-20e8de1d7eeb", false, "User" },
                    { "d6a439be-be7e-48eb-af32-392ea276781a", 0, "7d9f7b05-ca13-4d94-9444-e789d025a2c7", "kalle@havenoemail.com", true, "Karl", true, "Karlsson", false, null, "KALLE@HAVENOEMAIL.COM", "OWNER", "AQAAAAIAAYagAAAAEEMeeE5AUwopsiUApiPYkFAgWmHnb3TvA1PSZr+wInL6TknA7WuCWVrrBLmNg5JNKQ==", null, false, "47f8e505-0074-4962-ae1a-778662ed9375", false, "Owner" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductDisctiption", "ProductName", "ProductPrice" },
                values: new object[,]
                {
                    { new Guid("0ad13427-560a-4e59-b789-dc64b0ca921d"), "Drink", "Pepsi", 10m },
                    { new Guid("5c8a3193-15a6-43f2-918c-6721fa585c5a"), "Meat", "Pork", 97m },
                    { new Guid("bc18846d-3114-4c67-bb64-1d78bb56ae4a"), "Fruit", "Apple", 3m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d6a439be-be7e-48eb-af32-392ea276781a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("0ad13427-560a-4e59-b789-dc64b0ca921d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("5c8a3193-15a6-43f2-918c-6721fa585c5a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("bc18846d-3114-4c67-bb64-1d78bb56ae4a"));
        }
    }
}
