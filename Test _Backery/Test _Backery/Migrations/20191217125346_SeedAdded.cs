using Microsoft.EntityFrameworkCore.Migrations;

namespace Test__Backery.Migrations
{
    public partial class SeedAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pastries_Catagories_CategoryId",
                table: "Pastries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Catagories",
                table: "Catagories");

            migrationBuilder.RenameTable(
                name: "Catagories",
                newName: "Categories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "CategoryId");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 1, "Bread", "Lovely bread made with love" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 2, "Cakes", "Delicious cakes for every day" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 3, "Cakes for special occasions", "Get ready to PARTY!!!" });

            migrationBuilder.InsertData(
                table: "Pastries",
                columns: new[] { "PastriesId", "CategoryId", "InStock", "IsbackeryOfTheWeek", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { 1, 1, true, false, "Freshly baked with delicious crumb", "Håndværker", 5m, "NammeNam" },
                    { 4, 1, true, true, "Long bread from France - the true parisian feeling", "Baguette", 20m, "Long Bread" },
                    { 2, 2, true, false, "o", "Smørkage", 30m, "Lots of butter" },
                    { 3, 3, true, true, "Wedding time :-)", "Bryllupskage", 25000m, "I DO" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Pastries_Categories_CategoryId",
                table: "Pastries",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pastries_Categories_CategoryId",
                table: "Pastries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.DeleteData(
                table: "Pastries",
                keyColumn: "PastriesId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pastries",
                keyColumn: "PastriesId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pastries",
                keyColumn: "PastriesId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pastries",
                keyColumn: "PastriesId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Catagories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Catagories",
                table: "Catagories",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pastries_Catagories_CategoryId",
                table: "Pastries",
                column: "CategoryId",
                principalTable: "Catagories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
