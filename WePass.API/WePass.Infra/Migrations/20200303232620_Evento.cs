using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WePass.Infra.Migrations
{
    public partial class Evento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Evento",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateDate = table.Column<DateTimeOffset>(nullable: false),
                    UpdateDate = table.Column<DateTimeOffset>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    NomeEvento = table.Column<string>(nullable: true),
                    Categoria = table.Column<string>(nullable: true),
                    ValorIngresso = table.Column<string>(nullable: true),
                    DataEvento = table.Column<DateTime>(nullable: false),
                    quantidadeIngresso = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Id_Evento", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Evento");
        }
    }
}
