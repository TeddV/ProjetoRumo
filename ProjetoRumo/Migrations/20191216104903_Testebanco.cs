using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoRumo.Migrations
{
    public partial class Testebanco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantidade",
                table: "Pedidos");

            migrationBuilder.AddColumn<string>(
                name: "Quantidade",
                table: "Cozinha",
                type: "varchar(3)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Quantidade",
                table: "Copa",
                type: "varchar(3)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantidade",
                table: "Cozinha");

            migrationBuilder.DropColumn(
                name: "Quantidade",
                table: "Copa");

            migrationBuilder.AddColumn<string>(
                name: "Quantidade",
                table: "Pedidos",
                type: "varchar(3)",
                nullable: false,
                defaultValue: "");
        }
    }
}
