using Microsoft.EntityFrameworkCore.Migrations;

namespace BackBeta.Infrastructure.CrossCutting.IoC.Migrations
{
    public partial class AddFornecedorContato2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fornecedor_FornecedorContato_FornecedorId",
                table: "Fornecedor");

            migrationBuilder.DropIndex(
                name: "IX_Fornecedor_FornecedorId",
                table: "Fornecedor");

            migrationBuilder.DropColumn(
                name: "FornecedorContatoId",
                table: "Fornecedor");

            migrationBuilder.DropColumn(
                name: "FornecedorId",
                table: "Fornecedor");

            migrationBuilder.AddColumn<int>(
                name: "FornecedorId",
                table: "FornecedorContato",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_FornecedorContato_FornecedorId",
                table: "FornecedorContato",
                column: "FornecedorId");

            migrationBuilder.AddForeignKey(
                name: "FK_FornecedorContato_Fornecedor_FornecedorId",
                table: "FornecedorContato",
                column: "FornecedorId",
                principalTable: "Fornecedor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FornecedorContato_Fornecedor_FornecedorId",
                table: "FornecedorContato");

            migrationBuilder.DropIndex(
                name: "IX_FornecedorContato_FornecedorId",
                table: "FornecedorContato");

            migrationBuilder.DropColumn(
                name: "FornecedorId",
                table: "FornecedorContato");

            migrationBuilder.AddColumn<int>(
                name: "FornecedorContatoId",
                table: "Fornecedor",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FornecedorId",
                table: "Fornecedor",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Fornecedor_FornecedorId",
                table: "Fornecedor",
                column: "FornecedorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Fornecedor_FornecedorContato_FornecedorId",
                table: "Fornecedor",
                column: "FornecedorId",
                principalTable: "FornecedorContato",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
