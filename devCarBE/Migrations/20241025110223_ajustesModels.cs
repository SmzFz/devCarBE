using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace devCarBE.Migrations
{
    /// <inheritdoc />
    public partial class ajustesModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Veiculos_Patios_PatioId",
                table: "Veiculos");

            migrationBuilder.DropIndex(
                name: "IX_Veiculos_PatioId",
                table: "Veiculos");

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Veiculos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Veiculos");

            migrationBuilder.CreateIndex(
                name: "IX_Veiculos_PatioId",
                table: "Veiculos",
                column: "PatioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Veiculos_Patios_PatioId",
                table: "Veiculos",
                column: "PatioId",
                principalTable: "Patios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
