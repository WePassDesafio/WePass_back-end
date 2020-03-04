using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WePass.Infra.Migrations
{
    public partial class Relacionamento_Pagamento_Compra : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "PagamentoId",
                table: "Compra",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Compra_PagamentoId",
                table: "Compra",
                column: "PagamentoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Compra_Pagamento_PagamentoId",
                table: "Compra",
                column: "PagamentoId",
                principalTable: "Pagamento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Compra_Pagamento_PagamentoId",
                table: "Compra");

            migrationBuilder.DropIndex(
                name: "IX_Compra_PagamentoId",
                table: "Compra");

            migrationBuilder.DropColumn(
                name: "PagamentoId",
                table: "Compra");
        }
    }
}
