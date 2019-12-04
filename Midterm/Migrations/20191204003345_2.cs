using Microsoft.EntityFrameworkCore.Migrations;

namespace OccultShop.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Products_ProductId",
                table: "Reviews");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "Reviews",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReviewId1",
                table: "Reviews",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CartId1",
                table: "Carts",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CartItemId",
                table: "Carts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ReviewId1",
                table: "Reviews",
                column: "ReviewId1");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_CartId1",
                table: "Carts",
                column: "CartId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Carts_CartId1",
                table: "Carts",
                column: "CartId1",
                principalTable: "Carts",
                principalColumn: "CartId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Products_ProductId",
                table: "Reviews",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Reviews_ReviewId1",
                table: "Reviews",
                column: "ReviewId1",
                principalTable: "Reviews",
                principalColumn: "ReviewId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Carts_CartId1",
                table: "Carts");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Products_ProductId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Reviews_ReviewId1",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_ReviewId1",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_Carts_CartId1",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "ReviewId1",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "CartId1",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "CartItemId",
                table: "Carts");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "Reviews",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Products_ProductId",
                table: "Reviews",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
