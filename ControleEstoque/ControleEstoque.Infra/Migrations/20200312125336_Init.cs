using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ControleEstoque.Infra.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Senha = table.Column<string>(nullable: false),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    DataNascimento = table.Column<DateTime>(nullable: false),
                    NivelAcesso = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "Id", "DataCriacao", "DataNascimento", "Email", "NivelAcesso", "Nome", "Senha" },
                values: new object[] { new Guid("81d9ac1d-7795-4848-a61b-980be8802b48"), new DateTime(2020, 3, 12, 9, 53, 35, 969, DateTimeKind.Local).AddTicks(7887), new DateTime(2001, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "fred@gmail.com", 0, "Fred", "26d6a8ad97c75ffc548f6873e5e93ce475479e3e1a1097381e" });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "Id", "DataCriacao", "DataNascimento", "Email", "NivelAcesso", "Nome", "Senha" },
                values: new object[] { new Guid("29494fb3-deba-4737-b499-91696ede988d"), new DateTime(2020, 3, 12, 9, 53, 35, 970, DateTimeKind.Local).AddTicks(9051), new DateTime(2001, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "gabriela@gmail.com", 1, "Gabriela", "26d6a8ad97c75ffc548f6873e5e93ce475479e3e1a1097381e" });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "Id", "DataCriacao", "DataNascimento", "Email", "NivelAcesso", "Nome", "Senha" },
                values: new object[] { new Guid("4669cc94-6139-4a54-9415-ab714892bcb1"), new DateTime(2020, 3, 12, 9, 53, 35, 970, DateTimeKind.Local).AddTicks(9120), new DateTime(2001, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "ericka@gmail.com", 2, "Ericka", "26d6a8ad97c75ffc548f6873e5e93ce475479e3e1a1097381e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
