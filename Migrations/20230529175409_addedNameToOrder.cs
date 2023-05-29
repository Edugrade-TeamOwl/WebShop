using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebShop.Migrations
{
    /// <inheritdoc />
    public partial class addedNameToOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "622bb628-c10a-4b13-a5e6-fc94ba0f02f1", "AQAAAAIAAYagAAAAEEk5THcFRjhkqlee25GZJ6H0bF68epLTzQfQSHvoNtwc8jn/kjxhKRQ3JwMXAyhvww==", "9728778d-0779-49dd-85a7-2cbe23e43c45" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "IsAdmin", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "743fce31-3649-4314-8631-7dce26d3bd4b", 0, "66217584-3a01-48f7-b15d-82d5ddd5048c", "kalle@havenoemail.com", true, "Karl", true, "Karlsson", false, null, "KALLE@HAVENOEMAIL.COM", "KALLE@HAVENOEMAIL.COM", "AQAAAAIAAYagAAAAEKF5a1fQCXoj2yEKjplZG5CbvVrGFkoqAdzgRJitRIRitkBNIw1Osg5dc0bv2QWq/Q==", null, false, "0e5ef78b-9d24-4e9c-a03f-0b07726c1bb5", false, "kalle@havenoemail.com" });

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 1,
                column: "ProductId",
                value: new Guid("f81606c5-09fe-4a0f-80c5-7f5273232857"));

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 2,
                column: "ProductId",
                value: new Guid("f37cfd7e-037d-4cbc-bab3-99d53975e354"));

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 3,
                column: "ProductId",
                value: new Guid("a27d2247-c0d4-488a-9c6d-297217ea433b"));

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 4,
                column: "ProductId",
                value: new Guid("f81606c5-09fe-4a0f-80c5-7f5273232857"));

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 5,
                column: "ProductId",
                value: new Guid("a27d2247-c0d4-488a-9c6d-297217ea433b"));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                columns: new[] { "FirstName", "LastName", "OrderedAt" },
                values: new object[] { "Jens", "Jensson", new DateTime(2023, 5, 29, 19, 54, 9, 351, DateTimeKind.Local).AddTicks(1102) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                columns: new[] { "FirstName", "LastName", "OrderedAt" },
                values: new object[] { "Jens", "Jensson", new DateTime(2023, 5, 29, 19, 54, 9, 351, DateTimeKind.Local).AddTicks(1146) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3,
                columns: new[] { "FirstName", "LastName", "OrderedAt" },
                values: new object[] { "Jens", "Jensson", new DateTime(2023, 5, 29, 19, 54, 9, 351, DateTimeKind.Local).AddTicks(1149) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductDisctiption", "ProductName", "ProductPrice" },
                values: new object[,]
                {
                    { new Guid("a27d2247-c0d4-488a-9c6d-297217ea433b"), "Fruit", "Apple", 3m },
                    { new Guid("f37cfd7e-037d-4cbc-bab3-99d53975e354"), "Meat", "Pork", 97m },
                    { new Guid("f81606c5-09fe-4a0f-80c5-7f5273232857"), "Drink", "Pepsi", 10m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "743fce31-3649-4314-8631-7dce26d3bd4b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a27d2247-c0d4-488a-9c6d-297217ea433b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f37cfd7e-037d-4cbc-bab3-99d53975e354"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f81606c5-09fe-4a0f-80c5-7f5273232857"));

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d6e59941-12b4-40ab-a77b-efccf91ff9e7", "AQAAAAIAAYagAAAAEFyZJwtvBX0YfEFnDOUZD++fHxcyfu6AiKzXzpFe3Q47osHy9fk1UY/DZ+Hxm1Zorg==", "0c561c29-bebc-46cb-84a9-68a19f5b426b" });

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
    }
}
