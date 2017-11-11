using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using sispedidos.Data;

namespace sispedidos.Data.Migrations
{
    [DbContext(typeof(sispedidosDbContext))]
    [Migration("20171104213641_sisPedidosNew")]
    partial class sisPedidosNew
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("sispedidos.Entidades.Almacen", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Codalm");

                    b.Property<string>("Nomalm");

                    b.HasKey("Id");

                    b.ToTable("Almacenes");
                });

            modelBuilder.Entity("sispedidos.Entidades.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CodCliente");

                    b.Property<string>("Departamento");

                    b.Property<string>("Direccion");

                    b.Property<string>("Distrito");

                    b.Property<string>("Email");

                    b.Property<string>("NombreCliente");

                    b.Property<string>("Notas");

                    b.Property<string>("RucCliente");

                    b.Property<string>("Telefono1");

                    b.Property<string>("Telefono2");

                    b.Property<int>("TipoDocumento");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("sispedidos.Entidades.Docu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AlmacenId");

                    b.Property<int?>("ClienteId");

                    b.Property<DateTime?>("Fechadocu");

                    b.Property<DateTime?>("Fechavencimiento");

                    b.Property<int?>("FormapagoId");

                    b.Property<string>("Moneda");

                    b.Property<string>("Notas");

                    b.Property<decimal>("Tcambio");

                    b.Property<int?>("TipodocuId");

                    b.Property<decimal>("Total");

                    b.Property<string>("Usuario");

                    b.Property<int?>("VendedorId");

                    b.Property<string>("numguia");

                    b.HasKey("Id");

                    b.HasIndex("AlmacenId");

                    b.HasIndex("ClienteId");

                    b.HasIndex("FormapagoId");

                    b.HasIndex("TipodocuId");

                    b.HasIndex("VendedorId");

                    b.ToTable("Docus");
                });

            modelBuilder.Entity("sispedidos.Entidades.Formapago", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Codfpago");

                    b.Property<string>("Nombrefpago");

                    b.HasKey("Id");

                    b.ToTable("Formapagos");
                });

            modelBuilder.Entity("sispedidos.Entidades.Material", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CodigoAuxiliar");

                    b.Property<DateTime>("FechaCreacion");

                    b.Property<string>("Nombre");

                    b.Property<string>("Unidad");

                    b.HasKey("Id");

                    b.ToTable("Materiales");
                });

            modelBuilder.Entity("sispedidos.Entidades.Movi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Cantidad");

                    b.Property<int?>("DocuId");

                    b.Property<DateTime?>("Fecha");

                    b.Property<int?>("MaterialId");

                    b.Property<string>("Notas");

                    b.Property<decimal>("Precio");

                    b.Property<decimal>("Stotal");

                    b.Property<string>("Unidad");

                    b.HasKey("Id");

                    b.HasIndex("DocuId");

                    b.HasIndex("MaterialId");

                    b.ToTable("Movis");
                });

            modelBuilder.Entity("sispedidos.Entidades.Tipodocu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Documento");

                    b.HasKey("Id");

                    b.ToTable("Tipodocus");
                });

            modelBuilder.Entity("sispedidos.Entidades.Transportista", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Codigo");

                    b.Property<string>("Licencia");

                    b.Property<string>("Llegada");

                    b.Property<string>("Nombre");

                    b.Property<string>("Partida");

                    b.Property<string>("Placa");

                    b.Property<string>("Ruc");

                    b.HasKey("Id");

                    b.ToTable("Transportistas");
                });

            modelBuilder.Entity("sispedidos.Entidades.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Clave");

                    b.Property<string>("CodigoUsuario");

                    b.Property<string>("NombreUsuario");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("sispedidos.Entidades.Vendedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CodigoVendedor");

                    b.Property<string>("DireccionVendedor");

                    b.Property<string>("NombreVendedor");

                    b.Property<string>("Observacion");

                    b.Property<string>("TelefonoVendedor");

                    b.HasKey("Id");

                    b.ToTable("Vendedores");
                });

            modelBuilder.Entity("sispedidos.Entidades.Docu", b =>
                {
                    b.HasOne("sispedidos.Entidades.Almacen", "Almacen")
                        .WithMany()
                        .HasForeignKey("AlmacenId");

                    b.HasOne("sispedidos.Entidades.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId");

                    b.HasOne("sispedidos.Entidades.Formapago", "Formapago")
                        .WithMany()
                        .HasForeignKey("FormapagoId");

                    b.HasOne("sispedidos.Entidades.Tipodocu", "Tipodocu")
                        .WithMany()
                        .HasForeignKey("TipodocuId");

                    b.HasOne("sispedidos.Entidades.Vendedor", "Vendedor")
                        .WithMany()
                        .HasForeignKey("VendedorId");
                });

            modelBuilder.Entity("sispedidos.Entidades.Movi", b =>
                {
                    b.HasOne("sispedidos.Entidades.Docu", "Docu")
                        .WithMany()
                        .HasForeignKey("DocuId");

                    b.HasOne("sispedidos.Entidades.Material", "Material")
                        .WithMany()
                        .HasForeignKey("MaterialId");
                });
        }
    }
}
