using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class madeExtraPickupDayPropertyNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "55c55dfe-2918-4244-a52f-7f156adaf836");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a80e9bf0-8373-4e58-aa89-f3af8e184789");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExtraPickupDay",
                table: "Customers",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3dc683b6-b2d0-4dec-8643-dcbf85a7fe39", "5e8d250b-7ccf-45a8-ab9f-352c1c4d573d", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7e273606-8c4a-451c-969e-48a12762bc70", "c10f7264-7e0f-4389-b524-8e1e37af4da7", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3dc683b6-b2d0-4dec-8643-dcbf85a7fe39");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7e273606-8c4a-451c-969e-48a12762bc70");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExtraPickupDay",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a80e9bf0-8373-4e58-aa89-f3af8e184789", "47b64a14-f873-4746-b8ff-8ecf17deb517", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "55c55dfe-2918-4244-a52f-7f156adaf836", "16a17b03-e84c-42d9-9451-9eed5a1d397d", "Employee", "EMPLOYEE" });
        }
    }
}
