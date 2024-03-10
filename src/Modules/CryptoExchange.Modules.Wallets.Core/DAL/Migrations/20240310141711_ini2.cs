using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CryptoExchange.Modules.Wallets.Core.DAL.Migrations
{
    /// <inheritdoc />
    public partial class ini2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WalletAdress",
                schema: "wallet",
                table: "Wallets");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalSaldo",
                schema: "wallet",
                table: "Wallets",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double precision");

            migrationBuilder.AddColumn<string>(
                name: "WalletAddress",
                schema: "wallet",
                table: "Wallets",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WalletAddress",
                schema: "wallet",
                table: "Wallets");

            migrationBuilder.AlterColumn<double>(
                name: "TotalSaldo",
                schema: "wallet",
                table: "Wallets",
                type: "double precision",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AddColumn<string>(
                name: "WalletAdress",
                schema: "wallet",
                table: "Wallets",
                type: "text",
                nullable: true);
        }
    }
}
