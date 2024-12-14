using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addedMoreProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_TicketInstances_TicketInstanceId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCarts_TicketInstances_TicketInstanceId",
                table: "ShoppingCarts");

            migrationBuilder.DropIndex(
                name: "IX_ShoppingCarts_TicketInstanceId",
                table: "ShoppingCarts");

            migrationBuilder.DropIndex(
                name: "IX_Orders_TicketInstanceId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "TicketInstanceId",
                table: "ShoppingCarts");

            migrationBuilder.DropColumn(
                name: "TicketInstanceId",
                table: "Orders");

            migrationBuilder.AddColumn<int>(
                name: "Capacity",
                table: "Venues",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "TicketInstances",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ShoppingCartId",
                table: "TicketInstances",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "TotalPrice",
                table: "Orders",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateIndex(
                name: "IX_TicketInstances_OrderId",
                table: "TicketInstances",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_TicketInstances_ShoppingCartId",
                table: "TicketInstances",
                column: "ShoppingCartId");

            migrationBuilder.AddForeignKey(
                name: "FK_TicketInstances_Orders_OrderId",
                table: "TicketInstances",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TicketInstances_ShoppingCarts_ShoppingCartId",
                table: "TicketInstances",
                column: "ShoppingCartId",
                principalTable: "ShoppingCarts",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TicketInstances_Orders_OrderId",
                table: "TicketInstances");

            migrationBuilder.DropForeignKey(
                name: "FK_TicketInstances_ShoppingCarts_ShoppingCartId",
                table: "TicketInstances");

            migrationBuilder.DropIndex(
                name: "IX_TicketInstances_OrderId",
                table: "TicketInstances");

            migrationBuilder.DropIndex(
                name: "IX_TicketInstances_ShoppingCartId",
                table: "TicketInstances");

            migrationBuilder.DropColumn(
                name: "Capacity",
                table: "Venues");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "TicketInstances");

            migrationBuilder.DropColumn(
                name: "ShoppingCartId",
                table: "TicketInstances");

            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "Orders");

            migrationBuilder.AddColumn<int>(
                name: "TicketInstanceId",
                table: "ShoppingCarts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TicketInstanceId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCarts_TicketInstanceId",
                table: "ShoppingCarts",
                column: "TicketInstanceId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_TicketInstanceId",
                table: "Orders",
                column: "TicketInstanceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_TicketInstances_TicketInstanceId",
                table: "Orders",
                column: "TicketInstanceId",
                principalTable: "TicketInstances",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCarts_TicketInstances_TicketInstanceId",
                table: "ShoppingCarts",
                column: "TicketInstanceId",
                principalTable: "TicketInstances",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
