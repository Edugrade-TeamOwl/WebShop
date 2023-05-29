using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebShop.Migrations
{
    /// <inheritdoc />
    public partial class addedMoreData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aff2190b-85fb-40b9-a752-423960748e4c", "AQAAAAIAAYagAAAAEN5rtp6ubz4Pb7lHV7gv2TVV2KQfs0N4UxJrp4RLJi0uvWcDP6fHsxBjzliZIF4+GA==", "13a91933-fd38-41d6-a1d5-11562022b486" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "IsAdmin", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "eda54eeb-1409-4a68-9a84-c2d231eb716f", 0, "d7f63850-891d-491f-949c-4d942fd02760", "kalle@havenoemail.com", true, "Karl", true, "Karlsson", false, null, "KALLE@HAVENOEMAIL.COM", "OWNER", "AQAAAAIAAYagAAAAEOdZSi+/qZPkIssqxS9fhXbl9b9AQpzY+87r49Ibnib+5cY86s0H3uMnLTraE4UFuA==", null, false, "b3e17025-43b6-4081-b780-34a1c7ef0dcd", false, "Owner" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "Adress", "City", "OrderedAt", "UserId", "ZipCode" },
                values: new object[,]
                {
                    { 1, "testvägen1", "teststaden", new DateTime(2023, 5, 25, 16, 25, 8, 569, DateTimeKind.Local).AddTicks(6326), "1", "123 45" },
                    { 2, "testvägen1", "teststaden", new DateTime(2023, 5, 25, 16, 25, 8, 569, DateTimeKind.Local).AddTicks(6370), "1", "123 45" },
                    { 3, "testvägen1", "teststaden", new DateTime(2023, 5, 25, 16, 25, 8, 569, DateTimeKind.Local).AddTicks(6373), "1", "123 45" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductDisctiption", "ProductName", "ProductPrice" },
                values: new object[,]
                {
                    { new Guid("01c708fe-ffba-4537-99b0-5788ffd1edf0"), "Meat", "Pork", 97m },
                    { new Guid("4cb67407-0437-4bc6-abd0-0d2dea6d6e91"), "Drink", "Pepsi", 10m },
                    { new Guid("8948c2b5-7db0-4034-9d43-312065565262"), "Fruit", "Apple", 3m }
                });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "OrderDetailId", "OrderId", "ProductId", "ProductQuantity" },
                values: new object[,]
                {
                    { 1, 1, new Guid("4cb67407-0437-4bc6-abd0-0d2dea6d6e91"), 2 },
                    { 2, 1, new Guid("01c708fe-ffba-4537-99b0-5788ffd1edf0"), 5 },
                    { 3, 1, new Guid("8948c2b5-7db0-4034-9d43-312065565262"), 4 },
                    { 4, 2, new Guid("4cb67407-0437-4bc6-abd0-0d2dea6d6e91"), 1 },
                    { 5, 3, new Guid("8948c2b5-7db0-4034-9d43-312065565262"), 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eda54eeb-1409-4a68-9a84-c2d231eb716f");

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("01c708fe-ffba-4537-99b0-5788ffd1edf0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4cb67407-0437-4bc6-abd0-0d2dea6d6e91"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("8948c2b5-7db0-4034-9d43-312065565262"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d8b80286-c2c3-4b98-b397-0ec1cbb6956a", "AQAAAAIAAYagAAAAEMM4bKL7v8u7twDfCCjsWJZ9/d72XRYw7nerM/9iiarKDqteW0h1A48QXwjNRmj53g==", "e98e0e03-723e-421f-b8ea-20e8de1d7eeb" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "IsAdmin", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d6a439be-be7e-48eb-af32-392ea276781a", 0, "7d9f7b05-ca13-4d94-9444-e789d025a2c7", "kalle@havenoemail.com", true, "Karl", true, "Karlsson", false, null, "KALLE@HAVENOEMAIL.COM", "OWNER", "AQAAAAIAAYagAAAAEEMeeE5AUwopsiUApiPYkFAgWmHnb3TvA1PSZr+wInL6TknA7WuCWVrrBLmNg5JNKQ==", null, false, "47f8e505-0074-4962-ae1a-778662ed9375", false, "Owner" });

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
    }
}
