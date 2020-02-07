using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineBabyshop.Migrations
{
    public partial class bbmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCartItems_Order_OrderId",
                table: "ShoppingCartItems");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_ShoppingCartItems_OrderId",
                table: "ShoppingCartItems");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "ShoppingCartItems");

            migrationBuilder.AddColumn<int>(
                name: "ShoppingCartItemsId",
                table: "Order",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Order_ShoppingCartItemsId",
                table: "Order",
                column: "ShoppingCartItemsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_ShoppingCartItems_ShoppingCartItemsId",
                table: "Order",
                column: "ShoppingCartItemsId",
                principalTable: "ShoppingCartItems",
                principalColumn: "ShoppingCartItemsId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_ShoppingCartItems_ShoppingCartItemsId",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_ShoppingCartItemsId",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "ShoppingCartItemsId",
                table: "Order");

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "ShoppingCartItems",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderDetailsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShoppingCartItemsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderDetailsId);
                    table.ForeignKey(
                        name: "FK_OrderDetails_ShoppingCartItems_ShoppingCartItemsId",
                        column: x => x.ShoppingCartItemsId,
                        principalTable: "ShoppingCartItems",
                        principalColumn: "ShoppingCartItemsId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_OrderId",
                table: "ShoppingCartItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ShoppingCartItemsId",
                table: "OrderDetails",
                column: "ShoppingCartItemsId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCartItems_Order_OrderId",
                table: "ShoppingCartItems",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
