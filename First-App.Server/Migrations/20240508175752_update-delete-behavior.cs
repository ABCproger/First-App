using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace First_App.Server.Migrations
{
    /// <inheritdoc />
    public partial class updatedeletebehavior : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cards_Priority_PriorityId",
                table: "cards");

            migrationBuilder.AddForeignKey(
                name: "FK_cards_Priority_PriorityId",
                table: "cards",
                column: "PriorityId",
                principalTable: "Priority",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cards_Priority_PriorityId",
                table: "cards");

            migrationBuilder.AddForeignKey(
                name: "FK_cards_Priority_PriorityId",
                table: "cards",
                column: "PriorityId",
                principalTable: "Priority",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
