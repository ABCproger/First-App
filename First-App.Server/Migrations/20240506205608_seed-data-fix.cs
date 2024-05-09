using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace First_App.Server.Migrations
{
    /// <inheritdoc />
    public partial class seeddatafix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "cards",
                keyColumn: "id",
                keyValue: 20,
                column: "CardColumnId",
                value: 20);

            migrationBuilder.UpdateData(
                table: "cards",
                keyColumn: "id",
                keyValue: 21,
                column: "CardColumnId",
                value: 20);

            migrationBuilder.UpdateData(
                table: "cards",
                keyColumn: "id",
                keyValue: 22,
                column: "CardColumnId",
                value: 20);

            migrationBuilder.UpdateData(
                table: "cards",
                keyColumn: "id",
                keyValue: 23,
                column: "CardColumnId",
                value: 20);

            migrationBuilder.UpdateData(
                table: "cards",
                keyColumn: "id",
                keyValue: 24,
                column: "CardColumnId",
                value: 20);

            migrationBuilder.UpdateData(
                table: "cards",
                keyColumn: "id",
                keyValue: 25,
                column: "CardColumnId",
                value: 21);

            migrationBuilder.UpdateData(
                table: "cards",
                keyColumn: "id",
                keyValue: 26,
                column: "CardColumnId",
                value: 21);

            migrationBuilder.UpdateData(
                table: "cards",
                keyColumn: "id",
                keyValue: 27,
                column: "CardColumnId",
                value: 21);

            migrationBuilder.UpdateData(
                table: "cards",
                keyColumn: "id",
                keyValue: 28,
                column: "CardColumnId",
                value: 21);

            migrationBuilder.UpdateData(
                table: "cards",
                keyColumn: "id",
                keyValue: 29,
                column: "CardColumnId",
                value: 21);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "cards",
                keyColumn: "id",
                keyValue: 20,
                column: "CardColumnId",
                value: null);

            migrationBuilder.UpdateData(
                table: "cards",
                keyColumn: "id",
                keyValue: 21,
                column: "CardColumnId",
                value: null);

            migrationBuilder.UpdateData(
                table: "cards",
                keyColumn: "id",
                keyValue: 22,
                column: "CardColumnId",
                value: null);

            migrationBuilder.UpdateData(
                table: "cards",
                keyColumn: "id",
                keyValue: 23,
                column: "CardColumnId",
                value: null);

            migrationBuilder.UpdateData(
                table: "cards",
                keyColumn: "id",
                keyValue: 24,
                column: "CardColumnId",
                value: null);

            migrationBuilder.UpdateData(
                table: "cards",
                keyColumn: "id",
                keyValue: 25,
                column: "CardColumnId",
                value: null);

            migrationBuilder.UpdateData(
                table: "cards",
                keyColumn: "id",
                keyValue: 26,
                column: "CardColumnId",
                value: null);

            migrationBuilder.UpdateData(
                table: "cards",
                keyColumn: "id",
                keyValue: 27,
                column: "CardColumnId",
                value: null);

            migrationBuilder.UpdateData(
                table: "cards",
                keyColumn: "id",
                keyValue: 28,
                column: "CardColumnId",
                value: null);

            migrationBuilder.UpdateData(
                table: "cards",
                keyColumn: "id",
                keyValue: 29,
                column: "CardColumnId",
                value: null);
        }
    }
}
