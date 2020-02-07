using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineBabyshop.Migrations
{
    public partial class amigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_ShoppingCartItems_ShoppingCartItemsId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Order_OrderId",
                table: "OrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_Order_ShoppingCartItemsId",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "AddressLine1",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "AddressLine2",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "OrderPlaced",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "OrderTotal",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "State",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "ZipCode",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "ShoppingCartItemsId",
                table: "Order");

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "ShoppingCartItems",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ShoppingCartItemsId",
                table: "OrderDetails",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "AddressLine1",
                table: "Order",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AddressLine2",
                table: "Order",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Order",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Order",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Order",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Order",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "OrderPlaced",
                table: "Order",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<decimal>(
                name: "OrderTotal",
                table: "Order",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Order",
                maxLength: 25,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Order",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ZipCode",
                table: "Order",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_OrderId",
                table: "ShoppingCartItems",
                column: "OrderId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCartItems_Order_OrderId",
                table: "ShoppingCartItems",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_ShoppingCartItems_ShoppingCartItemsId",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCartItems_Order_OrderId",
                table: "ShoppingCartItems");

            migrationBuilder.DropIndex(
                name: "IX_ShoppingCartItems_OrderId",
                table: "ShoppingCartItems");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_ShoppingCartItemsId",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "ShoppingCartItems");

            migrationBuilder.DropColumn(
                name: "ShoppingCartItemsId",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "AddressLine1",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "AddressLine2",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "OrderPlaced",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "OrderTotal",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "ZipCode",
                table: "Order");

            migrationBuilder.AddColumn<string>(
                name: "AddressLine1",
                table: "OrderDetails",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AddressLine2",
                table: "OrderDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "OrderDetails",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "OrderDetails",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "OrderDetails",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "OrderDetails",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "OrderDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "OrderPlaced",
                table: "OrderDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<decimal>(
                name: "OrderTotal",
                table: "OrderDetails",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "OrderDetails",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "OrderDetails",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ZipCode",
                table: "OrderDetails",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ShoppingCartItemsId",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Order_OrderId",
                table: "OrderDetails",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
