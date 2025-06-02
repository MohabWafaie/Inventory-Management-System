using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventoryManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductMovement_Products_ProductId",
                table: "ProductMovement");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductMovement_Warehouses_WarehouseId",
                table: "ProductMovement");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductMovement",
                table: "ProductMovement");

            migrationBuilder.RenameTable(
                name: "ProductMovement",
                newName: "ProductMovements");

            migrationBuilder.RenameIndex(
                name: "IX_ProductMovement_WarehouseId",
                table: "ProductMovements",
                newName: "IX_ProductMovements_WarehouseId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductMovement_ProductId",
                table: "ProductMovements",
                newName: "IX_ProductMovements_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductMovements",
                table: "ProductMovements",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductMovements_Products_ProductId",
                table: "ProductMovements",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductMovements_Warehouses_WarehouseId",
                table: "ProductMovements",
                column: "WarehouseId",
                principalTable: "Warehouses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductMovements_Products_ProductId",
                table: "ProductMovements");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductMovements_Warehouses_WarehouseId",
                table: "ProductMovements");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductMovements",
                table: "ProductMovements");

            migrationBuilder.RenameTable(
                name: "ProductMovements",
                newName: "ProductMovement");

            migrationBuilder.RenameIndex(
                name: "IX_ProductMovements_WarehouseId",
                table: "ProductMovement",
                newName: "IX_ProductMovement_WarehouseId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductMovements_ProductId",
                table: "ProductMovement",
                newName: "IX_ProductMovement_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductMovement",
                table: "ProductMovement",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductMovement_Products_ProductId",
                table: "ProductMovement",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductMovement_Warehouses_WarehouseId",
                table: "ProductMovement",
                column: "WarehouseId",
                principalTable: "Warehouses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
