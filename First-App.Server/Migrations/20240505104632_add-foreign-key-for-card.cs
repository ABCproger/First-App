using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace First_App.Server.Migrations
{
    /// <inheritdoc />
    public partial class addforeignkeyforcard : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cards_CardColumns_CardColumnId",
                table: "cards");

            migrationBuilder.AlterColumn<int>(
                name: "CardColumnId",
                table: "cards",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_cards_CardColumns_CardColumnId",
                table: "cards",
                column: "CardColumnId",
                principalTable: "CardColumns",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cards_CardColumns_CardColumnId",
                table: "cards");

            migrationBuilder.AlterColumn<int>(
                name: "CardColumnId",
                table: "cards",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_cards_CardColumns_CardColumnId",
                table: "cards",
                column: "CardColumnId",
                principalTable: "CardColumns",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
