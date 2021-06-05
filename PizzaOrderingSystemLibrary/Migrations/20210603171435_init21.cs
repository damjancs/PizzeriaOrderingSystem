using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaOrderingSystemLibrary.Migrations
{
    public partial class init21 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DishAddition_OrderItem_OrderItemModelId",
                table: "DishAddition");

            migrationBuilder.DropIndex(
                name: "IX_DishAddition_OrderItemModelId",
                table: "DishAddition");

            migrationBuilder.DropColumn(
                name: "OrderItemModelId",
                table: "DishAddition");

            migrationBuilder.AddColumn<string>(
                name: "DishAdditions",
                table: "OrderItem",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DishAdditions",
                table: "OrderItem");

            migrationBuilder.AddColumn<int>(
                name: "OrderItemModelId",
                table: "DishAddition",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DishAddition_OrderItemModelId",
                table: "DishAddition",
                column: "OrderItemModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_DishAddition_OrderItem_OrderItemModelId",
                table: "DishAddition",
                column: "OrderItemModelId",
                principalTable: "OrderItem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
