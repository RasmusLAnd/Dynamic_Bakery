using Microsoft.EntityFrameworkCore.Migrations;

namespace Test__Backery.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Catagories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catagories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Pastries",
                columns: table => new
                {
                    PastriesId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    ShortDescription = table.Column<string>(nullable: true),
                    LongDescription = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    IsbackeryOfTheWeek = table.Column<bool>(nullable: false),
                    InStock = table.Column<bool>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pastries", x => x.PastriesId);
                    table.ForeignKey(
                        name: "FK_Pastries_Catagories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Catagories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pastries_CategoryId",
                table: "Pastries",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pastries");

            migrationBuilder.DropTable(
                name: "Catagories");
        }
    }
}
