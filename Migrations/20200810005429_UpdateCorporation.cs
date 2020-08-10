using Microsoft.EntityFrameworkCore.Migrations;

namespace BasicLogin.Migrations
{
    public partial class UpdateCorporation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "Corporations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Corporations_PersonId",
                table: "Corporations",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Corporations_Persons_PersonId",
                table: "Corporations",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Corporations_Persons_PersonId",
                table: "Corporations");

            migrationBuilder.DropIndex(
                name: "IX_Corporations_PersonId",
                table: "Corporations");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Corporations");
        }
    }
}
