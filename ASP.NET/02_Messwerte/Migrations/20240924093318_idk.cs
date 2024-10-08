using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _02_Messwerte.Migrations
{
    /// <inheritdoc />
    public partial class idk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MessWert_MessStationen_MessStationId",
                table: "MessWert");

            migrationBuilder.DropIndex(
                name: "IX_MessWert_MessStationId",
                table: "MessWert");

            migrationBuilder.DropColumn(
                name: "MessStationId",
                table: "MessWert");

            migrationBuilder.AddColumn<int>(
                name: "StationId",
                table: "MessWert",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_MessWert_StationId",
                table: "MessWert",
                column: "StationId");

            migrationBuilder.AddForeignKey(
                name: "FK_MessWert_MessStationen_StationId",
                table: "MessWert",
                column: "StationId",
                principalTable: "MessStationen",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MessWert_MessStationen_StationId",
                table: "MessWert");

            migrationBuilder.DropIndex(
                name: "IX_MessWert_StationId",
                table: "MessWert");

            migrationBuilder.DropColumn(
                name: "StationId",
                table: "MessWert");

            migrationBuilder.AddColumn<int>(
                name: "MessStationId",
                table: "MessWert",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MessWert_MessStationId",
                table: "MessWert",
                column: "MessStationId");

            migrationBuilder.AddForeignKey(
                name: "FK_MessWert_MessStationen_MessStationId",
                table: "MessWert",
                column: "MessStationId",
                principalTable: "MessStationen",
                principalColumn: "Id");
        }
    }
}
