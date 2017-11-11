using sispedidos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sispedidos.web.Models
{
    public class FormapagoViewModel
    {
        public List<Formapago> Formapagos { get; set; }
        public bool ExistenFormapagos => Formapagos.Count > 0;
    }
}
