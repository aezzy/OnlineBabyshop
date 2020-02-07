using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineBabyshop.Migrations
{
    public partial class zzzzzzmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Total",
                table: "ShoppingCartItems");

            migrationBuilder.AddColumn<decimal>(
                name: "OrderTotal",
                table: "ShoppingCartItems",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderTotal",
                table: "ShoppingCartItems");

            migrationBuilder.AddColumn<decimal>(
                name: "Total",
                table: "ShoppingCartItems",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
