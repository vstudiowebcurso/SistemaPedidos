using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sispedidos.Entidades
{
    public class Transportista
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Ruc { get; set; }
        public string Licencia { get; set; }
        public string Placa { get; set; }
        public string Partida { get; set; }
        public string Llegada { get; set; }
    }
}
