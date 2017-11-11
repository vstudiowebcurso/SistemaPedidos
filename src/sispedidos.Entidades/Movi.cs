using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sispedidos.Entidades
{
    public class Movi
    {
        public int Id { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public string Unidad { get; set; }
        public decimal Stotal { get; set; }
        public string Notas { get; set; }
        public DateTime? Fecha { get; set; }

        public Docu Docu { get; set; }
        public Material Material { get; set; }
    }
}
