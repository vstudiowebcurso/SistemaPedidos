using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace sispedidos.Data.Migrations
{
    public partial class sispedidosRelacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Almacenes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Codalm = table.Column<string>(nullable: true),
                    Nomalm = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Almacenes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CodCliente = table.Column<string>(nullable: true),
                    Departamento = table.Column<string>(nullable: true),
                    Direccion = table.Column<string>(nullable: true),
                    Distrito = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    NombreCliente = table.Column<string>(nullable: true),
                    Notas = table.Column<string>(nullable: true),
                    RucCliente = table.Column<string>(nullable: true),
                    Telefono1 = table.Column<string>(nullable: true),
                    Telefono2 = table.Column<string>(nullable: true),
                    TipoDocumento = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Formapagos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Codfpago = table.Column<string>(nullable: true),
                    Nombrefpago = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Formapagos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tipodocus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Documento = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipodocus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transportistas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Codigo = table.Column<string>(nullable: true),
                    Licencia = table.Column<string>(nullable: true),
                    Llegada = table.Column<string>(nullable: true),
                    Nombre = table.Column<string>(nullable: true),
                    Partida = table.Column<string>(nullable: true),
                    Placa = table.Column<string>(nullable: true),
                    Ruc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transportistas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Clave = table.Column<string>(nullable: true),
                    CodigoUsuario = table.Column<string>(nullable: true),
                    NombreUsuario = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vendedores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CodigoVendedor = table.Column<string>(nullable: true),
                    DireccionVendedor = table.Column<string>(nullable: true),
                    NombreVendedor = table.Column<string>(nullable: true),
                    Observacion = table.Column<string>(nullable: true),
                    TelefonoVendedor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendedores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Docus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AlmacenId = table.Column<int>(nullable: true),
                    ClienteId = table.Column<int>(nullable: true),
                    Fechadocu = table.Column<DateTime>(nullable: true),
                    Fechavencimiento = table.Column<DateTime>(nullable: true),
                    FormapagoId = table.Column<int>(nullable: true),
                    Moneda = table.Column<string>(nullable: true),
                    Notas = table.Column<string>(nullable: true),
                    Tcambio = table.Column<decimal>(nullable: false),
                    TipodocuId = table.Column<int>(nullable: true),
                    Total = table.Column<decimal>(nullable: false),
                    Usuario = table.Column<string>(nullable: true),
                    VendedorId = table.Column<int>(nullable: true),
                    numguia = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Docus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Docus_Almacenes_AlmacenId",
                        column: x => x.AlmacenId,
                        principalTable: "Almacenes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Docus_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Docus_Formapagos_FormapagoId",
                        column: x => x.FormapagoId,
                        principalTable: "Formapagos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Docus_Tipodocus_TipodocuId",
                        column: x => x.TipodocuId,
                        principalTable: "Tipodocus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Docus_Vendedores_VendedorId",
                        column: x => x.VendedorId,
                        principalTable: "Vendedores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Movis",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cantidad = table.Column<int>(nullable: false),
                    DocuId = table.Column<int>(nullable: true),
                    Fecha = table.Column<DateTime>(nullable: true),
                    MaterialId = table.Column<int>(nullable: true),
                    Notas = table.Column<string>(nullable: true),
                    Precio = table.Column<decimal>(nullable: false),
                    Stotal = table.Column<decimal>(nullable: false),
                    Unidad = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movis_Docus_DocuId",
                        column: x => x.DocuId,
                        principalTable: "Docus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Movis_Materiales_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Materiales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Docus_AlmacenId",
                table: "Docus",
                column: "AlmacenId");

            migrationBuilder.CreateIndex(
                name: "IX_Docus_ClienteId",
                table: "Docus",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Docus_FormapagoId",
                table: "Docus",
                column: "FormapagoId");

            migrationBuilder.CreateIndex(
                name: "IX_Docus_TipodocuId",
                table: "Docus",
                column: "TipodocuId");

            migrationBuilder.CreateIndex(
                name: "IX_Docus_VendedorId",
                table: "Docus",
                column: "VendedorId");

            migrationBuilder.CreateIndex(
                name: "IX_Movis_DocuId",
                table: "Movis",
                column: "DocuId");

            migrationBuilder.CreateIndex(
                name: "IX_Movis_MaterialId",
                table: "Movis",
                column: "MaterialId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movis");

            migrationBuilder.DropTable(
                name: "Transportistas");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Docus");

            migrationBuilder.DropTable(
                name: "Almacenes");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Formapagos");

            migrationBuilder.DropTable(
                name: "Tipodocus");

            migrationBuilder.DropTable(
                name: "Vendedores");
        }
    }
}
