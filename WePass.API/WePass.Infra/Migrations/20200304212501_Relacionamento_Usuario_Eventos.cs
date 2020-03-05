using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WePass.Infra.Migrations
{
    public partial class Relacionamento_Usuario_Eventos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "UsuarioId",
                table: "Evento",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Evento_UsuarioId",
                table: "Evento",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Evento_Usuario_UsuarioId",
                table: "Evento",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Evento_Usuario_UsuarioId",
                table: "Evento");

            migrationBuilder.DropIndex(
                name: "IX_Evento_UsuarioId",
                table: "Evento");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Evento");
        }
    }
}
