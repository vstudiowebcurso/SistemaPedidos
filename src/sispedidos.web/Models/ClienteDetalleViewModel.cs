using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sispedidos.web.Models
{
    public class ClienteDetalleViewModel
    {
        public int Id { get; set; }
        public string CodCliente { get; set; }
        public string NombreCliente { get; set; }
        public string RucCliente { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public string Direccion { get; set; }
        public string Distrito { get; set; }
        public string Departamento { get; set; }
        public string Notas { get; set; }
        public string Email { get; set; }

    }
}
