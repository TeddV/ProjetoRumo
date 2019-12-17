using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoRumo.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Copa",
                columns: table => new
                {
                    CopaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BebidaEscolhida = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Copa", x => x.CopaId);
                });

            migrationBuilder.CreateTable(
                name: "Cozinha",
                columns: table => new
                {
                    CozinhaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PratoEscolho = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cozinha", x => x.CozinhaId);
                });

            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    PedidoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantidade = table.Column<string>(type: "varchar(3)", nullable: false),
                    MesaSolicitante = table.Column<string>(type: "varchar(4)", nullable: false),
                    Cliente = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.PedidoId);
                });

            migrationBuilder.CreateTable(
                name: "PedidoCopa",
                columns: table => new
                {
                    PedidoCopaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PedidoId = table.Column<int>(nullable: false),
                    PedidoFK = table.Column<int>(nullable: true),
                    CopaId = table.Column<int>(nullable: false),
                    CopaFK = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PedidoCopa", x => x.PedidoCopaID);
                    table.ForeignKey(
                        name: "FK_PedidoCopa_Copa_CopaFK",
                        column: x => x.CopaFK,
                        principalTable: "Copa",
                        principalColumn: "CopaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PedidoCopa_Pedidos_PedidoFK",
                        column: x => x.PedidoFK,
                        principalTable: "Pedidos",
                        principalColumn: "PedidoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PedidoCozinha",
                columns: table => new
                {
                    PedidoCozinhaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PedidoId = table.Column<int>(nullable: false),
                    PedidoFK = table.Column<int>(nullable: true),
                    CozinhaId = table.Column<int>(nullable: false),
                    CozninhaFK = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PedidoCozinha", x => x.PedidoCozinhaId);
                    table.ForeignKey(
                        name: "FK_PedidoCozinha_Cozinha_CozninhaFK",
                        column: x => x.CozninhaFK,
                        principalTable: "Cozinha",
                        principalColumn: "CozinhaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PedidoCozinha_Pedidos_PedidoFK",
                        column: x => x.PedidoFK,
                        principalTable: "Pedidos",
                        principalColumn: "PedidoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PedidoCopa_CopaFK",
                table: "PedidoCopa",
                column: "CopaFK");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoCopa_PedidoFK",
                table: "PedidoCopa",
                column: "PedidoFK");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoCozinha_CozninhaFK",
                table: "PedidoCozinha",
                column: "CozninhaFK");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoCozinha_PedidoFK",
                table: "PedidoCozinha",
                column: "PedidoFK");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PedidoCopa");

            migrationBuilder.DropTable(
                name: "PedidoCozinha");

            migrationBuilder.DropTable(
                name: "Copa");

            migrationBuilder.DropTable(
                name: "Cozinha");

            migrationBuilder.DropTable(
                name: "Pedidos");
        }
    }
}
