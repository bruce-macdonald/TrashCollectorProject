using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class updatedPropertiesAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MyProperty",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3dc683b6-b2d0-4dec-8643-dcbf85a7fe39",
                column: "ConcurrencyStamp",
                value: "5e8d250b-7ccf-45a8-ab9f-352c1c4d573d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7e273606-8c4a-451c-969e-48a12762bc70",
                column: "ConcurrencyStamp",
                value: "c10f7264-7e0f-4389-b524-8e1e37af4da7");
        }
    }
}
