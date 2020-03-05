using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WePass.Infra.Migrations
{
    public partial class Relacionamento_Usuario_Pagamento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "UsuarioId",
                table: "Pagamento",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Pagamento_UsuarioId",
                table: "Pagamento",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pagamento_Usuario_UsuarioId",
                table: "Pagamento",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pagamento_Usuario_UsuarioId",
                table: "Pagamento");

            migrationBuilder.DropIndex(
                name: "IX_Pagamento_UsuarioId",
                table: "Pagamento");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Pagamento");
        }
    }
}
