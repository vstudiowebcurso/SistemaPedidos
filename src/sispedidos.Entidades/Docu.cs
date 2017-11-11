using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sispedidos.Entidades
{
    public class Docu
    {
        public int Id { get; set; }
        public string numguia { get; set; }
        public DateTime? Fechadocu { get; set; }
        public DateTime? Fechavencimiento { get; set; }
        public decimal Total { get; set; }
        public decimal Tcambio { get; set; }
        public string Moneda { get; set; }
        public string Notas { get; set; }
        public string Usuario { get; set; }

        public Tipodocu Tipodocu { get; set; }
        public Almacen Almacen { get; set; }
        public Vendedor Vendedor { get; set; }
        public Formapago Formapago { get; set; }
        public Cliente Cliente { get; set; }
    }
}
