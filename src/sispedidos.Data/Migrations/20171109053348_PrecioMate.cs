using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace sispedidos.Data.Migrations
{
    public partial class PrecioMate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "PrecioUnitario",
                table: "Materiales",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PrecioUnitario",
                table: "Materiales");
        }
    }
}
