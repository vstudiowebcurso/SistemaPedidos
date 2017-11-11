using sispedidos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sispedidos.web.Models
{
    public class UsuarioViewModel
    {
        public List<Usuario> Usuarios { get; set; }
        public bool ExistenUsuarios => Usuarios.Count > 0;
    }
}
