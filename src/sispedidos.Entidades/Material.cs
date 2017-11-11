using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sispedidos.Entidades
{
    public class Material
    {
        public int Id { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string Unidad { get; set; }
        public string Nombre { get; set; }
        public string CodigoAuxiliar { get; set; }
    }
}
