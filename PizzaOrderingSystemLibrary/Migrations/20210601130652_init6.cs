using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaOrderingSystemLibrary.Migrations
{
    public partial class init6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DishId",
                table: "OrderItem",
                newName: "Quantity");

            migrationBuilder.AddColumn<string>(
                name: "DishName",
                table: "OrderItem",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DishName",
                table: "OrderItem");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "OrderItem",
                newName: "DishId");
        }
    }
}
