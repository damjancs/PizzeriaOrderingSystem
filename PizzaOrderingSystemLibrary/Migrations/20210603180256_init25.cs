using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaOrderingSystemLibrary.Migrations
{
    public partial class init25 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_Order_OrderModelId",
                table: "OrderItem");

            migrationBuilder.DropIndex(
                name: "IX_OrderItem_OrderModelId",
                table: "OrderItem");

            migrationBuilder.DropColumn(
                name: "OrderModelId",
                table: "OrderItem");

            migrationBuilder.AddColumn<string>(
                name: "OrderItems",
                table: "Order",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderedItemId",
                table: "Order",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Order_OrderedItemId",
                table: "Order",
                column: "OrderedItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_OrderItem_OrderedItemId",
                table: "Order",
                column: "OrderedItemId",
                principalTable: "OrderItem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_OrderItem_OrderedItemId",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_OrderedItemId",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "OrderItems",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "OrderedItemId",
                table: "Order");

            migrationBuilder.AddColumn<int>(
                name: "OrderModelId",
                table: "OrderItem",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_OrderModelId",
                table: "OrderItem",
                column: "OrderModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_Order_OrderModelId",
                table: "OrderItem",
                column: "OrderModelId",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
