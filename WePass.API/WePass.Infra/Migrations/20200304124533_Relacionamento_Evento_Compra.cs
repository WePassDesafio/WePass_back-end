using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WePass.Infra.Migrations
{
    public partial class Relacionamento_Evento_Compra : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "quantidadeIngresso",
                table: "Evento",
                newName: "QuantidadeIngresso");

            migrationBuilder.AddColumn<Guid>(
                name: "EventoId",
                table: "Compra",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Compra_EventoId",
                table: "Compra",
                column: "EventoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Compra_Evento_EventoId",
                table: "Compra",
                column: "EventoId",
                principalTable: "Evento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Compra_Evento_EventoId",
                table: "Compra");

            migrationBuilder.DropIndex(
                name: "IX_Compra_EventoId",
                table: "Compra");

            migrationBuilder.DropColumn(
                name: "EventoId",
                table: "Compra");

            migrationBuilder.RenameColumn(
                name: "QuantidadeIngresso",
                table: "Evento",
                newName: "quantidadeIngresso");
        }
    }
}
