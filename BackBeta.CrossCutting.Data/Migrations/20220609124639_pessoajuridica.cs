using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BackBeta.CrossCutting.Data.Migrations
{
    public partial class pessoajuridica : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PessoaJuridica",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cnpj = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nome = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    RazaoSocial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Idade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataNascimento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataCadastro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NomeFantasia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Cep = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Complemento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Logradouro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bairro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Municipio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Uf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pais = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DataInclusao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataAlteracao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InscricaoMunicipal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InscMunicipalIsenta = table.Column<bool>(type: "bit", nullable: false),
                    InscricaoEstadual = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InscEstadualIsenta = table.Column<bool>(type: "bit", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PessoaJuridica", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PessoaJuridica_Email",
                table: "PessoaJuridica",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PessoaJuridica");
        }
    }
}
