using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CryptoExchange.Modules.Users.Core.Migrations
{
    public partial class roles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "09dddde2-2d5f-435d-bf62-a85da497695a", "18370df8-62ea-4287-8c0a-21c54886b32b", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "415fdc61-2619-4ebf-b994-e6e3f91b24d7", "069f3bfa-c678-4712-8314-056c386e17e3", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "09dddde2-2d5f-435d-bf62-a85da497695a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "415fdc61-2619-4ebf-b994-e6e3f91b24d7");
        }
    }
}
