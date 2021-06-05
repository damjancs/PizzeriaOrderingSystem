using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaOrderingSystemLibrary.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DishAddition_DishModel_DishModelId",
                table: "DishAddition");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DishModel",
                table: "DishModel");

            migrationBuilder.RenameTable(
                name: "DishModel",
                newName: "Dish");

            migrationBuilder.AddColumn<int>(
                name: "OrderModelId",
                table: "OrderItem",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dish",
                table: "Dish",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_OrderModelId",
                table: "OrderItem",
                column: "OrderModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_DishAddition_Dish_DishModelId",
                table: "DishAddition",
                column: "DishModelId",
                principalTable: "Dish",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_Order_OrderModelId",
                table: "OrderItem",
                column: "OrderModelId",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DishAddition_Dish_DishModelId",
                table: "DishAddition");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_Order_OrderModelId",
                table: "OrderItem");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropIndex(
                name: "IX_OrderItem_OrderModelId",
                table: "OrderItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Dish",
                table: "Dish");

            migrationBuilder.DropColumn(
                name: "OrderModelId",
                table: "OrderItem");

            migrationBuilder.RenameTable(
                name: "Dish",
                newName: "DishModel");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DishModel",
                table: "DishModel",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DishAddition_DishModel_DishModelId",
                table: "DishAddition",
                column: "DishModelId",
                principalTable: "DishModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
