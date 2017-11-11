using sispedidos.Data;
using sispedidos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sispedidos.Negocio
{
    public class ClienteNegocio
    {
        private readonly sispedidosDbContext _db;

        public ClienteNegocio(sispedidosDbContext db)
        {
            _db = db;
        }

        public List<Cliente> ObtenerTodos()
        {
            return _db.Clientes.ToList();
        }
    }
}
