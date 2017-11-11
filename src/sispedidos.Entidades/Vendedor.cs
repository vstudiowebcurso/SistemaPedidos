using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sispedidos.Entidades
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string NombreVendedor { get; set; }
        public string DireccionVendedor { get; set; }
        public string TelefonoVendedor { get; set; }
        public string CodigoVendedor { get; set; }
        public string Observacion { get; set; }
    }
}
