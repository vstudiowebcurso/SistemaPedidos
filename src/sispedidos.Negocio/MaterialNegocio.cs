using sispedidos.Data;
using sispedidos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sispedidos.Negocio
{
    public class MaterialNegocio
    {
        private readonly sispedidosDbContext _db;

        public MaterialNegocio(sispedidosDbContext db)
        {
            _db = db;
        }

        public List<Material> ObtenerTodos()
        {
            return _db.Materiales.ToList();
        }

    }
}
