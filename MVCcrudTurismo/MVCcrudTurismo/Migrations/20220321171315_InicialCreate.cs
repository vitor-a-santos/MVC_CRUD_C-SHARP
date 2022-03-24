using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCcrudTurismo.Migrations
{
    public partial class InicialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Passageiros",
                columns: table => new
                {
                    PassageiroId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomePassageiro = table.Column<string>(type: "varchar(200)", nullable: false),
                    CpfPassageiro = table.Column<string>(type: "nvarchar(15)", nullable: false),
                    Pagamento = table.Column<string>(type: "varchar(50)", nullable: true),
                    Destino = table.Column<string>(type: "varchar(250)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passageiros", x => x.PassageiroId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Passageiros");
        }
    }
}
