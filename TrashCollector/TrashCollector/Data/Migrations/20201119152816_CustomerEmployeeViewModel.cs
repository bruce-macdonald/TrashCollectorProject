using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class CustomerEmployeeViewModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3dc683b6-b2d0-4dec-8643-dcbf85a7fe39",
                column: "ConcurrencyStamp",
                value: "781d984d-1bf0-4cf9-800c-bdd0db7d49dd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7e273606-8c4a-451c-969e-48a12762bc70",
                column: "ConcurrencyStamp",
                value: "10f166bf-b4fd-42b0-ae30-58951e1a7a86");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3dc683b6-b2d0-4dec-8643-dcbf85a7fe39",
                column: "ConcurrencyStamp",
                value: "8f67a4f8-d19b-4532-8f06-10586f3552fa");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7e273606-8c4a-451c-969e-48a12762bc70",
                column: "ConcurrencyStamp",
                value: "8636c5e2-49e7-48d6-9e66-05448564d09a");
        }
    }
}
