using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sispedidos.web.Models
{
    public class MaterialDetalleViewModel
    {
        public int Id { get; set; }
        public string Unidad { get; set; }
        public string Nombre { get; set; }
        public string CodigoAuxiliar { get; set; }
        public decimal PrecioUnitario { get; set; }
    }
}
