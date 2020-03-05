using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WePass.Infra.Migrations
{
    public partial class Pagamento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pagamento",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateDate = table.Column<DateTimeOffset>(nullable: false),
                    UpdateDate = table.Column<DateTimeOffset>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    FormaPagamento = table.Column<string>(nullable: true),
                    numeroCartao = table.Column<int>(nullable: true),
                    validadeCartao = table.Column<DateTime>(nullable: true),
                    codigoSeguranca = table.Column<int>(nullable: true),
                    Dinheiro = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Id_Pagamento", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pagamento");
        }
    }
}
