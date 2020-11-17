using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class updatedCustomerProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "1aa4a088-18e1-4e83-8c9d-334a3d2ad9d9", "d19abd14-6122-4f75-8ec4-fcaeeadb25a2", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7352b466-758e-4216-bd00-db532884708d", "b3d27271-c9cd-4aad-a8e1-14f1f217aa68", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1aa4a088-18e1-4e83-8c9d-334a3d2ad9d9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7352b466-758e-4216-bd00-db532884708d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "acfd5290-f06e-4a2e-9a24-f9e7198fad4e", "c2b22743-ec31-44d2-b89a-03da96d92e59", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "27e91fc1-2dcc-4189-ba9c-889d1032fe8a", "3b352abd-ec5e-44a9-b182-89880cc11a01", "Employee", "EMPLOYEE" });
        }
    }
}
