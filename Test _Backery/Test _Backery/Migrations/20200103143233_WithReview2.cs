using Microsoft.EntityFrameworkCore.Migrations;

namespace Test__Backery.Migrations
{
    public partial class WithReview2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReviewDetails_Reviews_ReviewID",
                table: "ReviewDetails");

            migrationBuilder.DropIndex(
                name: "IX_ReviewDetails_ReviewID",
                table: "ReviewDetails");

            migrationBuilder.DropColumn(
                name: "ReviewID",
                table: "ReviewDetails");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReviewID",
                table: "ReviewDetails",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ReviewDetails_ReviewID",
                table: "ReviewDetails",
                column: "ReviewID");

            migrationBuilder.AddForeignKey(
                name: "FK_ReviewDetails_Reviews_ReviewID",
                table: "ReviewDetails",
                column: "ReviewID",
                principalTable: "Reviews",
                principalColumn: "ReviewID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
