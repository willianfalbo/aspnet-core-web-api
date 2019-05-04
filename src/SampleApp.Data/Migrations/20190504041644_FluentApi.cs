using Microsoft.EntityFrameworkCore.Migrations;

namespace SampleApp.Data.Migrations
{
    public partial class FluentApi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "PRODUCT");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "CATEGORY");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "PRODUCT",
                newName: "PRICE");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "PRODUCT",
                newName: "NAME");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "PRODUCT",
                newName: "DESCRIPTION");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "PRODUCT",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "StockQuantity",
                table: "PRODUCT",
                newName: "STOCK_QUANTITY");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "PRODUCT",
                newName: "CATEGORY_ID");

            migrationBuilder.RenameIndex(
                name: "IX_Products_CategoryId",
                table: "PRODUCT",
                newName: "IX_PRODUCT_CATEGORY_ID");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "CATEGORY",
                newName: "NAME");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "CATEGORY",
                newName: "DESCRIPTION");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "CATEGORY",
                newName: "ID");

            migrationBuilder.AlterColumn<decimal>(
                name: "PRICE",
                table: "PRODUCT",
                type: "DECIMAL(38,8)",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<string>(
                name: "NAME",
                table: "PRODUCT",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DESCRIPTION",
                table: "PRODUCT",
                maxLength: 1000,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "STOCK_QUANTITY",
                table: "PRODUCT",
                type: "INT",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "CATEGORY_ID",
                table: "PRODUCT",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "NAME",
                table: "CATEGORY",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DESCRIPTION",
                table: "CATEGORY",
                maxLength: 1000,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PRODUCT",
                table: "PRODUCT",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CATEGORY",
                table: "CATEGORY",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_PRODUCTS_CATEGORIES_CATEGORY_ID",
                table: "PRODUCT",
                column: "CATEGORY_ID",
                principalTable: "CATEGORY",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PRODUCTS_CATEGORIES_CATEGORY_ID",
                table: "PRODUCT");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PRODUCT",
                table: "PRODUCT");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CATEGORY",
                table: "CATEGORY");

            migrationBuilder.RenameTable(
                name: "PRODUCT",
                newName: "Products");

            migrationBuilder.RenameTable(
                name: "CATEGORY",
                newName: "Categories");

            migrationBuilder.RenameColumn(
                name: "PRICE",
                table: "Products",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "NAME",
                table: "Products",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "DESCRIPTION",
                table: "Products",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Products",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "STOCK_QUANTITY",
                table: "Products",
                newName: "StockQuantity");

            migrationBuilder.RenameColumn(
                name: "CATEGORY_ID",
                table: "Products",
                newName: "CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_PRODUCT_CATEGORY_ID",
                table: "Products",
                newName: "IX_Products_CategoryId");

            migrationBuilder.RenameColumn(
                name: "NAME",
                table: "Categories",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "DESCRIPTION",
                table: "Categories",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Categories",
                newName: "Id");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Products",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "DECIMAL(38,8)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Products",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1000,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "StockQuantity",
                table: "Products",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INT",
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Products",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Categories",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1000,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
