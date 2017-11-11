using sispedidos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sispedidos.web.Models
{
    public class ClienteViewModel
    {
        public List<Cliente> Clientes { get; set; }
        public bool ExistenClientes => Clientes.Count > 0;
    }
}
