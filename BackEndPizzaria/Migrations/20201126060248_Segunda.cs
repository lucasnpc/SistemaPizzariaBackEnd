using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEndPizzaria.Migrations
{
    public partial class Segunda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    userId = table.Column<string>(type: "text", nullable: false),
                    userSenha = table.Column<string>(type: "text", nullable: true),
                    pizzariaidPizzaria = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.userId);
                    table.ForeignKey(
                        name: "FK_users_pizzarias_pizzariaidPizzaria",
                        column: x => x.pizzariaidPizzaria,
                        principalTable: "pizzarias",
                        principalColumn: "idPizzaria",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_users_pizzariaidPizzaria",
                table: "users",
                column: "pizzariaidPizzaria");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
