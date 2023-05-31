using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebShop.Migrations
{
    /// <inheritdoc />
    public partial class AddedTotalOrderAmount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<decimal>(
                name: "TotalOrderAmount",
                table: "Orders",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dffbd448-aabc-4129-8408-1492496cfc45", "AQAAAAIAAYagAAAAEBkdZtTkgUz+SA7ORKxrZBT82tbeKyCiKJF9mhp0TGJXD6C32LXr4FFWtfJcrTeqRg==", "12ba6c37-65e5-4e8c-9119-e6b2f4c77f94" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "IsAdmin", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "19e1e14b-8b59-4524-9b5d-d513dc04901c", 0, "af630c81-83c1-4acb-8888-aee7cc1153ad", "kalle@havenoemail.com", true, "Karl", true, "Karlsson", false, null, "KALLE@HAVENOEMAIL.COM", "KALLE@HAVENOEMAIL.COM", "AQAAAAIAAYagAAAAEG3OEw9HiONCMXcY55xgSdrfcpjl1nrCBr4dYOz5tV+qi0Cu5qTXNuwjQv1nvpnpBg==", null, false, "56996d7a-81f0-454e-8725-009482dbecb4", false, "kalle@havenoemail.com" });

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 1,
                column: "ProductId",
                value: new Guid("28c843cc-f564-415c-a99a-d3eb914d3fa9"));

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 2,
                column: "ProductId",
                value: new Guid("dbf2a727-33ef-44de-8d43-b2be2db1dd29"));

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 3,
                column: "ProductId",
                value: new Guid("20c7199e-ee10-40d2-b4dc-d73d19336065"));

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 4,
                column: "ProductId",
                value: new Guid("28c843cc-f564-415c-a99a-d3eb914d3fa9"));

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 5,
                column: "ProductId",
                value: new Guid("20c7199e-ee10-40d2-b4dc-d73d19336065"));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                columns: new[] { "OrderedAt", "TotalOrderAmount" },
                values: new object[] { new DateTime(2023, 5, 30, 3, 9, 5, 822, DateTimeKind.Local).AddTicks(7776), 0m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                columns: new[] { "OrderedAt", "TotalOrderAmount" },
                values: new object[] { new DateTime(2023, 5, 30, 3, 9, 5, 822, DateTimeKind.Local).AddTicks(7830), 0m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3,
                columns: new[] { "OrderedAt", "TotalOrderAmount" },
                values: new object[] { new DateTime(2023, 5, 30, 3, 9, 5, 822, DateTimeKind.Local).AddTicks(7833), 0m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductDisctiption", "ProductName", "ProductPrice" },
                values: new object[,]
                {
                    { new Guid("20c7199e-ee10-40d2-b4dc-d73d19336065"), "Fruit", "Apple", 3m },
                    { new Guid("28c843cc-f564-415c-a99a-d3eb914d3fa9"), "Drink", "Pepsi", 10m },
                    { new Guid("dbf2a727-33ef-44de-8d43-b2be2db1dd29"), "Meat", "Pork", 97m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19e1e14b-8b59-4524-9b5d-d513dc04901c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("20c7199e-ee10-40d2-b4dc-d73d19336065"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("28c843cc-f564-415c-a99a-d3eb914d3fa9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("dbf2a727-33ef-44de-8d43-b2be2db1dd29"));

            migrationBuilder.DropColumn(
                name: "TotalOrderAmount",
                table: "Orders");

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
                column: "OrderedAt",
                value: new DateTime(2023, 5, 29, 19, 54, 9, 351, DateTimeKind.Local).AddTicks(1102));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "OrderedAt",
                value: new DateTime(2023, 5, 29, 19, 54, 9, 351, DateTimeKind.Local).AddTicks(1146));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3,
                column: "OrderedAt",
                value: new DateTime(2023, 5, 29, 19, 54, 9, 351, DateTimeKind.Local).AddTicks(1149));

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
    }
}
