using sispedidos.Data;
using sispedidos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sispedidos.Negocio
{
    public class FormapagoNegocio
    {
        private readonly sispedidosDbContext _db;

        public FormapagoNegocio(sispedidosDbContext db)
        {
            _db = db;
        }

        public List<Formapago> ObtenerTodos()
        {
            return _db.Formapagos.ToList();
        }
    }
}
