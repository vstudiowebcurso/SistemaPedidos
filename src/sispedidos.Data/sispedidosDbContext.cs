using Microsoft.EntityFrameworkCore;
using sispedidos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sispedidos.Data
{
    public class sispedidosDbContext : DbContext
    {
        public sispedidosDbContext(DbContextOptions<sispedidosDbContext> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Material> Materiales { get; set; }
        public DbSet<Almacen> Almacenes { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Formapago> Formapagos { get; set; }
        public DbSet<Tipodocu> Tipodocus { get; set; }
        public DbSet<Transportista> Transportistas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Vendedor> Vendedores { get; set; }
        public DbSet<Docu> Docus { get; set; } //pedidos
        public DbSet<Movi> Movis { get; set; }
    }
}
