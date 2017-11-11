using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using sispedidos.Data;

namespace sispedidos.Data.Migrations
{
    [DbContext(typeof(sispedidosDbContext))]
    [Migration("20171102045557_sispedidosInit")]
    partial class sispedidosInit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
        }
    }
}
