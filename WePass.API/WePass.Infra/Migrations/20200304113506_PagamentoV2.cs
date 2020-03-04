using Microsoft.EntityFrameworkCore.Migrations;

namespace WePass.Infra.Migrations
{
    public partial class PagamentoV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FormaPagamento",
                table: "Pagamento",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FormaPagamento",
                table: "Pagamento");
        }
    }
}
