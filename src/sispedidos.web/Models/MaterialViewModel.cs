using sispedidos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sispedidos.web.Models
{
    public class MaterialViewModel
    {
        public List<Material> Materiales { get; set; }
        public bool ExistenMateriales => Materiales.Count > 0;
        

    }
}
