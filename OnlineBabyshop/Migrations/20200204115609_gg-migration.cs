using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineBabyshop.Migrations
{
    public partial class ggmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ShoppingCartItemsId",
                table: "OrderDetails",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ShoppingCartItemsId",
                table: "OrderDetails",
                column: "ShoppingCartItemsId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_ShoppingCartItems_ShoppingCartItemsId",
                table: "OrderDetails",
                column: "ShoppingCartItemsId",
                principalTable: "ShoppingCartItems",
                principalColumn: "ShoppingCartItemsId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_ShoppingCartItems_ShoppingCartItemsId",
                table: "OrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_ShoppingCartItemsId",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "ShoppingCartItemsId",
                table: "OrderDetails");
        }
    }
}
