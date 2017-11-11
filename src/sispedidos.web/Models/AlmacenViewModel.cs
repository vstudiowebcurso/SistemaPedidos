using sispedidos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sispedidos.web.Models
{
    public class AlmacenViewModel
    {
        public List<Almacen> Almacenes { get; set; }
        public bool ExistenAlmacenes => Almacenes.Count > 0;
    }
}
