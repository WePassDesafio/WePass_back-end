using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WePass.Infra.Migrations
{
    public partial class Relacionamento_Usuario_Compra : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "UsuarioId",
                table: "Compra",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Compra_UsuarioId",
                table: "Compra",
                column: "UsuarioId");

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
                name: "FK_Compra_Usuario_UsuarioId",
                table: "Compra");

            migrationBuilder.DropIndex(
                name: "IX_Compra_UsuarioId",
                table: "Compra");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Compra");
        }
    }
}
