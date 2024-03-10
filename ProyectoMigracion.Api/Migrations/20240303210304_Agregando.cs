using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoMigracion.Api.Migrations
{
    /// <inheritdoc />
    public partial class Agregando : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Clientes_ClienteId",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_ClienteId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Tickets");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_ClientesId",
                table: "Tickets",
                column: "ClientesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Clientes_ClientesId",
                table: "Tickets",
                column: "ClientesId",
                principalTable: "Clientes",
                principalColumn: "ClienteId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Clientes_ClientesId",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_ClientesId",
                table: "Tickets");

            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "Tickets",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_ClienteId",
                table: "Tickets",
                column: "ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Clientes_ClienteId",
                table: "Tickets",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "ClienteId");
        }
    }
}
