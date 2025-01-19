using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class CharacterStats : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BaseStatsId",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CurrentStatsId",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Stats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WW = table.Column<int>(type: "int", nullable: false),
                    US = table.Column<int>(type: "int", nullable: false),
                    K = table.Column<int>(type: "int", nullable: false),
                    Odp = table.Column<int>(type: "int", nullable: false),
                    Zr = table.Column<int>(type: "int", nullable: false),
                    Int = table.Column<int>(type: "int", nullable: false),
                    Sw = table.Column<int>(type: "int", nullable: false),
                    Ogd = table.Column<int>(type: "int", nullable: false),
                    A = table.Column<int>(type: "int", nullable: false),
                    Zyw = table.Column<int>(type: "int", nullable: false),
                    S = table.Column<int>(type: "int", nullable: false),
                    Wt = table.Column<int>(type: "int", nullable: false),
                    Sz = table.Column<int>(type: "int", nullable: false),
                    Mag = table.Column<int>(type: "int", nullable: false),
                    PO = table.Column<int>(type: "int", nullable: false),
                    PP = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stats", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Characters_BaseStatsId",
                table: "Characters",
                column: "BaseStatsId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Characters_CurrentStatsId",
                table: "Characters",
                column: "CurrentStatsId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Stats_BaseStatsId",
                table: "Characters",
                column: "BaseStatsId",
                principalTable: "Stats",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Stats_CurrentStatsId",
                table: "Characters",
                column: "CurrentStatsId",
                principalTable: "Stats",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Stats_BaseStatsId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Stats_CurrentStatsId",
                table: "Characters");

            migrationBuilder.DropTable(
                name: "Stats");

            migrationBuilder.DropIndex(
                name: "IX_Characters_BaseStatsId",
                table: "Characters");

            migrationBuilder.DropIndex(
                name: "IX_Characters_CurrentStatsId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "BaseStatsId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "CurrentStatsId",
                table: "Characters");
        }
    }
}
