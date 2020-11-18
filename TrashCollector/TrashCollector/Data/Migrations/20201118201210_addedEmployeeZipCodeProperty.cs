using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class addedEmployeeZipCodeProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ZipCode",
                table: "Employees",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ZipCode",
                table: "Employees");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3dc683b6-b2d0-4dec-8643-dcbf85a7fe39",
                column: "ConcurrencyStamp",
                value: "02d03c05-560d-4dc3-a72e-45c42be1980c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7e273606-8c4a-451c-969e-48a12762bc70",
                column: "ConcurrencyStamp",
                value: "df30d03f-075c-4d3e-b86d-8a11145052ca");
        }
    }
}
