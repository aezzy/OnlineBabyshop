using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineBabyshop.Migrations
{
    public partial class ddmigraton : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCartItems_Product_ProductId",
                table: "ShoppingCartItems");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "ShoppingCartItems",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "ShoppingCartItems",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ProductName",
                table: "ShoppingCartItems",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCartItems_Product_ProductId",
                table: "ShoppingCartItems",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCartItems_Product_ProductId",
                table: "ShoppingCartItems");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "ShoppingCartItems");

            migrationBuilder.DropColumn(
                name: "ProductName",
                table: "ShoppingCartItems");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "ShoppingCartItems",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCartItems_Product_ProductId",
                table: "ShoppingCartItems",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
