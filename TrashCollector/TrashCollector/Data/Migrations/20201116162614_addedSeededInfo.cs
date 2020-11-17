using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class addedSeededInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b0387862-012e-4d8d-bd07-452acc4f2f94");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1a9c943e-2700-4029-858c-6631e3dfc49a", "4a31984c-6fc0-4793-9eba-db798ce33883", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1a9c943e-2700-4029-858c-6631e3dfc49a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b0387862-012e-4d8d-bd07-452acc4f2f94", "c12d59dd-a890-4044-92c4-3eb7f3a1abb3", "Admin", "ADMIN" });
        }
    }
}
