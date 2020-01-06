using Microsoft.EntityFrameworkCore.Migrations;

namespace Test__Backery.Migrations
{
    public partial class ReviewWithText : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ReviewComm",
                table: "Reviews",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReviewComm",
                table: "Reviews");
        }
    }
}
