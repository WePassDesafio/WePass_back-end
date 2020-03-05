using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WePass.Infra.Migrations
{
    public partial class Relacionamento_Compra_Usuario_Pagamento_Evento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "EventoId",
                table: "Compra",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "PagamentoId",
                table: "Compra",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "UsuarioId",
                table: "Compra",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Compra_EventoId",
                table: "Compra",
                column: "EventoId");

            migrationBuilder.CreateIndex(
                name: "IX_Compra_PagamentoId",
                table: "Compra",
                column: "PagamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Compra_UsuarioId",
                table: "Compra",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Compra_Evento_EventoId",
                table: "Compra",
                column: "EventoId",
                principalTable: "Evento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Compra_Pagamento_PagamentoId",
                table: "Compra",
                column: "PagamentoId",
                principalTable: "Pagamento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Compra_Usuario_UsuarioId",
                table: "Compra",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Compra_Evento_EventoId",
                table: "Compra");

            migrationBuilder.DropForeignKey(
                name: "FK_Compra_Pagamento_PagamentoId",
                table: "Compra");

            migrationBuilder.DropForeignKey(
                name: "FK_Compra_Usuario_UsuarioId",
                table: "Compra");

            migrationBuilder.DropIndex(
                name: "IX_Compra_EventoId",
                table: "Compra");

            migrationBuilder.DropIndex(
                name: "IX_Compra_PagamentoId",
                table: "Compra");

            migrationBuilder.DropIndex(
                name: "IX_Compra_UsuarioId",
                table: "Compra");

            migrationBuilder.DropColumn(
                name: "EventoId",
                table: "Compra");

            migrationBuilder.DropColumn(
                name: "PagamentoId",
                table: "Compra");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Compra");
        }
    }
}
