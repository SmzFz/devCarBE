using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace devCarBE.Migrations
{
    /// <inheritdoc />
    public partial class ajustesModelTwo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Locacoes_Clientes_ClienteId",
                table: "Locacoes");

            migrationBuilder.DropForeignKey(
                name: "FK_Locacoes_Veiculos_VeiculoId",
                table: "Locacoes");

            migrationBuilder.DropIndex(
                name: "IX_Locacoes_ClienteId",
                table: "Locacoes");

            migrationBuilder.DropIndex(
                name: "IX_Locacoes_VeiculoId",
                table: "Locacoes");

            migrationBuilder.AddColumn<double>(
                name: "ValorDaDiaria",
                table: "Veiculos",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "DiasLocados",
                table: "Locacoes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "ValorLocacao",
                table: "Locacoes",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ValorDaDiaria",
                table: "Veiculos");

            migrationBuilder.DropColumn(
                name: "DiasLocados",
                table: "Locacoes");

            migrationBuilder.DropColumn(
                name: "ValorLocacao",
                table: "Locacoes");

            migrationBuilder.CreateIndex(
                name: "IX_Locacoes_ClienteId",
                table: "Locacoes",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Locacoes_VeiculoId",
                table: "Locacoes",
                column: "VeiculoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Locacoes_Clientes_ClienteId",
                table: "Locacoes",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Locacoes_Veiculos_VeiculoId",
                table: "Locacoes",
                column: "VeiculoId",
                principalTable: "Veiculos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
