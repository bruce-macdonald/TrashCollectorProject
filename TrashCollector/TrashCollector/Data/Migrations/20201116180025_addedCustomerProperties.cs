using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class addedCustomerProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "acfd5290-f06e-4a2e-9a24-f9e7198fad4e", "c2b22743-ec31-44d2-b89a-03da96d92e59", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "27e91fc1-2dcc-4189-ba9c-889d1032fe8a", "3b352abd-ec5e-44a9-b182-89880cc11a01", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "27e91fc1-2dcc-4189-ba9c-889d1032fe8a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "acfd5290-f06e-4a2e-9a24-f9e7198fad4e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8e8f3842-2ad4-41f0-a1f5-853fa103a02f", "b2751a18-9d85-451f-98e6-a1291f79527b", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "17dca538-a03e-4f30-8cc6-b936790d7cc4", "169f7037-3af9-458a-8537-573d01d0ed3f", "Employee", "EMPLOYEE" });
        }
    }
}
