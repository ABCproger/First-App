using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace First_App.Server.Migrations
{
    /// <inheritdoc />
    public partial class addnavpropertycardcolumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CardColumns_Boards_BoardId",
                table: "CardColumns");

            migrationBuilder.AlterColumn<int>(
                name: "BoardId",
                table: "CardColumns",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CardColumns_Boards_BoardId",
                table: "CardColumns",
                column: "BoardId",
                principalTable: "Boards",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CardColumns_Boards_BoardId",
                table: "CardColumns");

            migrationBuilder.AlterColumn<int>(
                name: "BoardId",
                table: "CardColumns",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_CardColumns_Boards_BoardId",
                table: "CardColumns",
                column: "BoardId",
                principalTable: "Boards",
                principalColumn: "id");
        }
    }
}
