using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebShop.Migrations
{
    /// <inheritdoc />
    public partial class updatednames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1d949963-60f1-43dc-bdf0-658ef2ffd201");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("325770d8-4cac-4169-bcca-3126e522f0bd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("6ccd68f9-e073-4955-a01c-6e8096666a36"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b5e996d1-7b19-47f2-a88b-3454138ca674"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "d6e59941-12b4-40ab-a77b-efccf91ff9e7", "JENS@HAVENOEMAIL.COM", "AQAAAAIAAYagAAAAEFyZJwtvBX0YfEFnDOUZD++fHxcyfu6AiKzXzpFe3Q47osHy9fk1UY/DZ+Hxm1Zorg==", "0c561c29-bebc-46cb-84a9-68a19f5b426b", "jens@havenoemail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "IsAdmin", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3309d8e1-7f58-49cc-a125-a7345315831a", 0, "2f290534-c96b-4fbc-9cdf-d138022fa98e", "kalle@havenoemail.com", true, "Karl", true, "Karlsson", false, null, "KALLE@HAVENOEMAIL.COM", "KALLE@HAVENOEMAIL.COM", "AQAAAAIAAYagAAAAEPXOBt+K8FNSLXv9OcGFdUQlxeUV+ejqIXm+vCWIeD+wwL/q9Swxr5KsHBkDlcYVFA==", null, false, "4ecf603d-0f78-4294-90d4-bcc87a7fdf4e", false, "kalle@havenoemail.com" });

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 1,
                column: "ProductId",
                value: new Guid("387f5f0b-2dfa-4ddb-b088-b5803f1b8c46"));

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 2,
                column: "ProductId",
                value: new Guid("ef6b200f-7f2a-4b16-adb6-7030e9a8a297"));

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 3,
                column: "ProductId",
                value: new Guid("89bd722f-ac7c-4b13-b02e-6f172ad02b5c"));

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 4,
                column: "ProductId",
                value: new Guid("387f5f0b-2dfa-4ddb-b088-b5803f1b8c46"));

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 5,
                column: "ProductId",
                value: new Guid("89bd722f-ac7c-4b13-b02e-6f172ad02b5c"));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "OrderedAt",
                value: new DateTime(2023, 5, 29, 19, 47, 1, 953, DateTimeKind.Local).AddTicks(1590));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "OrderedAt",
                value: new DateTime(2023, 5, 29, 19, 47, 1, 953, DateTimeKind.Local).AddTicks(1641));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3,
                column: "OrderedAt",
                value: new DateTime(2023, 5, 29, 19, 47, 1, 953, DateTimeKind.Local).AddTicks(1644));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductDisctiption", "ProductName", "ProductPrice" },
                values: new object[,]
                {
                    { new Guid("387f5f0b-2dfa-4ddb-b088-b5803f1b8c46"), "Drink", "Pepsi", 10m },
                    { new Guid("89bd722f-ac7c-4b13-b02e-6f172ad02b5c"), "Fruit", "Apple", 3m },
                    { new Guid("ef6b200f-7f2a-4b16-adb6-7030e9a8a297"), "Meat", "Pork", 97m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3309d8e1-7f58-49cc-a125-a7345315831a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("387f5f0b-2dfa-4ddb-b088-b5803f1b8c46"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("89bd722f-ac7c-4b13-b02e-6f172ad02b5c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("ef6b200f-7f2a-4b16-adb6-7030e9a8a297"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "a5909157-ea51-4916-9f2e-e22d8185e026", "USER", "AQAAAAIAAYagAAAAEBq2W9d/pCSmngqdgmP1GMmXCrnM5CuPmUm4htPsHktbmKdxP2+O4ZXQMeZPo8XJGA==", "317a6f0b-82af-41f1-97f4-3f9afda2c4fb", "User" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "IsAdmin", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1d949963-60f1-43dc-bdf0-658ef2ffd201", 0, "0c745132-e48c-4189-bc08-24365c542563", "kalle@havenoemail.com", true, "Karl", true, "Karlsson", false, null, "KALLE@HAVENOEMAIL.COM", "OWNER", "AQAAAAIAAYagAAAAEEaglHEaC8peV4UDBI7j1yzodkhOr37QS/+zi8OoEcKEZYwByxbusVE92SasrN+L7Q==", null, false, "de0981d6-f76d-48a0-a089-f70a2daf7e33", false, "Owner" });

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 1,
                column: "ProductId",
                value: new Guid("b5e996d1-7b19-47f2-a88b-3454138ca674"));

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 2,
                column: "ProductId",
                value: new Guid("6ccd68f9-e073-4955-a01c-6e8096666a36"));

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 3,
                column: "ProductId",
                value: new Guid("325770d8-4cac-4169-bcca-3126e522f0bd"));

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 4,
                column: "ProductId",
                value: new Guid("b5e996d1-7b19-47f2-a88b-3454138ca674"));

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 5,
                column: "ProductId",
                value: new Guid("325770d8-4cac-4169-bcca-3126e522f0bd"));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "OrderedAt",
                value: new DateTime(2023, 5, 27, 15, 48, 40, 467, DateTimeKind.Local).AddTicks(3544));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "OrderedAt",
                value: new DateTime(2023, 5, 27, 15, 48, 40, 467, DateTimeKind.Local).AddTicks(3594));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3,
                column: "OrderedAt",
                value: new DateTime(2023, 5, 27, 15, 48, 40, 467, DateTimeKind.Local).AddTicks(3596));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductDisctiption", "ProductName", "ProductPrice" },
                values: new object[,]
                {
                    { new Guid("325770d8-4cac-4169-bcca-3126e522f0bd"), "Fruit", "Apple", 3m },
                    { new Guid("6ccd68f9-e073-4955-a01c-6e8096666a36"), "Meat", "Pork", 97m },
                    { new Guid("b5e996d1-7b19-47f2-a88b-3454138ca674"), "Drink", "Pepsi", 10m }
                });
        }
    }
}
