using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineBabyshop.Migrations
{
    public partial class zzzmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Total",
                table: "ShoppingCartItems",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Total",
                table: "ShoppingCartItems");
        }
    }
}
