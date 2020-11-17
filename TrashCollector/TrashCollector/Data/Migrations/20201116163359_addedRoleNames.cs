using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class addedRoleNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1a9c943e-2700-4029-858c-6631e3dfc49a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8e8f3842-2ad4-41f0-a1f5-853fa103a02f", "b2751a18-9d85-451f-98e6-a1291f79527b", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "17dca538-a03e-4f30-8cc6-b936790d7cc4", "169f7037-3af9-458a-8537-573d01d0ed3f", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "17dca538-a03e-4f30-8cc6-b936790d7cc4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8e8f3842-2ad4-41f0-a1f5-853fa103a02f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1a9c943e-2700-4029-858c-6631e3dfc49a", "4a31984c-6fc0-4793-9eba-db798ce33883", "Admin", "ADMIN" });
        }
    }
}
