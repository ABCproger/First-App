using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace First_App.Server.Migrations
{
    /// <inheritdoc />
    public partial class addpriority : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PriorityId",
                table: "cards",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Priority",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Priority", x => x.id);
                });

            migrationBuilder.UpdateData(
                table: "cards",
                keyColumn: "id",
                keyValue: 20,
                column: "PriorityId",
                value: null);

            migrationBuilder.UpdateData(
                table: "cards",
                keyColumn: "id",
                keyValue: 21,
                column: "PriorityId",
                value: null);

            migrationBuilder.UpdateData(
                table: "cards",
                keyColumn: "id",
                keyValue: 22,
                column: "PriorityId",
                value: null);

            migrationBuilder.UpdateData(
                table: "cards",
                keyColumn: "id",
                keyValue: 23,
                column: "PriorityId",
                value: null);

            migrationBuilder.UpdateData(
                table: "cards",
                keyColumn: "id",
                keyValue: 24,
                column: "PriorityId",
                value: null);

            migrationBuilder.UpdateData(
                table: "cards",
                keyColumn: "id",
                keyValue: 25,
                column: "PriorityId",
                value: null);

            migrationBuilder.UpdateData(
                table: "cards",
                keyColumn: "id",
                keyValue: 26,
                column: "PriorityId",
                value: null);

            migrationBuilder.UpdateData(
                table: "cards",
                keyColumn: "id",
                keyValue: 27,
                column: "PriorityId",
                value: null);

            migrationBuilder.UpdateData(
                table: "cards",
                keyColumn: "id",
                keyValue: 28,
                column: "PriorityId",
                value: null);

            migrationBuilder.UpdateData(
                table: "cards",
                keyColumn: "id",
                keyValue: 29,
                column: "PriorityId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_cards_PriorityId",
                table: "cards",
                column: "PriorityId");

            migrationBuilder.AddForeignKey(
                name: "FK_cards_Priority_PriorityId",
                table: "cards",
                column: "PriorityId",
                principalTable: "Priority",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cards_Priority_PriorityId",
                table: "cards");

            migrationBuilder.DropTable(
                name: "Priority");

            migrationBuilder.DropIndex(
                name: "IX_cards_PriorityId",
                table: "cards");

            migrationBuilder.DropColumn(
                name: "PriorityId",
                table: "cards");
        }
    }
}
