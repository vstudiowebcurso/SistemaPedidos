using sispedidos.Data;
using sispedidos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sispedidos.Negocio
{
    public class AlmacenNegocio
    {
        private readonly sispedidosDbContext _db;

        public AlmacenNegocio(sispedidosDbContext db)
        {
            _db = db;
        }

        public List<Almacen> ObtenerTodos()
        {
            return _db.Almacenes.ToList();
        }
    }
}
