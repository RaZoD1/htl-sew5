using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _02_Messwerte.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MessStationen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    BetriebsDauer = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessStationen", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MessWert",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Value = table.Column<int>(type: "INTEGER", nullable: false),
                    Unit = table.Column<string>(type: "TEXT", nullable: false),
                    MessStationId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessWert", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MessWert_MessStationen_MessStationId",
                        column: x => x.MessStationId,
                        principalTable: "MessStationen",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_MessWert_MessStationId",
                table: "MessWert",
                column: "MessStationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MessWert");

            migrationBuilder.DropTable(
                name: "MessStationen");
        }
    }
}
