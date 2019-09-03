using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UberFinancas.Migrations
{
    public partial class UsuarioAcres : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Usuario",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<double>(
                name: "Preco",
                table: "Usuario",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "Preco",
                table: "Usuario");
        }
    }
}
