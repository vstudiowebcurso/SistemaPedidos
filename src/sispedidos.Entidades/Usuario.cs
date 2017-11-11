using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sispedidos.Entidades
{
    public class Usuario
    {
        public int Id { get; set; }
        public string CodigoUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Clave { get; set; }
    }
}
