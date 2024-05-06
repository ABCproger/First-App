using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace First_App.Server.Migrations
{
    /// <inheritdoc />
    public partial class seeddatatest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "due_date",
                table: "cards",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Boards",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 20, "testBoard" },
                    { 21, "secondTestBoard" }
                });

            migrationBuilder.InsertData(
                table: "cards",
                columns: new[] { "id", "CardColumnId", "description", "due_date", "name" },
                values: new object[,]
                {
                    { 20, null, "some description for first card", new DateTime(2024, 4, 12, 2, 13, 2, 0, DateTimeKind.Utc), "first card" },
                    { 21, null, "some description for second card", new DateTime(2025, 4, 12, 4, 13, 2, 0, DateTimeKind.Utc), "second card" },
                    { 22, null, "some description for third card", new DateTime(2024, 4, 3, 2, 13, 2, 0, DateTimeKind.Utc), "third card" },
                    { 23, null, "some description for fourth card", new DateTime(2024, 1, 12, 12, 13, 2, 0, DateTimeKind.Utc), "fourth card" },
                    { 24, null, "some description for fifth card", new DateTime(2024, 4, 2, 2, 13, 2, 0, DateTimeKind.Utc), "fifth card" },
                    { 25, null, "some description second column card", new DateTime(2024, 4, 12, 2, 13, 2, 0, DateTimeKind.Utc), "second column card" },
                    { 26, null, "some description second column card2", new DateTime(2024, 4, 8, 2, 13, 2, 0, DateTimeKind.Utc), "second column card2" },
                    { 27, null, "some description second column card3", new DateTime(2024, 4, 9, 2, 13, 2, 0, DateTimeKind.Utc), "second column card3" },
                    { 28, null, "some description for second column card4", new DateTime(2024, 4, 11, 2, 13, 2, 0, DateTimeKind.Utc), "second column card4" },
                    { 29, null, "some description for second column card5", new DateTime(2024, 4, 10, 2, 13, 2, 0, DateTimeKind.Utc), "second column card5" }
                });

            migrationBuilder.InsertData(
                table: "CardColumns",
                columns: new[] { "id", "BoardId", "name" },
                values: new object[,]
                {
                    { 20, 20, "first column" },
                    { 21, 20, "second column" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Boards",
                keyColumn: "id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "CardColumns",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "CardColumns",
                keyColumn: "id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "cards",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "cards",
                keyColumn: "id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "cards",
                keyColumn: "id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "cards",
                keyColumn: "id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "cards",
                keyColumn: "id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "cards",
                keyColumn: "id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "cards",
                keyColumn: "id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "cards",
                keyColumn: "id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "cards",
                keyColumn: "id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "cards",
                keyColumn: "id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Boards",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.AlterColumn<DateTime>(
                name: "due_date",
                table: "cards",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);
        }
    }
}
