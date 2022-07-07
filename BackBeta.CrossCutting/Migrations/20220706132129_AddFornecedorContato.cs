using Microsoft.EntityFrameworkCore.Migrations;

namespace BackBeta.Infrastructure.CrossCutting.IoC.Migrations
{
    public partial class AddFornecedorContato : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Produto",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

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

            migrationBuilder.CreateTable(
                name: "FornecedorContato",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Funcao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cpf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FornecedorContato", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fornecedor_FornecedorContato_FornecedorId",
                table: "Fornecedor");

            migrationBuilder.DropTable(
                name: "FornecedorContato");

            migrationBuilder.DropIndex(
                name: "IX_Fornecedor_FornecedorId",
                table: "Fornecedor");

            migrationBuilder.DropColumn(
                name: "FornecedorContatoId",
                table: "Fornecedor");

            migrationBuilder.DropColumn(
                name: "FornecedorId",
                table: "Fornecedor");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Produto",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100);
        }
    }
}
