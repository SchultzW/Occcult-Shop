using Microsoft.EntityFrameworkCore.Migrations;

namespace OccultShop.Migrations
{
    public partial class _6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CartItemID",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Carts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Products_CartItemID",
                table: "Products",
                column: "CartItemID");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_CartItems_CartItemID",
                table: "Products",
                column: "CartItemID",
                principalTable: "CartItems",
                principalColumn: "CartItemID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_CartItems_CartItemID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CartItemID",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CartItemID",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Carts");
        }
    }
}
