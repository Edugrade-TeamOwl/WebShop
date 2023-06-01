using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebShop.Migrations
{
    /// <inheritdoc />
    public partial class newUpdates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cfc73e4f-8a3b-450a-aece-eab1f9889b6a", "AQAAAAIAAYagAAAAEEzhKWzym+TC4XstDVA2C9kXfjXDNeks487yPJmh7KfQE78VgKdPFYKMWKuD5fH1VQ==", "10151d7f-dfbe-471b-98b4-e733ff8d6583" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "IsAdmin", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c5a20759-a248-4a97-acc0-e221a8c267a0", 0, "39e9a715-93ea-449a-9c61-adde5b604266", "kalle@havenoemail.com", true, "Karl", true, "Karlsson", false, null, "KALLE@HAVENOEMAIL.COM", "KALLE@HAVENOEMAIL.COM", "AQAAAAIAAYagAAAAEPQHLKFFlEnNdmHhT/SgCrdK+Dkg/6UzxAgrnz2SgKNYGRQQJJq+K2wDSm44zF+4nQ==", null, false, "38eb77e9-1e37-4a80-975e-38a568baea64", false, "kalle@havenoemail.com" });

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 1,
                column: "ProductId",
                value: new Guid("0197f662-96e2-492d-919d-a875ebd710ee"));

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 2,
                column: "ProductId",
                value: new Guid("150826a4-4082-4e3e-928c-5b7a5eda21cb"));

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 3,
                column: "ProductId",
                value: new Guid("9f103b49-5eee-46d2-bfe3-5f2e491d70be"));

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 4,
                column: "ProductId",
                value: new Guid("0197f662-96e2-492d-919d-a875ebd710ee"));

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 5,
                column: "ProductId",
                value: new Guid("9f103b49-5eee-46d2-bfe3-5f2e491d70be"));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "OrderedAt",
                value: new DateTime(2023, 6, 1, 13, 7, 18, 15, DateTimeKind.Local).AddTicks(9457));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "OrderedAt",
                value: new DateTime(2023, 6, 1, 13, 7, 18, 15, DateTimeKind.Local).AddTicks(9499));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3,
                column: "OrderedAt",
                value: new DateTime(2023, 6, 1, 13, 7, 18, 15, DateTimeKind.Local).AddTicks(9501));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductDisctiption", "ProductName", "ProductPrice" },
                values: new object[,]
                {
                    { new Guid("0197f662-96e2-492d-919d-a875ebd710ee"), "Drink", "Pepsi", 10m },
                    { new Guid("150826a4-4082-4e3e-928c-5b7a5eda21cb"), "Meat", "Pork", 97m },
                    { new Guid("9f103b49-5eee-46d2-bfe3-5f2e491d70be"), "Fruit", "Apple", 3m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c5a20759-a248-4a97-acc0-e221a8c267a0");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("0197f662-96e2-492d-919d-a875ebd710ee"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("150826a4-4082-4e3e-928c-5b7a5eda21cb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("9f103b49-5eee-46d2-bfe3-5f2e491d70be"));

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
                column: "OrderedAt",
                value: new DateTime(2023, 6, 1, 2, 16, 18, 559, DateTimeKind.Local).AddTicks(4265));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "OrderedAt",
                value: new DateTime(2023, 6, 1, 2, 16, 18, 559, DateTimeKind.Local).AddTicks(4315));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3,
                column: "OrderedAt",
                value: new DateTime(2023, 6, 1, 2, 16, 18, 559, DateTimeKind.Local).AddTicks(4318));

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
    }
}
