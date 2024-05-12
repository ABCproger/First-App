using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace First_App.Server.Migrations
{
    /// <inheritdoc />
    public partial class changeOnDeleteBehaviour : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CardActivityLogs_cards_CardId",
                table: "CardActivityLogs");

            migrationBuilder.DropForeignKey(
                name: "FK_CardColumns_Boards_BoardId",
                table: "CardColumns");

            migrationBuilder.DropForeignKey(
                name: "FK_cards_Priority_PriorityId",
                table: "cards");

            migrationBuilder.AddForeignKey(
                name: "FK_CardActivityLogs_cards_CardId",
                table: "CardActivityLogs",
                column: "CardId",
                principalTable: "cards",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CardColumns_Boards_BoardId",
                table: "CardColumns",
                column: "BoardId",
                principalTable: "Boards",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_cards_Priority_PriorityId",
                table: "cards",
                column: "PriorityId",
                principalTable: "Priority",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CardActivityLogs_cards_CardId",
                table: "CardActivityLogs");

            migrationBuilder.DropForeignKey(
                name: "FK_CardColumns_Boards_BoardId",
                table: "CardColumns");

            migrationBuilder.DropForeignKey(
                name: "FK_cards_Priority_PriorityId",
                table: "cards");

            migrationBuilder.AddForeignKey(
                name: "FK_CardActivityLogs_cards_CardId",
                table: "CardActivityLogs",
                column: "CardId",
                principalTable: "cards",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CardColumns_Boards_BoardId",
                table: "CardColumns",
                column: "BoardId",
                principalTable: "Boards",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_cards_Priority_PriorityId",
                table: "cards",
                column: "PriorityId",
                principalTable: "Priority",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
