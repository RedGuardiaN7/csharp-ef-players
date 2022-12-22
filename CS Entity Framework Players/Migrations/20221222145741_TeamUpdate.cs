using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CSEntityFrameworkPlayers.Migrations
{
    /// <inheritdoc />
    public partial class TeamUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Player",
                table: "Player");

            migrationBuilder.DropIndex(
                name: "IX_Player_Surname",
                table: "Player");

            migrationBuilder.RenameTable(
                name: "Player",
                newName: "player");

            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "player",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "TeamId",
                table: "player",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_player",
                table: "player",
                column: "PlayerId");

            migrationBuilder.CreateTable(
                name: "team",
                columns: table => new
                {
                    TeamId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Coach = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Colors = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_team", x => x.TeamId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_player_TeamId",
                table: "player",
                column: "TeamId");

            migrationBuilder.AddForeignKey(
                name: "FK_player_team_TeamId",
                table: "player",
                column: "TeamId",
                principalTable: "team",
                principalColumn: "TeamId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_player_team_TeamId",
                table: "player");

            migrationBuilder.DropTable(
                name: "team");

            migrationBuilder.DropPrimaryKey(
                name: "PK_player",
                table: "player");

            migrationBuilder.DropIndex(
                name: "IX_player_TeamId",
                table: "player");

            migrationBuilder.DropColumn(
                name: "TeamId",
                table: "player");

            migrationBuilder.RenameTable(
                name: "player",
                newName: "Player");

            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "Player",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Player",
                table: "Player",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Player_Surname",
                table: "Player",
                column: "Surname",
                unique: true);
        }
    }
}
