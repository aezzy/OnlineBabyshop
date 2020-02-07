using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineBabyshop.Migrations
{
    public partial class UpdatedOrderDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_ShoppingCartItems_ShoppingCartItemsId",
                table: "OrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_ShoppingCartItemsId",
                table: "OrderDetails");

            migrationBuilder.AddColumn<int>(
                name: "OrderDetailsId",
                table: "ShoppingCartItems",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_OrderDetailsId",
                table: "ShoppingCartItems",
                column: "OrderDetailsId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCartItems_OrderDetails_OrderDetailsId",
                table: "ShoppingCartItems",
                column: "OrderDetailsId",
                principalTable: "OrderDetails",
                principalColumn: "OrderDetailsId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCartItems_OrderDetails_OrderDetailsId",
                table: "ShoppingCartItems");

            migrationBuilder.DropIndex(
                name: "IX_ShoppingCartItems_OrderDetailsId",
                table: "ShoppingCartItems");

            migrationBuilder.DropColumn(
                name: "OrderDetailsId",
                table: "ShoppingCartItems");

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
    }
}
