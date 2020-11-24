using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEndPizzaria.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "pizzarias",
                columns: table => new
                {
                    idPizzaria = table.Column<string>(type: "text", nullable: false),
                    nomePizzaria = table.Column<string>(type: "text", nullable: true),
                    ruaPizzaria = table.Column<string>(type: "text", nullable: true),
                    numeroPizzaria = table.Column<string>(type: "text", nullable: true),
                    bairroPizzaria = table.Column<string>(type: "text", nullable: true),
                    cidadePizzaria = table.Column<string>(type: "text", nullable: true),
                    estadoPizzaria = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pizzarias", x => x.idPizzaria);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "pizzarias");
        }
    }
}
