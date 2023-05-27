using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebShop.Migrations
{
    /// <inheritdoc />
    public partial class namenullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eda54eeb-1409-4a68-9a84-c2d231eb716f");

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

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.CreateTable(
                name: "ShoppingCart",
                columns: table => new
                {
                    ShoppingCartId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCart", x => x.ShoppingCartId);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a5909157-ea51-4916-9f2e-e22d8185e026", "AQAAAAIAAYagAAAAEBq2W9d/pCSmngqdgmP1GMmXCrnM5CuPmUm4htPsHktbmKdxP2+O4ZXQMeZPo8XJGA==", "317a6f0b-82af-41f1-97f4-3f9afda2c4fb" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShoppingCart");

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

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

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

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 1,
                column: "ProductId",
                value: new Guid("4cb67407-0437-4bc6-abd0-0d2dea6d6e91"));

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 2,
                column: "ProductId",
                value: new Guid("01c708fe-ffba-4537-99b0-5788ffd1edf0"));

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 3,
                column: "ProductId",
                value: new Guid("8948c2b5-7db0-4034-9d43-312065565262"));

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 4,
                column: "ProductId",
                value: new Guid("4cb67407-0437-4bc6-abd0-0d2dea6d6e91"));

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 5,
                column: "ProductId",
                value: new Guid("8948c2b5-7db0-4034-9d43-312065565262"));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "OrderedAt",
                value: new DateTime(2023, 5, 25, 16, 25, 8, 569, DateTimeKind.Local).AddTicks(6326));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "OrderedAt",
                value: new DateTime(2023, 5, 25, 16, 25, 8, 569, DateTimeKind.Local).AddTicks(6370));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3,
                column: "OrderedAt",
                value: new DateTime(2023, 5, 25, 16, 25, 8, 569, DateTimeKind.Local).AddTicks(6373));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductDisctiption", "ProductName", "ProductPrice" },
                values: new object[,]
                {
                    { new Guid("01c708fe-ffba-4537-99b0-5788ffd1edf0"), "Meat", "Pork", 97m },
                    { new Guid("4cb67407-0437-4bc6-abd0-0d2dea6d6e91"), "Drink", "Pepsi", 10m },
                    { new Guid("8948c2b5-7db0-4034-9d43-312065565262"), "Fruit", "Apple", 3m }
                });
        }
    }
}
