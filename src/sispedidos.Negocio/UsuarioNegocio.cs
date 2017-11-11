using sispedidos.Data;
using sispedidos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sispedidos.Negocio
{
    public class UsuarioNegocio
    {
        private readonly sispedidosDbContext _db;

        public UsuarioNegocio(sispedidosDbContext db)
        {
            _db = db;
        }

        public List<Usuario> ObtenerTodos()
        {
            return _db.Usuarios.ToList();
        }
    }
}
