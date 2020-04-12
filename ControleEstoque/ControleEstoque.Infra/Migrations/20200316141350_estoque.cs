using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ControleEstoque.Infra.Migrations
{
    public partial class estoque : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: new Guid("29494fb3-deba-4737-b499-91696ede988d"));

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: new Guid("4669cc94-6139-4a54-9415-ab714892bcb1"));

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: new Guid("81d9ac1d-7795-4848-a61b-980be8802b48"));

            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "Usuario",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "Estoque",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Ativo = table.Column<bool>(nullable: false),
                    Loja = table.Column<int>(nullable: false),
                    Codigo = table.Column<string>(nullable: false),
                    Nome = table.Column<string>(nullable: false),
                    Descricao = table.Column<string>(nullable: false),
                    ValorCusto = table.Column<decimal>(nullable: false),
                    ValorVenda = table.Column<decimal>(nullable: false),
                    PercentualVenda = table.Column<decimal>(nullable: false),
                    QuantidadeEmEstoque = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estoque", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Estoque",
                columns: new[] { "Id", "Ativo", "Codigo", "Descricao", "Loja", "Nome", "PercentualVenda", "QuantidadeEmEstoque", "ValorCusto", "ValorVenda" },
                values: new object[,]
                {
                    { new Guid("83fce0bd-b56c-4e44-a4b1-0c26ea4dfa83"), false, "UC200", "Uma bela faca", 0, "Faca", 250m, 50, 20m, 50m },
                    { new Guid("91dd6e13-1a6b-413d-a724-02933a9c23fd"), false, "UC200", "Uma bela faca 2.0", 1, "Faca 2.0", 250m, 50, 20m, 50m }
                });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "Id", "Ativo", "DataCriacao", "DataNascimento", "Email", "NivelAcesso", "Nome", "Senha" },
                values: new object[,]
                {
                    { new Guid("0441da01-a2bd-443d-a00f-178e3d7c1120"), false, new DateTime(2020, 3, 16, 11, 13, 50, 431, DateTimeKind.Local).AddTicks(7553), new DateTime(2001, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "fred@gmail.com", 0, "Fred", "26d6a8ad97c75ffc548f6873e5e93ce475479e3e1a1097381e" },
                    { new Guid("1d7bd54c-818e-431e-a866-141c91dc6162"), false, new DateTime(2020, 3, 16, 11, 13, 50, 432, DateTimeKind.Local).AddTicks(2702), new DateTime(2001, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "gabriela@gmail.com", 1, "Gabriela", "26d6a8ad97c75ffc548f6873e5e93ce475479e3e1a1097381e" },
                    { new Guid("840c7b7a-5a52-4656-8361-9d01abc1f7e6"), false, new DateTime(2020, 3, 16, 11, 13, 50, 432, DateTimeKind.Local).AddTicks(2714), new DateTime(2001, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "ericka@gmail.com", 2, "Ericka", "26d6a8ad97c75ffc548f6873e5e93ce475479e3e1a1097381e" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Estoque");

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: new Guid("0441da01-a2bd-443d-a00f-178e3d7c1120"));

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: new Guid("1d7bd54c-818e-431e-a866-141c91dc6162"));

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: new Guid("840c7b7a-5a52-4656-8361-9d01abc1f7e6"));

            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "Usuario");

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
    }
}
