﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace QuickBuy.repositorio.Migrations
{
    public partial class NovaColunaProdutoNomeArquivo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NomeArquivo",
                table: "Produto",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NomeArquivo",
                table: "Produto");
        }
    }
}
