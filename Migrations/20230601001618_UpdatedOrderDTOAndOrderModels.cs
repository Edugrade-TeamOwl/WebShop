using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebShop.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedOrderDTOAndOrderModels : Migration
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
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ce6ca554-8558-42e8-b82e-efe72655b881", "AQAAAAIAAYagAAAAEIrLvRx26UaP1SJ8y2SmyZz9pRC2w1h5RMxkSpR2tvojMzY2eHSf0u/NzUqZVNsaIw==", "3aaf0664-2dbc-46dc-82bd-27d3694fa776" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "IsAdmin", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3b623207-8337-4773-9174-23e6e42d5d16", 0, "0de67663-0ef0-425e-ae92-9922731e623d", "kalle@havenoemail.com", true, "Karl", true, "Karlsson", false, null, "KALLE@HAVENOEMAIL.COM", "KALLE@HAVENOEMAIL.COM", "AQAAAAIAAYagAAAAEOg9n63NzWbUBK+cglBayBQdG2sO/TOiKsolVAWZ44iP3bSm26qMh4ZTMNMUEKAK3A==", null, false, "56972a48-9960-438e-ba88-9a4398d387c9", false, "kalle@havenoemail.com" });

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 1,
                column: "ProductId",
                value: new Guid("0a6aec7b-f03e-420e-a27d-36704aa71b1f"));

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 2,
                column: "ProductId",
                value: new Guid("0a318485-e17a-4fa9-9b19-a40dc465c23e"));

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 3,
                column: "ProductId",
                value: new Guid("e333b34d-2024-47c0-a48c-532786de3b56"));

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 4,
                column: "ProductId",
                value: new Guid("0a6aec7b-f03e-420e-a27d-36704aa71b1f"));

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 5,
                column: "ProductId",
                value: new Guid("e333b34d-2024-47c0-a48c-532786de3b56"));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                columns: new[] { "OrderedAt", "TotalOrderAmount" },
                values: new object[] { new DateTime(2023, 6, 1, 2, 16, 18, 559, DateTimeKind.Local).AddTicks(4265), 0m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                columns: new[] { "OrderedAt", "TotalOrderAmount" },
                values: new object[] { new DateTime(2023, 6, 1, 2, 16, 18, 559, DateTimeKind.Local).AddTicks(4315), 0m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3,
                columns: new[] { "OrderedAt", "TotalOrderAmount" },
                values: new object[] { new DateTime(2023, 6, 1, 2, 16, 18, 559, DateTimeKind.Local).AddTicks(4318), 0m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductDisctiption", "ProductName", "ProductPrice" },
                values: new object[,]
                {
                    { new Guid("0a318485-e17a-4fa9-9b19-a40dc465c23e"), "Meat", "Pork", 97m },
                    { new Guid("0a6aec7b-f03e-420e-a27d-36704aa71b1f"), "Drink", "Pepsi", 10m },
                    { new Guid("e333b34d-2024-47c0-a48c-532786de3b56"), "Fruit", "Apple", 3m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b623207-8337-4773-9174-23e6e42d5d16");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("0a318485-e17a-4fa9-9b19-a40dc465c23e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("0a6aec7b-f03e-420e-a27d-36704aa71b1f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e333b34d-2024-47c0-a48c-532786de3b56"));

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
